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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVacuumTo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVacuumDemExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumFrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumTo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(262, 262);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(348, 39);
            this.tbxMachineName.TabIndex = 51;
            // 
            // cbxMachineCode
            // 
            this.cbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMachineCode.FormattingEnabled = true;
            this.cbxMachineCode.Location = new System.Drawing.Point(262, 218);
            this.cbxMachineCode.Name = "cbxMachineCode";
            this.cbxMachineCode.Size = new System.Drawing.Size(224, 38);
            this.cbxMachineCode.TabIndex = 50;
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
            this.label4.TabIndex = 49;
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
            this.label1.TabIndex = 48;
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
            this.cbxCategorysName.TabIndex = 47;
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(262, 128);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(224, 38);
            this.cbxFactoryCode.TabIndex = 46;
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
            this.label3.TabIndex = 45;
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
            this.label2.TabIndex = 44;
            this.label2.Text = "廠房名稱";
            // 
            // btnVacuumDemStore
            // 
            this.btnVacuumDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemStore.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemStore.Image")));
            this.btnVacuumDemStore.Location = new System.Drawing.Point(1080, 9);
            this.btnVacuumDemStore.Name = "btnVacuumDemStore";
            this.btnVacuumDemStore.Size = new System.Drawing.Size(100, 100);
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
            this.btnVacuumDemExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemExit.Image")));
            this.btnVacuumDemExit.Location = new System.Drawing.Point(1185, 9);
            this.btnVacuumDemExit.Name = "btnVacuumDemExit";
            this.btnVacuumDemExit.Size = new System.Drawing.Size(100, 100);
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
            this.btnVacuumDemDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemDemand.Image")));
            this.btnVacuumDemDemand.Location = new System.Drawing.Point(115, 9);
            this.btnVacuumDemDemand.Name = "btnVacuumDemDemand";
            this.btnVacuumDemDemand.Size = new System.Drawing.Size(100, 100);
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
            this.btnVacuumDemDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemDelete.Image")));
            this.btnVacuumDemDelete.Location = new System.Drawing.Point(974, 9);
            this.btnVacuumDemDelete.Name = "btnVacuumDemDelete";
            this.btnVacuumDemDelete.Size = new System.Drawing.Size(100, 100);
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
            this.btnVacuumDemModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemModify.Image")));
            this.btnVacuumDemModify.Location = new System.Drawing.Point(9, 9);
            this.btnVacuumDemModify.Name = "btnVacuumDemModify";
            this.btnVacuumDemModify.Size = new System.Drawing.Size(100, 100);
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
            this.btnVacuumDemAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemAdd.Image")));
            this.btnVacuumDemAdd.Location = new System.Drawing.Point(868, 9);
            this.btnVacuumDemAdd.Name = "btnVacuumDemAdd";
            this.btnVacuumDemAdd.Size = new System.Drawing.Size(100, 100);
            this.btnVacuumDemAdd.TabIndex = 38;
            this.btnVacuumDemAdd.Text = "新增";
            this.btnVacuumDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemAdd.UseVisualStyleBackColor = false;
            this.btnVacuumDemAdd.Visible = false;
            // 
            // dgvVacuumFrom
            // 
            this.dgvVacuumFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacuumFrom.Location = new System.Drawing.Point(0, 35);
            this.dgvVacuumFrom.MultiSelect = false;
            this.dgvVacuumFrom.Name = "dgvVacuumFrom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvVacuumFrom.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVacuumFrom.RowTemplate.Height = 31;
            this.dgvVacuumFrom.Size = new System.Drawing.Size(1296, 255);
            this.dgvVacuumFrom.TabIndex = 52;
            this.dgvVacuumFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacuumFrom_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVacuumFrom);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1296, 295);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料檢視";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVacuumTo);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1296, 429);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明細資料檢視";
            // 
            // dgvVacuumTo
            // 
            this.dgvVacuumTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacuumTo.Location = new System.Drawing.Point(0, 35);
            this.dgvVacuumTo.MultiSelect = false;
            this.dgvVacuumTo.Name = "dgvVacuumTo";
            this.dgvVacuumTo.RowTemplate.Height = 31;
            this.dgvVacuumTo.Size = new System.Drawing.Size(1296, 385);
            this.dgvVacuumTo.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.btnVacuumDemExport);
            this.groupBox3.Controls.Add(this.btnVacuumDemAdd);
            this.groupBox3.Controls.Add(this.btnVacuumDemModify);
            this.groupBox3.Controls.Add(this.btnVacuumDemDelete);
            this.groupBox3.Controls.Add(this.tbxMachineName);
            this.groupBox3.Controls.Add(this.btnVacuumDemDemand);
            this.groupBox3.Controls.Add(this.cbxMachineCode);
            this.groupBox3.Controls.Add(this.btnVacuumDemExit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnVacuumDemStore);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbxCategorysName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbxFactoryCode);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1296, 320);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            // 
            // btnVacuumDemExport
            // 
            this.btnVacuumDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnVacuumDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemExport.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemExport.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemExport.Image")));
            this.btnVacuumDemExport.Location = new System.Drawing.Point(221, 9);
            this.btnVacuumDemExport.Name = "btnVacuumDemExport";
            this.btnVacuumDemExport.Size = new System.Drawing.Size(100, 100);
            this.btnVacuumDemExport.TabIndex = 52;
            this.btnVacuumDemExport.Text = "匯出";
            this.btnVacuumDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemExport.UseVisualStyleBackColor = false;
            this.btnVacuumDemExport.Click += new System.EventHandler(this.btnVacuumDemExport_Click);
            // 
            // VacuumDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1296, 1044);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VacuumDem";
            this.Text = "VacuumDem";
            this.Load += new System.EventHandler(this.VacuumDem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumFrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuumTo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVacuumTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVacuumDemExport;
    }
}