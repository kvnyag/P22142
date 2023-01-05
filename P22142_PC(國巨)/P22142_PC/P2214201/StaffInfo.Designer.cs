namespace P2214201
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.btnStaffInfoAdd = new System.Windows.Forms.Button();
            this.btnStaffInfoModify = new System.Windows.Forms.Button();
            this.btnStaffInfoDelete = new System.Windows.Forms.Button();
            this.btnStaffInfoDemand = new System.Windows.Forms.Button();
            this.btnStaffInfoExit = new System.Windows.Forms.Button();
            this.btnStaffInfoStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRuleCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStaffAcount = new System.Windows.Forms.TextBox();
            this.tbxStaffName = new System.Windows.Forms.TextBox();
            this.cbxAccountStatus = new System.Windows.Forms.ComboBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.gbxShow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.gbxFun.SuspendLayout();
            this.gbxShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStaffInfoAdd
            // 
            this.btnStaffInfoAdd.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoAdd.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoAdd.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoAdd.Image")));
            this.btnStaffInfoAdd.Location = new System.Drawing.Point(12, 11);
            this.btnStaffInfoAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoAdd.Name = "btnStaffInfoAdd";
            this.btnStaffInfoAdd.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoAdd.TabIndex = 2;
            this.btnStaffInfoAdd.Text = "新增";
            this.btnStaffInfoAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoAdd.UseVisualStyleBackColor = false;
            this.btnStaffInfoAdd.Click += new System.EventHandler(this.btnStaffInfoAdd_Click);
            // 
            // btnStaffInfoModify
            // 
            this.btnStaffInfoModify.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoModify.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoModify.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoModify.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoModify.Image")));
            this.btnStaffInfoModify.Location = new System.Drawing.Point(107, 11);
            this.btnStaffInfoModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoModify.Name = "btnStaffInfoModify";
            this.btnStaffInfoModify.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoModify.TabIndex = 3;
            this.btnStaffInfoModify.Text = "修改";
            this.btnStaffInfoModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoModify.UseVisualStyleBackColor = false;
            this.btnStaffInfoModify.Click += new System.EventHandler(this.btnStaffInfoModify_Click);
            // 
            // btnStaffInfoDelete
            // 
            this.btnStaffInfoDelete.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoDelete.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoDelete.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoDelete.Image")));
            this.btnStaffInfoDelete.Location = new System.Drawing.Point(200, 11);
            this.btnStaffInfoDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoDelete.Name = "btnStaffInfoDelete";
            this.btnStaffInfoDelete.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoDelete.TabIndex = 4;
            this.btnStaffInfoDelete.Text = "刪除";
            this.btnStaffInfoDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoDelete.UseVisualStyleBackColor = false;
            this.btnStaffInfoDelete.Click += new System.EventHandler(this.btnStaffInfoDelete_Click);
            // 
            // btnStaffInfoDemand
            // 
            this.btnStaffInfoDemand.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoDemand.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoDemand.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoDemand.Image")));
            this.btnStaffInfoDemand.Location = new System.Drawing.Point(295, 11);
            this.btnStaffInfoDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoDemand.Name = "btnStaffInfoDemand";
            this.btnStaffInfoDemand.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoDemand.TabIndex = 5;
            this.btnStaffInfoDemand.Text = "查詢";
            this.btnStaffInfoDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoDemand.UseVisualStyleBackColor = false;
            this.btnStaffInfoDemand.Click += new System.EventHandler(this.btnStaffInfoDemand_Click);
            // 
            // btnStaffInfoExit
            // 
            this.btnStaffInfoExit.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoExit.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoExit.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoExit.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoExit.Image")));
            this.btnStaffInfoExit.Location = new System.Drawing.Point(1057, 11);
            this.btnStaffInfoExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoExit.Name = "btnStaffInfoExit";
            this.btnStaffInfoExit.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoExit.TabIndex = 6;
            this.btnStaffInfoExit.Text = "離開";
            this.btnStaffInfoExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoExit.UseVisualStyleBackColor = false;
            this.btnStaffInfoExit.Visible = false;
            // 
            // btnStaffInfoStore
            // 
            this.btnStaffInfoStore.BackColor = System.Drawing.Color.Teal;
            this.btnStaffInfoStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffInfoStore.FlatAppearance.BorderSize = 0;
            this.btnStaffInfoStore.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffInfoStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffInfoStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffInfoStore.Image")));
            this.btnStaffInfoStore.Location = new System.Drawing.Point(964, 11);
            this.btnStaffInfoStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffInfoStore.Name = "btnStaffInfoStore";
            this.btnStaffInfoStore.Size = new System.Drawing.Size(89, 84);
            this.btnStaffInfoStore.TabIndex = 7;
            this.btnStaffInfoStore.Text = "儲存";
            this.btnStaffInfoStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffInfoStore.UseVisualStyleBackColor = false;
            this.btnStaffInfoStore.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(120, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "權限群組";
            // 
            // cbxRuleCode
            // 
            this.cbxRuleCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxRuleCode.FormattingEnabled = true;
            this.cbxRuleCode.Location = new System.Drawing.Point(240, 148);
            this.cbxRuleCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRuleCode.Name = "cbxRuleCode";
            this.cbxRuleCode.Size = new System.Drawing.Size(180, 33);
            this.cbxRuleCode.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(120, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "人員帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(631, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "人員名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(631, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "帳號狀態";
            // 
            // tbxStaffAcount
            // 
            this.tbxStaffAcount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxStaffAcount.Location = new System.Drawing.Point(240, 185);
            this.tbxStaffAcount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStaffAcount.Name = "tbxStaffAcount";
            this.tbxStaffAcount.Size = new System.Drawing.Size(180, 34);
            this.tbxStaffAcount.TabIndex = 14;
            // 
            // tbxStaffName
            // 
            this.tbxStaffName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxStaffName.Location = new System.Drawing.Point(751, 152);
            this.tbxStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStaffName.Name = "tbxStaffName";
            this.tbxStaffName.Size = new System.Drawing.Size(180, 34);
            this.tbxStaffName.TabIndex = 15;
            // 
            // cbxAccountStatus
            // 
            this.cbxAccountStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxAccountStatus.FormattingEnabled = true;
            this.cbxAccountStatus.Location = new System.Drawing.Point(751, 190);
            this.cbxAccountStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAccountStatus.Name = "cbxAccountStatus";
            this.cbxAccountStatus.Size = new System.Drawing.Size(180, 33);
            this.cbxAccountStatus.TabIndex = 16;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(3, 11);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(1152, 608);
            this.dgvStaff.TabIndex = 17;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // gbxFun
            // 
            this.gbxFun.AutoSize = true;
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.btnStaffInfoAdd);
            this.gbxFun.Controls.Add(this.btnStaffInfoModify);
            this.gbxFun.Controls.Add(this.cbxAccountStatus);
            this.gbxFun.Controls.Add(this.btnStaffInfoDelete);
            this.gbxFun.Controls.Add(this.tbxStaffName);
            this.gbxFun.Controls.Add(this.btnStaffInfoDemand);
            this.gbxFun.Controls.Add(this.tbxStaffAcount);
            this.gbxFun.Controls.Add(this.btnStaffInfoExit);
            this.gbxFun.Controls.Add(this.label4);
            this.gbxFun.Controls.Add(this.btnStaffInfoStore);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.label1);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.cbxRuleCode);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Size = new System.Drawing.Size(1157, 268);
            this.gbxFun.TabIndex = 18;
            this.gbxFun.TabStop = false;
            // 
            // gbxShow
            // 
            this.gbxShow.BackColor = System.Drawing.Color.Transparent;
            this.gbxShow.Controls.Add(this.dgvStaff);
            this.gbxShow.Location = new System.Drawing.Point(0, 266);
            this.gbxShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow.Name = "gbxShow";
            this.gbxShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow.Size = new System.Drawing.Size(1157, 622);
            this.gbxShow.TabIndex = 19;
            this.gbxShow.TabStop = false;
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxShow);
            this.Controls.Add(this.gbxFun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffInfo";
            this.Text = "人員基本資料";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StaffInfo_Paint);
            this.Resize += new System.EventHandler(this.StaffInfo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.gbxShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStaffInfoAdd;
        private System.Windows.Forms.Button btnStaffInfoModify;
        private System.Windows.Forms.Button btnStaffInfoDelete;
        private System.Windows.Forms.Button btnStaffInfoDemand;
        private System.Windows.Forms.Button btnStaffInfoExit;
        private System.Windows.Forms.Button btnStaffInfoStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRuleCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxStaffAcount;
        private System.Windows.Forms.TextBox tbxStaffName;
        private System.Windows.Forms.ComboBox cbxAccountStatus;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.GroupBox gbxShow;
    }
}