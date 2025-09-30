namespace LW3_Form5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.lblFilterValue = new System.Windows.Forms.Label();
            this.cbFilterField = new System.Windows.Forms.ComboBox();
            this.lblFilterField = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbSubtitle = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.sslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tslBaseUrl = new System.Windows.Forms.ToolStripLabel();
            this.tstBaseUrl = new System.Windows.Forms.ToolStripTextBox();
            this.tslResource = new System.Windows.Forms.ToolStripLabel();
            this.tscResource = new System.Windows.Forms.ToolStripComboBox();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrTypingDelay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.ssMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.gbFilter);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pbPreview);
            this.scMain.Panel2.Controls.Add(this.tbDescription);
            this.scMain.Panel2.Controls.Add(this.lblDescription);
            this.scMain.Panel2.Controls.Add(this.tbSubtitle);
            this.scMain.Panel2.Controls.Add(this.lblSubtitle);
            this.scMain.Panel2.Controls.Add(this.tbTitle);
            this.scMain.Panel2.Controls.Add(this.lblTitle);
            this.scMain.Panel2.Controls.Add(this.tbId);
            this.scMain.Panel2.Controls.Add(this.lblId);
            this.scMain.Size = new System.Drawing.Size(882, 553);
            this.scMain.SplitterDistance = 600;
            this.scMain.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.dgvItems);
            this.gbFilter.Controls.Add(this.btnResetFilter);
            this.gbFilter.Controls.Add(this.btnApplyFilter);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.lblFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterField);
            this.gbFilter.Controls.Add(this.lblFilterField);
            this.gbFilter.Location = new System.Drawing.Point(3, 34);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(594, 444);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 64);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(574, 343);
            this.dgvItems.TabIndex = 6;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(511, 28);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 5;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(429, 29);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilter.TabIndex = 4;
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(263, 29);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(150, 22);
            this.tbFilterValue.TabIndex = 3;
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.AutoSize = true;
            this.lblFilterValue.Location = new System.Drawing.Point(211, 28);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Size = new System.Drawing.Size(45, 16);
            this.lblFilterValue.TabIndex = 2;
            this.lblFilterValue.Text = "Value:";
            // 
            // cbFilterField
            // 
            this.cbFilterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterField.FormattingEnabled = true;
            this.cbFilterField.Location = new System.Drawing.Point(55, 28);
            this.cbFilterField.Name = "cbFilterField";
            this.cbFilterField.Size = new System.Drawing.Size(150, 24);
            this.cbFilterField.TabIndex = 1;
            // 
            // lblFilterField
            // 
            this.lblFilterField.AutoSize = true;
            this.lblFilterField.Location = new System.Drawing.Point(9, 28);
            this.lblFilterField.Name = "lblFilterField";
            this.lblFilterField.Size = new System.Drawing.Size(40, 16);
            this.lblFilterField.TabIndex = 0;
            this.lblFilterField.Text = "Field:";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(20, 349);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(177, 149);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 8;
            this.pbPreview.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(20, 173);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(177, 170);
            this.tbDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 154);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // tbSubtitle
            // 
            this.tbSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubtitle.Location = new System.Drawing.Point(58, 129);
            this.tbSubtitle.Name = "tbSubtitle";
            this.tbSubtitle.ReadOnly = true;
            this.tbSubtitle.Size = new System.Drawing.Size(139, 22);
            this.tbSubtitle.TabIndex = 5;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(17, 132);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(40, 16);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Extra:";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(97, 107);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(100, 22);
            this.tbTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(14, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title/Name:";
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(45, 85);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(152, 22);
            this.tbId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslStatus,
            this.sspProgress,
            this.sslCount});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(882, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // sslStatus
            // 
            this.sslStatus.Name = "sslStatus";
            this.sslStatus.Size = new System.Drawing.Size(151, 20);
            this.sslStatus.Text = "toolStripStatusLabel1";
            // 
            // sspProgress
            // 
            this.sspProgress.Name = "sspProgress";
            this.sspProgress.Size = new System.Drawing.Size(100, 18);
            this.sspProgress.Visible = false;
            // 
            // sslCount
            // 
            this.sslCount.Name = "sslCount";
            this.sslCount.Size = new System.Drawing.Size(151, 20);
            this.sslCount.Text = "toolStripStatusLabel1";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslBaseUrl,
            this.tstBaseUrl,
            this.tslResource,
            this.tscResource,
            this.tsbLoad,
            this.tsbRefresh});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(882, 31);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // tslBaseUrl
            // 
            this.tslBaseUrl.Name = "tslBaseUrl";
            this.tslBaseUrl.Size = new System.Drawing.Size(73, 28);
            this.tslBaseUrl.Text = "Base URL:";
            // 
            // tstBaseUrl
            // 
            this.tstBaseUrl.AutoSize = false;
            this.tstBaseUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstBaseUrl.Name = "tstBaseUrl";
            this.tstBaseUrl.Size = new System.Drawing.Size(200, 31);
            this.tstBaseUrl.Text = "https://ghibliapi.vercel.app";
            // 
            // tslResource
            // 
            this.tslResource.Name = "tslResource";
            this.tslResource.Size = new System.Drawing.Size(72, 28);
            this.tslResource.Text = "Resource:";
            // 
            // tscResource
            // 
            this.tscResource.AutoSize = false;
            this.tscResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscResource.Name = "tscResource";
            this.tscResource.Size = new System.Drawing.Size(160, 28);
            // 
            // tsbLoad
            // 
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(46, 28);
            this.tsbLoad.Text = "Load";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(62, 28);
            this.tsbRefresh.Text = "Refresh";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // tmrTypingDelay
            // 
            this.tmrTypingDelay.Interval = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.scMain);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REST Client — Ghibli";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel sslStatus;
        private System.Windows.Forms.ToolStripProgressBar sspProgress;
        private System.Windows.Forms.ToolStripStatusLabel sslCount;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel tslBaseUrl;
        private System.Windows.Forms.ToolStripTextBox tstBaseUrl;
        private System.Windows.Forms.ToolStripLabel tslResource;
        private System.Windows.Forms.ToolStripComboBox tscResource;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblFilterValue;
        private System.Windows.Forms.ComboBox cbFilterField;
        private System.Windows.Forms.Label lblFilterField;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.BindingSource bsItems;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbSubtitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Timer tmrTypingDelay;
    }
}

