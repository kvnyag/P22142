namespace P2214201
{
    partial class CompressDem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressDem));
            this.dgvCompressTo = new System.Windows.Forms.DataGridView();
            this.dgvCompressFrom = new System.Windows.Forms.DataGridView();
            this.gbxShow2 = new System.Windows.Forms.GroupBox();
            this.gbxShow1 = new System.Windows.Forms.GroupBox();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCompressDemExport = new System.Windows.Forms.Button();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.cbxMachineCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompressDemStore = new System.Windows.Forms.Button();
            this.btnCompressDemExit = new System.Windows.Forms.Button();
            this.btnCompressDemDemand = new System.Windows.Forms.Button();
            this.btnCompressDemDelete = new System.Windows.Forms.Button();
            this.btnCompressDemModify = new System.Windows.Forms.Button();
            this.btnCompressDemAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressFrom)).BeginInit();
            this.gbxShow2.SuspendLayout();
            this.gbxShow1.SuspendLayout();
            this.gbxFun.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompressTo
            // 
            this.dgvCompressTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressTo.Location = new System.Drawing.Point(0, 29);
            this.dgvCompressTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompressTo.MultiSelect = false;
            this.dgvCompressTo.Name = "dgvCompressTo";
            this.dgvCompressTo.RowTemplate.Height = 31;
            this.dgvCompressTo.Size = new System.Drawing.Size(1152, 321);
            this.dgvCompressTo.TabIndex = 32;
            // 
            // dgvCompressFrom
            // 
            this.dgvCompressFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressFrom.Location = new System.Drawing.Point(0, 29);
            this.dgvCompressFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompressFrom.MultiSelect = false;
            this.dgvCompressFrom.Name = "dgvCompressFrom";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvCompressFrom.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCompressFrom.RowTemplate.Height = 31;
            this.dgvCompressFrom.Size = new System.Drawing.Size(1152, 212);
            this.dgvCompressFrom.TabIndex = 52;
            this.dgvCompressFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompressFrom_CellClick);
            // 
            // gbxShow2
            // 
            this.gbxShow2.Controls.Add(this.dgvCompressTo);
            this.gbxShow2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow2.Location = new System.Drawing.Point(0, 512);
            this.gbxShow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Name = "gbxShow2";
            this.gbxShow2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow2.Size = new System.Drawing.Size(1157, 358);
            this.gbxShow2.TabIndex = 70;
            this.gbxShow2.TabStop = false;
            this.gbxShow2.Text = "明細資料檢視";
            // 
            // gbxShow1
            // 
            this.gbxShow1.Controls.Add(this.dgvCompressFrom);
            this.gbxShow1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShow1.Location = new System.Drawing.Point(0, 266);
            this.gbxShow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Name = "gbxShow1";
            this.gbxShow1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxShow1.Size = new System.Drawing.Size(1157, 246);
            this.gbxShow1.TabIndex = 69;
            this.gbxShow1.TabStop = false;
            this.gbxShow1.Text = "資料檢視";
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.dtpEnd);
            this.gbxFun.Controls.Add(this.label6);
            this.gbxFun.Controls.Add(this.label5);
            this.gbxFun.Controls.Add(this.dtpStart);
            this.gbxFun.Controls.Add(this.btnCompressDemExport);
            this.gbxFun.Controls.Add(this.tbxMachineName);
            this.gbxFun.Controls.Add(this.cbxMachineCode);
            this.gbxFun.Controls.Add(this.label4);
            this.gbxFun.Controls.Add(this.label1);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.btnCompressDemStore);
            this.gbxFun.Controls.Add(this.btnCompressDemExit);
            this.gbxFun.Controls.Add(this.btnCompressDemDemand);
            this.gbxFun.Controls.Add(this.btnCompressDemDelete);
            this.gbxFun.Controls.Add(this.btnCompressDemModify);
            this.gbxFun.Controls.Add(this.btnCompressDemAdd);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxFun.Size = new System.Drawing.Size(1157, 266);
            this.gbxFun.TabIndex = 74;
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
            this.dtpEnd.TabIndex = 87;
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
            this.label6.TabIndex = 86;
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
            this.label5.TabIndex = 85;
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
            this.dtpStart.TabIndex = 84;
            // 
            // btnCompressDemExport
            // 
            this.btnCompressDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemExport.FlatAppearance.BorderSize = 0;
            this.btnCompressDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemExport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemExport.Image")));
            this.btnCompressDemExport.Location = new System.Drawing.Point(196, 8);
            this.btnCompressDemExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemExport.Name = "btnCompressDemExport";
            this.btnCompressDemExport.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemExport.TabIndex = 83;
            this.btnCompressDemExport.Text = "匯出";
            this.btnCompressDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemExport.UseVisualStyleBackColor = false;
            this.btnCompressDemExport.Click += new System.EventHandler(this.btnCompressDemExport_Click);
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
            // btnCompressDemStore
            // 
            this.btnCompressDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemStore.FlatAppearance.BorderSize = 0;
            this.btnCompressDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemStore.Image")));
            this.btnCompressDemStore.Location = new System.Drawing.Point(960, 8);
            this.btnCompressDemStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemStore.Name = "btnCompressDemStore";
            this.btnCompressDemStore.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemStore.TabIndex = 74;
            this.btnCompressDemStore.Text = "儲存";
            this.btnCompressDemStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemStore.UseVisualStyleBackColor = false;
            this.btnCompressDemStore.Visible = false;
            // 
            // btnCompressDemExit
            // 
            this.btnCompressDemExit.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemExit.FlatAppearance.BorderSize = 0;
            this.btnCompressDemExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemExit.Image")));
            this.btnCompressDemExit.Location = new System.Drawing.Point(1053, 8);
            this.btnCompressDemExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemExit.Name = "btnCompressDemExit";
            this.btnCompressDemExit.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemExit.TabIndex = 73;
            this.btnCompressDemExit.Text = "離開";
            this.btnCompressDemExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemExit.UseVisualStyleBackColor = false;
            this.btnCompressDemExit.Visible = false;
            // 
            // btnCompressDemDemand
            // 
            this.btnCompressDemDemand.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemDemand.FlatAppearance.BorderSize = 0;
            this.btnCompressDemDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemDemand.Image")));
            this.btnCompressDemDemand.Location = new System.Drawing.Point(103, 8);
            this.btnCompressDemDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemDemand.Name = "btnCompressDemDemand";
            this.btnCompressDemDemand.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemDemand.TabIndex = 72;
            this.btnCompressDemDemand.Text = "查詢";
            this.btnCompressDemDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemDemand.UseVisualStyleBackColor = false;
            this.btnCompressDemDemand.Click += new System.EventHandler(this.btnCompressDemDemand_Click);
            // 
            // btnCompressDemDelete
            // 
            this.btnCompressDemDelete.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemDelete.Enabled = false;
            this.btnCompressDemDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemDelete.FlatAppearance.BorderSize = 0;
            this.btnCompressDemDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemDelete.Image")));
            this.btnCompressDemDelete.Location = new System.Drawing.Point(865, 8);
            this.btnCompressDemDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemDelete.Name = "btnCompressDemDelete";
            this.btnCompressDemDelete.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemDelete.TabIndex = 71;
            this.btnCompressDemDelete.Text = "刪除";
            this.btnCompressDemDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemDelete.UseVisualStyleBackColor = false;
            this.btnCompressDemDelete.Visible = false;
            // 
            // btnCompressDemModify
            // 
            this.btnCompressDemModify.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemModify.Enabled = false;
            this.btnCompressDemModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemModify.FlatAppearance.BorderSize = 0;
            this.btnCompressDemModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemModify.Image")));
            this.btnCompressDemModify.Location = new System.Drawing.Point(8, 8);
            this.btnCompressDemModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemModify.Name = "btnCompressDemModify";
            this.btnCompressDemModify.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemModify.TabIndex = 70;
            this.btnCompressDemModify.Text = "修改";
            this.btnCompressDemModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemModify.UseVisualStyleBackColor = false;
            this.btnCompressDemModify.Click += new System.EventHandler(this.btnCompressDemModify_Click);
            // 
            // btnCompressDemAdd
            // 
            this.btnCompressDemAdd.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemAdd.Enabled = false;
            this.btnCompressDemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemAdd.FlatAppearance.BorderSize = 0;
            this.btnCompressDemAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemAdd.Image")));
            this.btnCompressDemAdd.Location = new System.Drawing.Point(772, 8);
            this.btnCompressDemAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressDemAdd.Name = "btnCompressDemAdd";
            this.btnCompressDemAdd.Size = new System.Drawing.Size(89, 84);
            this.btnCompressDemAdd.TabIndex = 69;
            this.btnCompressDemAdd.Text = "新增";
            this.btnCompressDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemAdd.UseVisualStyleBackColor = false;
            this.btnCompressDemAdd.Visible = false;
            // 
            // CompressDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxFun);
            this.Controls.Add(this.gbxShow2);
            this.Controls.Add(this.gbxShow1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompressDem";
            this.Text = "CompressDem";
            this.Load += new System.EventHandler(this.CompressDem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CompressDem_Paint);
            this.Resize += new System.EventHandler(this.CompressDem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressFrom)).EndInit();
            this.gbxShow2.ResumeLayout(false);
            this.gbxShow1.ResumeLayout(false);
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompressTo;
        private System.Windows.Forms.DataGridView dgvCompressFrom;
        private System.Windows.Forms.GroupBox gbxShow2;
        private System.Windows.Forms.GroupBox gbxShow1;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.ComboBox cbxMachineCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompressDemStore;
        private System.Windows.Forms.Button btnCompressDemExit;
        private System.Windows.Forms.Button btnCompressDemDemand;
        private System.Windows.Forms.Button btnCompressDemDelete;
        private System.Windows.Forms.Button btnCompressDemModify;
        private System.Windows.Forms.Button btnCompressDemAdd;
        private System.Windows.Forms.Button btnCompressDemExport;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}