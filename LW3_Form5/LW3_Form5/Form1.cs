using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW3_Form5
{
    public partial class MainForm : Form
    {
        private ApiClient _client;
        private List<Film> _allFilms = new List<Film>();  

        public MainForm()
        {
            InitializeComponent();

            dgvItems.DataSource = bsItems;
            dgvItems.AutoGenerateColumns = false;

            tstBaseUrl.Text = "https://ghibliapi.vercel.app";
            tscResource.Items.Clear();
            tscResource.Items.Add("/films");
            tscResource.SelectedIndex = 0;
            tscResource.Enabled = false; 

            tsbLoad.Click += async (s, e) => await LoadFilmsAsync();
            tsbRefresh.Click += async (s, e) => await LoadFilmsAsync();
            dgvItems.SelectionChanged += async (s, e) => await LoadFilmDetailsAsync();
            btnApplyFilter.Click += (s, e) => ApplyFilter();
            btnResetFilter.Click += (s, e) => ResetFilter();
            tbFilterValue.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { ApplyFilter(); e.SuppressKeyPress = true; } };

            EnsureFilmColumns();
            PopulateFilterFields();
        }

        private void ToggleUi(bool enabled)
        {
            tsbLoad.Enabled = enabled;
            tsbRefresh.Enabled = enabled;
            sspProgress.Visible = !enabled;
        }

        private async Task LoadFilmsAsync()
        {
            var baseUrl = (tstBaseUrl.Text ?? "").Trim();
            if (string.IsNullOrEmpty(baseUrl)) return;

            try
            {
                ToggleUi(false);
                sslStatus.Text = "Loading films...";

                if (_client != null) _client.Dispose();
                _client = new ApiClient(baseUrl);

                var items = await _client.GetFilmsAsync();

                _allFilms = items;
                bsItems.DataSource = _allFilms;
                dgvItems.Refresh();

                sslCount.Text = items.Count + " items";
                sslStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                sslStatus.Text = "Error: " + ex.Message;
                MessageBox.Show(ex.Message, "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private async Task LoadFilmDetailsAsync()
        {
            try
            {
                if (_client == null) return;
                if (dgvItems.SelectedRows.Count == 0) return;

                var idCell = dgvItems.SelectedRows[0].Cells["Id"].Value;
                var id = idCell == null ? "" : idCell.ToString();
                if (string.IsNullOrEmpty(id)) return;

                sslStatus.Text = "Loading details...";
                var film = await _client.GetFilmByIdAsync(id);
                if (film != null)
                {
                    tbId.Text = film.Id;
                    tbTitle.Text = film.Title;
                    tbSubtitle.Text = film.Director;     
                    tbDescription.Text = film.Description;
                }
                sslStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                sslStatus.Text = "Details error: " + ex.Message;
            }
        }
        private void EnsureFilmColumns()
        {
            dgvItems.ScrollBars = ScrollBars.Both;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvItems.RowHeadersVisible = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dgvItems.Columns.Count > 0 && dgvItems.Columns["Id"] != null)
            {
                dgvItems.Columns["Id"].Visible = true;     
                dgvItems.Columns["Id"].Width = 260;        
                return;
            }

            dgvItems.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "Id",
                HeaderText = "Id",
                Visible = true,
                Width = 260
            };
            dgvItems.Columns.Add(colId);

            var colTitle = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                Name = "Title",
                HeaderText = "Title"
            };
            dgvItems.Columns.Add(colTitle);
            var colDirector = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Director",
                Name = "Director",
                HeaderText = "Director"
            };
            dgvItems.Columns.Add(colDirector);
            var colYear = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReleaseDate",
                Name = "ReleaseDate",
                HeaderText = "Year"
            };
            dgvItems.Columns.Add(colYear);
        }

        private void PopulateFilterFields()
        {
            cbFilterField.Items.Clear();
            cbFilterField.Items.Add("Title");
            cbFilterField.Items.Add("Director");
            cbFilterField.Items.Add("Year");
            cbFilterField.SelectedIndex = 0;
        }

        private void ApplyFilter()
        {
            if (_allFilms == null || _allFilms.Count == 0) return;

            var field = cbFilterField.SelectedItem == null ? "Title" : cbFilterField.SelectedItem.ToString();
            var value = (tbFilterValue.Text ?? "").Trim().ToLower();

            if (string.IsNullOrEmpty(value))
            {
                bsItems.DataSource = _allFilms;
                sslCount.Text = _allFilms.Count + " items";
                sslStatus.Text = "Filter cleared";
                return;
            }

            var filtered = new System.Collections.Generic.List<Film>();
            foreach (var f in _allFilms)
            {
                string candidate;
                switch (field)
                {
                    case "Title": candidate = f.Title; break;
                    case "Director": candidate = f.Director; break;
                    case "Year": candidate = f.ReleaseDate; break;
                    default: candidate = f.Title; break;
                }

                if (!string.IsNullOrEmpty(candidate) &&
                    candidate.ToLower().IndexOf(value, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    filtered.Add(f);
                }
            }

            bsItems.DataSource = filtered;
            sslCount.Text = filtered.Count + " items";
            sslStatus.Text = "Filter applied";
        }
        private void ResetFilter()
        {
            tbFilterValue.Text = "";
            bsItems.DataSource = _allFilms;
            sslCount.Text = _allFilms.Count + " items";
            sslStatus.Text = "Filter cleared";
        }
    }
}
