namespace AndroidTranferTool
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.cmbDBType = new System.Windows.Forms.ComboBox();
            this.ckbInput = new System.Windows.Forms.CheckBox();
            this.txtInputConvert = new System.Windows.Forms.TextBox();
            this.btnSelInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelOutput = new System.Windows.Forms.Button();
            this.txtOutputConvert = new System.Windows.Forms.TextBox();
            this.ckbOutput = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "匯入檔案類型";
            // 
            // txtFileType
            // 
            this.txtFileType.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtFileType.Location = new System.Drawing.Point(200, 40);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(140, 45);
            this.txtFileType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "匯出資料庫名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label3.Location = new System.Drawing.Point(343, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "若有多種請以 ; 區隔)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label4.Location = new System.Drawing.Point(338, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "(空白表示全部";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtOutputFolder.Location = new System.Drawing.Point(20, 145);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(500, 41);
            this.txtOutputFolder.TabIndex = 5;
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnSelFolder.Location = new System.Drawing.Point(200, 95);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(180, 45);
            this.btnSelFolder.TabIndex = 6;
            this.btnSelFolder.Text = "選取資料夾";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "匯出檔案位置";
            // 
            // txtDBName
            // 
            this.txtDBName.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtDBName.Location = new System.Drawing.Point(230, 40);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(130, 45);
            this.txtDBName.TabIndex = 8;
            // 
            // cmbDBType
            // 
            this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDBType.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.cmbDBType.FormattingEnabled = true;
            this.cmbDBType.Items.AddRange(new object[] {
            "db3",
            "db"});
            this.cmbDBType.Location = new System.Drawing.Point(365, 40);
            this.cmbDBType.Name = "cmbDBType";
            this.cmbDBType.Size = new System.Drawing.Size(90, 43);
            this.cmbDBType.TabIndex = 9;
            // 
            // ckbInput
            // 
            this.ckbInput.AutoSize = true;
            this.ckbInput.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.ckbInput.Location = new System.Drawing.Point(20, 100);
            this.ckbInput.Name = "ckbInput";
            this.ckbInput.Size = new System.Drawing.Size(265, 39);
            this.ckbInput.TabIndex = 11;
            this.ckbInput.Text = "啟用匯入轉檔程式";
            this.ckbInput.UseVisualStyleBackColor = true;
            this.ckbInput.CheckedChanged += new System.EventHandler(this.ckbInput_CheckedChanged);
            // 
            // txtInputConvert
            // 
            this.txtInputConvert.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtInputConvert.Location = new System.Drawing.Point(20, 145);
            this.txtInputConvert.Name = "txtInputConvert";
            this.txtInputConvert.ReadOnly = true;
            this.txtInputConvert.Size = new System.Drawing.Size(500, 36);
            this.txtInputConvert.TabIndex = 12;
            // 
            // btnSelInput
            // 
            this.btnSelInput.BackColor = System.Drawing.Color.White;
            this.btnSelInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelInput.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnSelInput.Location = new System.Drawing.Point(290, 100);
            this.btnSelInput.Name = "btnSelInput";
            this.btnSelInput.Size = new System.Drawing.Size(230, 40);
            this.btnSelInput.TabIndex = 13;
            this.btnSelInput.Text = "選取匯入轉檔程式";
            this.btnSelInput.UseVisualStyleBackColor = false;
            this.btnSelInput.Click += new System.EventHandler(this.btnSelInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelOutput
            // 
            this.btnSelOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelOutput.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnSelOutput.Location = new System.Drawing.Point(290, 200);
            this.btnSelOutput.Name = "btnSelOutput";
            this.btnSelOutput.Size = new System.Drawing.Size(230, 40);
            this.btnSelOutput.TabIndex = 17;
            this.btnSelOutput.Text = "選取匯出轉檔程式";
            this.btnSelOutput.UseVisualStyleBackColor = true;
            this.btnSelOutput.Click += new System.EventHandler(this.btnSelOutput_Click);
            // 
            // txtOutputConvert
            // 
            this.txtOutputConvert.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtOutputConvert.Location = new System.Drawing.Point(20, 245);
            this.txtOutputConvert.Name = "txtOutputConvert";
            this.txtOutputConvert.ReadOnly = true;
            this.txtOutputConvert.Size = new System.Drawing.Size(500, 36);
            this.txtOutputConvert.TabIndex = 16;
            // 
            // ckbOutput
            // 
            this.ckbOutput.AutoSize = true;
            this.ckbOutput.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.ckbOutput.Location = new System.Drawing.Point(20, 200);
            this.ckbOutput.Name = "ckbOutput";
            this.ckbOutput.Size = new System.Drawing.Size(265, 39);
            this.ckbOutput.TabIndex = 15;
            this.ckbOutput.Text = "啟用匯出轉檔程式";
            this.ckbOutput.UseVisualStyleBackColor = true;
            this.ckbOutput.CheckedChanged += new System.EventHandler(this.ckbOutput_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btnSave.Location = new System.Drawing.Point(320, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btnClose.Location = new System.Drawing.Point(120, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 50);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelInput);
            this.groupBox1.Controls.Add(this.txtFileType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInputConvert);
            this.groupBox1.Controls.Add(this.ckbInput);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "電腦 → 手持裝置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelFolder);
            this.groupBox2.Controls.Add(this.txtDBName);
            this.groupBox2.Controls.Add(this.txtOutputConvert);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOutputFolder);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSelOutput);
            this.groupBox2.Controls.Add(this.ckbOutput);
            this.groupBox2.Controls.Add(this.cmbDBType);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(10, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 300);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手持裝置  → 電腦";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定頁";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.ComboBox cmbDBType;
        private System.Windows.Forms.CheckBox ckbInput;
        private System.Windows.Forms.TextBox txtInputConvert;
        private System.Windows.Forms.Button btnSelInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelOutput;
        private System.Windows.Forms.TextBox txtOutputConvert;
        private System.Windows.Forms.CheckBox ckbOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}