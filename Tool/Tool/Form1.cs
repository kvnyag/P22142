using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tool
{
    public partial class Form1 : Form
    {
        //公用變數
        string explain;//用於說明按鈕用

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DB_Data_Transfer_explain_Click(object sender, EventArgs e)
        {//兩個相同Table的資料庫資料互傳 --> 說明
            explain = "資料庫 P22111001_PC 與 P22111001_PDA 資料互傳，Table 為 ：RGReceipt_Basket\r\n";
            explain += "1.App.config 加入 useLegacyV2RuntimeActivationPolicy=\"" + "true" + "\"";
            MessageBox.Show(explain);
        }

        private void btn_DB_Data_Transfer_Click(object sender, EventArgs e)
        {//兩個相同Table的資料庫資料互傳 --> 執行
            //注意事項
            //....1.一般呼叫法如下
            //....string pda_DBPath = "Data Source=" + Application.StartupPath + "\\" + "P22111001_PDA.db3";
            //....2.App.Config裡面加入『useLegacyV2RuntimeActivationPolicy="true"』
            //參數集中

            string str_Return;

            DB_Data_Transfer DBDT = new DB_Data_Transfer();
            str_Return = DBDT.DB_Data_Transfer_Example(System.Windows.Forms.Application.StartupPath);

            if (str_Return != "OK")
                MessageBox.Show(str_Return, "PDA內容上傳");
        }

        private void btn_Report_By_Excel_explain_Click(object sender, EventArgs e)
        {//使用Excel做報表 --> 說明
            explain = "使用Excel做報表\r\n";
            explain += "1.NuGet安裝 Microsoft.Office.Interop.Excel\r\n";
            explain += "2.using Microsoft.Office.Interop.Excel;\r\n";
            explain += "3.using System.Drawing;";
            MessageBox.Show(explain);
        }

        private void btn_Report_By_Excel_Click(object sender, EventArgs e)
        {//使用Excel做報表 --> 執行
            Report_By_Excel RBE = new Report_By_Excel();
            string str_Return = RBE.Report_By_Excel_Example();

            if (str_Return != "OK")
                MessageBox.Show(str_Return, "Excel執行範例");
        }

        private void btnOpenXML_Explain_Click(object sender, EventArgs e)
        {//開啟XML檔 --> 說明
            explain = "";
            explain += "開啟XML檔";
            MessageBox.Show(explain);
        }

        private void btnOpenXML_Click(object sender, EventArgs e)
        {//開啟XML檔 --> 執行
            string xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
            System.Diagnostics.Process.Start("Explorer.exe", xmlPath);
        }

        private void btnOpenForm_Explain_Click(object sender, EventArgs e)
        {//開啟另一個Form --> 說明
            explain = "";
            explain += "開啟另一個Form";
            MessageBox.Show(explain);
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {//開啟另一個Form --> 執行
            using(Form2 fm2 = new Form2())
            {
                this.Visible = false;
                fm2.Owner = this;
                fm2.ShowDialog();

                fm2.Close();
                fm2.Dispose();
                this.Visible = true;
            }
        }

        private void btnDateTimePicker_Explain_Click(object sender, EventArgs e)
        {//DateTimePicker應用 --> 說明
            explain = "";
            explain += "DataTimePicker應用";
            MessageBox.Show(explain);
        }

        private void dtpHowToUse_ValueChanged(object sender, EventArgs e)
        {//DateTimePicker應用 --> 執行
            int iYear = dtpHowToUse.Value.Year;
            int iMonth = dtpHowToUse.Value.Month;
            int iDay = dtpHowToUse.Value.Day;

            tbxYear.Text = iYear.ToString();
            tbxMonth.Text = iMonth.ToString().PadLeft(2, '0');
            tbxDay.Text = iDay.ToString().PadLeft(2, '0');

            int iRepublic = iYear - 1911;
            tbxYear.Text = iRepublic.ToString();
        }

        private void btnDataGridView_Explain_Click(object sender, EventArgs e)
        {//DateTimePicker應用 --> 說明
            explain = "";
            explain += "DateTimePicker應用";
            MessageBox.Show(explain);
        }

        private void button1_Click(object sender, EventArgs e)
        {//DateTimePicker應用 --> 執行
            using (DataGridView_Example fm = new DataGridView_Example())
            {
                this.Visible = false;
                fm.Owner = this;
                fm.ShowDialog();

                fm.Close();
                fm.Dispose();
                this.Visible = true;
            }
        }

        private void btnSelectFileExplain_Click(object sender, EventArgs e)
        {//開啟檔案 --> 說明
            explain = "開啟檔案\r\n";
            explain += "1.using System.Windows.Forms;\r\n";
            MessageBox.Show(explain);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {//開啟檔案 --> 執行
            OpenFile OF = new OpenFile();
            string str_Return = OF.btnSelectFileExample1();

            if (str_Return == "OK")
                MessageBox.Show("檔案開啟完成", "開啟檔案範例");
            else
                MessageBox.Show("檔案開啟失敗", "開啟檔案範例");
        }

        private void btnPrintBarcodeExplain_Click(object sender, EventArgs e)
        {//使用ZXing印條碼 --> 說明
            explain = "使用ZXing印條碼\r\n";
            explain += "1.NuGet安裝 ZXing.Net\r\n";
            explain += "2.NuGet安裝 DataMatrix.Net\r\n";
            explain += "3.using ZXing;\r\n";
            explain += "4.using ZXing.QrCode;\r\n";
            explain += "5.using System.Drawing;\r\n";
            explain += "6.在Form中加入PrintDocument;\r\n";
            MessageBox.Show(explain);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {//使用ZXing印條碼 --> 執行
            //設定列印空間大小
            System.Drawing.Printing.PaperSize printPageSize = new System.Drawing.Printing.PaperSize();
            //設置標籤紙大小(10cm*17.5cm)
            //10.0cm = 3.937007874 inches * 100 = 393.7007874
            //17.5cm = 6.88976378 inches * 100 = 688.976378
            printPageSize = new System.Drawing.Printing.PaperSize("Lable", 394, 689);//列印100mm*175mm的標籤紙
            printPageSize.RawKind = 150;
            PrintDoc.DefaultPageSettings.PaperSize = printPageSize;
            //設置標籤機名稱
            PrintDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            PrintDoc.Print();
        }

        public void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //參數集中
            float Xpos = 0, Ypos = 0, Length = 0;
            Bitmap bmp;
            PrintBarcode pb = new PrintBarcode();

            //1.畫外框
            #region
            //....畫筆顏色資訊
            Pen _Pen = new Pen(Color.Black);
            _Pen.Width = 1;
            SolidBrush _SolidBrush = new SolidBrush(_Pen.Color);
            //....畫直線(左框線)
            Xpos = (float)10.0;
            Ypos = (float)0.0;
            Length = (float)259.0;
            e.Graphics.DrawLine(_Pen, Xpos, Ypos, Xpos, Ypos + Length);
            //....畫直線(右框線)
            Xpos = (float)400.0;
            Ypos = (float)0.0;
            Length = (float)259.0;
            e.Graphics.DrawLine(_Pen, Xpos, Ypos, Xpos, Ypos + Length);
            //....畫直線(下框線)
            Xpos = (float)10.0;
            Ypos = (float)257.5;
            Length = (float)390.0;
            e.Graphics.DrawLine(_Pen, Xpos, Ypos, Xpos + Length, Ypos);
            //....畫直線(上框線)
            Xpos = (float)10.0;
            Ypos = (float)1.5;
            Length = (float)390.0;
            e.Graphics.DrawLine(_Pen, Xpos, Ypos, Xpos + Length, Ypos);
            #endregion
            //2.繪製文字
            #region
            //....文字格式設定
            System.Drawing.Color TextColor = ColorTranslator.FromHtml("#000000"); //設定文字顏色
            SolidBrush TextBrush = new SolidBrush(TextColor); //建立畫筆
            System.Drawing.Font FontSt1 = new System.Drawing.Font(Text, (float)7); //設定文字大小 7
            System.Drawing.Font FontSt2 = new System.Drawing.Font(Text, (float)7, System.Drawing.FontStyle.Bold); //設定文字大小 7，且為粗體字
            //e.Graphics.RotateTransform(90); //轉向90度
            //....印出文字"Product Name :"，在畫紙上 x = 15、y = 2 位置。
            e.Graphics.DrawString("Product Name :", FontSt1, SystemBrushes.ControlText, 15, 2);
            #endregion
            //3.繪製一維碼
            #region
            //...............................一般編碼...............................
            //....建一張新圖 bmp
            bmp = null;
            //....利用Code39編碼，將"Product Name"印成一維條碼
            bmp = pb.BarCode_Code39("Product Name", 30, 1);
            //....將編碼好的圖片在畫紙上 x = 8、y = 15 位置印出。條碼長度 130、條碼寬度 20。
            e.Graphics.DrawImage(bmp, 8, 15, Convert.ToInt16("130"), Convert.ToInt16("20"));
            //...............................DataMatrix...............................
            bmp = null;
            bmp = pb.BarCode_DataMatrix("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5, 5);
            e.Graphics.DrawImage(bmp, 310, 170, Convert.ToInt16("80"), Convert.ToInt16("80"));
            //...............................QRCode...............................
            bmp = null;
            bmp = pb.BarCode_QRCode("", 100, 1);
            e.Graphics.DrawImage(bmp, 310, 170, Convert.ToInt16("180"), Convert.ToInt16("80"));
            #endregion
            //4.放一張已存在的圖進畫紙
            string sLogoPath = System.IO.Directory.GetCurrentDirectory() + @"\Logo_img\";
            e.Graphics.DrawImage(Image.FromFile(sLogoPath + "RoHS_70_22.png"), 190, 230, Convert.ToInt16("30"), Convert.ToInt16("15"));
        }
    }
}
