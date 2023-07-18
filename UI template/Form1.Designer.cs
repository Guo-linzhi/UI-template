namespace UI_template
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAbnormal = new System.Windows.Forms.Button();
            this.btmDownload = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnConnent = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnAbnormal);
            this.panelMenu.Controls.Add(this.btmDownload);
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.btnManual);
            this.panelMenu.Controls.Add(this.btnAuto);
            this.panelMenu.Controls.Add(this.btnConnent);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 651);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Image = global::UI_template.Properties.Resources.gears_solid_modified;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 352);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(210, 48);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAbnormal
            // 
            this.btnAbnormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbnormal.FlatAppearance.BorderSize = 0;
            this.btnAbnormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbnormal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAbnormal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbnormal.Image = global::UI_template.Properties.Resources.circle_xmark_solid_modified;
            this.btnAbnormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbnormal.Location = new System.Drawing.Point(0, 304);
            this.btnAbnormal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbnormal.Name = "btnAbnormal";
            this.btnAbnormal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAbnormal.Size = new System.Drawing.Size(210, 48);
            this.btnAbnormal.TabIndex = 7;
            this.btnAbnormal.Text = "Abnormal";
            this.btnAbnormal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbnormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbnormal.UseVisualStyleBackColor = true;
            this.btnAbnormal.Click += new System.EventHandler(this.btnAbnormal_Click);
            // 
            // btmDownload
            // 
            this.btmDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmDownload.FlatAppearance.BorderSize = 0;
            this.btmDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmDownload.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btmDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btmDownload.Image = global::UI_template.Properties.Resources.download_solid_modified;
            this.btmDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmDownload.Location = new System.Drawing.Point(0, 256);
            this.btmDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btmDownload.Name = "btmDownload";
            this.btmDownload.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btmDownload.Size = new System.Drawing.Size(210, 48);
            this.btmDownload.TabIndex = 6;
            this.btmDownload.Text = "Download";
            this.btmDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmDownload.UseVisualStyleBackColor = true;
            this.btmDownload.Click += new System.EventHandler(this.btmDownload_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.Image = global::UI_template.Properties.Resources.clock_solid_modified;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 208);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(210, 48);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnManual
            // 
            this.btnManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnManual.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManual.Image = global::UI_template.Properties.Resources.hand_point_up_solid_modified;
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual.Location = new System.Drawing.Point(0, 160);
            this.btnManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnManual.Size = new System.Drawing.Size(210, 48);
            this.btnManual.TabIndex = 4;
            this.btnManual.Text = "Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuto.FlatAppearance.BorderSize = 0;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuto.Image = global::UI_template.Properties.Resources.repeat_solid_modified;
            this.btnAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuto.Location = new System.Drawing.Point(0, 112);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAuto.Size = new System.Drawing.Size(210, 48);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Auto";
            this.btnAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnConnent
            // 
            this.btnConnent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnent.FlatAppearance.BorderSize = 0;
            this.btnConnent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnent.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConnent.Image = global::UI_template.Properties.Resources.link_solid_modified;
            this.btnConnent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnent.Location = new System.Drawing.Point(0, 64);
            this.btnConnent.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnent.Name = "btnConnent";
            this.btnConnent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConnent.Size = new System.Drawing.Size(210, 48);
            this.btnConnent.TabIndex = 2;
            this.btnConnent.Text = "Connent";
            this.btnConnent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnent.UseVisualStyleBackColor = true;
            this.btnConnent.Click += new System.EventHandler(this.btnConnent_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 64);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code Name";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnClosefrm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(210, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(824, 64);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(725, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 24);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(762, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 24);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(799, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClosefrm
            // 
            this.btnClosefrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClosefrm.FlatAppearance.BorderSize = 0;
            this.btnClosefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrm.Image = global::UI_template.Properties.Resources.share_solid_modified;
            this.btnClosefrm.Location = new System.Drawing.Point(0, 0);
            this.btnClosefrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(56, 64);
            this.btnClosefrm.TabIndex = 1;
            this.btnClosefrm.UseVisualStyleBackColor = true;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(331, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(210, 64);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(824, 587);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::UI_template.Properties.Resources.立喬LOGO_直式1;
            this.pictureBox1.Location = new System.Drawing.Point(116, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 651);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1050, 690);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnConnent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAbnormal;
        private System.Windows.Forms.Button btmDownload;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

