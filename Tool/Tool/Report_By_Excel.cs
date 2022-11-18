using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tool
{
    class Report_By_Excel
    {
        public string Report_By_Excel_Example()
        {
            //參數集中
            string Date, path_Excel;
            Excel.Application app_Excel;
            Excel.Workbook book_Excel;
            Excel.Worksheet sheet_Excel;
            Excel.Range range_Excel;
            //日期格式
            Date = DateTime.Now.ToString("yyyyMMdd");
            //Excel路徑
            path_Excel = System.Windows.Forms.Application.StartupPath + "\\" + Date;
            //建一個新的Excel
            app_Excel = new Excel.Application();
            //....停用警告訊息
            app_Excel.DisplayAlerts = false;
            //....讓Excel文件可見
            app_Excel.Visible = true;
            //....加入新的活頁簿
            app_Excel.Workbooks.Add(Type.Missing);
            //活頁簿
            //....引用第一個活頁簿
            book_Excel = app_Excel.Workbooks[1];
            //....設定活頁簿焦點
            book_Excel.Activate();
            try
            {
                //工作表
                //....引用第一個工作表
                sheet_Excel = book_Excel.Worksheets[1];
                //....引用第一個工作表
                sheet_Excel.Name = "工作表測試";
                //....設定工作表焦點
                sheet_Excel.Activate();

                //可以開始亂搞了
                //....設定第1列資料
                app_Excel.Cells[1, 1] = "名稱";
                app_Excel.Cells[1, 2] = "數量";
                //....設定第1列顏色
                range_Excel = sheet_Excel.Range[sheet_Excel.Cells[1, 1], sheet_Excel.Cells[1, 2]];
                range_Excel.Select();
                range_Excel.Font.Color = ColorTranslator.ToOle(Color.White);
                range_Excel.Interior.Color = ColorTranslator.ToOle(Color.DimGray);
                //....設定第2列資料
                app_Excel.Cells[2, 1] = "AA";
                app_Excel.Cells[2, 2] = "10";
                //....設定第3列資料
                app_Excel.Cells[3, 1] = "BB";
                app_Excel.Cells[3, 2] = "20";
                //....設定第4列資料
                app_Excel.Cells[4, 1] = "CC";
                app_Excel.Cells[4, 2] = "30";
                //....設定第5列資料
                app_Excel.Cells[5, 1] = "總計";
                //....設定總和公式 =SUM(B2:B4)
                app_Excel.Cells[5, 2].Formula = string.Format("=SUM(B{0}:B{1})", 2, 4);
                //....設定第5列顏色
                range_Excel = sheet_Excel.Range[sheet_Excel.Cells[5, 1], sheet_Excel.Cells[5, 2]];
                range_Excel.Select();
                range_Excel.Font.Color = ColorTranslator.ToOle(Color.Red);
                range_Excel.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                //....自動調整欄寬
                range_Excel = sheet_Excel.Range[sheet_Excel.Cells[1, 1], sheet_Excel.Cells[5, 2]];
                range_Excel.Select();
                range_Excel.Columns.AutoFit();
                try
                {
                    //另存活頁簿
                    book_Excel.SaveAs(path_Excel, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Console.WriteLine("儲存文件於 " + Environment.NewLine + path_Excel);
                    return "OK";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
                    return "Error!!!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("產生報表時出錯！" + Environment.NewLine + ex.Message);
                return "Error!!!";
            }
        
        }
    }
}
