namespace P2214201
{
    partial class VacuumDem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacuumDem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.cbxMachineCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVacuumDemStore = new System.Windows.Forms.Button();
            this.btnVacuumDemExit = new System.Windows.Forms.Button();
            this.btnVacuumDemDemand = new System.Windows.Forms.Button();
            this.btnVacuumDemDelete = new System.Windows.Forms.Button();
            this.btnVacuumDemModify = new System.Windows.Forms.Button();
            this.btnVacuumDemAdd = new System.Windows.Forms.Button();
            this.dgvVacuumFrom = new System.Windows.Forms.DataGridView();
            this.gbxShow1 = new System.Windows.Forms.GroupBox();
            this.gbxShow2 = new System.Windows.Forms.GroupBox();
            this.dgvVacuumTo = new System.Windows.Forms.DataGridView();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnVacuumDemExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumFrom)).BeginInit();
            this.gbxShow1.SuspendLayout();
            this.gbxShow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumTo)).BeginInit();
            this.gbxFun.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(240, 222);
            this.tbxMachineName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(309, 34);
            this.tbxMachineName.TabIndex = 51;
            // 
            // cbxMachineCode
            // 
            this.cbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMachineCode.FormattingEnabled = true;
            this.cbxMachineCode.Location = new System.Drawing.Point(240, 185);
            this.cbxMachineCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMachineCode.Name = "cbxMachineCode";
            this.cbxMachineCode.Size = new System.Drawing.Size(200, 33);
            this.cbxMachineCode.TabIndex = 50;
            this.cbxMachineCode.SelectedIndexChanged += new System.EventHandler(this.cbxMachineCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(120, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 49;
            this.label4.Text = "機械名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(120, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "機械編號";
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
            // btnVacuumDemStore
            // 
            this.btnVacuumDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemStore.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemStore.Image")));
            this.btnVacuumDemStore.Location = new System.Drawing.Point(960, 8);
            this.btnVacuumDemStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemStore.Name = "btnVacuumDemStore";
            this.btnVacuumDemStore.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemStore.TabIndex = 43;
            this.btnVacuumDemStore.Text = "儲存";
            this.btnVacuumDemStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemStore.UseVisualStyleBackColor = false;
            this.btnVacuumDemStore.Visible = false;
            // 
            // btnVacuumDemExit
            // 
            this.btnVacuumDemExit.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemExit.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemExit.Image")));
            this.btnVacuumDemExit.Location = new System.Drawing.Point(1053, 8);
            this.btnVacuumDemExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemExit.Name = "btnVacuumDemExit";
            this.btnVacuumDemExit.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemExit.TabIndex = 42;
            this.btnVacuumDemExit.Text = "離開";
            this.btnVacuumDemExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemExit.UseVisualStyleBackColor = false;
            this.btnVacuumDemExit.Visible = false;
            // 
            // btnVacuumDemDemand
            // 
            this.btnVacuumDemDemand.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemDemand.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemDemand.Image")));
            this.btnVacuumDemDemand.Location = new System.Drawing.Point(103, 8);
            this.btnVacuumDemDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemDemand.Name = "btnVacuumDemDemand";
            this.btnVacuumDemDemand.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemDemand.TabIndex = 41;
            this.btnVacuumDemDemand.Text = "查詢";
            this.btnVacuumDemDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemDemand.UseVisualStyleBackColor = false;
            this.btnVacuumDemDemand.Click += new System.EventHandler(this.btnVacuumDemDemand_Click);
            // 
            // btnVacuumDemDelete
            // 
            this.btnVacuumDemDelete.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemDelete.Enabled = false;
            this.btnVacuumDemDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemDelete.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemDelete.Image")));
            this.btnVacuumDemDelete.Location = new System.Drawing.Point(865, 8);
            this.btnVacuumDemDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemDelete.Name = "btnVacuumDemDelete";
            this.btnVacuumDemDelete.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemDelete.TabIndex = 40;
            this.btnVacuumDemDelete.Text = "刪除";
            this.btnVacuumDemDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemDelete.UseVisualStyleBackColor = false;
            this.btnVacuumDemDelete.Visible = false;
            // 
            // btnVacuumDemModify
            // 
            this.btnVacuumDemModify.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemModify.Enabled = false;
            this.btnVacuumDemModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemModify.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemModify.Image")));
            this.btnVacuumDemModify.Location = new System.Drawing.Point(8, 8);
            this.btnVacuumDemModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemModify.Name = "btnVacuumDemModify";
            this.btnVacuumDemModify.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemModify.TabIndex = 39;
            this.btnVacuumDemModify.Text = "修改";
            this.btnVacuumDemModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemModify.UseVisualStyleBackColor = false;
            this.btnVacuumDemModify.Click += new System.EventHandler(this.btnVacuumDemModify_Click);
            // 
            // btnVacuumDemAdd
            // 
            this.btnVacuumDemAdd.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemAdd.Enabled = false;
            this.btnVacuumDemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemAdd.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemAdd.Image")));
            this.btnVacuumDemAdd.Location = new System.Drawing.Point(772, 8);
            this.btnVacuumDemAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemAdd.Name = "btnVacuumDemAdd";
            this.btnVacuumDemAdd.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemAdd.TabIndex = 38;
            this.btnVacuumDemAdd.Text = "新增";
            this.btnVacuumDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemAdd.UseVisualStyleBackColor = false;
            this.btnVacuumDemAdd.Visible = false;
            // 
            // dgvVacuumFrom
            // 
            this.dgvVacuumFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacuumFrom.Location = new System.Drawing.Point(0, 29);
            this.dgvVacuumFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVacuumFrom.MultiSelect = false;
            this.dgvVacuumFrom.Name = "dgvVacuumFrom";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvVacuumFrom.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVacuumFrom.RowTemplate.Height = 31;
            this.dgvVacuumFrom.Size = new System.Drawing.Size(1152, 212);
            this.dgvVacuumFrom.TabIndex = 52;
            this.dgvVacuumFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacuumFrom_CellClick);
            // 
            // gbxShow1
            // 
            this.gbxShow1.Controls.Add(this.dgvVacuumFrom);
            this.gbxShow1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow1.Location = new System.Drawing.Point(0, 266);
            this.gbxShow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Name = "gbxShow1";
            this.gbxShow1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Size = new System.Drawing.Size(1157, 246);
            this.gbxShow1.TabIndex = 53;
            this.gbxShow1.TabStop = false;
            this.gbxShow1.Text = "資料檢視";
            // 
            // gbxShow2
            // 
            this.gbxShow2.Controls.Add(this.dgvVacuumTo);
            this.gbxShow2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow2.Location = new System.Drawing.Point(0, 512);
            this.gbxShow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Name = "gbxShow2";
            this.gbxShow2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Size = new System.Drawing.Size(1157, 358);
            this.gbxShow2.TabIndex = 54;
            this.gbxShow2.TabStop = false;
            this.gbxShow2.Text = "明細資料檢視";
            // 
            // dgvVacuumTo
            // 
            this.dgvVacuumTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacuumTo.Location = new System.Drawing.Point(0, 29);
            this.dgvVacuumTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVacuumTo.MultiSelect = false;
            this.dgvVacuumTo.Name = "dgvVacuumTo";
            this.dgvVacuumTo.RowTemplate.Height = 31;
            this.dgvVacuumTo.Size = new System.Drawing.Size(1152, 321);
            this.dgvVacuumTo.TabIndex = 32;
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.dtpEnd);
            this.gbxFun.Controls.Add(this.label6);
            this.gbxFun.Controls.Add(this.label5);
            this.gbxFun.Controls.Add(this.dtpStart);
            this.gbxFun.Controls.Add(this.btnVacuumDemExport);
            this.gbxFun.Controls.Add(this.btnVacuumDemAdd);
            this.gbxFun.Controls.Add(this.btnVacuumDemModify);
            this.gbxFun.Controls.Add(this.btnVacuumDemDelete);
            this.gbxFun.Controls.Add(this.tbxMachineName);
            this.gbxFun.Controls.Add(this.btnVacuumDemDemand);
            this.gbxFun.Controls.Add(this.cbxMachineCode);
            this.gbxFun.Controls.Add(this.btnVacuumDemExit);
            this.gbxFun.Controls.Add(this.label4);
            this.gbxFun.Controls.Add(this.btnVacuumDemStore);
            this.gbxFun.Controls.Add(this.label1);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Size = new System.Drawing.Size(1157, 266);
            this.gbxFun.TabIndex = 55;
            this.gbxFun.TabStop = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(774, 153);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(173, 35);
            this.dtpEnd.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(657, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 55;
            this.label6.Text = "查詢訖日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(657, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 54;
            this.label5.Text = "查詢起日";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(774, 110);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(173, 35);
            this.dtpStart.TabIndex = 53;
            // 
            // btnVacuumDemExport
            // 
            this.btnVacuumDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemExport.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemExport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVacuumDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemExport.Image")));
            this.btnVacuumDemExport.Location = new System.Drawing.Point(196, 8);
            this.btnVacuumDemExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacuumDemExport.Name = "btnVacuumDemExport";
            this.btnVacuumDemExport.Size = new System.Drawing.Size(89, 84);
            this.btnVacuumDemExport.TabIndex = 52;
            this.btnVacuumDemExport.Text = "匯出";
            this.btnVacuumDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemExport.UseVisualStyleBackColor = false;
            this.btnVacuumDemExport.Click += new System.EventHandler(this.btnVacuumDemExport_Click);
            // 
            // VacuumDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxFun);
            this.Controls.Add(this.gbxShow2);
            this.Controls.Add(this.gbxShow1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VacuumDem";
            this.Text = "VacuumDem";
            this.Load += new System.EventHandler(this.VacuumDem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VacuumDem_Paint);
            this.Resize += new System.EventHandler(this.VacuumDem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumFrom)).EndInit();
            this.gbxShow1.ResumeLayout(false);
            this.gbxShow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumTo)).EndInit();
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.ComboBox cbxMachineCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVacuumDemStore;
        private System.Windows.Forms.Button btnVacuumDemExit;
        private System.Windows.Forms.Button btnVacuumDemDemand;
        private System.Windows.Forms.Button btnVacuumDemDelete;
        private System.Windows.Forms.Button btnVacuumDemModify;
        private System.Windows.Forms.Button btnVacuumDemAdd;
        private System.Windows.Forms.DataGridView dgvVacuumFrom;
        private System.Windows.Forms.GroupBox gbxShow1;
        private System.Windows.Forms.GroupBox gbxShow2;
        private System.Windows.Forms.DataGridView dgvVacuumTo;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.Button btnVacuumDemExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}