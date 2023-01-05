namespace P2214201
{
    partial class AirConditionDem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirConditionDem));
            this.gbxShow2 = new System.Windows.Forms.GroupBox();
            this.dgvAirConditionTo = new System.Windows.Forms.DataGridView();
            this.gbxShow1 = new System.Windows.Forms.GroupBox();
            this.dgvAirConditionFrom = new System.Windows.Forms.DataGridView();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnAirConditionDemExport = new System.Windows.Forms.Button();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.cbxMachineCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAirConditionDemStore = new System.Windows.Forms.Button();
            this.btnAirConditionDemExit = new System.Windows.Forms.Button();
            this.btnAirConditionDemDemand = new System.Windows.Forms.Button();
            this.btnAirConditionDemDelete = new System.Windows.Forms.Button();
            this.btnAirConditionDemModify = new System.Windows.Forms.Button();
            this.btnAirConditionDemAdd = new System.Windows.Forms.Button();
            this.gbxShow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).BeginInit();
            this.gbxShow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).BeginInit();
            this.gbxFun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxShow2
            // 
            this.gbxShow2.Controls.Add(this.dgvAirConditionTo);
            this.gbxShow2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow2.Location = new System.Drawing.Point(0, 512);
            this.gbxShow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Name = "gbxShow2";
            this.gbxShow2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Size = new System.Drawing.Size(1157, 358);
            this.gbxShow2.TabIndex = 72;
            this.gbxShow2.TabStop = false;
            this.gbxShow2.Text = "明細資料檢視";
            // 
            // dgvAirConditionTo
            // 
            this.dgvAirConditionTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionTo.Location = new System.Drawing.Point(0, 29);
            this.dgvAirConditionTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirConditionTo.MultiSelect = false;
            this.dgvAirConditionTo.Name = "dgvAirConditionTo";
            this.dgvAirConditionTo.RowTemplate.Height = 31;
            this.dgvAirConditionTo.Size = new System.Drawing.Size(1152, 321);
            this.dgvAirConditionTo.TabIndex = 32;
            // 
            // gbxShow1
            // 
            this.gbxShow1.Controls.Add(this.dgvAirConditionFrom);
            this.gbxShow1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow1.Location = new System.Drawing.Point(0, 266);
            this.gbxShow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Name = "gbxShow1";
            this.gbxShow1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Size = new System.Drawing.Size(1157, 246);
            this.gbxShow1.TabIndex = 71;
            this.gbxShow1.TabStop = false;
            this.gbxShow1.Text = "資料檢視";
            // 
            // dgvAirConditionFrom
            // 
            this.dgvAirConditionFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionFrom.Location = new System.Drawing.Point(0, 29);
            this.dgvAirConditionFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirConditionFrom.MultiSelect = false;
            this.dgvAirConditionFrom.Name = "dgvAirConditionFrom";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvAirConditionFrom.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAirConditionFrom.RowTemplate.Height = 31;
            this.dgvAirConditionFrom.Size = new System.Drawing.Size(1152, 212);
            this.dgvAirConditionFrom.TabIndex = 52;
            this.dgvAirConditionFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompressFrom_CellClick);
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.dtpEnd);
            this.gbxFun.Controls.Add(this.label6);
            this.gbxFun.Controls.Add(this.label5);
            this.gbxFun.Controls.Add(this.dtpStart);
            this.gbxFun.Controls.Add(this.btnAirConditionDemExport);
            this.gbxFun.Controls.Add(this.tbxMachineName);
            this.gbxFun.Controls.Add(this.cbxMachineCode);
            this.gbxFun.Controls.Add(this.label4);
            this.gbxFun.Controls.Add(this.label1);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.btnAirConditionDemStore);
            this.gbxFun.Controls.Add(this.btnAirConditionDemExit);
            this.gbxFun.Controls.Add(this.btnAirConditionDemDemand);
            this.gbxFun.Controls.Add(this.btnAirConditionDemDelete);
            this.gbxFun.Controls.Add(this.btnAirConditionDemModify);
            this.gbxFun.Controls.Add(this.btnAirConditionDemAdd);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Size = new System.Drawing.Size(1157, 266);
            this.gbxFun.TabIndex = 73;
            this.gbxFun.TabStop = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(775, 153);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(173, 35);
            this.dtpEnd.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(658, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 86;
            this.label6.Text = "查詢訖日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(658, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 85;
            this.label5.Text = "查詢起日";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(775, 110);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(173, 35);
            this.dtpStart.TabIndex = 84;
            // 
            // btnAirConditionDemExport
            // 
            this.btnAirConditionDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemExport.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemExport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemExport.Image")));
            this.btnAirConditionDemExport.Location = new System.Drawing.Point(196, 8);
            this.btnAirConditionDemExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemExport.Name = "btnAirConditionDemExport";
            this.btnAirConditionDemExport.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemExport.TabIndex = 83;
            this.btnAirConditionDemExport.Text = "匯出";
            this.btnAirConditionDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemExport.UseVisualStyleBackColor = false;
            this.btnAirConditionDemExport.Click += new System.EventHandler(this.btnAirConditionDemExport_Click);
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(240, 222);
            this.tbxMachineName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(309, 34);
            this.tbxMachineName.TabIndex = 82;
            // 
            // cbxMachineCode
            // 
            this.cbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMachineCode.FormattingEnabled = true;
            this.cbxMachineCode.Location = new System.Drawing.Point(240, 185);
            this.cbxMachineCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMachineCode.Name = "cbxMachineCode";
            this.cbxMachineCode.Size = new System.Drawing.Size(200, 33);
            this.cbxMachineCode.TabIndex = 81;
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
            this.label4.TabIndex = 80;
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
            this.label1.TabIndex = 79;
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
            this.cbxCategorysName.TabIndex = 78;
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(240, 110);
            this.cbxFactoryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(200, 33);
            this.cbxFactoryCode.TabIndex = 77;
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
            this.label3.TabIndex = 76;
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
            this.label2.TabIndex = 75;
            this.label2.Text = "廠房名稱";
            // 
            // btnAirConditionDemStore
            // 
            this.btnAirConditionDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemStore.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemStore.Image")));
            this.btnAirConditionDemStore.Location = new System.Drawing.Point(960, 8);
            this.btnAirConditionDemStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemStore.Name = "btnAirConditionDemStore";
            this.btnAirConditionDemStore.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemStore.TabIndex = 74;
            this.btnAirConditionDemStore.Text = "儲存";
            this.btnAirConditionDemStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemStore.UseVisualStyleBackColor = false;
            this.btnAirConditionDemStore.Visible = false;
            // 
            // btnAirConditionDemExit
            // 
            this.btnAirConditionDemExit.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemExit.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemExit.Image")));
            this.btnAirConditionDemExit.Location = new System.Drawing.Point(1053, 8);
            this.btnAirConditionDemExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemExit.Name = "btnAirConditionDemExit";
            this.btnAirConditionDemExit.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemExit.TabIndex = 73;
            this.btnAirConditionDemExit.Text = "離開";
            this.btnAirConditionDemExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemExit.UseVisualStyleBackColor = false;
            this.btnAirConditionDemExit.Visible = false;
            // 
            // btnAirConditionDemDemand
            // 
            this.btnAirConditionDemDemand.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemDemand.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemDemand.Image")));
            this.btnAirConditionDemDemand.Location = new System.Drawing.Point(103, 8);
            this.btnAirConditionDemDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemDemand.Name = "btnAirConditionDemDemand";
            this.btnAirConditionDemDemand.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemDemand.TabIndex = 72;
            this.btnAirConditionDemDemand.Text = "查詢";
            this.btnAirConditionDemDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemDemand.UseVisualStyleBackColor = false;
            this.btnAirConditionDemDemand.Click += new System.EventHandler(this.btnAirConditionDemDemand_Click);
            // 
            // btnAirConditionDemDelete
            // 
            this.btnAirConditionDemDelete.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemDelete.Enabled = false;
            this.btnAirConditionDemDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemDelete.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemDelete.Image")));
            this.btnAirConditionDemDelete.Location = new System.Drawing.Point(865, 8);
            this.btnAirConditionDemDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemDelete.Name = "btnAirConditionDemDelete";
            this.btnAirConditionDemDelete.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemDelete.TabIndex = 71;
            this.btnAirConditionDemDelete.Text = "刪除";
            this.btnAirConditionDemDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemDelete.UseVisualStyleBackColor = false;
            this.btnAirConditionDemDelete.Visible = false;
            // 
            // btnAirConditionDemModify
            // 
            this.btnAirConditionDemModify.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemModify.Enabled = false;
            this.btnAirConditionDemModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemModify.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemModify.Image")));
            this.btnAirConditionDemModify.Location = new System.Drawing.Point(8, 8);
            this.btnAirConditionDemModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemModify.Name = "btnAirConditionDemModify";
            this.btnAirConditionDemModify.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemModify.TabIndex = 70;
            this.btnAirConditionDemModify.Text = "修改";
            this.btnAirConditionDemModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemModify.UseVisualStyleBackColor = false;
            this.btnAirConditionDemModify.Click += new System.EventHandler(this.btnAirConditionDemModify_Click);
            // 
            // btnAirConditionDemAdd
            // 
            this.btnAirConditionDemAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemAdd.Enabled = false;
            this.btnAirConditionDemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemAdd.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemAdd.Image")));
            this.btnAirConditionDemAdd.Location = new System.Drawing.Point(772, 8);
            this.btnAirConditionDemAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionDemAdd.Name = "btnAirConditionDemAdd";
            this.btnAirConditionDemAdd.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionDemAdd.TabIndex = 69;
            this.btnAirConditionDemAdd.Text = "新增";
            this.btnAirConditionDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemAdd.UseVisualStyleBackColor = false;
            this.btnAirConditionDemAdd.Visible = false;
            // 
            // AirConditionDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxFun);
            this.Controls.Add(this.gbxShow2);
            this.Controls.Add(this.gbxShow1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AirConditionDem";
            this.Text = "AirConditionDem";
            this.Load += new System.EventHandler(this.AirConditionDem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AirConditionDem_Paint);
            this.Resize += new System.EventHandler(this.AirConditionDem_Resize);
            this.gbxShow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).EndInit();
            this.gbxShow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).EndInit();
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxShow2;
        private System.Windows.Forms.DataGridView dgvAirConditionTo;
        private System.Windows.Forms.GroupBox gbxShow1;
        private System.Windows.Forms.DataGridView dgvAirConditionFrom;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.ComboBox cbxMachineCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAirConditionDemStore;
        private System.Windows.Forms.Button btnAirConditionDemExit;
        private System.Windows.Forms.Button btnAirConditionDemDemand;
        private System.Windows.Forms.Button btnAirConditionDemDelete;
        private System.Windows.Forms.Button btnAirConditionDemModify;
        private System.Windows.Forms.Button btnAirConditionDemAdd;
        private System.Windows.Forms.Button btnAirConditionDemExport;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}