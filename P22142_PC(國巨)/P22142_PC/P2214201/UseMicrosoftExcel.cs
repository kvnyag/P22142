using System;
using Excel = Microsoft.Office.Interop.Excel;
using REGAL.Data.DataAccess;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace P2214201
{
    class UseMicrosoftExcel
    {
        //公用變數
        //*****************************************************************************************
        //SQL Server
        string strSQL;
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        UseSQLServer USQL = new UseSQLServer();
        //*****************************************************************************************
        //Excel
        Excel.Application excel;
        Excel.Workbook book;
        Excel.Worksheet sheet;
        Excel.Range range;
        //*****************************************************************************************
        //其他
        UseXML UXML = new UseXML();
        string[] arrChar = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        //*****************************************************************************************

        public void RepRuning(string StartDate, string EndDate, string RuningMachine)
        {
            //*************************************************************************************
            //專用於產出真空機、空壓機、冷氣機記錄的報表用
            //輸入值：StartDate --> 查詢起始日期再往前一個記錄日的時間。
            //        EndDate   --> 查詢訖日。
            //  RuningMachine   --> 執行哪個報表。
            //*************************************************************************************
            //參數
            int i, j = 0, k, idxRDH006, idxTimes, arrSheetLen, arrRDH006Len, arrTimesLen, TidxRDH006 = 0;
            string RDH006, RDH007, RDB004, RDB008, RDB009, RDB00567, RDB010, RDH008, StartCell, EndCell, EndCellName = "", Report, ReportPath;
            string[] arrSheet, arrRDH006, arrTimes, ReportData, ReportBackData;
            DataTable dt_Rep = new DataTable();
            //建一個新的Excel
            excel = new Excel.Application();
            //....停用警告訊息
            excel.DisplayAlerts = false;
            //....讓Excel文件可見
            excel.Visible = true;
            //....加入新的活頁簿
            excel.Workbooks.Add(Type.Missing);
            //活頁簿
            //....引用第一個活頁簿
            book = excel.Workbooks[1];
            //....設定活頁簿焦點
            book.Activate();
            //目前工作表的數量
            int currentNumOfSheet = book.Worksheets.Count;
            try
            {
                //取得工作表名稱
                if(RuningMachine == "Vacuum")
                    arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", "A");
                else if(RuningMachine == "Compress")
                    arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", "B");
                else
                    arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", "C");
                arrSheetLen = arrSheet.Length;
                //補足工作表
                if(currentNumOfSheet < arrSheetLen)
                    for(i = currentNumOfSheet; i < arrSheetLen; i++)
                        book.Worksheets.Add();

                for (k = 0; k < arrSheetLen; k++)
                {
                    //工作表
                    //....引用第一個工作表
                    sheet = book.Worksheets[k + 1];
                    //....引用第一個工作表
                    if (RuningMachine == "Vacuum")
                        sheet.Name = arrSheet[k] + "真空機";
                    else if (RuningMachine == "Compress")
                        sheet.Name = arrSheet[k] + "空壓機";
                    else
                        sheet.Name = arrSheet[k] + "冷氣機";
                    //....設定工作表焦點
                    sheet.Activate();
                    //....設定第1列資料
                    if (RuningMachine == "Vacuum")
                        excel.Cells[1, 1] = "真空機運轉紀錄表";
                    else if (RuningMachine == "Compress")
                        excel.Cells[1, 1] = "空壓機運轉紀錄表";
                    else
                        excel.Cells[1, 1] = "冷氣機運轉紀錄表";

                    RangeFit(ref sheet, "A1", "E1", 2);
                    
                    //取得共有多少巡檢資料
                    if (RuningMachine == "Vacuum")
                        arrRDH006 = GetSqlData(StartDate, EndDate, "Sheet01", arrSheet[k], "A");
                    else if (RuningMachine == "Compress")
                        arrRDH006 = GetSqlData(StartDate, EndDate, "Sheet01", arrSheet[k], "B");
                    else
                        arrRDH006 = GetSqlData(StartDate, EndDate, "Sheet01", arrSheet[k], "C");

                    arrRDH006Len = arrRDH006.Length;
                    //取得時間排序陣列
                    if (RuningMachine == "Vacuum")
                        arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], "A");
                    else if (RuningMachine == "Compress")
                        arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], "B");
                    else
                        arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], "C");

                    arrTimesLen = arrTimes.Length;
                    //填入機械編號、機械名稱、項目、備註1、備註2、參考、日期
                    for (i = 0; i < arrRDH006Len; i++)
                    {
                        excel.Cells[(2 + ((7 + arrTimesLen) * i)), 1] = "機械編號";
                        excel.Cells[(2 + ((7 + arrTimesLen) * i)), 2] = arrRDH006[i];
                        excel.Cells[(3 + ((7 + arrTimesLen) * i)), 1] = "機械名稱";
                        excel.Cells[(4 + ((7 + arrTimesLen) * i)), 1] = "項目";
                        excel.Cells[(5 + ((7 + arrTimesLen) * i)), 1] = "備註1";
                        excel.Cells[(6 + ((7 + arrTimesLen) * i)), 1] = "備註2";
                        excel.Cells[(7 + ((7 + arrTimesLen) * i)), 1] = "參考";
                        for (j = 0; j < arrTimesLen; j++)
                            excel.Cells[(8 + ((7 + arrTimesLen) * i)) + j, 1] = arrTimes[j];
                    }
                    //取得項目、備註1、備註2、參考值，填入Excel。
                    if (RuningMachine == "Vacuum")
                        dt_Rep = GetSqlDataTable(StartDate, EndDate, "GetBodyParaABC", arrSheet[k], "A");
                    else if (RuningMachine == "Compress")
                        dt_Rep = GetSqlDataTable(StartDate, EndDate, "GetBodyParaABC", arrSheet[k], "B");
                    else
                        dt_Rep = GetSqlDataTable(StartDate, EndDate, "GetBodyParaABC", arrSheet[k], "C");
                    for (i = 0; i < dt_Rep.Rows.Count; i++)
                    {
                        //儲存回傳資料
                        RDH006 = dt_Rep.Rows[i]["RDH006"].ToString().Trim(); //機械編號
                        RDH007 = dt_Rep.Rows[i]["RDH007"].ToString().Trim(); //機械名稱
                        RDB004 = dt_Rep.Rows[i]["RDB004"].ToString().Trim(); //項目
                        RDB00567 = dt_Rep.Rows[i]["RDB00567"].ToString().Trim(); //參考
                        RDB008 = dt_Rep.Rows[i]["RDB008"].ToString().Trim(); //備註1
                        RDB009 = dt_Rep.Rows[i]["RDB009"].ToString().Trim(); //備註2
                        RDB010 = dt_Rep.Rows[i]["RDB010"].ToString().Trim(); //數值
                        RDH008 = dt_Rep.Rows[i]["RDH008"].ToString().Trim(); //記錄日期
                        //查詢回傳資料在 arrRDH006 的索引值
                        idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                        //查詢回傳資料在 arrTimes 的索引值
                        idxTimes = Array.IndexOf(arrTimes, RDH008);
                        //當項目改變針對機械編號、名稱執行合併儲存格
                        if(TidxRDH006 != idxRDH006)
                        {
                            EndCellName = ColumnName(j + 2 - 1);
                            StartCell = "B" + ((2 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                            EndCell = EndCellName + ((2 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                            RangeFit(ref sheet, StartCell, EndCell, 1);

                            StartCell = "B" + ((3 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                            EndCell = EndCellName + ((3 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                            RangeFit(ref sheet, StartCell, EndCell, 1);

                            TidxRDH006 = idxRDH006;
                        }
                        //依索引值填入相對應的位置
                        excel.Cells[(3 + ((7 + arrTimesLen) * idxRDH006)), 2] = RDH007; //機械名稱
                        for (j = 0; j < 100; j++)
                        {
                            object O = excel.Cells[(4 + ((7 + arrTimesLen) * idxRDH006)), j + 2].Value;
                            string S = Convert.ToString(O);

                            if (S == RDB004)
                                break;

                            if (S == "")
                            {
                                excel.Cells[(4 + ((7 + arrTimesLen) * idxRDH006)), j + 2] = RDB004;   //項目
                                excel.Cells[(5 + ((7 + arrTimesLen) * idxRDH006)), j + 2] = RDB008;   //備註1
                                excel.Cells[(6 + ((7 + arrTimesLen) * idxRDH006)), j + 2] = RDB009;   //備註1
                                excel.Cells[(7 + ((7 + arrTimesLen) * idxRDH006)), j + 2] = RDB00567; //參考
                                break;
                            }
                        }
                        excel.Cells[(8 + ((7 + arrTimesLen) * idxRDH006)) + idxTimes, j + 2] = RDB010;
                    }
                    //針對機械編號、名稱執行合併儲存格
                    EndCellName = ColumnName(j + 1);
                    StartCell = "B" + ((2 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                    EndCell = EndCellName + ((2 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                    RangeFit(ref sheet, StartCell, EndCell, 1);

                    StartCell = "B" + ((3 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                    EndCell = EndCellName + ((3 + ((7 + arrTimesLen) * TidxRDH006))).ToString();
                    RangeFit(ref sheet, StartCell, EndCell, 1);

                    //欄位自動調整適合大小
                    sheet.Cells.EntireRow.AutoFit();
                    sheet.Cells.EntireColumn.AutoFit();
                }
                //儲存 Excel
                Report = "/settings/Report/";
                ReportData = new string[] { Report + "ReportAdr", Report + RuningMachine + "Name" };
                ReportBackData = UXML.ReadXML(ReportData);
                ReportPath = ReportBackData[0] + ReportBackData[1] + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
                //查詢資料夾是否存在
                if (!Directory.Exists(ReportBackData[0]))
                    Directory.CreateDirectory(ReportBackData[0]);
                //存放檔案
                excel.ActiveWorkbook.SaveAs(ReportPath);
                //清空
                sheet = null;
                book.Close();
                book = null;
                excel.Quit();
                excel = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("產生報表時出錯！，系統訊息：" + Ex.Message, "產出報表出錯");
            }
        }

        public void RepHydropower(string StartDate, string EndDate,string isExist)
        {
            //*************************************************************************************
            //專用於產出水電表記錄的報表用
            //輸入值：StartDate --> 查詢起始日期再往前一個記錄日的時間。
            //        EndDate   --> 查詢訖日。
            //        isExist   --> 查詢起始日期再往前一個記錄日的時間是否存在。
            //*************************************************************************************
            //參數
            int i, j, k, idxRDH006, idxTimes, arrSheetLen, arrRDH006Len, arrTimesLen;
            string RDH006, RDB004, RDB00567, RDB008, RDB009, RDH008, RDB010, Report, ReportPath, EndCellName;
            string[] arrSheet, arrRDH006, arrTimes, ReportData, ReportBackData;
            DataTable dt_Rep;
            //建一個新的Excel
            excel = new Excel.Application();
            //....停用警告訊息
            excel.DisplayAlerts = false;
            //....讓Excel文件可見
            excel.Visible = true;
            //....加入新的活頁簿
            excel.Workbooks.Add(Type.Missing);
            //活頁簿
            //....引用第一個活頁簿
            book = excel.Workbooks[1];
            //....設定活頁簿焦點
            book.Activate();
            //目前工作表的數量
            int currentNumOfSheet = book.Worksheets.Count;
            try
            {
                //取得工作表名稱
                arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", "D");
                arrSheetLen = arrSheet.Length;
                //補足工作表
                if (currentNumOfSheet < arrSheetLen)
                    for (i = currentNumOfSheet; i < arrSheetLen; i++)
                        book.Worksheets.Add();

                for (k = 0; k < arrSheetLen; k++)
                {
                    //工作表
                    //....引用第一個工作表
                    sheet = book.Worksheets[k + 1];
                    //....引用第一個工作表
                    sheet.Name = arrSheet[k] + "水電錶指數";
                    //....設定工作表焦點
                    sheet.Activate();
                    //....設定第1列資料
                    excel.Cells[1, 1] = "廠房：" + arrSheet[k];
                    range = sheet.get_Range("C1", "G1");
                    range.Merge(0);
                    excel.Cells[1, 3] = "電錶、水錶、機械運轉、時間指數表";
                    //....設定第2列資料
                    excel.Cells[2, 1] = "排序";
                    //取得共有多少巡檢資料
                    arrRDH006 = GetSqlData(StartDate, EndDate, "Sheet01", arrSheet[k], "D");
                    arrRDH006Len = arrRDH006.Length;
                    for (i = 0; i < arrRDH006Len; i++)
                        excel.Cells[2, 3 + i] = (i + 1).ToString();
                    //....設定第3~6列資料
                    excel.Cells[3, 1] = "項目";
                    excel.Cells[4, 1] = "備註1";
                    excel.Cells[5, 1] = "備註2";
                    excel.Cells[6, 1] = "參考";
                    //取得項目、備註1、備註2、參考值，填入Excel。
                    dt_Rep = GetSqlDataTable(StartDate, EndDate, "GetBodyPara", arrSheet[k], "D");
                    for (i = 0; i < dt_Rep.Rows.Count; i++)
                    {
                        //儲存回傳資料
                        RDH006 = dt_Rep.Rows[i]["RDH006"].ToString().Trim(); //機械編號
                        RDB004 = dt_Rep.Rows[i]["RDB004"].ToString().Trim(); //項目
                        RDB00567 = dt_Rep.Rows[i]["RDB00567"].ToString().Trim(); //參考
                        RDB008 = dt_Rep.Rows[i]["RDB008"].ToString().Trim(); //備註1
                        RDB009 = dt_Rep.Rows[i]["RDB009"].ToString().Trim(); //備註2
                                                                             //查詢回傳資料在 arrRDH006 的索引值
                        idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                        //依索引值填入相對應的位置
                        excel.Cells[3, 3 + idxRDH006] = RDB004;
                        excel.Cells[4, 3 + idxRDH006] = RDB008;
                        excel.Cells[5, 3 + idxRDH006] = RDB009;
                        excel.Cells[6, 3 + idxRDH006] = RDB00567;
                    }
                    //....設定第7列資料
                    excel.Cells[7, 1] = "時間";
                    //取得時間排序陣列
                    arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], "D");
                    arrTimesLen = arrTimes.Length;
                    //....設定第 9 + 2*i 列資料
                    for (i = 0; i < arrTimesLen; i++)
                    {
                        //若查詢日往前最近一日的日期是存在的，arrTimes第一筆存放的不可填入報表
                        if (isExist == "Y" && i == 0)
                            continue;

                        excel.Cells[(9 + (2 * i)), 1] = arrTimes[i];
                        excel.Cells[(8 + (2 * i)), 2] = "前日差異";
                        excel.Cells[(9 + (2 * i)), 2] = "本日指數";
                        //在每項"本日指數"欄畫下線
                        EndCellName = ColumnName(arrRDH006Len + 1);
                        range = sheet.get_Range("A" + (9 + (2 * i)).ToString(), EndCellName + (9 + (2 * i)).ToString());

                        range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium;
                    }
                    //取得各項目在某時間數值資料填入
                    dt_Rep = GetSqlDataTable(StartDate, EndDate, "GetBodyValue", arrSheet[k], "D");
                    for (i = 0; i < dt_Rep.Rows.Count; i++)
                    {
                        //儲存回傳資料
                        RDH006 = dt_Rep.Rows[i]["RDH006"].ToString().Trim(); //機械編號
                        RDH008 = dt_Rep.Rows[i]["RDH008"].ToString().Trim(); //記錄時間
                        RDB010 = dt_Rep.Rows[i]["RDB010"].ToString().Trim(); //數值
                                                                             //查詢回傳資料在 arrRDH006 的索引值
                        idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                        //查詢回傳資料在 arrTimes 的索引值
                        idxTimes = Array.IndexOf(arrTimes, RDH008);
                        //填入查詢起日往前最近的記錄時間的數值
                        if (isExist == "N")
                        {
                            //因查詢起日往前最近一日的日期是空白，填入0
                            excel.Cells[7, 3 + idxRDH006] = "0";
                            //填入某項目在某日期的資料
                            excel.Cells[(9 + (2 * idxTimes)), 3 + idxRDH006] = RDB010;
                        }
                        else
                        {
                            //填入某項目在某日期的資料
                            excel.Cells[(7 + (2 * idxTimes)), 3 + idxRDH006] = RDB010;
                        }
                    }
                    //計算前日差異
                    for (i = 0; i < arrRDH006Len; i++)
                    {
                        for (j = arrTimesLen - 1; j >= 0; j--)
                        {
                            object T = excel.Cells[(9 + (2 * j)), 3 + i].Value;
                            object B = excel.Cells[(9 + (2 * (j - 1))), 3 + i].Value;
                            double TValue = Convert.ToDouble(T);
                            double BValue = Convert.ToDouble(B);
                            excel.Cells[(8 + (2 * j)), 3 + i] = TValue - BValue;
                        }
                        excel.Cells[7, 3 + i] = "";
                    }
                    //欄位自動調整適合大小
                    sheet.Cells.EntireRow.AutoFit();
                    sheet.Cells.EntireColumn.AutoFit();
                }
                //儲存 Excel
                Report = "/settings/Report/";
                ReportData = new string[] { Report + "ReportAdr", Report + "HydropowerName" };
                ReportBackData = UXML.ReadXML(ReportData);
                ReportPath = ReportBackData[0] + ReportBackData[1] + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
                //查詢資料夾是否存在
                if(!Directory.Exists(ReportBackData[0]))
                    Directory.CreateDirectory(ReportBackData[0]);
                //存放檔案
                excel.ActiveWorkbook.SaveAs(ReportPath);
                //清空
                sheet = null;
                book.Close();
                book = null;
                excel.Quit();
                excel = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("產生報表時出錯！，系統訊息：" + Ex.Message, "產出報表出錯");
            }
        }

        private string[] GetSqlData(string StartDate, string EndDate, string ToDoWhat, string Parameter, string RDH004)
        {
            //*************************************************************************************
            //輸入值：StartDate --> 抓取資料的起日
            //          EndDate --> 抓取資料的訖日
            //         ToDoWhat --> 要執行的動作
            //        Parameter --> 配合 ToDoWhat 提供一參數，好方便使用。
            //*************************************************************************************
            string strSQL;
            string[] arrTemp;

            strSQL = "";

            if (ToDoWhat == "SheetName")
            {
                strSQL += "SELECT RDH002 ";
                strSQL += "FROM RECORDS_HEADS ";
                strSQL += "WHERE RDH004 = '" + RDH004 + "' ";
                strSQL += "AND RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "GROUP BY RDH002 ";
            }
            else if (ToDoWhat == "Sheet01")
            {
                strSQL += "SELECT RDH006 ";
                strSQL += "FROM RECORDS_HEADS ";
                strSQL += "WHERE RDH004 = '" + RDH004 + "' ";
                strSQL += "AND RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND RDH002 = '" + Parameter + "' GROUP BY RDH006 ";
            }
            else if (ToDoWhat == "Chronologically")
            {
                strSQL += "SELECT RDH008 ";
                strSQL += "FROM RECORDS_HEADS ";
                strSQL += "WHERE RDH004 = '" + RDH004 + "' ";
                strSQL += "AND RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND RDH002 = '" + Parameter + "' GROUP BY RDH008 ";
            }

            dt = USQL.SQLSelect(ref da, strSQL);

            arrTemp = new string[dt.Rows.Count];
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (ToDoWhat == "SheetName")
                    arrTemp[i] = dt.Rows[i]["RDH002"].ToString().Trim();
                else if (ToDoWhat == "Sheet01")
                    arrTemp[i] = dt.Rows[i]["RDH006"].ToString().Trim();
                else if (ToDoWhat == "Chronologically")
                    arrTemp[i] = dt.Rows[i]["RDH008"].ToString().Trim();
            }

            return arrTemp;
        }

        private DataTable GetSqlDataTable(string StartDate, string EndDate, string ToDoWhat, string Parameter, string RDH004)
        {
            //*************************************************************************************
            //輸入值：StartDate --> 抓取資料的起日
            //          EndDate --> 抓取資料的訖日
            //         ToDoWhat --> 要執行的動作
            //        Parameter --> 配合 ToDoWhat 提供一參數，好方便使用。
            //*************************************************************************************
            strSQL = "";
            if (ToDoWhat == "GetBodyPara")
            {
                strSQL += "SELECT a.RDH006,a.RDH007,b.RDB004,b.RDB008,b.RDB009,(b.RDB005 + b.RDB006 + b.RDB007) as RDB00567 ";
                strSQL += "FROM RECORDS_HEADS a, RECORDS_BODYS b ";
                strSQL += "WHERE a.RDH001 = b.RDB001 ";
                strSQL += "AND a.RDH004 = '" + RDH004 + "' ";
                strSQL += "AND a.RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND a.RDH002 = '" + Parameter + "' ";
                strSQL += "GROUP BY a.RDH006,a.RDH007,b.RDB004,b.RDB008,b.RDB009,b.RDB005,b.RDB006,b.RDB007 ";
            }
            else if(ToDoWhat == "GetBodyValue")
            {
                strSQL += "SELECT a.RDH006,a.RDH008,b.RDB010 ";
                strSQL += "FROM RECORDS_HEADS a,RECORDS_BODYS b ";
                strSQL += "WHERE a.RDH001 = b.RDB001 ";
                strSQL += "AND a.RDH004 = '" + RDH004 + "' ";
                strSQL += "AND a.RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND a.RDH002 = '" + Parameter + "' ";
                strSQL += "GROUP BY RDH006,RDH008,RDB010 ";
            }
            else if (ToDoWhat == "GetBodyParaABC")
            {
                strSQL += "SELECT a.RDH006,a.RDH007,b.RDB003,b.RDB004,b.RDB008,b.RDB009,(b.RDB005 + b.RDB006 + b.RDB007) as RDB00567,a.RDH008,b.RDB010 ";
                strSQL += "FROM RECORDS_HEADS a, RECORDS_BODYS b ";
                strSQL += "WHERE a.RDH001 = b.RDB001 ";
                strSQL += "AND a.RDH004 = '" + RDH004 + "' ";
                strSQL += "AND a.RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND a.RDH002 = '" + Parameter + "' ";
                strSQL += "GROUP BY a.RDH006,a.RDH007,b.RDB003,b.RDB004,b.RDB008,b.RDB009,b.RDB005,b.RDB006,b.RDB007,a.RDH008,b.RDB010 ";
            }
            
            dt = USQL.SQLSelect(ref da, strSQL);

            return dt;
        }

        private string ColumnName(int MaxY)
        {
            //*************************************************************************************
            //用以計算 MaxY 所在欄位的代表值。 ex: "A" or "AC" or "BH" ....
            //*************************************************************************************
            string Y1 = "", Y2 = "";
            if (MaxY <= 26)
                Y1 = arrChar[MaxY];
            else
            {
                Y1 = arrChar[(MaxY / 26) - 1];
                Y2 = arrChar[(MaxY % 26)];
            }

            return (Y1 + Y2);
        }

        private void RangeFit(ref Excel.Worksheet sheet, string StartCell, string EndCell, int RangeType)
        {
            if(RangeType == 1)
            {
                range = sheet.get_Range(StartCell, EndCell);
                range.Merge(0);
                range.Font.Size = 12;
                //range.Font.Bold = true;
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            else if(RangeType == 2)
            {
                range = sheet.get_Range(StartCell, EndCell);
                range.Merge(0);
                range.Font.Size = 20;
                range.Font.Bold = true;
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }
    }
}
