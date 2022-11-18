namespace Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DB_Data_Transfer = new System.Windows.Forms.GroupBox();
            this.btn_DB_Data_Transfer = new System.Windows.Forms.Button();
            this.btn_DB_Data_Transfer_explain = new System.Windows.Forms.Button();
            this.Report_By_Excel = new System.Windows.Forms.GroupBox();
            this.btn_Report_By_Excel = new System.Windows.Forms.Button();
            this.btn_Report_By_Excel_explain = new System.Windows.Forms.Button();
            this.gBoxOpenXML = new System.Windows.Forms.GroupBox();
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.btnOpenXML_Explain = new System.Windows.Forms.Button();
            this.gBoxOpenForm = new System.Windows.Forms.GroupBox();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.btnOpenForm_Explain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxDay = new System.Windows.Forms.TextBox();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.dtpHowToUse = new System.Windows.Forms.DateTimePicker();
            this.btnDateTimePicker_Explain = new System.Windows.Forms.Button();
            this.gbxDataGridView = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDataGridView_Explain = new System.Windows.Forms.Button();
            this.gBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectFileExplain = new System.Windows.Forms.Button();
            this.gBoxPringBarcode = new System.Windows.Forms.GroupBox();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.btnPrintBarcodeExplain = new System.Windows.Forms.Button();
            this.PrintDoc = new System.Drawing.Printing.PrintDocument();
            this.DB_Data_Transfer.SuspendLayout();
            this.Report_By_Excel.SuspendLayout();
            this.gBoxOpenXML.SuspendLayout();
            this.gBoxOpenForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDataGridView.SuspendLayout();
            this.gBoxSelectFile.SuspendLayout();
            this.gBoxPringBarcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // DB_Data_Transfer
            // 
            this.DB_Data_Transfer.Controls.Add(this.btn_DB_Data_Transfer);
            this.DB_Data_Transfer.Controls.Add(this.btn_DB_Data_Transfer_explain);
            this.DB_Data_Transfer.Location = new System.Drawing.Point(12, 12);
            this.DB_Data_Transfer.Name = "DB_Data_Transfer";
            this.DB_Data_Transfer.Size = new System.Drawing.Size(308, 76);
            this.DB_Data_Transfer.TabIndex = 0;
            this.DB_Data_Transfer.TabStop = false;
            this.DB_Data_Transfer.Text = "兩個相同Table的資料庫資料互傳";
            // 
            // btn_DB_Data_Transfer
            // 
            this.btn_DB_Data_Transfer.Location = new System.Drawing.Point(123, 28);
            this.btn_DB_Data_Transfer.Name = "btn_DB_Data_Transfer";
            this.btn_DB_Data_Transfer.Size = new System.Drawing.Size(166, 34);
            this.btn_DB_Data_Transfer.TabIndex = 1;
            this.btn_DB_Data_Transfer.Text = "執行";
            this.btn_DB_Data_Transfer.UseVisualStyleBackColor = true;
            this.btn_DB_Data_Transfer.Click += new System.EventHandler(this.btn_DB_Data_Transfer_Click);
            // 
            // btn_DB_Data_Transfer_explain
            // 
            this.btn_DB_Data_Transfer_explain.Location = new System.Drawing.Point(15, 28);
            this.btn_DB_Data_Transfer_explain.Name = "btn_DB_Data_Transfer_explain";
            this.btn_DB_Data_Transfer_explain.Size = new System.Drawing.Size(86, 34);
            this.btn_DB_Data_Transfer_explain.TabIndex = 1;
            this.btn_DB_Data_Transfer_explain.Text = "說明";
            this.btn_DB_Data_Transfer_explain.UseVisualStyleBackColor = true;
            this.btn_DB_Data_Transfer_explain.Click += new System.EventHandler(this.btn_DB_Data_Transfer_explain_Click);
            // 
            // Report_By_Excel
            // 
            this.Report_By_Excel.Controls.Add(this.btn_Report_By_Excel);
            this.Report_By_Excel.Controls.Add(this.btn_Report_By_Excel_explain);
            this.Report_By_Excel.Location = new System.Drawing.Point(12, 94);
            this.Report_By_Excel.Name = "Report_By_Excel";
            this.Report_By_Excel.Size = new System.Drawing.Size(308, 76);
            this.Report_By_Excel.TabIndex = 1;
            this.Report_By_Excel.TabStop = false;
            this.Report_By_Excel.Text = "使用Excel做報表";
            // 
            // btn_Report_By_Excel
            // 
            this.btn_Report_By_Excel.Location = new System.Drawing.Point(123, 28);
            this.btn_Report_By_Excel.Name = "btn_Report_By_Excel";
            this.btn_Report_By_Excel.Size = new System.Drawing.Size(166, 34);
            this.btn_Report_By_Excel.TabIndex = 3;
            this.btn_Report_By_Excel.Text = "執行";
            this.btn_Report_By_Excel.UseVisualStyleBackColor = true;
            this.btn_Report_By_Excel.Click += new System.EventHandler(this.btn_Report_By_Excel_Click);
            // 
            // btn_Report_By_Excel_explain
            // 
            this.btn_Report_By_Excel_explain.Location = new System.Drawing.Point(15, 28);
            this.btn_Report_By_Excel_explain.Name = "btn_Report_By_Excel_explain";
            this.btn_Report_By_Excel_explain.Size = new System.Drawing.Size(86, 34);
            this.btn_Report_By_Excel_explain.TabIndex = 2;
            this.btn_Report_By_Excel_explain.Text = "說明";
            this.btn_Report_By_Excel_explain.UseVisualStyleBackColor = true;
            this.btn_Report_By_Excel_explain.Click += new System.EventHandler(this.btn_Report_By_Excel_explain_Click);
            // 
            // gBoxOpenXML
            // 
            this.gBoxOpenXML.Controls.Add(this.btnOpenXML);
            this.gBoxOpenXML.Controls.Add(this.btnOpenXML_Explain);
            this.gBoxOpenXML.Location = new System.Drawing.Point(12, 177);
            this.gBoxOpenXML.Name = "gBoxOpenXML";
            this.gBoxOpenXML.Size = new System.Drawing.Size(308, 76);
            this.gBoxOpenXML.TabIndex = 2;
            this.gBoxOpenXML.TabStop = false;
            this.gBoxOpenXML.Text = "開啟XML檔";
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Location = new System.Drawing.Point(123, 28);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(166, 34);
            this.btnOpenXML.TabIndex = 3;
            this.btnOpenXML.Text = "執行";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            this.btnOpenXML.Click += new System.EventHandler(this.btnOpenXML_Click);
            // 
            // btnOpenXML_Explain
            // 
            this.btnOpenXML_Explain.Location = new System.Drawing.Point(15, 28);
            this.btnOpenXML_Explain.Name = "btnOpenXML_Explain";
            this.btnOpenXML_Explain.Size = new System.Drawing.Size(86, 34);
            this.btnOpenXML_Explain.TabIndex = 2;
            this.btnOpenXML_Explain.Text = "說明";
            this.btnOpenXML_Explain.UseVisualStyleBackColor = true;
            this.btnOpenXML_Explain.Click += new System.EventHandler(this.btnOpenXML_Explain_Click);
            // 
            // gBoxOpenForm
            // 
            this.gBoxOpenForm.Controls.Add(this.btnOpenForm);
            this.gBoxOpenForm.Controls.Add(this.btnOpenForm_Explain);
            this.gBoxOpenForm.Location = new System.Drawing.Point(12, 260);
            this.gBoxOpenForm.Name = "gBoxOpenForm";
            this.gBoxOpenForm.Size = new System.Drawing.Size(308, 76);
            this.gBoxOpenForm.TabIndex = 3;
            this.gBoxOpenForm.TabStop = false;
            this.gBoxOpenForm.Text = "開啟另一個Form";
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(123, 28);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(166, 34);
            this.btnOpenForm.TabIndex = 3;
            this.btnOpenForm.Text = "執行";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // btnOpenForm_Explain
            // 
            this.btnOpenForm_Explain.Location = new System.Drawing.Point(15, 28);
            this.btnOpenForm_Explain.Name = "btnOpenForm_Explain";
            this.btnOpenForm_Explain.Size = new System.Drawing.Size(86, 34);
            this.btnOpenForm_Explain.TabIndex = 2;
            this.btnOpenForm_Explain.Text = "說明";
            this.btnOpenForm_Explain.UseVisualStyleBackColor = true;
            this.btnOpenForm_Explain.Click += new System.EventHandler(this.btnOpenForm_Explain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxDay);
            this.groupBox1.Controls.Add(this.tbxMonth);
            this.groupBox1.Controls.Add(this.tbxYear);
            this.groupBox1.Controls.Add(this.dtpHowToUse);
            this.groupBox1.Controls.Add(this.btnDateTimePicker_Explain);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DateTimePicker應用";
            // 
            // tbxDay
            // 
            this.tbxDay.Location = new System.Drawing.Point(204, 72);
            this.tbxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDay.Name = "tbxDay";
            this.tbxDay.Size = new System.Drawing.Size(84, 29);
            this.tbxDay.TabIndex = 7;
            // 
            // tbxMonth
            // 
            this.tbxMonth.Location = new System.Drawing.Point(110, 70);
            this.tbxMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(84, 29);
            this.tbxMonth.TabIndex = 6;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(15, 70);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(84, 29);
            this.tbxYear.TabIndex = 5;
            // 
            // dtpHowToUse
            // 
            this.dtpHowToUse.Location = new System.Drawing.Point(123, 30);
            this.dtpHowToUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHowToUse.Name = "dtpHowToUse";
            this.dtpHowToUse.Size = new System.Drawing.Size(164, 29);
            this.dtpHowToUse.TabIndex = 5;
            this.dtpHowToUse.ValueChanged += new System.EventHandler(this.dtpHowToUse_ValueChanged);
            // 
            // btnDateTimePicker_Explain
            // 
            this.btnDateTimePicker_Explain.Location = new System.Drawing.Point(15, 28);
            this.btnDateTimePicker_Explain.Name = "btnDateTimePicker_Explain";
            this.btnDateTimePicker_Explain.Size = new System.Drawing.Size(86, 34);
            this.btnDateTimePicker_Explain.TabIndex = 2;
            this.btnDateTimePicker_Explain.Text = "說明";
            this.btnDateTimePicker_Explain.UseVisualStyleBackColor = true;
            this.btnDateTimePicker_Explain.Click += new System.EventHandler(this.btnDateTimePicker_Explain_Click);
            // 
            // gbxDataGridView
            // 
            this.gbxDataGridView.Controls.Add(this.button1);
            this.gbxDataGridView.Controls.Add(this.btnDataGridView_Explain);
            this.gbxDataGridView.Location = new System.Drawing.Point(12, 464);
            this.gbxDataGridView.Name = "gbxDataGridView";
            this.gbxDataGridView.Size = new System.Drawing.Size(308, 76);
            this.gbxDataGridView.TabIndex = 5;
            this.gbxDataGridView.TabStop = false;
            this.gbxDataGridView.Text = "DataGridView應用";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDataGridView_Explain
            // 
            this.btnDataGridView_Explain.Location = new System.Drawing.Point(15, 28);
            this.btnDataGridView_Explain.Name = "btnDataGridView_Explain";
            this.btnDataGridView_Explain.Size = new System.Drawing.Size(86, 34);
            this.btnDataGridView_Explain.TabIndex = 2;
            this.btnDataGridView_Explain.Text = "說明";
            this.btnDataGridView_Explain.UseVisualStyleBackColor = true;
            this.btnDataGridView_Explain.Click += new System.EventHandler(this.btnDataGridView_Explain_Click);
            // 
            // gBoxSelectFile
            // 
            this.gBoxSelectFile.Controls.Add(this.btnSelectFile);
            this.gBoxSelectFile.Controls.Add(this.btnSelectFileExplain);
            this.gBoxSelectFile.Location = new System.Drawing.Point(12, 546);
            this.gBoxSelectFile.Name = "gBoxSelectFile";
            this.gBoxSelectFile.Size = new System.Drawing.Size(308, 77);
            this.gBoxSelectFile.TabIndex = 6;
            this.gBoxSelectFile.TabStop = false;
            this.gBoxSelectFile.Text = "選擇要後續處理的檔案";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(123, 28);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(166, 35);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "執行";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectFileExplain
            // 
            this.btnSelectFileExplain.Location = new System.Drawing.Point(15, 28);
            this.btnSelectFileExplain.Name = "btnSelectFileExplain";
            this.btnSelectFileExplain.Size = new System.Drawing.Size(85, 35);
            this.btnSelectFileExplain.TabIndex = 2;
            this.btnSelectFileExplain.Text = "說明";
            this.btnSelectFileExplain.UseVisualStyleBackColor = true;
            this.btnSelectFileExplain.Click += new System.EventHandler(this.btnSelectFileExplain_Click);
            // 
            // gBoxPringBarcode
            // 
            this.gBoxPringBarcode.Controls.Add(this.btnPrintBarcode);
            this.gBoxPringBarcode.Controls.Add(this.btnPrintBarcodeExplain);
            this.gBoxPringBarcode.Location = new System.Drawing.Point(326, 12);
            this.gBoxPringBarcode.Name = "gBoxPringBarcode";
            this.gBoxPringBarcode.Size = new System.Drawing.Size(308, 76);
            this.gBoxPringBarcode.TabIndex = 5;
            this.gBoxPringBarcode.TabStop = false;
            this.gBoxPringBarcode.Text = "使用ZXing印條碼";
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Location = new System.Drawing.Point(123, 28);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(166, 35);
            this.btnPrintBarcode.TabIndex = 3;
            this.btnPrintBarcode.Text = "執行";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // btnPrintBarcodeExplain
            // 
            this.btnPrintBarcodeExplain.Location = new System.Drawing.Point(15, 28);
            this.btnPrintBarcodeExplain.Name = "btnPrintBarcodeExplain";
            this.btnPrintBarcodeExplain.Size = new System.Drawing.Size(85, 35);
            this.btnPrintBarcodeExplain.TabIndex = 2;
            this.btnPrintBarcodeExplain.Text = "說明";
            this.btnPrintBarcodeExplain.UseVisualStyleBackColor = true;
            this.btnPrintBarcodeExplain.Click += new System.EventHandler(this.btnPrintBarcodeExplain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 642);
            this.Controls.Add(this.gBoxPringBarcode);
            this.Controls.Add(this.gBoxSelectFile);
            this.Controls.Add(this.gbxDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxOpenForm);
            this.Controls.Add(this.gBoxOpenXML);
            this.Controls.Add(this.Report_By_Excel);
            this.Controls.Add(this.DB_Data_Transfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DB_Data_Transfer.ResumeLayout(false);
            this.Report_By_Excel.ResumeLayout(false);
            this.gBoxOpenXML.ResumeLayout(false);
            this.gBoxOpenForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDataGridView.ResumeLayout(false);
            this.gBoxSelectFile.ResumeLayout(false);
            this.gBoxPringBarcode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DB_Data_Transfer;
        private System.Windows.Forms.Button btn_DB_Data_Transfer;
        private System.Windows.Forms.Button btn_DB_Data_Transfer_explain;
        private System.Windows.Forms.GroupBox Report_By_Excel;
        private System.Windows.Forms.Button btn_Report_By_Excel_explain;
        private System.Windows.Forms.Button btn_Report_By_Excel;
        private System.Windows.Forms.GroupBox gBoxOpenXML;
        private System.Windows.Forms.Button btnOpenXML;
        private System.Windows.Forms.Button btnOpenXML_Explain;
        private System.Windows.Forms.GroupBox gBoxOpenForm;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Button btnOpenForm_Explain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxDay;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.DateTimePicker dtpHowToUse;
        private System.Windows.Forms.Button btnDateTimePicker_Explain;
        private System.Windows.Forms.GroupBox gbxDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDataGridView_Explain;
        private System.Windows.Forms.GroupBox gBoxSelectFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSelectFileExplain;
        private System.Windows.Forms.GroupBox gBoxPringBarcode;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.Button btnPrintBarcodeExplain;
        private System.Drawing.Printing.PrintDocument PrintDoc;
    }
}

