namespace P2214201
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSQLPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSQLUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSQLDBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSQLServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxSQLPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxSQLUserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxSQLDBName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSQLServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server 設定";
            // 
            // tbxSQLPassword
            // 
            this.tbxSQLPassword.Location = new System.Drawing.Point(188, 192);
            this.tbxSQLPassword.Name = "tbxSQLPassword";
            this.tbxSQLPassword.Size = new System.Drawing.Size(349, 36);
            this.tbxSQLPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password：";
            // 
            // tbxSQLUserID
            // 
            this.tbxSQLUserID.Location = new System.Drawing.Point(188, 144);
            this.tbxSQLUserID.Name = "tbxSQLUserID";
            this.tbxSQLUserID.Size = new System.Drawing.Size(349, 36);
            this.tbxSQLUserID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserID：";
            // 
            // tbxSQLDBName
            // 
            this.tbxSQLDBName.Location = new System.Drawing.Point(188, 94);
            this.tbxSQLDBName.Name = "tbxSQLDBName";
            this.tbxSQLDBName.Size = new System.Drawing.Size(349, 36);
            this.tbxSQLDBName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name：";
            // 
            // tbxSQLServerIP
            // 
            this.tbxSQLServerIP.Location = new System.Drawing.Point(188, 45);
            this.tbxSQLServerIP.Name = "tbxSQLServerIP";
            this.tbxSQLServerIP.Size = new System.Drawing.Size(349, 36);
            this.tbxSQLServerIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQLServerIP：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSQLServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSQLDBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSQLUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSQLPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}