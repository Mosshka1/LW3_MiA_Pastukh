using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace LW3_4
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient http = new HttpClient
        {
            BaseAddress = new Uri("https://dog.ceo/"),
            Timeout = TimeSpan.FromSeconds(15)
        };

        private readonly JsonSerializerOptions jsonOpts = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
        private List<string> _urls = new List<string>();
        private int _i = -1;

        public Form1()
        {
            InitializeComponent();
            pbDog.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateNav();
        }
        private async void btnFetch_Click(object sender, EventArgs e)
        {
            btnFetch.Enabled = false;
            try
            {
                var resp = await http.GetAsync("api/breeds/image/random");
                SetMeta(resp);
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                SetPrettyJson(json);
                string url = "";
                using (var doc = JsonDocument.Parse(json))
                {
                    if (doc.RootElement.TryGetProperty("message", out var msgProp) && msgProp.ValueKind == JsonValueKind.String)
                        url = msgProp.GetString();
                }

                if (!string.IsNullOrEmpty(url))
                {
                    _urls = new List<string> { url };
                    _i = 0;
                    pbDog.LoadAsync(url);
                }
                else
                {
                    _urls.Clear(); _i = -1; pbDog.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            finally
            {
                UpdateNav();
                btnFetch.Enabled = true;
            }
        }
        private async void btnLoadN_Click(object sender, EventArgs e)
        {
            btnLoadN.Enabled = btnPrev.Enabled = btnNext.Enabled = false;
            try
            {
                int n = (int)numericUpDown1.Value;
                var resp = await http.GetAsync("api/breeds/image/random/" + n);
                SetMeta(resp);
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                SetPrettyJson(json);

                var list = new List<string>();
                using (var doc = JsonDocument.Parse(json))
                {
                    var root = doc.RootElement;
                    if (root.TryGetProperty("message", out var arr) && arr.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var it in arr.EnumerateArray())
                        {
                            if (it.ValueKind == JsonValueKind.String)
                            {
                                var u = it.GetString();
                                if (!string.IsNullOrEmpty(u)) list.Add(u);
                            }
                        }
                    }
                }

                if (list.Count > 0)
                {
                    _urls = list;
                    _i = 0;
                    pbDog.LoadAsync(_urls[_i]);
                }
                else
                {
                    _urls.Clear(); _i = -1; pbDog.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            finally
            {
                UpdateNav();
                btnLoadN.Enabled = true;
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_i > 0)
            {
                _i--;
                pbDog.LoadAsync(_urls[_i]);
                UpdateNav();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_i >= 0 && _i < _urls.Count - 1)
            {
                _i++;
                pbDog.LoadAsync(_urls[_i]);
                UpdateNav();
            }
        }
        private void UpdateNav()
        {
            btnPrev.Enabled = _i > 0;
            btnNext.Enabled = _i >= 0 && _i < _urls.Count - 1;
            lblCounter.Text = _urls.Count == 0 ? "0/0" : (_i + 1) + "/" + _urls.Count;
        }

        private void SetMeta(HttpResponseMessage resp)
        {
            txtRequestUrl.Text = resp.RequestMessage != null ? resp.RequestMessage.RequestUri.ToString() : "";
            txtStatus.Text = ((int)resp.StatusCode) + " " + resp.ReasonPhrase;
        }

        private void SetPrettyJson(string json)
        {
            try
            {
                using (var doc = JsonDocument.Parse(json))
                    txtJson.Text = JsonSerializer.Serialize(doc.RootElement, jsonOpts);
            }
            catch
            {
                txtJson.Text = json;
            }
        }
    }
}
