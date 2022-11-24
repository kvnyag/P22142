namespace P2214201
{
    partial class FactoryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactoryInfo));
            this.btnFactoryInfoStore = new System.Windows.Forms.Button();
            this.btnFactoryInfoExit = new System.Windows.Forms.Button();
            this.btnFactoryInfoDemand = new System.Windows.Forms.Button();
            this.btnFactoryInfoDelete = new System.Windows.Forms.Button();
            this.btnFactoryInfoModify = new System.Windows.Forms.Button();
            this.btnFactoryInfoAdd = new System.Windows.Forms.Button();
            this.dgvFactory = new System.Windows.Forms.DataGridView();
            this.tbxFactoryName = new System.Windows.Forms.TextBox();
            this.tbxFactoryCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactoryInfoStore
            // 
            this.btnFactoryInfoStore.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoStore.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoStore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoStore.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoStore.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoStore.Image")));
            this.btnFactoryInfoStore.Location = new System.Drawing.Point(602, 6);
            this.btnFactoryInfoStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoStore.Name = "btnFactoryInfoStore";
            this.btnFactoryInfoStore.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoStore.TabIndex = 13;
            this.btnFactoryInfoStore.Text = "儲存";
            this.btnFactoryInfoStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoStore.UseVisualStyleBackColor = false;
            this.btnFactoryInfoStore.Visible = false;
            // 
            // btnFactoryInfoExit
            // 
            this.btnFactoryInfoExit.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoExit.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoExit.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoExit.Image")));
            this.btnFactoryInfoExit.Location = new System.Drawing.Point(673, 6);
            this.btnFactoryInfoExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoExit.Name = "btnFactoryInfoExit";
            this.btnFactoryInfoExit.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoExit.TabIndex = 12;
            this.btnFactoryInfoExit.Text = "離開";
            this.btnFactoryInfoExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoExit.UseVisualStyleBackColor = false;
            this.btnFactoryInfoExit.Visible = false;
            // 
            // btnFactoryInfoDemand
            // 
            this.btnFactoryInfoDemand.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoDemand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoDemand.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoDemand.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoDemand.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoDemand.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoDemand.Image")));
            this.btnFactoryInfoDemand.Location = new System.Drawing.Point(218, 6);
            this.btnFactoryInfoDemand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoDemand.Name = "btnFactoryInfoDemand";
            this.btnFactoryInfoDemand.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoDemand.TabIndex = 11;
            this.btnFactoryInfoDemand.Text = "查詢";
            this.btnFactoryInfoDemand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoDemand.UseVisualStyleBackColor = false;
            this.btnFactoryInfoDemand.Click += new System.EventHandler(this.btnFactoryInfoDemand_Click_1);
            // 
            // btnFactoryInfoDelete
            // 
            this.btnFactoryInfoDelete.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoDelete.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoDelete.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoDelete.Image")));
            this.btnFactoryInfoDelete.Location = new System.Drawing.Point(147, 6);
            this.btnFactoryInfoDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoDelete.Name = "btnFactoryInfoDelete";
            this.btnFactoryInfoDelete.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoDelete.TabIndex = 10;
            this.btnFactoryInfoDelete.Text = "刪除";
            this.btnFactoryInfoDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoDelete.UseVisualStyleBackColor = false;
            this.btnFactoryInfoDelete.Click += new System.EventHandler(this.btnFactoryInfoDelete_Click_1);
            // 
            // btnFactoryInfoModify
            // 
            this.btnFactoryInfoModify.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoModify.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoModify.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoModify.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoModify.Image")));
            this.btnFactoryInfoModify.Location = new System.Drawing.Point(77, 6);
            this.btnFactoryInfoModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoModify.Name = "btnFactoryInfoModify";
            this.btnFactoryInfoModify.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoModify.TabIndex = 9;
            this.btnFactoryInfoModify.Text = "修改";
            this.btnFactoryInfoModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoModify.UseVisualStyleBackColor = false;
            this.btnFactoryInfoModify.Click += new System.EventHandler(this.btnFactoryInfoModify_Click_1);
            // 
            // btnFactoryInfoAdd
            // 
            this.btnFactoryInfoAdd.BackColor = System.Drawing.Color.Teal;
            this.btnFactoryInfoAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactoryInfoAdd.FlatAppearance.BorderSize = 0;
            this.btnFactoryInfoAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFactoryInfoAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnFactoryInfoAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnFactoryInfoAdd.Image")));
            this.btnFactoryInfoAdd.Location = new System.Drawing.Point(6, 6);
            this.btnFactoryInfoAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactoryInfoAdd.Name = "btnFactoryInfoAdd";
            this.btnFactoryInfoAdd.Size = new System.Drawing.Size(67, 67);
            this.btnFactoryInfoAdd.TabIndex = 8;
            this.btnFactoryInfoAdd.Text = "新增";
            this.btnFactoryInfoAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactoryInfoAdd.UseVisualStyleBackColor = false;
            this.btnFactoryInfoAdd.Click += new System.EventHandler(this.btnFactoryInfoAdd_Click);
            // 
            // dgvFactory
            // 
            this.dgvFactory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactory.Location = new System.Drawing.Point(0, 213);
            this.dgvFactory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFactory.MultiSelect = false;
            this.dgvFactory.Name = "dgvFactory";
            this.dgvFactory.RowTemplate.Height = 31;
            this.dgvFactory.Size = new System.Drawing.Size(747, 487);
            this.dgvFactory.TabIndex = 15;
            this.dgvFactory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactory_CellClick);
            // 
            // tbxFactoryName
            // 
            this.tbxFactoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxFactoryName.Location = new System.Drawing.Point(135, 145);
            this.tbxFactoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFactoryName.Name = "tbxFactoryName";
            this.tbxFactoryName.Size = new System.Drawing.Size(136, 29);
            this.tbxFactoryName.TabIndex = 19;
            // 
            // tbxFactoryCode
            // 
            this.tbxFactoryCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxFactoryCode.Location = new System.Drawing.Point(135, 111);
            this.tbxFactoryCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFactoryCode.Name = "tbxFactoryCode";
            this.tbxFactoryCode.Size = new System.Drawing.Size(136, 29);
            this.tbxFactoryCode.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(47, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "廠房名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "廠房代號";
            // 
            // FactoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 696);
            this.Controls.Add(this.tbxFactoryName);
            this.Controls.Add(this.tbxFactoryCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFactory);
            this.Controls.Add(this.btnFactoryInfoStore);
            this.Controls.Add(this.btnFactoryInfoExit);
            this.Controls.Add(this.btnFactoryInfoDemand);
            this.Controls.Add(this.btnFactoryInfoDelete);
            this.Controls.Add(this.btnFactoryInfoModify);
            this.Controls.Add(this.btnFactoryInfoAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FactoryInfo";
            this.Text = "FactoryInfo";
            this.Load += new System.EventHandler(this.FactoryInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFactoryInfoStore;
        private System.Windows.Forms.Button btnFactoryInfoExit;
        private System.Windows.Forms.Button btnFactoryInfoDemand;
        private System.Windows.Forms.Button btnFactoryInfoDelete;
        private System.Windows.Forms.Button btnFactoryInfoModify;
        private System.Windows.Forms.Button btnFactoryInfoAdd;
        private System.Windows.Forms.DataGridView dgvFactory;
        private System.Windows.Forms.TextBox tbxFactoryName;
        private System.Windows.Forms.TextBox tbxFactoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}