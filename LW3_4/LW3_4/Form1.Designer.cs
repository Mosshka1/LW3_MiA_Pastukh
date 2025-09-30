namespace LW3_4
{
    partial class Form1
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
            this.pbDog = new System.Windows.Forms.PictureBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.txtRequestUrl = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnLoadN = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDog
            // 
            this.pbDog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDog.Location = new System.Drawing.Point(258, 72);
            this.pbDog.Name = "pbDog";
            this.pbDog.Size = new System.Drawing.Size(384, 304);
            this.pbDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog.TabIndex = 0;
            this.pbDog.TabStop = false;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(217, 28);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(97, 28);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch!";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(6, 21);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJson.Size = new System.Drawing.Size(210, 100);
            this.txtJson.TabIndex = 2;
            // 
            // txtRequestUrl
            // 
            this.txtRequestUrl.Location = new System.Drawing.Point(30, 28);
            this.txtRequestUrl.Multiline = true;
            this.txtRequestUrl.Name = "txtRequestUrl";
            this.txtRequestUrl.ReadOnly = true;
            this.txtRequestUrl.Size = new System.Drawing.Size(181, 22);
            this.txtRequestUrl.TabIndex = 3;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(320, 31);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(122, 25);
            this.txtStatus.TabIndex = 4;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(445, 385);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(25, 16);
            this.lblCounter.TabIndex = 5;
            this.lblCounter.Text = "0/0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnLoadN
            // 
            this.btnLoadN.Location = new System.Drawing.Point(136, 235);
            this.btnLoadN.Name = "btnLoadN";
            this.btnLoadN.Size = new System.Drawing.Size(75, 23);
            this.btnLoadN.TabIndex = 7;
            this.btnLoadN.Text = "Load N";
            this.btnLoadN.UseVisualStyleBackColor = true;
            this.btnLoadN.Click += new System.EventHandler(this.btnLoadN_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(401, 382);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(25, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "◀";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(492, 382);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJson);
            this.groupBox1.Location = new System.Drawing.Point(30, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnLoadN);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRequestUrl);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.pbDog);
            this.Name = "Form1";
            this.Text = "LW3_4";
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDog;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.TextBox txtRequestUrl;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnLoadN;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

