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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirConditionDem));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAirConditionTo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAirConditionFrom = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAirConditionTo);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1296, 429);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明細資料檢視";
            // 
            // dgvAirConditionTo
            // 
            this.dgvAirConditionTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionTo.Location = new System.Drawing.Point(0, 35);
            this.dgvAirConditionTo.MultiSelect = false;
            this.dgvAirConditionTo.Name = "dgvAirConditionTo";
            this.dgvAirConditionTo.RowTemplate.Height = 31;
            this.dgvAirConditionTo.Size = new System.Drawing.Size(1296, 385);
            this.dgvAirConditionTo.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAirConditionFrom);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1296, 295);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料檢視";
            // 
            // dgvAirConditionFrom
            // 
            this.dgvAirConditionFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionFrom.Location = new System.Drawing.Point(0, 35);
            this.dgvAirConditionFrom.MultiSelect = false;
            this.dgvAirConditionFrom.Name = "dgvAirConditionFrom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvAirConditionFrom.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAirConditionFrom.RowTemplate.Height = 31;
            this.dgvAirConditionFrom.Size = new System.Drawing.Size(1296, 255);
            this.dgvAirConditionFrom.TabIndex = 52;
            this.dgvAirConditionFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompressFrom_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.btnAirConditionDemExport);
            this.groupBox3.Controls.Add(this.tbxMachineName);
            this.groupBox3.Controls.Add(this.cbxMachineCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbxCategorysName);
            this.groupBox3.Controls.Add(this.cbxFactoryCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAirConditionDemStore);
            this.groupBox3.Controls.Add(this.btnAirConditionDemExit);
            this.groupBox3.Controls.Add(this.btnAirConditionDemDemand);
            this.groupBox3.Controls.Add(this.btnAirConditionDemDelete);
            this.groupBox3.Controls.Add(this.btnAirConditionDemModify);
            this.groupBox3.Controls.Add(this.btnAirConditionDemAdd);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1296, 320);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            // 
            // btnAirConditionDemExport
            // 
            this.btnAirConditionDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemExport.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemExport.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemExport.Image")));
            this.btnAirConditionDemExport.Location = new System.Drawing.Point(221, 9);
            this.btnAirConditionDemExport.Name = "btnAirConditionDemExport";
            this.btnAirConditionDemExport.Size = new System.Drawing.Size(100, 100);
            this.btnAirConditionDemExport.TabIndex = 83;
            this.btnAirConditionDemExport.Text = "匯出";
            this.btnAirConditionDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemExport.UseVisualStyleBackColor = false;
            this.btnAirConditionDemExport.Click += new System.EventHandler(this.btnAirConditionDemExport_Click);
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(262, 262);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(348, 39);
            this.tbxMachineName.TabIndex = 82;
            // 
            // cbxMachineCode
            // 
            this.cbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMachineCode.FormattingEnabled = true;
            this.cbxMachineCode.Location = new System.Drawing.Point(262, 218);
            this.cbxMachineCode.Name = "cbxMachineCode";
            this.cbxMachineCode.Size = new System.Drawing.Size(224, 38);
            this.cbxMachineCode.TabIndex = 81;
            this.cbxMachineCode.SelectedIndexChanged += new System.EventHandler(this.cbxMachineCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(128, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 80;
            this.label4.Text = "機械名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(128, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 79;
            this.label1.Text = "機械編號";
            // 
            // cbxCategorysName
            // 
            this.cbxCategorysName.Enabled = false;
            this.cbxCategorysName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCategorysName.FormattingEnabled = true;
            this.cbxCategorysName.Location = new System.Drawing.Point(262, 172);
            this.cbxCategorysName.Name = "cbxCategorysName";
            this.cbxCategorysName.Size = new System.Drawing.Size(224, 38);
            this.cbxCategorysName.TabIndex = 78;
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(262, 128);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(224, 38);
            this.cbxFactoryCode.TabIndex = 77;
            this.cbxFactoryCode.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryCode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(128, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 76;
            this.label3.Text = "類別名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(128, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 75;
            this.label2.Text = "廠房名稱";
            // 
            // btnAirConditionDemStore
            // 
            this.btnAirConditionDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionDemStore.FlatAppearance.BorderSize = 0;
            this.btnAirConditionDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionDemStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemStore.Image")));
            this.btnAirConditionDemStore.Location = new System.Drawing.Point(1080, 9);
            this.btnAirConditionDemStore.Name = "btnAirConditionDemStore";
            this.btnAirConditionDemStore.Size = new System.Drawing.Size(100, 100);
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
            this.btnAirConditionDemExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemExit.Image")));
            this.btnAirConditionDemExit.Location = new System.Drawing.Point(1185, 9);
            this.btnAirConditionDemExit.Name = "btnAirConditionDemExit";
            this.btnAirConditionDemExit.Size = new System.Drawing.Size(100, 100);
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
            this.btnAirConditionDemDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemDemand.Image")));
            this.btnAirConditionDemDemand.Location = new System.Drawing.Point(115, 9);
            this.btnAirConditionDemDemand.Name = "btnAirConditionDemDemand";
            this.btnAirConditionDemDemand.Size = new System.Drawing.Size(100, 100);
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
            this.btnAirConditionDemDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemDelete.Image")));
            this.btnAirConditionDemDelete.Location = new System.Drawing.Point(974, 9);
            this.btnAirConditionDemDelete.Name = "btnAirConditionDemDelete";
            this.btnAirConditionDemDelete.Size = new System.Drawing.Size(100, 100);
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
            this.btnAirConditionDemModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemModify.Image")));
            this.btnAirConditionDemModify.Location = new System.Drawing.Point(9, 9);
            this.btnAirConditionDemModify.Name = "btnAirConditionDemModify";
            this.btnAirConditionDemModify.Size = new System.Drawing.Size(100, 100);
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
            this.btnAirConditionDemAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnAirConditionDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionDemAdd.Image")));
            this.btnAirConditionDemAdd.Location = new System.Drawing.Point(868, 9);
            this.btnAirConditionDemAdd.Name = "btnAirConditionDemAdd";
            this.btnAirConditionDemAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAirConditionDemAdd.TabIndex = 69;
            this.btnAirConditionDemAdd.Text = "新增";
            this.btnAirConditionDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionDemAdd.UseVisualStyleBackColor = false;
            this.btnAirConditionDemAdd.Visible = false;
            // 
            // AirConditionDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1296, 1044);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AirConditionDem";
            this.Text = "AirConditionDem";
            this.Load += new System.EventHandler(this.AirConditionDem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAirConditionTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAirConditionFrom;
        private System.Windows.Forms.GroupBox groupBox3;
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
    }
}