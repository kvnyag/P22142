namespace P2214201
{
    partial class CompressRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressRep));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.cbxMachineCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.dgvCompressTo = new System.Windows.Forms.DataGridView();
            this.dgvCompressFrom = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompressRepStore = new System.Windows.Forms.Button();
            this.btnCompressRepExit = new System.Windows.Forms.Button();
            this.btnCompressRepDemand = new System.Windows.Forms.Button();
            this.btnCompressRepDelete = new System.Windows.Forms.Button();
            this.btnCompressRepModify = new System.Windows.Forms.Button();
            this.btnCompressRepAdd = new System.Windows.Forms.Button();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.gbxShow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressFrom)).BeginInit();
            this.gbxFun.SuspendLayout();
            this.gbxShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Teal;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(539, 399);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(57, 54);
            this.btnRight.TabIndex = 57;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Teal;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(539, 155);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(57, 54);
            this.btnLeft.TabIndex = 56;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // tbxMachineName
            // 
            this.tbxMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxMachineName.Location = new System.Drawing.Point(240, 222);
            this.tbxMachineName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMachineName.Name = "tbxMachineName";
            this.tbxMachineName.Size = new System.Drawing.Size(309, 34);
            this.tbxMachineName.TabIndex = 55;
            // 
            // cbxMachineCode
            // 
            this.cbxMachineCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMachineCode.FormattingEnabled = true;
            this.cbxMachineCode.Location = new System.Drawing.Point(240, 185);
            this.cbxMachineCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMachineCode.Name = "cbxMachineCode";
            this.cbxMachineCode.Size = new System.Drawing.Size(200, 33);
            this.cbxMachineCode.TabIndex = 54;
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
            this.label4.TabIndex = 53;
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
            this.label1.TabIndex = 52;
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
            this.cbxCategorysName.TabIndex = 51;
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(240, 110);
            this.cbxFactoryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(200, 33);
            this.cbxFactoryCode.TabIndex = 50;
            this.cbxFactoryCode.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryCode_SelectedIndexChanged);
            // 
            // dgvCompressTo
            // 
            this.dgvCompressTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressTo.Location = new System.Drawing.Point(603, 11);
            this.dgvCompressTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompressTo.MultiSelect = false;
            this.dgvCompressTo.Name = "dgvCompressTo";
            this.dgvCompressTo.RowTemplate.Height = 31;
            this.dgvCompressTo.Size = new System.Drawing.Size(549, 609);
            this.dgvCompressTo.TabIndex = 49;
            this.dgvCompressTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompressTo_CellContentClick);
            // 
            // dgvCompressFrom
            // 
            this.dgvCompressFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompressFrom.Location = new System.Drawing.Point(3, 11);
            this.dgvCompressFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompressFrom.MultiSelect = false;
            this.dgvCompressFrom.Name = "dgvCompressFrom";
            this.dgvCompressFrom.RowTemplate.Height = 31;
            this.dgvCompressFrom.Size = new System.Drawing.Size(533, 609);
            this.dgvCompressFrom.TabIndex = 48;
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
            this.label3.TabIndex = 47;
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
            this.label2.TabIndex = 46;
            this.label2.Text = "廠房代號";
            // 
            // btnCompressRepStore
            // 
            this.btnCompressRepStore.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepStore.FlatAppearance.BorderSize = 0;
            this.btnCompressRepStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepStore.Image")));
            this.btnCompressRepStore.Location = new System.Drawing.Point(960, 8);
            this.btnCompressRepStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepStore.Name = "btnCompressRepStore";
            this.btnCompressRepStore.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepStore.TabIndex = 45;
            this.btnCompressRepStore.Text = "儲存";
            this.btnCompressRepStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepStore.UseVisualStyleBackColor = false;
            this.btnCompressRepStore.Visible = false;
            // 
            // btnCompressRepExit
            // 
            this.btnCompressRepExit.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepExit.FlatAppearance.BorderSize = 0;
            this.btnCompressRepExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepExit.Image")));
            this.btnCompressRepExit.Location = new System.Drawing.Point(1053, 8);
            this.btnCompressRepExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepExit.Name = "btnCompressRepExit";
            this.btnCompressRepExit.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepExit.TabIndex = 44;
            this.btnCompressRepExit.Text = "離開";
            this.btnCompressRepExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepExit.UseVisualStyleBackColor = false;
            this.btnCompressRepExit.Visible = false;
            // 
            // btnCompressRepDemand
            // 
            this.btnCompressRepDemand.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepDemand.FlatAppearance.BorderSize = 0;
            this.btnCompressRepDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepDemand.Image")));
            this.btnCompressRepDemand.Location = new System.Drawing.Point(289, 8);
            this.btnCompressRepDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepDemand.Name = "btnCompressRepDemand";
            this.btnCompressRepDemand.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepDemand.TabIndex = 43;
            this.btnCompressRepDemand.Text = "查詢";
            this.btnCompressRepDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepDemand.UseVisualStyleBackColor = false;
            this.btnCompressRepDemand.Visible = false;
            // 
            // btnCompressRepDelete
            // 
            this.btnCompressRepDelete.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepDelete.Enabled = false;
            this.btnCompressRepDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepDelete.FlatAppearance.BorderSize = 0;
            this.btnCompressRepDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepDelete.Image")));
            this.btnCompressRepDelete.Location = new System.Drawing.Point(196, 8);
            this.btnCompressRepDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepDelete.Name = "btnCompressRepDelete";
            this.btnCompressRepDelete.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepDelete.TabIndex = 42;
            this.btnCompressRepDelete.Text = "刪除";
            this.btnCompressRepDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepDelete.UseVisualStyleBackColor = false;
            this.btnCompressRepDelete.Click += new System.EventHandler(this.btnCompressRepDelete_Click);
            // 
            // btnCompressRepModify
            // 
            this.btnCompressRepModify.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepModify.Enabled = false;
            this.btnCompressRepModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepModify.FlatAppearance.BorderSize = 0;
            this.btnCompressRepModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepModify.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepModify.Image")));
            this.btnCompressRepModify.Location = new System.Drawing.Point(103, 8);
            this.btnCompressRepModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepModify.Name = "btnCompressRepModify";
            this.btnCompressRepModify.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepModify.TabIndex = 41;
            this.btnCompressRepModify.Text = "修改";
            this.btnCompressRepModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepModify.UseVisualStyleBackColor = false;
            this.btnCompressRepModify.Click += new System.EventHandler(this.btnCompressRepModify_Click);
            // 
            // btnCompressRepAdd
            // 
            this.btnCompressRepAdd.BackColor = System.Drawing.Color.Teal;
            this.btnCompressRepAdd.Enabled = false;
            this.btnCompressRepAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompressRepAdd.FlatAppearance.BorderSize = 0;
            this.btnCompressRepAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompressRepAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompressRepAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCompressRepAdd.Image")));
            this.btnCompressRepAdd.Location = new System.Drawing.Point(8, 8);
            this.btnCompressRepAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompressRepAdd.Name = "btnCompressRepAdd";
            this.btnCompressRepAdd.Size = new System.Drawing.Size(89, 84);
            this.btnCompressRepAdd.TabIndex = 40;
            this.btnCompressRepAdd.Text = "新增";
            this.btnCompressRepAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompressRepAdd.UseVisualStyleBackColor = false;
            this.btnCompressRepAdd.Click += new System.EventHandler(this.btnCompressRepAdd_Click);
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.btnCompressRepAdd);
            this.gbxFun.Controls.Add(this.btnCompressRepModify);
            this.gbxFun.Controls.Add(this.btnCompressRepDelete);
            this.gbxFun.Controls.Add(this.btnCompressRepDemand);
            this.gbxFun.Controls.Add(this.tbxMachineName);
            this.gbxFun.Controls.Add(this.btnCompressRepExit);
            this.gbxFun.Controls.Add(this.cbxMachineCode);
            this.gbxFun.Controls.Add(this.btnCompressRepStore);
            this.gbxFun.Controls.Add(this.label4);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.label1);
            this.gbxFun.Controls.Add(this.label3);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Location = new System.Drawing.Point(0, 0);
            this.gbxFun.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFun.Name = "gbxFun";
            this.gbxFun.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFun.Size = new System.Drawing.Size(1157, 268);
            this.gbxFun.TabIndex = 58;
            this.gbxFun.TabStop = false;
            // 
            // gbxShow
            // 
            this.gbxShow.BackColor = System.Drawing.Color.Transparent;
            this.gbxShow.Controls.Add(this.dgvCompressFrom);
            this.gbxShow.Controls.Add(this.dgvCompressTo);
            this.gbxShow.Controls.Add(this.btnRight);
            this.gbxShow.Controls.Add(this.btnLeft);
            this.gbxShow.Location = new System.Drawing.Point(0, 266);
            this.gbxShow.Margin = new System.Windows.Forms.Padding(4);
            this.gbxShow.Name = "gbxShow";
            this.gbxShow.Padding = new System.Windows.Forms.Padding(4);
            this.gbxShow.Size = new System.Drawing.Size(1157, 622);
            this.gbxShow.TabIndex = 59;
            this.gbxShow.TabStop = false;
            // 
            // CompressRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxShow);
            this.Controls.Add(this.gbxFun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompressRep";
            this.Text = "空壓機運轉記錄表";
            this.Load += new System.EventHandler(this.CompressRep_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CompressRep_Paint);
            this.Resize += new System.EventHandler(this.CompressRep_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompressFrom)).EndInit();
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.gbxShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.ComboBox cbxMachineCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.DataGridView dgvCompressTo;
        private System.Windows.Forms.DataGridView dgvCompressFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompressRepStore;
        private System.Windows.Forms.Button btnCompressRepExit;
        private System.Windows.Forms.Button btnCompressRepDemand;
        private System.Windows.Forms.Button btnCompressRepDelete;
        private System.Windows.Forms.Button btnCompressRepModify;
        private System.Windows.Forms.Button btnCompressRepAdd;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.GroupBox gbxShow;
    }
}