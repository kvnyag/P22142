namespace AndroidTranferTool
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbPDAtoPC = new System.Windows.Forms.GroupBox();
            this.btnLogExport = new System.Windows.Forms.Button();
            this.btnPDAtoPC = new System.Windows.Forms.Button();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gpbPCtoPDA = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPCtoPDA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.gpbPDAtoPC.SuspendLayout();
            this.pnlConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbPCtoPDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(319, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version：";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.DimGray;
            this.labelVersion.Location = new System.Drawing.Point(393, 428);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(75, 25);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "0.0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label3.Location = new System.Drawing.Point(65, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "資料傳輸工具";
            // 
            // gpbPDAtoPC
            // 
            this.gpbPDAtoPC.Controls.Add(this.btnLogExport);
            this.gpbPDAtoPC.Controls.Add(this.btnPDAtoPC);
            this.gpbPDAtoPC.Location = new System.Drawing.Point(251, 133);
            this.gpbPDAtoPC.Name = "gpbPDAtoPC";
            this.gpbPDAtoPC.Size = new System.Drawing.Size(208, 247);
            this.gpbPDAtoPC.TabIndex = 5;
            this.gpbPDAtoPC.TabStop = false;
            this.gpbPDAtoPC.Text = "手持裝置  → 電腦";
            // 
            // btnLogExport
            // 
            this.btnLogExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogExport.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogExport.Location = new System.Drawing.Point(28, 147);
            this.btnLogExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogExport.Name = "btnLogExport";
            this.btnLogExport.Size = new System.Drawing.Size(146, 50);
            this.btnLogExport.TabIndex = 1;
            this.btnLogExport.Text = "Log 匯出";
            this.btnLogExport.UseVisualStyleBackColor = true;
            this.btnLogExport.Click += new System.EventHandler(this.btnLogExport_Click);
            // 
            // btnPDAtoPC
            // 
            this.btnPDAtoPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDAtoPC.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPDAtoPC.Location = new System.Drawing.Point(28, 49);
            this.btnPDAtoPC.Margin = new System.Windows.Forms.Padding(5);
            this.btnPDAtoPC.Name = "btnPDAtoPC";
            this.btnPDAtoPC.Size = new System.Drawing.Size(146, 50);
            this.btnPDAtoPC.TabIndex = 1;
            this.btnPDAtoPC.Text = "檔案匯出";
            this.btnPDAtoPC.UseVisualStyleBackColor = true;
            this.btnPDAtoPC.Click += new System.EventHandler(this.btnPDAtoPC_Click);
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.pictureBox1);
            this.pnlConnect.Controls.Add(this.label5);
            this.pnlConnect.Controls.Add(this.label4);
            this.pnlConnect.Controls.Add(this.label2);
            this.pnlConnect.Controls.Add(this.btnConnect);
            this.pnlConnect.Location = new System.Drawing.Point(12, 12);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(456, 392);
            this.pnlConnect.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(71, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "PDA端請進入傳輸模式，再按下連接按鈕";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(88, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "請使用USB傳輸線將PDA與電腦連接";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label2.Location = new System.Drawing.Point(130, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "請連接您的設備";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConnect.Location = new System.Drawing.Point(147, 164);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(146, 54);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "連接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gpbPCtoPDA
            // 
            this.gpbPCtoPDA.Controls.Add(this.btnUpdate);
            this.gpbPCtoPDA.Controls.Add(this.btnPCtoPDA);
            this.gpbPCtoPDA.Location = new System.Drawing.Point(22, 133);
            this.gpbPCtoPDA.Name = "gpbPCtoPDA";
            this.gpbPCtoPDA.Size = new System.Drawing.Size(200, 247);
            this.gpbPCtoPDA.TabIndex = 6;
            this.gpbPCtoPDA.TabStop = false;
            this.gpbPCtoPDA.Text = "電腦 → 手持裝置";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(28, 145);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 54);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "程式更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPCtoPDA
            // 
            this.btnPCtoPDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCtoPDA.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPCtoPDA.Location = new System.Drawing.Point(28, 47);
            this.btnPCtoPDA.Margin = new System.Windows.Forms.Padding(5);
            this.btnPCtoPDA.Name = "btnPCtoPDA";
            this.btnPCtoPDA.Size = new System.Drawing.Size(146, 54);
            this.btnPCtoPDA.TabIndex = 2;
            this.btnPCtoPDA.Text = "檔案匯入";
            this.btnPCtoPDA.UseVisualStyleBackColor = true;
            this.btnPCtoPDA.Visible = false;
            this.btnPCtoPDA.Click += new System.EventHandler(this.btnPCtoPDA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(167, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "RegalScan©2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(68, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "請確保傳輸線保持連接，傳輸過程中請勿拔除";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // picSetting
            // 
            this.picSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSetting.Image = ((System.Drawing.Image)(resources.GetObject("picSetting.Image")));
            this.picSetting.Location = new System.Drawing.Point(380, 30);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(74, 39);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSetting.TabIndex = 11;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 471);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpbPCtoPDA);
            this.Controls.Add(this.gpbPDAtoPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資料傳輸工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gpbPDAtoPC.ResumeLayout(false);
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbPCtoPDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbPDAtoPC;
        private System.Windows.Forms.Button btnPDAtoPC;
        private System.Windows.Forms.GroupBox gpbPCtoPDA;
        private System.Windows.Forms.Button btnPCtoPDA;
        private System.Windows.Forms.Button btnLogExport;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picSetting;
    }
}

