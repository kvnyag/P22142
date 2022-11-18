namespace Tool
{
    partial class DataGridView_Example
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
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDataGridViewSet = new System.Windows.Forms.Button();
            this.btnBuildTable = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataGridView
            // 
            this.dgvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView.Location = new System.Drawing.Point(12, 37);
            this.dgvDataGridView.Name = "dgvDataGridView";
            this.dgvDataGridView.RowTemplate.Height = 24;
            this.dgvDataGridView.Size = new System.Drawing.Size(776, 401);
            this.dgvDataGridView.TabIndex = 0;
            // 
            // btnDataGridViewSet
            // 
            this.btnDataGridViewSet.Location = new System.Drawing.Point(12, 12);
            this.btnDataGridViewSet.Name = "btnDataGridViewSet";
            this.btnDataGridViewSet.Size = new System.Drawing.Size(114, 19);
            this.btnDataGridViewSet.TabIndex = 1;
            this.btnDataGridViewSet.Text = "設定DataGridView";
            this.btnDataGridViewSet.UseVisualStyleBackColor = true;
            this.btnDataGridViewSet.Click += new System.EventHandler(this.btnDataGridViewSet_Click);
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.Location = new System.Drawing.Point(132, 10);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(75, 23);
            this.btnBuildTable.TabIndex = 2;
            this.btnBuildTable.Text = "建立資料表";
            this.btnBuildTable.UseVisualStyleBackColor = true;
            this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(213, 10);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 3;
            this.btnAddData.Text = "新增資料";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(294, 10);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修改資料";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(591, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "刪除資料";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "僅可修改某一欄資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取得點選格資訊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridView_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnBuildTable);
            this.Controls.Add(this.btnDataGridViewSet);
            this.Controls.Add(this.dgvDataGridView);
            this.Name = "DataGridView_Example";
            this.Text = "DataGridView_Example";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.Button btnDataGridViewSet;
        private System.Windows.Forms.Button btnBuildTable;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}