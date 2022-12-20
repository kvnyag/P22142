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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressDem));
            this.dgvCompressTo = new System.Windows.Forms.DataGridView();
            this.dgvCompressFrom = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompressTo
            // 
            this.dgvCompressTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressTo.Location = new System.Drawing.Point(0, 35);
            this.dgvCompressTo.MultiSelect = false;
            this.dgvCompressTo.Name = "dgvCompressTo";
            this.dgvCompressTo.RowTemplate.Height = 31;
            this.dgvCompressTo.Size = new System.Drawing.Size(1296, 385);
            this.dgvCompressTo.TabIndex = 32;
            // 
            // dgvCompressFrom
            // 
            this.dgvCompressFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressFrom.Location = new System.Drawing.Point(0, 35);
            this.dgvCompressFrom.MultiSelect = false;
            this.dgvCompressFrom.Name = "dgvCompressFrom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvCompressFrom.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompressFrom.RowTemplate.Height = 31;
            this.dgvCompressFrom.Size = new System.Drawing.Size(1296, 255);
            this.dgvCompressFrom.TabIndex = 52;
            this.dgvCompressFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompressFrom_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCompressTo);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1296, 429);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明細資料檢視";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompressFrom);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1296, 295);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料檢視";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.btnCompressDemExport);
            this.groupBox3.Controls.Add(this.tbxMachineName);
            this.groupBox3.Controls.Add(this.cbxMachineCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbxCategorysName);
            this.groupBox3.Controls.Add(this.cbxFactoryCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCompressDemStore);
            this.groupBox3.Controls.Add(this.btnCompressDemExit);
            this.groupBox3.Controls.Add(this.btnCompressDemDemand);
            this.groupBox3.Controls.Add(this.btnCompressDemDelete);
            this.groupBox3.Controls.Add(this.btnCompressDemModify);
            this.groupBox3.Controls.Add(this.btnCompressDemAdd);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1296, 320);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            // 
            // btnCompressDemExport
            // 
            this.btnCompressDemExport.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemExport.FlatAppearance.BorderSize = 0;
            this.btnCompressDemExport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemExport.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemExport.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemExport.Image")));
            this.btnCompressDemExport.Location = new System.Drawing.Point(221, 9);
            this.btnCompressDemExport.Name = "btnCompressDemExport";
            this.btnCompressDemExport.Size = new System.Drawing.Size(100, 100);
            this.btnCompressDemExport.TabIndex = 83;
            this.btnCompressDemExport.Text = "匯出";
            this.btnCompressDemExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemExport.UseVisualStyleBackColor = false;
            this.btnCompressDemExport.Click += new System.EventHandler(this.btnCompressDemExport_Click);
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
            // btnCompressDemStore
            // 
            this.btnCompressDemStore.BackColor = System.Drawing.Color.Teal;
            this.btnCompressDemStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressDemStore.FlatAppearance.BorderSize = 0;
            this.btnCompressDemStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressDemStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemStore.Image")));
            this.btnCompressDemStore.Location = new System.Drawing.Point(1080, 9);
            this.btnCompressDemStore.Name = "btnCompressDemStore";
            this.btnCompressDemStore.Size = new System.Drawing.Size(100, 100);
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
            this.btnCompressDemExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemExit.Image")));
            this.btnCompressDemExit.Location = new System.Drawing.Point(1185, 9);
            this.btnCompressDemExit.Name = "btnCompressDemExit";
            this.btnCompressDemExit.Size = new System.Drawing.Size(100, 100);
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
            this.btnCompressDemDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemDemand.Image")));
            this.btnCompressDemDemand.Location = new System.Drawing.Point(115, 9);
            this.btnCompressDemDemand.Name = "btnCompressDemDemand";
            this.btnCompressDemDemand.Size = new System.Drawing.Size(100, 100);
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
            this.btnCompressDemDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemDelete.Image")));
            this.btnCompressDemDelete.Location = new System.Drawing.Point(974, 9);
            this.btnCompressDemDelete.Name = "btnCompressDemDelete";
            this.btnCompressDemDelete.Size = new System.Drawing.Size(100, 100);
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
            this.btnCompressDemModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemModify.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemModify.Image")));
            this.btnCompressDemModify.Location = new System.Drawing.Point(9, 9);
            this.btnCompressDemModify.Name = "btnCompressDemModify";
            this.btnCompressDemModify.Size = new System.Drawing.Size(100, 100);
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
            this.btnCompressDemAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnCompressDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressDemAdd.Image")));
            this.btnCompressDemAdd.Location = new System.Drawing.Point(868, 9);
            this.btnCompressDemAdd.Name = "btnCompressDemAdd";
            this.btnCompressDemAdd.Size = new System.Drawing.Size(100, 100);
            this.btnCompressDemAdd.TabIndex = 69;
            this.btnCompressDemAdd.Text = "新增";
            this.btnCompressDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressDemAdd.UseVisualStyleBackColor = false;
            this.btnCompressDemAdd.Visible = false;
            // 
            // CompressDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1296, 1044);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompressDem";
            this.Text = "CompressDem";
            this.Load += new System.EventHandler(this.CompressDem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompressTo;
        private System.Windows.Forms.DataGridView dgvCompressFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
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
    }
}