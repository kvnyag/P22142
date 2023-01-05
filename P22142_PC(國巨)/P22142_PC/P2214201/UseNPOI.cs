using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using NPOI.SS.Util;
using REGAL.Data.DataAccess;
using System.Data;
using System.Text;
using System.IO;

namespace P2214201
{
    class UseNPOI
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
        HSSFWorkbook book = new HSSFWorkbook();
        ISheet sheet;
        IRow row;
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
            int i, j = 0, k, RowNo, arrSheetLen, arrRDH006Len, arrTimesLen, idxRDH006, idxTimes, iCG001;
            string CG001, CG002, RDH006, RDH007, RDB003, RDB004, RDB008, RDB009, RDB00567, RDB010, RDH008, Report, ReportPath;
            string[] arrSheet, arrRDH006, arrTimes, ReportData, ReportBackData;

            //取得目前的類別
            if (RuningMachine == "Vacuum")
            {
                CG001 = "A";
                CG002 = "真空機";
            }
            else if (RuningMachine == "Compress")
            {
                CG001 = "B";
                CG002 = "空壓機";
            }
            else
            {
                CG001 = "C";
                CG002 = "冷氣機";
            }

            //取得工作表名稱
            arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", CG001);
            arrSheetLen = arrSheet.Length;

            for (k = 0; k < arrSheetLen; k++)
            {
                //工作表
                //....引用第一個工作表
                sheet = book.CreateSheet(arrSheet[k] + CG002);
                //....設定第1列資料
                DealCell(ref sheet, "A1", "F1", "", ""); //合併A1 ~ E1
                DealCell(ref sheet, "A1", "", CG002 + "運轉紀錄表", "1");
                //....取得共有多少巡檢資料
                arrRDH006 = GetSqlData(StartDate, EndDate, "ItemName", arrSheet[k], CG001);
                arrRDH006Len = arrRDH006.Length;
                //....取得時間排序陣列
                arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], CG001);
                arrTimesLen = arrTimes.Length;
                //填入機械編號、機械名稱、項目、備註1、備註2、參考、日期
                for (i = 0; i < arrRDH006Len; i++)
                {
                    RowNo = (8 + arrTimesLen) * i;
                    DealCell(ref sheet, "A" + (2 + RowNo).ToString(), "", "機械編號", "");
                    DealCell(ref sheet, "B" + (2 + RowNo).ToString(), "", arrRDH006[i], "2");
                    DealCell(ref sheet, "A" + (3 + RowNo).ToString(), "", "機械名稱", "");
                    DealCell(ref sheet, "B" + (3 + RowNo).ToString(), "", "", "2");
                    DealCell(ref sheet, "A" + (4 + RowNo).ToString(), "", "項目代號", "");
                    DealCell(ref sheet, "A" + (5 + RowNo).ToString(), "", "項目名稱", "");
                    DealCell(ref sheet, "A" + (6 + RowNo).ToString(), "", "備註1", "");
                    DealCell(ref sheet, "A" + (7 + RowNo).ToString(), "", "備註2", "");
                    DealCell(ref sheet, "A" + (8 + RowNo).ToString(), "", "參考", "");
                    //針對機械編號、名稱執行合併儲存格
                    iCG001 = CategorysNo(StartDate, EndDate, arrSheet[k], CG001, arrRDH006[i]); //機械編號共有多少項目
                    string EndX = arrChar[Array.IndexOf(arrChar, "B") + iCG001 - 1];
                    DealCell(ref sheet, "B" + (2 + RowNo).ToString(), EndX + (2 + RowNo).ToString(), "", ""); //合併機械編號
                    DealCell(ref sheet, "B" + (3 + RowNo).ToString(), EndX + (3 + RowNo).ToString(), "", ""); //合併機械編號

                    for (j = 0; j < arrTimesLen; j++)
                        DealCell(ref sheet, "A" + (9 + RowNo + j).ToString(), "", arrTimes[j], "");
                }
                //取得項目、備註1、備註2、參考值，填入Excel。
                dt = GetSqlDataTable(StartDate, EndDate, "GetBodyParaABC", arrSheet[k], CG001);

                for (i = 0; i < dt.Rows.Count; i++)
                {
                    //儲存回傳資料
                    RDH006 = dt.Rows[i]["RDH006"].ToString().Trim();     //機械編號
                    RDH007 = dt.Rows[i]["RDH007"].ToString().Trim();     //機械名稱
                    RDB003 = dt.Rows[i]["RDB003"].ToString().Trim();     //項目代號
                    RDB004 = dt.Rows[i]["RDB004"].ToString().Trim();     //項目名稱
                    RDB00567 = dt.Rows[i]["RDB00567"].ToString().Trim(); //參考
                    RDB008 = dt.Rows[i]["RDB008"].ToString().Trim();     //備註1
                    RDB009 = dt.Rows[i]["RDB009"].ToString().Trim();     //備註2
                    RDB010 = dt.Rows[i]["RDB010"].ToString().Trim();     //數值
                    RDH008 = dt.Rows[i]["RDH008"].ToString().Trim();     //記錄日期
                    //查詢回傳資料在 arrRDH006 的索引值
                    idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                    //查詢回傳資料在 arrTimes 的索引值
                    idxTimes = Array.IndexOf(arrTimes, RDH008);
                    //依索引值填入相對應的位置
                    RowNo = (8 + arrTimesLen) * idxRDH006;
                    DealCell(ref sheet, "B" + (3 + RowNo).ToString(), "", RDH007, ""); //機械名稱
                    string S;
                    for (j = 0; j < 100; j++)
                    {
                        S = CellValue(ref sheet, ColumnName(j + 2) + (4 + RowNo).ToString());

                        if (S == RDB003)
                            break;

                        if (S == "")
                        {
                            DealCell(ref sheet, ColumnName(j + 2) + (4 + RowNo).ToString(), "", RDB003, ""); //項目代號
                            DealCell(ref sheet, ColumnName(j + 2) + (5 + RowNo).ToString(), "", RDB004, ""); //項目名稱
                            DealCell(ref sheet, ColumnName(j + 2) + (6 + RowNo).ToString(), "", RDB008, ""); //備註1
                            DealCell(ref sheet, ColumnName(j + 2) + (7 + RowNo).ToString(), "", RDB009, ""); //備註2
                            DealCell(ref sheet, ColumnName(j + 2) + (8 + RowNo).ToString(), "", RDB00567, ""); //參考

                            break;
                        }
                    }
                    DealCell(ref sheet, ColumnName(j + 2) + (9 + RowNo + idxTimes).ToString(), "", RDB010, ""); //數值
                }
            }
            //儲存 Excel
            Report = "/settings/Report/";
            ReportData = new string[] { Report + "ReportAdr", Report + RuningMachine + "Name" };
            ReportBackData = UXML.ReadXML(ReportData);
            ReportPath = ReportBackData[0] + ReportBackData[1] + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
            //存放檔案
            FileStream file = new FileStream(ReportPath, FileMode.Create);//產生檔案
            book.Write(file);
            file.Close();
        }

        public void RepHydropower(string StartDate, string EndDate, string isExist)
        {
            //*************************************************************************************
            //專用於產出水電表記錄的報表用
            //輸入值：StartDate --> 查詢起始日期再往前一個記錄日的時間。
            //        EndDate   --> 查詢訖日。
            //        isExist   --> 查詢起始日期再往前一個記錄日的時間是否存在。
            //*************************************************************************************
            //參數
            int i, j, k, RowNo, idxRDH006, idxTimes, arrSheetLen, arrRDH006Len, arrTimesLen;
            string RDH006, RDB004, RDB00567, RDB008, RDB009, RDH008, RDB010, Report, ReportPath;
            string[] arrSheet, arrRDH006, arrTimes, ReportData, ReportBackData;
            
            //取得工作表名稱
            arrSheet = GetSqlData(StartDate, EndDate, "SheetName", "", "D");
            arrSheetLen = arrSheet.Length;

            for (k = 0; k < arrSheetLen; k++)
            {
                //工作表
                //....引用第一個工作表
                sheet = book.CreateSheet(arrSheet[k] + "水電錶指數");
                //....設定第1列資料
                DealCell(ref sheet, "A1", "", "廠房：" + arrSheet[k], "");
                DealCell(ref sheet, "C1", "", "電錶、水錶、機械運轉、時間指數表", "");
                DealCell(ref sheet, "C1", "G1", "", ""); //合併 C1 ~ G1
                //....設定第2列資料
                DealCell(ref sheet, "A2", "", "排序", "");
                //....取得共有多少巡檢資料
                arrRDH006 = GetSqlData(StartDate, EndDate, "ItemName", arrSheet[k], "D");
                arrRDH006Len = arrRDH006.Length;
                for (i = 0; i < arrRDH006Len; i++)
                    DealCell(ref sheet, ColumnName(3 + i) + "2", "", (i + 1).ToString(), ""); //C2 ~ D2 ~ ... 填入序號
                //....設定第3~6列資料
                DealCell(ref sheet, "A3", "", "項目", "");
                DealCell(ref sheet, "A4", "", "備註1", "");
                DealCell(ref sheet, "A5", "", "備註2", "");
                DealCell(ref sheet, "A6", "", "參考", "");
                //取得項目、備註1、備註2、參考值，填入Excel。
                dt = GetSqlDataTable(StartDate, EndDate, "GetBodyParaD", arrSheet[k], "D");
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    //儲存回傳資料
                    RDH006   = dt.Rows[i]["RDH006"].ToString().Trim();   //機械編號
                    RDB004   = dt.Rows[i]["RDB004"].ToString().Trim();   //項目
                    RDB00567 = dt.Rows[i]["RDB00567"].ToString().Trim(); //參考
                    RDB008   = dt.Rows[i]["RDB008"].ToString().Trim();   //備註1
                    RDB009   = dt.Rows[i]["RDB009"].ToString().Trim();   //備註2
                    //查詢回傳資料在 arrRDH006 的索引值
                    idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                    //依索引值填入相對應的位置 
                    DealCell(ref sheet, ColumnName(3 + idxRDH006) + "3", "", RDB004, "");
                    DealCell(ref sheet, ColumnName(3 + idxRDH006) + "4", "", RDB008, "");
                    DealCell(ref sheet, ColumnName(3 + idxRDH006) + "5", "", RDB009, "");
                    DealCell(ref sheet, ColumnName(3 + idxRDH006) + "6", "", RDB00567, "");
                }
                //....設定第7列資料
                DealCell(ref sheet, "A7", "", "時間", "");
                //取得時間排序陣列
                arrTimes = GetSqlData(StartDate, EndDate, "Chronologically", arrSheet[k], "D");
                arrTimesLen = arrTimes.Length;
                //....設定第 9 + (2 * i) 列資料
                for (i = 0; i < arrTimesLen; i++)
                {
                    //若查詢日往前最近一日的日期是存在的，arrTimes第一筆存放的不可填入報表
                    if (isExist == "Y")
                    {
                        if (i == 0)
                            continue;
                        else
                            RowNo = (2 * (i - 1));
                    }
                    else
                        RowNo = (2 * i);
                    
                    DealCell(ref sheet, "A" + (9 + RowNo).ToString(), "", arrTimes[i], "");
                    DealCell(ref sheet, "B" + (8 + RowNo).ToString(), "", "前日差異", "");
                    DealCell(ref sheet, "B" + (9 + RowNo).ToString(), "", "本日指數", "");
                    
                }
                //取得各項目在某時間數值資料填入
                dt = GetSqlDataTable(StartDate, EndDate, "GetBodyValueD", arrSheet[k], "D");
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    //儲存回傳資料
                    RDH006 = dt.Rows[i]["RDH006"].ToString().Trim(); //機械編號
                    RDH008 = dt.Rows[i]["RDH008"].ToString().Trim(); //記錄時間
                    RDB010 = dt.Rows[i]["RDB010"].ToString().Trim(); //數值
                    //查詢回傳資料在 arrRDH006 的索引值
                    idxRDH006 = Array.IndexOf(arrRDH006, RDH006);
                    //查詢回傳資料在 arrTimes 的索引值
                    idxTimes = Array.IndexOf(arrTimes, RDH008);
                    //填入查詢起日往前最近的記錄時間的數值
                    if (isExist == "N")
                    {
                        //因查詢起日往前最近一日的日期是空白，填入0
                        DealCell(ref sheet, ColumnName(3 + idxRDH006) + "7", "", "0", "");
                        //填入某項目在某日期的資料
                        DealCell(ref sheet, ColumnName(3 + idxRDH006) + (9 + (2 * idxTimes)).ToString(), "", RDB010, "");
                    }
                    else
                    {
                        //填入某項目在某日期的資料
                        DealCell(ref sheet, ColumnName(3 + idxRDH006) + (7 + (2 * idxTimes)).ToString(), "", RDB010, "");
                    }
                }
                //計算前日差異
                for (i = 0; i < arrRDH006Len; i++)
                {
                    int t;

                    if (isExist == "Y")
                        t = arrTimesLen - 2;
                    else
                        t = arrTimesLen - 1;

                    for (j = t; j >= 0; j--)
                    {
                        string T = CellValue(ref sheet, ColumnName(3 + i) + (9 + (2 * j)).ToString());
                        string B = CellValue(ref sheet, ColumnName(3 + i) + (9 + (2 * (j - 1))).ToString());
                        if(T != "" && B != "")
                        {
                            double TValue = Convert.ToDouble(T);
                            double BValue = Convert.ToDouble(B);
                            DealCell(ref sheet, ColumnName(3 + i) + (8 + (2 * j)).ToString(), "", (TValue - BValue).ToString(), "");
                        }
                    }
                    DealCell(ref sheet, ColumnName(3 + i) + "7", "", "", "");
                }
            }
            //儲存 Excel
            Report = "/settings/Report/";
            ReportData = new string[] { Report + "ReportAdr", Report + "HydropowerName" };
            ReportBackData = UXML.ReadXML(ReportData);
            ReportPath = ReportBackData[0] + ReportBackData[1] + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
            //存放檔案
            FileStream file = new FileStream(ReportPath, FileMode.Create);//產生檔案
            book.Write(file);
            file.Close();
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
            else if (ToDoWhat == "ItemName")
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
                else if (ToDoWhat == "ItemName")
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
            if (ToDoWhat == "GetBodyParaD")
            {
                strSQL += "SELECT a.RDH006,a.RDH007,b.RDB004,b.RDB008,b.RDB009,(b.RDB005 + b.RDB006 + b.RDB007) as RDB00567 ";
                strSQL += "FROM RECORDS_HEADS a, RECORDS_BODYS b ";
                strSQL += "WHERE a.RDH001 = b.RDB001 ";
                strSQL += "AND a.RDH004 = '" + RDH004 + "' ";
                strSQL += "AND a.RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
                strSQL += "AND a.RDH002 = '" + Parameter + "' ";
                strSQL += "GROUP BY a.RDH006,a.RDH007,b.RDB004,b.RDB008,b.RDB009,b.RDB005,b.RDB006,b.RDB007 ";
            }
            else if (ToDoWhat == "GetBodyValueD")
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

        private int CategorysNo(string StartDate, string EndDate, string RDH002, string RDH004, string RDH006)
        {
            //*************************************************************************************
            //回傳某一機械編號有多少項目
            //*************************************************************************************
            int intBack;

            strSQL = "";
            strSQL += "SELECT b.RDB003 ";
            strSQL += "FROM RECORDS_HEADS a, RECORDS_BODYS b ";
            strSQL += "WHERE a.RDH001 = b.RDB001 ";
            strSQL += "AND a.RDH002 = '" + RDH002 + "' ";
            strSQL += "AND a.RDH004 = '" + RDH004 + "' ";
            strSQL += "AND a.RDH006 = '" + RDH006 + "' ";
            strSQL += "AND a.RDH008 BETWEEN '" + StartDate + "' AND '" + EndDate + "' ";
            strSQL += "GROUP BY b.RDB003 ";
            dt = USQL.SQLSelect(ref da, strSQL);
            intBack = dt.Rows.Count;

            return intBack;
        }

        private ICellStyle CellStyle(ref ISheet sheet, int CellType)
        {
            
            ICellStyle CStyle = book.CreateCellStyle();
            IFont Font = book.CreateFont();
            
            //設定樣式
            if (CellType == 1)
            {
                CStyle.Alignment = HorizontalAlignment.Center; //水平置中
                CStyle.VerticalAlignment = VerticalAlignment.Center; //垂直置中
                Font.FontName = "微軟正黑體";
                Font.FontHeightInPoints = 20;
                Font.IsBold = true;
                CStyle.SetFont(Font);
            }
            else if (CellType == 2)
            {
                CStyle.Alignment = HorizontalAlignment.Center; //水平置中
                CStyle.VerticalAlignment = VerticalAlignment.Center; //垂直置中
                Font.FontName = "微軟正黑體";
                Font.FontHeightInPoints = 12;
                Font.IsBold = true;
                CStyle.SetFont(Font);
            }
            else if (CellType == 3)
            {
                CStyle.BorderBottom = BorderStyle.Thin; //底線
            }

            return CStyle;
        }

        private void DealCell(ref ISheet sheet, string StartCellName, string EndCellName, string CellValue, string Style)
        {
            //*************************************************************************************
            //專門做 Excel 欄位處理。ex: GetCell or CreateCell or AddMergedRegion(欄位合併) or Style(字型變化)
            //輸入值：        sheet：利用傳址將工作表傳入。
            //        StartCellName：要處理的欄位 or 要合併的起始欄位。
            //          EndCellName：要合併的結束欄位。
            //            CellValue：要寫入欄位中的值。
            //                Style：字型變化。
            //*************************************************************************************
            //參數
            int sCellX, sCellY, eCellX, eCellY;
            
            //取得 StartCellName 的 X 與 Y 值
            sCellX = CellXY(StartCellName, "X");
            sCellY = CellXY(StartCellName, "Y");

            //若 EndCellName 空白表示單純填值，若不是空白 表示要做合併。
            if (EndCellName == "")
            {
                //試看看 GetRow 若不行則執行 CreateRow
                if (sheet.GetRow(sCellY) == null)
                    sheet.CreateRow(sCellY);
                //試看看 GetCell 若不行則執行 CreateCell
                if(sheet.GetRow(sCellY).GetCell(sCellX) == null)
                    sheet.GetRow(sCellY).CreateCell(sCellX);
                //填入值
                sheet.GetRow(sCellY).GetCell(sCellX).SetCellValue(CellValue);
                //字型變化
                if (Style != "")
                    sheet.GetRow(sCellY).GetCell(sCellX).CellStyle = CellStyle(ref sheet, int.Parse(Style));
            }
            else
            {
                //取得 StartCellName 的 X 與 Y 值
                eCellX = CellXY(EndCellName, "X");
                eCellY = CellXY(EndCellName, "Y");
                //執行合併
                sheet.AddMergedRegion(new CellRangeAddress(sCellY, eCellY, sCellX, eCellX));
            }
        }

        private string CellValue(ref ISheet sheet, string CellName)
        {
            //*************************************************************************************
            //用以取得Excel中某 Cell 的所填的值
            //*************************************************************************************
            //參數
            int CellX, CellY;
            string strBack;

            //取得 CellName 的 X 與 Y 值
            CellX = CellXY(CellName, "X");
            CellY = CellXY(CellName, "Y");
            //試看看 GetRow 若不行則執行 CreateRow
            if (sheet.GetRow(CellY) == null)
                sheet.CreateRow(CellY);
            //試看看 GetCell 若不行則執行 CreateCell
            if (sheet.GetRow(CellY).GetCell(CellX) == null)
                sheet.GetRow(CellY).CreateCell(CellX);
            //取回資料
            strBack = sheet.GetRow(CellY).GetCell(CellX).StringCellValue.ToString().Trim();

            return strBack;
        }

        private int CellXY(string CellName, string XorY)
        {
            //*************************************************************************************
            //傳入CellName及要回傳的是X或Y值。回傳CellName的X或Y值，但都是以數值格式回傳。
            //*************************************************************************************
            //參數
            int i, strLen, idxChar, CellX = 0, iCellX_01 = 0, iCellX_02 = 0, iCellX_03 = 0, CellY = 0;
            
            //取得 Cell值 英文部份
            strLen = CellName.Length;
            for(i = 0; i < strLen; i++)
            {
                idxChar = Array.IndexOf(arrChar, CellName.Substring(i, 1));
                if (idxChar != -1)
                {
                    if (i == 0)
                        iCellX_01 = idxChar + 1; //記錄英文部份的第一碼
                    else if (i == 1)
                        iCellX_02 = idxChar + 1; //記錄英文部份的第二碼
                    else
                        iCellX_03 = idxChar + 1; //記錄英文部份的第三碼
                }
                else
                    break;
            }
            if (iCellX_03 != 0)
                CellX = iCellX_01 * 26 * 26 + iCellX_02 * 26 + iCellX_03;
            else if (iCellX_02 != 0)
                CellX = iCellX_01 * 26 + iCellX_02;
            else
                CellX = iCellX_01;
            //取得 Cell值 數字部份
            CellY = int.Parse(CellName.Substring((i), strLen - i));

            if (XorY == "X")
                return CellX - 1;
            else if (XorY == "Y")
                return CellY - 1;
            else
                return -1;
        }
        private string ColumnName(int CellX)
        {
            //*************************************************************************************
            //回傳CellX所代表的英文代號。 ex: "A" or "AC" or "BH" .... PS: A -> CellX = 1 ; Z -> CellX = 26
            //*************************************************************************************
            string Y1 = "", Y2 = "";
            
            if (CellX <= 26)
                Y1 = arrChar[CellX - 1];
            else
            {
                if (CellX % 26 != 0)
                {
                    Y1 = arrChar[(CellX / 26) - 1];
                    Y2 = arrChar[(CellX % 26) - 1];
                }
                else
                {
                    Y1 = arrChar[(CellX / 26) - 2];
                    Y2 = arrChar[25];
                }
            }

            return (Y1 + Y2);
        }
    }
}
