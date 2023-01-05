namespace P2214201
{
    partial class AirConditionRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirConditionRep));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tbxMachineName = new System.Windows.Forms.TextBox();
            this.cbxMachineCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.dgvAirConditionTo = new System.Windows.Forms.DataGridView();
            this.dgvAirConditionFrom = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAirConditionRepStore = new System.Windows.Forms.Button();
            this.btnAirConditionRepExit = new System.Windows.Forms.Button();
            this.btnAirConditionRepDemand = new System.Windows.Forms.Button();
            this.btnAirConditionRepDelete = new System.Windows.Forms.Button();
            this.btnAirConditionRepModify = new System.Windows.Forms.Button();
            this.btnAirConditionRepAdd = new System.Windows.Forms.Button();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.gbxShow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).BeginInit();
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
            // dgvAirConditionTo
            // 
            this.dgvAirConditionTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionTo.Location = new System.Drawing.Point(603, 11);
            this.dgvAirConditionTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirConditionTo.MultiSelect = false;
            this.dgvAirConditionTo.Name = "dgvAirConditionTo";
            this.dgvAirConditionTo.RowTemplate.Height = 31;
            this.dgvAirConditionTo.Size = new System.Drawing.Size(549, 609);
            this.dgvAirConditionTo.TabIndex = 49;
            this.dgvAirConditionTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAirConditionTo_CellContentClick);
            // 
            // dgvAirConditionFrom
            // 
            this.dgvAirConditionFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirConditionFrom.Location = new System.Drawing.Point(3, 11);
            this.dgvAirConditionFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirConditionFrom.MultiSelect = false;
            this.dgvAirConditionFrom.Name = "dgvAirConditionFrom";
            this.dgvAirConditionFrom.RowTemplate.Height = 31;
            this.dgvAirConditionFrom.Size = new System.Drawing.Size(533, 609);
            this.dgvAirConditionFrom.TabIndex = 48;
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
            // btnAirConditionRepStore
            // 
            this.btnAirConditionRepStore.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepStore.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepStore.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepStore.Image")));
            this.btnAirConditionRepStore.Location = new System.Drawing.Point(960, 8);
            this.btnAirConditionRepStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepStore.Name = "btnAirConditionRepStore";
            this.btnAirConditionRepStore.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepStore.TabIndex = 45;
            this.btnAirConditionRepStore.Text = "儲存";
            this.btnAirConditionRepStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepStore.UseVisualStyleBackColor = false;
            this.btnAirConditionRepStore.Visible = false;
            // 
            // btnAirConditionRepExit
            // 
            this.btnAirConditionRepExit.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepExit.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepExit.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepExit.Image")));
            this.btnAirConditionRepExit.Location = new System.Drawing.Point(1053, 8);
            this.btnAirConditionRepExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepExit.Name = "btnAirConditionRepExit";
            this.btnAirConditionRepExit.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepExit.TabIndex = 44;
            this.btnAirConditionRepExit.Text = "離開";
            this.btnAirConditionRepExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepExit.UseVisualStyleBackColor = false;
            this.btnAirConditionRepExit.Visible = false;
            // 
            // btnAirConditionRepDemand
            // 
            this.btnAirConditionRepDemand.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepDemand.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepDemand.Image")));
            this.btnAirConditionRepDemand.Location = new System.Drawing.Point(289, 8);
            this.btnAirConditionRepDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepDemand.Name = "btnAirConditionRepDemand";
            this.btnAirConditionRepDemand.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepDemand.TabIndex = 43;
            this.btnAirConditionRepDemand.Text = "查詢";
            this.btnAirConditionRepDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepDemand.UseVisualStyleBackColor = false;
            this.btnAirConditionRepDemand.Visible = false;
            // 
            // btnAirConditionRepDelete
            // 
            this.btnAirConditionRepDelete.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepDelete.Enabled = false;
            this.btnAirConditionRepDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepDelete.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepDelete.Image")));
            this.btnAirConditionRepDelete.Location = new System.Drawing.Point(196, 8);
            this.btnAirConditionRepDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepDelete.Name = "btnAirConditionRepDelete";
            this.btnAirConditionRepDelete.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepDelete.TabIndex = 42;
            this.btnAirConditionRepDelete.Text = "刪除";
            this.btnAirConditionRepDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepDelete.UseVisualStyleBackColor = false;
            this.btnAirConditionRepDelete.Click += new System.EventHandler(this.btnAirConditionRepDelete_Click);
            // 
            // btnAirConditionRepModify
            // 
            this.btnAirConditionRepModify.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepModify.Enabled = false;
            this.btnAirConditionRepModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepModify.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepModify.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepModify.Image")));
            this.btnAirConditionRepModify.Location = new System.Drawing.Point(103, 8);
            this.btnAirConditionRepModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepModify.Name = "btnAirConditionRepModify";
            this.btnAirConditionRepModify.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepModify.TabIndex = 41;
            this.btnAirConditionRepModify.Text = "修改";
            this.btnAirConditionRepModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepModify.UseVisualStyleBackColor = false;
            this.btnAirConditionRepModify.Click += new System.EventHandler(this.btnAirConditionRepModify_Click);
            // 
            // btnAirConditionRepAdd
            // 
            this.btnAirConditionRepAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAirConditionRepAdd.Enabled = false;
            this.btnAirConditionRepAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAirConditionRepAdd.FlatAppearance.BorderSize = 0;
            this.btnAirConditionRepAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAirConditionRepAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAirConditionRepAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAirConditionRepAdd.Image")));
            this.btnAirConditionRepAdd.Location = new System.Drawing.Point(8, 8);
            this.btnAirConditionRepAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirConditionRepAdd.Name = "btnAirConditionRepAdd";
            this.btnAirConditionRepAdd.Size = new System.Drawing.Size(89, 84);
            this.btnAirConditionRepAdd.TabIndex = 40;
            this.btnAirConditionRepAdd.Text = "新增";
            this.btnAirConditionRepAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAirConditionRepAdd.UseVisualStyleBackColor = false;
            this.btnAirConditionRepAdd.Click += new System.EventHandler(this.btnAirConditionRepAdd_Click);
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.btnAirConditionRepAdd);
            this.gbxFun.Controls.Add(this.btnAirConditionRepModify);
            this.gbxFun.Controls.Add(this.btnAirConditionRepDelete);
            this.gbxFun.Controls.Add(this.btnAirConditionRepDemand);
            this.gbxFun.Controls.Add(this.tbxMachineName);
            this.gbxFun.Controls.Add(this.btnAirConditionRepExit);
            this.gbxFun.Controls.Add(this.cbxMachineCode);
            this.gbxFun.Controls.Add(this.btnAirConditionRepStore);
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
            this.gbxShow.Controls.Add(this.dgvAirConditionFrom);
            this.gbxShow.Controls.Add(this.dgvAirConditionTo);
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
            // AirConditionRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxShow);
            this.Controls.Add(this.gbxFun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AirConditionRep";
            this.Text = "冷氣運轉記錄表";
            this.Load += new System.EventHandler(this.AirConditionRep_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AirConditionRep_Paint);
            this.Resize += new System.EventHandler(this.AirConditionRep_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirConditionFrom)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAirConditionTo;
        private System.Windows.Forms.DataGridView dgvAirConditionFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAirConditionRepStore;
        private System.Windows.Forms.Button btnAirConditionRepExit;
        private System.Windows.Forms.Button btnAirConditionRepDemand;
        private System.Windows.Forms.Button btnAirConditionRepDelete;
        private System.Windows.Forms.Button btnAirConditionRepModify;
        private System.Windows.Forms.Button btnAirConditionRepAdd;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.GroupBox gbxShow;
    }
}