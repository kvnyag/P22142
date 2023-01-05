namespace P2214201
{
    partial class HydropowerRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydropowerRep));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.cbxCategorysName = new System.Windows.Forms.ComboBox();
            this.cbxFactoryCode = new System.Windows.Forms.ComboBox();
            this.dgvHydropowerTo = new System.Windows.Forms.DataGridView();
            this.dgvHydropowerFrom = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHydropowerRepStore = new System.Windows.Forms.Button();
            this.btnHydropowerRepExit = new System.Windows.Forms.Button();
            this.btnHydropowerRepDemand = new System.Windows.Forms.Button();
            this.btnHydropowerRepDelete = new System.Windows.Forms.Button();
            this.btnHydropowerRepModify = new System.Windows.Forms.Button();
            this.btnHydropowerRepAdd = new System.Windows.Forms.Button();
            this.gbxFun = new System.Windows.Forms.GroupBox();
            this.gbxShow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).BeginInit();
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
            // dgvHydropowerTo
            // 
            this.dgvHydropowerTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerTo.Location = new System.Drawing.Point(603, 11);
            this.dgvHydropowerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHydropowerTo.MultiSelect = false;
            this.dgvHydropowerTo.Name = "dgvHydropowerTo";
            this.dgvHydropowerTo.RowTemplate.Height = 31;
            this.dgvHydropowerTo.Size = new System.Drawing.Size(549, 609);
            this.dgvHydropowerTo.TabIndex = 49;
            this.dgvHydropowerTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHydropowerTo_CellContentClick);
            // 
            // dgvHydropowerFrom
            // 
            this.dgvHydropowerFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerFrom.Location = new System.Drawing.Point(3, 11);
            this.dgvHydropowerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHydropowerFrom.MultiSelect = false;
            this.dgvHydropowerFrom.Name = "dgvHydropowerFrom";
            this.dgvHydropowerFrom.RowTemplate.Height = 31;
            this.dgvHydropowerFrom.Size = new System.Drawing.Size(533, 609);
            this.dgvHydropowerFrom.TabIndex = 48;
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
            // btnHydropowerRepStore
            // 
            this.btnHydropowerRepStore.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepStore.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepStore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepStore.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepStore.Image")));
            this.btnHydropowerRepStore.Location = new System.Drawing.Point(960, 8);
            this.btnHydropowerRepStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepStore.Name = "btnHydropowerRepStore";
            this.btnHydropowerRepStore.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepStore.TabIndex = 45;
            this.btnHydropowerRepStore.Text = "儲存";
            this.btnHydropowerRepStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepStore.UseVisualStyleBackColor = false;
            this.btnHydropowerRepStore.Visible = false;
            // 
            // btnHydropowerRepExit
            // 
            this.btnHydropowerRepExit.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepExit.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepExit.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepExit.Image")));
            this.btnHydropowerRepExit.Location = new System.Drawing.Point(1053, 8);
            this.btnHydropowerRepExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepExit.Name = "btnHydropowerRepExit";
            this.btnHydropowerRepExit.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepExit.TabIndex = 44;
            this.btnHydropowerRepExit.Text = "離開";
            this.btnHydropowerRepExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepExit.UseVisualStyleBackColor = false;
            this.btnHydropowerRepExit.Visible = false;
            // 
            // btnHydropowerRepDemand
            // 
            this.btnHydropowerRepDemand.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepDemand.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepDemand.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepDemand.Image")));
            this.btnHydropowerRepDemand.Location = new System.Drawing.Point(289, 8);
            this.btnHydropowerRepDemand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepDemand.Name = "btnHydropowerRepDemand";
            this.btnHydropowerRepDemand.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepDemand.TabIndex = 43;
            this.btnHydropowerRepDemand.Text = "查詢";
            this.btnHydropowerRepDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepDemand.UseVisualStyleBackColor = false;
            this.btnHydropowerRepDemand.Visible = false;
            // 
            // btnHydropowerRepDelete
            // 
            this.btnHydropowerRepDelete.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepDelete.Enabled = false;
            this.btnHydropowerRepDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepDelete.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepDelete.Image")));
            this.btnHydropowerRepDelete.Location = new System.Drawing.Point(196, 8);
            this.btnHydropowerRepDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepDelete.Name = "btnHydropowerRepDelete";
            this.btnHydropowerRepDelete.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepDelete.TabIndex = 42;
            this.btnHydropowerRepDelete.Text = "刪除";
            this.btnHydropowerRepDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepDelete.UseVisualStyleBackColor = false;
            this.btnHydropowerRepDelete.Click += new System.EventHandler(this.btnHydropowerRepDelete_Click);
            // 
            // btnHydropowerRepModify
            // 
            this.btnHydropowerRepModify.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepModify.Enabled = false;
            this.btnHydropowerRepModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepModify.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepModify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepModify.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepModify.Image")));
            this.btnHydropowerRepModify.Location = new System.Drawing.Point(103, 8);
            this.btnHydropowerRepModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepModify.Name = "btnHydropowerRepModify";
            this.btnHydropowerRepModify.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepModify.TabIndex = 41;
            this.btnHydropowerRepModify.Text = "修改";
            this.btnHydropowerRepModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepModify.UseVisualStyleBackColor = false;
            this.btnHydropowerRepModify.Click += new System.EventHandler(this.btnHydropowerRepModify_Click);
            // 
            // btnHydropowerRepAdd
            // 
            this.btnHydropowerRepAdd.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepAdd.Enabled = false;
            this.btnHydropowerRepAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepAdd.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHydropowerRepAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepAdd.Image")));
            this.btnHydropowerRepAdd.Location = new System.Drawing.Point(8, 8);
            this.btnHydropowerRepAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHydropowerRepAdd.Name = "btnHydropowerRepAdd";
            this.btnHydropowerRepAdd.Size = new System.Drawing.Size(89, 84);
            this.btnHydropowerRepAdd.TabIndex = 40;
            this.btnHydropowerRepAdd.Text = "新增";
            this.btnHydropowerRepAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepAdd.UseVisualStyleBackColor = false;
            this.btnHydropowerRepAdd.Click += new System.EventHandler(this.btnHydropowerRepAdd_Click);
            // 
            // gbxFun
            // 
            this.gbxFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxFun.Controls.Add(this.btnHydropowerRepAdd);
            this.gbxFun.Controls.Add(this.btnHydropowerRepModify);
            this.gbxFun.Controls.Add(this.btnHydropowerRepDelete);
            this.gbxFun.Controls.Add(this.btnHydropowerRepDemand);
            this.gbxFun.Controls.Add(this.cbxCategorysName);
            this.gbxFun.Controls.Add(this.btnHydropowerRepExit);
            this.gbxFun.Controls.Add(this.cbxFactoryCode);
            this.gbxFun.Controls.Add(this.btnHydropowerRepStore);
            this.gbxFun.Controls.Add(this.label2);
            this.gbxFun.Controls.Add(this.label3);
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
            this.gbxShow.Controls.Add(this.dgvHydropowerFrom);
            this.gbxShow.Controls.Add(this.dgvHydropowerTo);
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
            // HydropowerRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 889);
            this.Controls.Add(this.gbxShow);
            this.Controls.Add(this.gbxFun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HydropowerRep";
            this.Text = "水電運轉記錄表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HydropowerRep_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HydropowerRep_Paint);
            this.Resize += new System.EventHandler(this.HydropowerRep_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).EndInit();
            this.gbxFun.ResumeLayout(false);
            this.gbxFun.PerformLayout();
            this.gbxShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.ComboBox cbxCategorysName;
        private System.Windows.Forms.ComboBox cbxFactoryCode;
        private System.Windows.Forms.DataGridView dgvHydropowerTo;
        private System.Windows.Forms.DataGridView dgvHydropowerFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHydropowerRepStore;
        private System.Windows.Forms.Button btnHydropowerRepExit;
        private System.Windows.Forms.Button btnHydropowerRepDemand;
        private System.Windows.Forms.Button btnHydropowerRepDelete;
        private System.Windows.Forms.Button btnHydropowerRepModify;
        private System.Windows.Forms.Button btnHydropowerRepAdd;
        private System.Windows.Forms.GroupBox gbxFun;
        private System.Windows.Forms.GroupBox gbxShow;
    }
}