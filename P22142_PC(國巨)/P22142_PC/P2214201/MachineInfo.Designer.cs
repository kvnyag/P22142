namespace P2214201
{
    partial class MachineInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineInfo));
            this.btnMachineInfoStore = new System.Windows.Forms.Button();
            this.btnReportInfoExit = new System.Windows.Forms.Button();
            this.btnMachineInfoDemand = new System.Windows.Forms.Button();
            this.btnMachineInfoDelete = new System.Windows.Forms.Button();
            this.btnMachineInfoModify = new System.Windows.Forms.Button();
            this.btnMachineInfoAdd = new System.Windows.Forms.Button();
            this.dgvMachine = new System.Windows.Forms.DataGridView();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.tbxMachineCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFactoryName = new System.Windows.Forms.ComboBox();
            this.cbxReportName = new System.Windows.Forms.ComboBox();
            this.tbxFactoryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMachineInfoStore
            // 
            this.btnMachineInfoStore.BackColor = System.Drawing.Color.Teal;
            this.btnMachineInfoStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMachineInfoStore.FlatAppearance.BorderSize = 0;
            this.btnMachineInfoStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachineInfoStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnMachineInfoStore.Image = ((System.Drawing.Image)(resources.GetObject("btnMachineInfoStore.Image")));
            this.btnMachineInfoStore.Location = new System.Drawing.Point(602, 6);
            this.btnMachineInfoStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMachineInfoStore.Name = "btnMachineInfoStore";
            this.btnMachineInfoStore.Size = new System.Drawing.Size(67, 67);
            this.btnMachineInfoStore.TabIndex = 13;
            this.btnMachineInfoStore.Text = "儲存";
            this.btnMachineInfoStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMachineInfoStore.UseVisualStyleBackColor = false;
            this.btnMachineInfoStore.Visible = false;
            // 
            // btnReportInfoExit
            // 
            this.btnReportInfoExit.BackColor = System.Drawing.Color.Teal;
            this.btnReportInfoExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportInfoExit.FlatAppearance.BorderSize = 0;
            this.btnReportInfoExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReportInfoExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnReportInfoExit.Image = ((System.Drawing.Image)(resources.GetObject("btnReportInfoExit.Image")));
            this.btnReportInfoExit.Location = new System.Drawing.Point(673, 6);
            this.btnReportInfoExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportInfoExit.Name = "btnReportInfoExit";
            this.btnReportInfoExit.Size = new System.Drawing.Size(67, 67);
            this.btnReportInfoExit.TabIndex = 12;
            this.btnReportInfoExit.Text = "離開";
            this.btnReportInfoExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportInfoExit.UseVisualStyleBackColor = false;
            this.btnReportInfoExit.Visible = false;
            // 
            // btnMachineInfoDemand
            // 
            this.btnMachineInfoDemand.BackColor = System.Drawing.Color.Teal;
            this.btnMachineInfoDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMachineInfoDemand.FlatAppearance.BorderSize = 0;
            this.btnMachineInfoDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachineInfoDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnMachineInfoDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnMachineInfoDemand.Image")));
            this.btnMachineInfoDemand.Location = new System.Drawing.Point(218, 6);
            this.btnMachineInfoDemand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMachineInfoDemand.Name = "btnMachineInfoDemand";
            this.btnMachineInfoDemand.Size = new System.Drawing.Size(67, 67);
            this.btnMachineInfoDemand.TabIndex = 11;
            this.btnMachineInfoDemand.Text = "查詢";
            this.btnMachineInfoDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMachineInfoDemand.UseVisualStyleBackColor = false;
            this.btnMachineInfoDemand.Click += new System.EventHandler(this.btnMachineInfoDemand_Click);
            // 
            // btnMachineInfoDelete
            // 
            this.btnMachineInfoDelete.BackColor = System.Drawing.Color.Teal;
            this.btnMachineInfoDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMachineInfoDelete.FlatAppearance.BorderSize = 0;
            this.btnMachineInfoDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachineInfoDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnMachineInfoDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnMachineInfoDelete.Image")));
            this.btnMachineInfoDelete.Location = new System.Drawing.Point(147, 6);
            this.btnMachineInfoDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMachineInfoDelete.Name = "btnMachineInfoDelete";
            this.btnMachineInfoDelete.Size = new System.Drawing.Size(67, 67);
            this.btnMachineInfoDelete.TabIndex = 10;
            this.btnMachineInfoDelete.Text = "刪除";
            this.btnMachineInfoDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMachineInfoDelete.UseVisualStyleBackColor = false;
            this.btnMachineInfoDelete.Click += new System.EventHandler(this.btnMachineInfoDelete_Click);
            // 
            // btnMachineInfoModify
            // 
            this.btnMachineInfoModify.BackColor = System.Drawing.Color.Teal;
            this.btnMachineInfoModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMachineInfoModify.FlatAppearance.BorderSize = 0;
            this.btnMachineInfoModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachineInfoModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnMachineInfoModify.Image = ((System.Drawing.Image)(resources.GetObject("btnMachineInfoModify.Image")));
            this.btnMachineInfoModify.Location = new System.Drawing.Point(77, 6);
            this.btnMachineInfoModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMachineInfoModify.Name = "btnMachineInfoModify";
            this.btnMachineInfoModify.Size = new System.Drawing.Size(67, 67);
            this.btnMachineInfoModify.TabIndex = 9;
            this.btnMachineInfoModify.Text = "修改";
            this.btnMachineInfoModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMachineInfoModify.UseVisualStyleBackColor = false;
            this.btnMachineInfoModify.Click += new System.EventHandler(this.btnMachineInfoModify_Click);
            // 
            // btnMachineInfoAdd
            // 
            this.btnMachineInfoAdd.BackColor = System.Drawing.Color.Teal;
            this.btnMachineInfoAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMachineInfoAdd.FlatAppearance.BorderSize = 0;
            this.btnMachineInfoAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachineInfoAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnMachineInfoAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnMachineInfoAdd.Image")));
            this.btnMachineInfoAdd.Location = new System.Drawing.Point(6, 6);
            this.btnMachineInfoAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMachineInfoAdd.Name = "btnMachineInfoAdd";
            this.btnMachineInfoAdd.Size = new System.Drawing.Size(67, 67);
            this.btnMachineInfoAdd.TabIndex = 8;
            this.btnMachineInfoAdd.Text = "新增";
            this.btnMachineInfoAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMachineInfoAdd.UseVisualStyleBackColor = false;
            this.btnMachineInfoAdd.Click += new System.EventHandler(this.btnMachineInfoAdd_Click);
            // 
            // dgvMachine
            // 
            this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachine.Location = new System.Drawing.Point(0, 213);
            this.dgvMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMachine.MultiSelect = false;
            this.dgvMachine.Name = "dgvMachine";
            this.dgvMachine.RowTemplate.Height = 31;
            this.dgvMachine.Size = new System.Drawing.Size(747, 487);
            this.dgvMachine.TabIndex = 15;
            this.dgvMachine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachine_CellClick);
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(399, 145);
            this.tbxMachineName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(279, 29);
            this.tbxMachineName.TabIndex = 19;
            // 
            // tbxMachineCode
            // 
            this.tbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineCode.Location = new System.Drawing.Point(466, 111);
            this.tbxMachineCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMachineCode.Name = "tbxMachineCode";
            this.tbxMachineCode.Size = new System.Drawing.Size(136, 29);
            this.tbxMachineCode.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(310, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "機械名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(310, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "機械編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "廠房名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "類別名稱";
            // 
            // cbxFactoryName
            // 
            this.cbxFactoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryName.FormattingEnabled = true;
            this.cbxFactoryName.Location = new System.Drawing.Point(135, 111);
            this.cbxFactoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFactoryName.Name = "cbxFactoryName";
            this.cbxFactoryName.Size = new System.Drawing.Size(135, 29);
            this.cbxFactoryName.TabIndex = 22;
            this.cbxFactoryName.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryName_SelectedIndexChanged);
            // 
            // cbxReportName
            // 
            this.cbxReportName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxReportName.FormattingEnabled = true;
            this.cbxReportName.Location = new System.Drawing.Point(135, 145);
            this.cbxReportName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxReportName.Name = "cbxReportName";
            this.cbxReportName.Size = new System.Drawing.Size(135, 29);
            this.cbxReportName.TabIndex = 23;
            // 
            // tbxFactoryName
            // 
            this.tbxFactoryName.Enabled = false;
            this.tbxFactoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxFactoryName.Location = new System.Drawing.Point(399, 111);
            this.tbxFactoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFactoryName.Name = "tbxFactoryName";
            this.tbxFactoryName.Size = new System.Drawing.Size(65, 29);
            this.tbxFactoryName.TabIndex = 24;
            // 
            // MachineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 696);
            this.Controls.Add(this.tbxFactoryName);
            this.Controls.Add(this.cbxReportName);
            this.Controls.Add(this.cbxFactoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMachineName);
            this.Controls.Add(this.tbxMachineCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMachine);
            this.Controls.Add(this.btnMachineInfoStore);
            this.Controls.Add(this.btnReportInfoExit);
            this.Controls.Add(this.btnMachineInfoDemand);
            this.Controls.Add(this.btnMachineInfoDelete);
            this.Controls.Add(this.btnMachineInfoModify);
            this.Controls.Add(this.btnMachineInfoAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MachineInfo";
            this.Text = "MachineInfo";
            this.Load += new System.EventHandler(this.MachineInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMachineInfoStore;
        private System.Windows.Forms.Button btnReportInfoExit;
        private System.Windows.Forms.Button btnMachineInfoDemand;
        private System.Windows.Forms.Button btnMachineInfoDelete;
        private System.Windows.Forms.Button btnMachineInfoModify;
        private System.Windows.Forms.Button btnMachineInfoAdd;
        private System.Windows.Forms.DataGridView dgvMachine;
        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.TextBox tbxMachineCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFactoryName;
        private System.Windows.Forms.ComboBox cbxReportName;
        private System.Windows.Forms.TextBox tbxFactoryName;
    }
}