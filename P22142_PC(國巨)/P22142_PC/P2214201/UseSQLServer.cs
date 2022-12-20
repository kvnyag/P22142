using REGAL.Data.DataAccess;
using System.Data.Common;
using System.Data;

namespace P2214201
{
    public partial class UseSQLServer
    {//所有使用 SQL Server的事都呼叫這個類別

        //公用變數
        DataAccess da;
        DbTransaction objTrans;

        private DataAccess CreateSQL()
        {
            //參數
            string SQLXMLPath;
            string[] SQLData, SQLBackData;

            //讀取XML檔抓取SQL連線相關資訊
            UseXML UXML = new UseXML();
            SQLXMLPath = "/settings/SQLServer/";
            SQLData = new string[] 
            {
                SQLXMLPath + "IP",
                SQLXMLPath + "DBName",
                SQLXMLPath + "UserID",
                SQLXMLPath + "Password"
            };
            SQLBackData = UXML.ReadXML(SQLData);
            
            //連線SQL Server
            da = new DataAccess();
            objTrans = null;

            //da.ConnectionString = @"Data Source=192.168.9.18;Database=DB22055;User Id=sa;Password=chi";
            //da.ConnectionString = @"Data Source=DESKTOP-S567K53\SQLEXPRESS;Database=DB22142;User Id=sa;Password=sa";
            //da.ConnectionString = @"Data Source=192.168.9.128\SQLEXPRESS;Database=DB22142;User Id=sa;Password=1234";
            da.ConnectionString = @"Data Source=" + SQLBackData[0] + ";Database=" + SQLBackData[1] + ";User Id=" + SQLBackData[2] + ";Password=" + SQLBackData[3];

            da.ProviderName = "System.Data.SqlClient";
            objTrans = da.CreateDbTransaction();
            string SQL_UpLevel = "set transaction isolation level read uncommitted ";
            da.ExecuteNonQuery(SQL_UpLevel); //避免查詢造成死結

            //回傳 DataAccess
            return da;
        }

        public DataTable SQLSelect(ref DataAccess da, string strSelect)
        {//********************************************************************
         //執行 SQL Server Select 動作
         //傳入值：
         //.......da：已做過 SQL Create 後的 DataAccess
         //.......strSelect：SQL Select 語法
         //********************************************************************
            //參數
            DataTable dt = new DataTable();

            //還沒做過 CreateSQL
            if (da.ConnectionString == null) 
                da = CreateSQL();
            //執行 Select
            dt = da.ExecuteDataTable(strSelect);
            //回傳 DataTable
            return dt;
        }

        public DataTable SQLSelect(string strSelect)
        {
            //********************************************************************
            //執行 SQL Server Select 動作
            //傳入值：
            //.......strSelect：SQL Select 語法
            //********************************************************************
            //參數
            DataTable dt = new DataTable();

            //還沒做過 CreateSQL
            da = CreateSQL();
            //執行 Select
            dt = da.ExecuteDataTable(strSelect);
            //回傳 DataTable
            return dt;
        }

        public DbTransaction SQLNonSelect(ref DataAccess da, ref DbTransaction objTrans, string strNonSelect)
        {//********************************************************************
         //執行 SQL Server 非 Select 動作
         //傳入值：
         //.......da：已做過 SQL Create 後的 DataAccess
         //.......objTrans：DbTransaction
         //.......strNonSelect：SQL Select 語法
         //********************************************************************
            //還沒做過 CreateSQL
            if (da.ConnectionString == null)
                da = CreateSQL();
            if(objTrans == null)
                objTrans = da.CreateDbTransaction();
            //執行 Insert、Update、Delete
            da.ExecuteNonQuery(strNonSelect, objTrans);
            //回傳 DbTransaction
            return objTrans;
        }

        public DbTransaction SQLNonSelect(ref DbTransaction objTrans, string strNonSelect)
        {//********************************************************************
         //執行 SQL Server 非 Select 動作
         //傳入值：
         //.......objTrans：DbTransaction
         //.......strNonSelect：SQL Select 語法
         //********************************************************************
         //還沒做過 CreateSQL
            da = CreateSQL();
            if (objTrans == null)
                objTrans = da.CreateDbTransaction();
            //執行 Insert、Update、Delete
            da.ExecuteNonQuery(strNonSelect, objTrans);
            //回傳 DbTransaction
            return objTrans;

        }

        public void SQLNonSelect(ref DataAccess da, string strNonSelect)
        {//********************************************************************
         //執行 SQL Server 非 Select 動作
         //傳入值：
         //.......da：已做過 SQL Create 後的 DataAccess
         //.......strNonSelect：SQL Select 語法
         //********************************************************************
         //還沒做過 CreateSQL
            if (da.ConnectionString == null)
                da = CreateSQL();
            //執行 Insert、Update、Delete
            da.ExecuteNonQuery(strNonSelect);
        }

        public void SQLNonSelect(string strNonSelect)
        {//********************************************************************
         //執行 SQL Server 非 Select 動作
         //傳入值：
         //.......strNonSelect：SQL Select 語法
         //********************************************************************
            //還沒做過 CreateSQL
            da = CreateSQL();
            //執行 Insert、Update、Delete
            da.ExecuteNonQuery(strNonSelect);
        }
        public string FindFT(string FT001, string FT002)
        {//查詢 類別 代號及名稱
            //參數
            string strSQL, backFT = "";
            DataTable dt = new DataTable();

            //還沒做過 CreateSQL
            da = CreateSQL();

            if (FT001 != "")
            {
                strSQL = "";
                strSQL += "Select FT002 From FACTORYS Where FT001 = '" + FT001 + "'";
                dt = SQLSelect(ref da, strSQL);
                FT002 = dt.Rows[0]["FT002"].ToString().Trim();
                backFT = FT002;
            }
            else if (FT002 != "")
            {
                strSQL = "";
                strSQL += "Select FT001 From FACTORYS Where FT002 = '" + FT002 + "'";
                dt = SQLSelect(ref da, strSQL);
                FT001 = dt.Rows[0]["FT001"].ToString().Trim();
                backFT = FT001;
            }

            return backFT;
        }
        public string FindCG(string CG001, string CG002)
        {//查詢 類別 代號及名稱
            //參數
            string strSQL, backCG = "";
            DataTable dt = new DataTable();

            //還沒做過 CreateSQL
            da = CreateSQL();

            if (CG001 != "")
            {
                strSQL = "";
                strSQL += "Select CG002 From CATEGORYS Where CG001 = '" + CG001 + "'";
                dt = SQLSelect(ref da, strSQL);
                CG002 = dt.Rows[0]["CG002"].ToString().Trim();
                backCG = CG002;
            }
            else if(CG002 != "")
            {
                strSQL = "";
                strSQL += "Select CG001 From CATEGORYS Where CG002 = '" + CG002 + "'";
                dt = SQLSelect(ref da, strSQL);
                CG001 = dt.Rows[0]["CG001"].ToString().Trim();
                backCG = CG001;
            }

            return backCG;
        }

        public string FindMN(string MN001, string MN002)
        {//查詢 機械 代號及名稱
            //參數
            string strSQL, backMN = "";
            DataTable dt = new DataTable();

            //還沒做過 CreateSQL
            da = CreateSQL();

            if (MN001 != "")
            {
                strSQL = "";
                strSQL += "Select MN002 From MECHNUMBERS Where MN001 = '" + MN001 + "'";
                dt = SQLSelect(ref da, strSQL);
                MN002 = dt.Rows[0]["MN002"].ToString().Trim();
                backMN = MN002;
            }
            else if (MN002 != "")
            {
                strSQL = "";
                strSQL += "Select MN001 From MECHNUMBERS Where MN002 = '" + MN002 + "'";
                dt = SQLSelect(ref da, strSQL);
                MN001 = dt.Rows[0]["CG001"].ToString().Trim();
                backMN = MN001;
            }

            return backMN;
        }

        public DataTable PCToPDA_MA(ref DataAccess da)
        {
            string strSQL;
            DataTable dt = new DataTable();

            strSQL = "Select a.VMH002 as MH002,b.FT002 as MH003,a.VMH003 as MH004,c.CG002 as MH005,a.VMH004 as MH006,d.MN002 as MH007,e.VMB003 as MB003,e.VMB004 as MB004,e.VMB005 as MB005,e.VMB006 as MB006,e.VMB007 as MB007,e.VMB008 as MB008,e.VMB009 as MB009,e.VMB015 as MB010 ";
            strSQL += "From VACUUM_HEADS a,FACTORYS b,CATEGORYS c,MECHNUMBERS d,VACUUM_BODYS e ";
            strSQL += "Where a.VMH002 = b.FT001 ";
            strSQL += "And a.VMH003 = c.CG001 ";
            strSQL += "And a.VMH004 = d.MN001 And b.FT001 = d.MN003 And c.CG001 = d.MN004 ";
            strSQL += "And a.VMH001 = e.VMB001 ";
            strSQL += "And a.VMH011 = 'Y' ";
            strSQL += "UNION ALL ";
            strSQL += "Select a.CAH002 as MH002,b.FT002 as MH003,a.CAH003 as MH004,c.CG002 as MH005,a.CAH004 as MH006,d.MN002 as MH007,e.CAB003 as MB003,e.CAB004 as MB004,e.CAB005 as MB005,e.CAB006 as MB006,e.CAB007 as MB007,e.CAB008 as MB008,e.CAB009 as MB009,e.CAB015 as MB010  ";
            strSQL += "From COMPRESSEDAIR_HEADS a,FACTORYS b,CATEGORYS c,MECHNUMBERS d,COMPRESSEDAIR_BODYS e ";
            strSQL += "Where a.CAH002 = b.FT001 ";
            strSQL += "And a.CAH003 = c.CG001 ";
            strSQL += "And a.CAH004 = d.MN001 And b.FT001 = d.MN003 And c.CG001 = d.MN004 ";
            strSQL += "And a.CAH001 = e.CAB001 ";
            strSQL += "And a.CAH011 = 'Y' ";
            strSQL += "UNION ALL ";
            strSQL += "Select a.COH002 as MH002,b.FT002 as MH003,a.COH003 as MH004,c.CG002 as MH005,a.COH004 as MH006,d.MN002 as MH007,e.COB003 as MB003,e.COB004 as MB004,e.COB005 as MB005,e.COB006 as MB006,e.COB007 as MB007,e.COB008 as MB008,e.COB009 as MB009,e.COB015 as MB010 ";
            strSQL += "From COLDAIR_HEADS a,FACTORYS b,CATEGORYS c,MECHNUMBERS d,COLDAIR_BODYS e ";
            strSQL += "Where a.COH002 = b.FT001 ";
            strSQL += "And a.COH003 = c.CG001 ";
            strSQL += "And a.COH004 = d.MN001 And b.FT001 = d.MN003 And c.CG001 = d.MN004 ";
            strSQL += "And a.COH001 = e.COB001 ";
            strSQL += "And a.COH011 = 'Y' ";
            strSQL += "UNION ALL ";
            strSQL += "Select a.WEH002 as MH002,b.FT002 as MH003,a.WEH003 as MH004,c.CG002 as MH005,d.WEB003 as MH006,d.WEB004 as MH007,d.WEB003 as MB003,d.WEB004 as MB004,d.WEB005 as MB005,d.WEB006 as MB006,d.WEB007 as MB007,d.WEB008 as MB008,d.WEB009 as MB009,d.WEB015 as MB010 ";
            strSQL += "From WATERELC_HEADS a,FACTORYS b,CATEGORYS c,WATERELC_BODYS d ";
            strSQL += "Where a.WEH002 = b.FT001 ";
            strSQL += "And a.WEH003 = c.CG001 ";
            strSQL += "And a.WEH001 = d.WEB001 ";
            strSQL += "And a.WEH009 = 'Y' ";
            strSQL += "Order by MH004,MH002,MH006,MB003";

            dt = SQLSelect(ref da, strSQL);

            return dt;
        }

        public DataTable PCToPDA_US(ref DataAccess da)
        {
            string strSQL;
            DataTable dt = new DataTable();

            strSQL = "Select a.UR001 as US001,a.UR002 as US002,a.UR003 as US003,a.UR004 as US004,b.RL002 as US005,a.UR010 as US006,a.UR011 as US007,a.UR012 as US008 ";
            strSQL += "From USERS a, ROLES b ";
            strSQL += "Where a.UR004 = b.RL001 ";

            dt = SQLSelect(ref da, strSQL);

            return dt;
        }
    }
}
