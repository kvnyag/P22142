namespace P2214201
{
    partial class HydropowerDem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydropowerDem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnHydropowerDemExport = new System.Windows.Forms.Button();
            this.btnHydropowerDemAdd = new System.Windows.Forms.Button();
            this.btnHydropowerDemModify = new System.Windows.Forms.Button();
            this.btnHydropowerDemDelete = new System.Windows.Forms.Button();
            this.btnHydropowerDemDemand = new System.Windows.Forms.Button();
            this.btnHydropowerDemExit = new System.Windows.Forms.Button();
            this.btnHydropowerDemStore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.gbxShow2 = new System.Windows.Forms.GroupBox();
            this.dgvHydropowerTo = new System.Windows.Forms.DataGridView();
            this.gbxShow1 = new System.Windows.Forms.GroupBox();
            this.dgvHydropowerFrom = new System.Windows.Forms.DataGridView();
            this.gbxFun.SuspendLayout();
            this.gbxShow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).BeginInit();
            this.gbxShow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.dtpEnd);
            this.gbxFun.Controls.Add(this.label6);
            this.gbxFun.Controls.Add(this.label5);
            this.gbxFun.Controls.Add(this.dtpStart);
            this.gbxFun.Controls.Add(this.btnHydropowerDemExport);
            this.gbxFun.Controls.Add(this.btnHydropowerDemAdd);
            this.gbxFun.Controls.Add(this.btnHydropowerDemModify);
            this.gbxFun.Controls.Add(this.btnHydropowerDemDelete);
            this.gbxFun.Controls.Add(this.btnHydropowerDemDemand);
            this.gbxFun.Controls.Add(this.btnHydropowerDemExit);
            this.gbxFun.Controls.Add(this.btnHydropowerDemStore);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Size = new System.Drawing.Size(1152, 266);
            this.gbxFun.TabIndex = 58;
            this.gbxFun.TabStop = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(777, 153);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(173, 35);
            this.dtpEnd.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(660, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "查詢訖日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(660, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "查詢起日";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(777, 110);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(173, 35);
            this.dtpStart.TabIndex = 57;
            // 
            // btnHydropowerDemExport
            // 
            this.btnHydropowerDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemExport.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemExport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemExport.Image")));
            this.btnHydropowerDemExport.Location = new System.Drawing.Point(196, 8);
            this.btnHydropowerDemExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemExport.Name = "btnHydropowerDemExport";
            this.btnHydropowerDemExport.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemExport.TabIndex = 53;
            this.btnHydropowerDemExport.Text = "匯出";
            this.btnHydropowerDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemExport.UseVisualStyleBackColor = false;
            this.btnHydropowerDemExport.Click += new System.EventHandler(this.btnHydropowerDemExport_Click);
            // 
            // btnHydropowerDemAdd
            // 
            this.btnHydropowerDemAdd.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemAdd.Enabled = false;
            this.btnHydropowerDemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemAdd.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemAdd.Image")));
            this.btnHydropowerDemAdd.Location = new System.Drawing.Point(772, 8);
            this.btnHydropowerDemAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemAdd.Name = "btnHydropowerDemAdd";
            this.btnHydropowerDemAdd.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemAdd.TabIndex = 38;
            this.btnHydropowerDemAdd.Text = "新增";
            this.btnHydropowerDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemAdd.UseVisualStyleBackColor = false;
            this.btnHydropowerDemAdd.Visible = false;
            // 
            // btnHydropowerDemModify
            // 
            this.btnHydropowerDemModify.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemModify.Enabled = false;
            this.btnHydropowerDemModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemModify.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemModify.Image")));
            this.btnHydropowerDemModify.Location = new System.Drawing.Point(8, 8);
            this.btnHydropowerDemModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemModify.Name = "btnHydropowerDemModify";
            this.btnHydropowerDemModify.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemModify.TabIndex = 39;
            this.btnHydropowerDemModify.Text = "修改";
            this.btnHydropowerDemModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemModify.UseVisualStyleBackColor = false;
            this.btnHydropowerDemModify.Click += new System.EventHandler(this.btnHydropowerDemModify_Click);
            // 
            // btnHydropowerDemDelete
            // 
            this.btnHydropowerDemDelete.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemDelete.Enabled = false;
            this.btnHydropowerDemDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemDelete.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemDelete.Image")));
            this.btnHydropowerDemDelete.Location = new System.Drawing.Point(865, 8);
            this.btnHydropowerDemDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemDelete.Name = "btnHydropowerDemDelete";
            this.btnHydropowerDemDelete.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemDelete.TabIndex = 40;
            this.btnHydropowerDemDelete.Text = "刪除";
            this.btnHydropowerDemDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemDelete.UseVisualStyleBackColor = false;
            this.btnHydropowerDemDelete.Visible = false;
            // 
            // btnHydropowerDemDemand
            // 
            this.btnHydropowerDemDemand.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemDemand.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemDemand.Image")));
            this.btnHydropowerDemDemand.Location = new System.Drawing.Point(103, 8);
            this.btnHydropowerDemDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemDemand.Name = "btnHydropowerDemDemand";
            this.btnHydropowerDemDemand.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemDemand.TabIndex = 41;
            this.btnHydropowerDemDemand.Text = "查詢";
            this.btnHydropowerDemDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemDemand.UseVisualStyleBackColor = false;
            this.btnHydropowerDemDemand.Click += new System.EventHandler(this.btnHydropowerDemDemand_Click);
            // 
            // btnHydropowerDemExit
            // 
            this.btnHydropowerDemExit.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemExit.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemExit.Image")));
            this.btnHydropowerDemExit.Location = new System.Drawing.Point(1053, 8);
            this.btnHydropowerDemExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemExit.Name = "btnHydropowerDemExit";
            this.btnHydropowerDemExit.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemExit.TabIndex = 42;
            this.btnHydropowerDemExit.Text = "離開";
            this.btnHydropowerDemExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemExit.UseVisualStyleBackColor = false;
            this.btnHydropowerDemExit.Visible = false;
            // 
            // btnHydropowerDemStore
            // 
            this.btnHydropowerDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerDemStore.FlatAppearance.BorderSize = 0;
            this.btnHydropowerDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerDemStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerDemStore.Image")));
            this.btnHydropowerDemStore.Location = new System.Drawing.Point(960, 8);
            this.btnHydropowerDemStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerDemStore.Name = "btnHydropowerDemStore";
            this.btnHydropowerDemStore.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerDemStore.TabIndex = 43;
            this.btnHydropowerDemStore.Text = "儲存";
            this.btnHydropowerDemStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerDemStore.UseVisualStyleBackColor = false;
            this.btnHydropowerDemStore.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(120, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "廠房名稱";
            // 
            // cbxCategorysName
            // 
            this.cbxCategorysName.Enabled = false;
            this.cbxCategorysName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCategorysName.FormattingEnabled = true;
            this.cbxCategorysName.Location = new System.Drawing.Point(240, 148);
            this.cbxCategorysName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCategorysName.Name = "cbxCategorysName";
            this.cbxCategorysName.Size = new System.Drawing.Size(200, 33);
            this.cbxCategorysName.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(120, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "類別名稱";
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(240, 110);
            this.cbxFactoryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(200, 33);
            this.cbxFactoryCode.TabIndex = 46;
            this.cbxFactoryCode.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryCode_SelectedIndexChanged);
            // 
            // gbxShow2
            // 
            this.gbxShow2.Controls.Add(this.dgvHydropowerTo);
            this.gbxShow2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow2.Location = new System.Drawing.Point(0, 512);
            this.gbxShow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Name = "gbxShow2";
            this.gbxShow2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Size = new System.Drawing.Size(1157, 358);
            this.gbxShow2.TabIndex = 57;
            this.gbxShow2.TabStop = false;
            this.gbxShow2.Text = "明細資料檢視";
            // 
            // dgvHydropowerTo
            // 
            this.dgvHydropowerTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerTo.Location = new System.Drawing.Point(0, 29);
            this.dgvHydropowerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHydropowerTo.MultiSelect = false;
            this.dgvHydropowerTo.Name = "dgvHydropowerTo";
            this.dgvHydropowerTo.RowTemplate.Height = 31;
            this.dgvHydropowerTo.Size = new System.Drawing.Size(1152, 321);
            this.dgvHydropowerTo.TabIndex = 32;
            // 
            // gbxShow1
            // 
            this.gbxShow1.Controls.Add(this.dgvHydropowerFrom);
            this.gbxShow1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow1.Location = new System.Drawing.Point(0, 266);
            this.gbxShow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Name = "gbxShow1";
            this.gbxShow1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Size = new System.Drawing.Size(1157, 246);
            this.gbxShow1.TabIndex = 56;
            this.gbxShow1.TabStop = false;
            this.gbxShow1.Text = "資料檢視";
            // 
            // dgvHydropowerFrom
            // 
            this.dgvHydropowerFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerFrom.Location = new System.Drawing.Point(0, 29);
            this.dgvHydropowerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHydropowerFrom.MultiSelect = false;
            this.dgvHydropowerFrom.Name = "dgvHydropowerFrom";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvHydropowerFrom.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHydropowerFrom.RowTemplate.Height = 31;
            this.dgvHydropowerFrom.Size = new System.Drawing.Size(1152, 212);
            this.dgvHydropowerFrom.TabIndex = 52;
            this.dgvHydropowerFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacuumFrom_CellClick);
            // 
            // HydropowerDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxFun);
            this.Controls.Add(this.gbxShow2);
            this.Controls.Add(this.gbxShow1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HydropowerDem";
            this.Text = "HydropowerDem";
            this.Load += new System.EventHandler(this.HydropowerDem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HydropowerDem_Paint);
            this.Resize += new System.EventHandler(this.HydropowerDem_Resize);
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.gbxShow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).EndInit();
            this.gbxShow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.Button btnHydropowerDemAdd;
        private System.Windows.Forms.Button btnHydropowerDemModify;
        private System.Windows.Forms.Button btnHydropowerDemDelete;
        private System.Windows.Forms.Button btnHydropowerDemDemand;
        private System.Windows.Forms.Button btnHydropowerDemExit;
        private System.Windows.Forms.Button btnHydropowerDemStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.GroupBox gbxShow2;
        private System.Windows.Forms.DataGridView dgvHydropowerTo;
        private System.Windows.Forms.GroupBox gbxShow1;
        private System.Windows.Forms.DataGridView dgvHydropowerFrom;
        private System.Windows.Forms.Button btnHydropowerDemExport;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}