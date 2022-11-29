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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Teal;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(606, 783);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(64, 64);
            this.btnRight.TabIndex = 57;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Teal;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(606, 490);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(64, 64);
            this.btnLeft.TabIndex = 56;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // cbxCategorysName
            // 
            this.cbxCategorysName.Enabled = false;
            this.cbxCategorysName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCategorysName.FormattingEnabled = true;
            this.cbxCategorysName.Location = new System.Drawing.Point(262, 172);
            this.cbxCategorysName.Name = "cbxCategorysName";
            this.cbxCategorysName.Size = new System.Drawing.Size(224, 38);
            this.cbxCategorysName.TabIndex = 51;
            // 
            // cbxFactoryCode
            // 
            this.cbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFactoryCode.FormattingEnabled = true;
            this.cbxFactoryCode.Location = new System.Drawing.Point(262, 128);
            this.cbxFactoryCode.Name = "cbxFactoryCode";
            this.cbxFactoryCode.Size = new System.Drawing.Size(224, 38);
            this.cbxFactoryCode.TabIndex = 50;
            this.cbxFactoryCode.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryCode_SelectedIndexChanged);
            // 
            // dgvHydropowerTo
            // 
            this.dgvHydropowerTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerTo.Location = new System.Drawing.Point(678, 320);
            this.dgvHydropowerTo.MultiSelect = false;
            this.dgvHydropowerTo.Name = "dgvHydropowerTo";
            this.dgvHydropowerTo.RowTemplate.Height = 31;
            this.dgvHydropowerTo.Size = new System.Drawing.Size(618, 730);
            this.dgvHydropowerTo.TabIndex = 49;
            this.dgvHydropowerTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHydropowerTo_CellContentClick);
            // 
            // dgvHydropowerFrom
            // 
            this.dgvHydropowerFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHydropowerFrom.Location = new System.Drawing.Point(0, 314);
            this.dgvHydropowerFrom.MultiSelect = false;
            this.dgvHydropowerFrom.Name = "dgvHydropowerFrom";
            this.dgvHydropowerFrom.RowTemplate.Height = 31;
            this.dgvHydropowerFrom.Size = new System.Drawing.Size(600, 730);
            this.dgvHydropowerFrom.TabIndex = 48;
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
            this.label3.TabIndex = 47;
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
            this.label2.TabIndex = 46;
            this.label2.Text = "廠房代號";
            // 
            // btnHydropowerRepStore
            // 
            this.btnHydropowerRepStore.BackColor = System.Drawing.Color.Teal;
            this.btnHydropowerRepStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHydropowerRepStore.FlatAppearance.BorderSize = 0;
            this.btnHydropowerRepStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHydropowerRepStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepStore.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepStore.Image")));
            this.btnHydropowerRepStore.Location = new System.Drawing.Point(1080, 9);
            this.btnHydropowerRepStore.Name = "btnHydropowerRepStore";
            this.btnHydropowerRepStore.Size = new System.Drawing.Size(100, 100);
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
            this.btnHydropowerRepExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepExit.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepExit.Image")));
            this.btnHydropowerRepExit.Location = new System.Drawing.Point(1185, 9);
            this.btnHydropowerRepExit.Name = "btnHydropowerRepExit";
            this.btnHydropowerRepExit.Size = new System.Drawing.Size(100, 100);
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
            this.btnHydropowerRepDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepDemand.Image")));
            this.btnHydropowerRepDemand.Location = new System.Drawing.Point(327, 9);
            this.btnHydropowerRepDemand.Name = "btnHydropowerRepDemand";
            this.btnHydropowerRepDemand.Size = new System.Drawing.Size(100, 100);
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
            this.btnHydropowerRepDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepDelete.Image")));
            this.btnHydropowerRepDelete.Location = new System.Drawing.Point(220, 9);
            this.btnHydropowerRepDelete.Name = "btnHydropowerRepDelete";
            this.btnHydropowerRepDelete.Size = new System.Drawing.Size(100, 100);
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
            this.btnHydropowerRepModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepModify.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepModify.Image")));
            this.btnHydropowerRepModify.Location = new System.Drawing.Point(116, 9);
            this.btnHydropowerRepModify.Name = "btnHydropowerRepModify";
            this.btnHydropowerRepModify.Size = new System.Drawing.Size(100, 100);
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
            this.btnHydropowerRepAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnHydropowerRepAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnHydropowerRepAdd.Image")));
            this.btnHydropowerRepAdd.Location = new System.Drawing.Point(9, 9);
            this.btnHydropowerRepAdd.Name = "btnHydropowerRepAdd";
            this.btnHydropowerRepAdd.Size = new System.Drawing.Size(100, 100);
            this.btnHydropowerRepAdd.TabIndex = 40;
            this.btnHydropowerRepAdd.Text = "新增";
            this.btnHydropowerRepAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHydropowerRepAdd.UseVisualStyleBackColor = false;
            this.btnHydropowerRepAdd.Click += new System.EventHandler(this.btnHydropowerRepAdd_Click);
            // 
            // HydropowerRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1296, 1044);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.cbxCategorysName);
            this.Controls.Add(this.cbxFactoryCode);
            this.Controls.Add(this.dgvHydropowerTo);
            this.Controls.Add(this.dgvHydropowerFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHydropowerRepStore);
            this.Controls.Add(this.btnHydropowerRepExit);
            this.Controls.Add(this.btnHydropowerRepDemand);
            this.Controls.Add(this.btnHydropowerRepDelete);
            this.Controls.Add(this.btnHydropowerRepModify);
            this.Controls.Add(this.btnHydropowerRepAdd);
            this.Name = "HydropowerRep";
            this.Text = "水電運轉記錄表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HydropowerRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHydropowerFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}