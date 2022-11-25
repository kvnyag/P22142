﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REGAL.Data.DataAccess;
using System.Data.Common;
using System.Data;

namespace P2214201
{
    class UseSQLServer
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

        public string FindCG(string CG001, string CG002)
        {//查詢 類別 代號及名稱
            //參數
            string strSQL, backCG = "";
            DataTable dt = new DataTable();

            if(CG001 != "")
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
    }
}
