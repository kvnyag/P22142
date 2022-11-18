using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace Tool
{
    class DB_Data_Transfer
    {
        public string DB_Data_Transfer_Example(string ApplicationPath)
        {
            //參數集中
            int i;
            string pda_strSQL, pc_strSQL, strError;

            try
            {
                //開啟 P22111001_PDA 資料庫
                REGAL.Data.DataAccess.SQLite.DataAccess pda_SQLite = new REGAL.Data.DataAccess.SQLite.DataAccess();
                string pda_DBPath = "Data Source=" + ApplicationPath + "\\" + "P22111001_PDA.db3";
                pda_SQLite.ConnectionString = pda_DBPath;
                DataTable pda_dt = new DataTable();

                //開啟 P22111001_PC 資料庫
                REGAL.Data.DataAccess.SQLite.DataAccess pc_SQLite = new REGAL.Data.DataAccess.SQLite.DataAccess();
                string pc_DBPath = "Data Source=" + ApplicationPath + "\\" + "P22111001_PC.db3";
                pc_SQLite.ConnectionString = pc_DBPath;
                DataTable pc_dt = new DataTable();

                //處理PDA資料庫(RGReceipt_Basket)
                //....取出PDA資料
                pda_strSQL = "Select * From RGReceipt_Basket";
                pda_dt = pda_SQLite.ExecuteDataTable(pda_strSQL);
                for (i = 0; i < pda_dt.Rows.Count; i++)
                {
                    //逐筆寫回PC端
                    //....確認該筆是否已存在PC端
                    pc_strSQL = "";
                    pc_strSQL += "Select Count(*) as No From RGReceipt_Basket Where RG_Basket_LotID = '" + pda_dt.Rows[i]["RG_Basket_LotID"] + "'";
                    pc_dt = pc_SQLite.ExecuteDataTable(pc_strSQL);
                    //....如果該筆不存在
                    if (pc_dt.Rows[0]["No"].ToString() == "0")
                    {
                        //....組合Insert into語句
                        pc_strSQL = CombineInsert(pda_dt, i, "RGReceipt_Basket");
                        //....將PDA資料填入PC資料庫中
                        pc_SQLite.ExecuteDataSet(pc_strSQL);
                    }
                }
                
                return "OK";
            }
            catch(Exception ex)
            {
                strError = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").Replace("-", "/");
                strError += " ==> DB3內容寫入SQL Server失敗，Try Catch訊息:" + ex.Message;
                MessageBox.Show(strError, "PDA內容上傳");

                return strError;
            }
        }

        public string CombineInsert(DataTable dt, int RowsNo, string TableName)
        {//用以組合SQL語法，專用於兩個相同Table的資料庫間資料互傳
            //參數集中
            int arrLeng = 0, i;
            string str_Return;
            string[] arrFieldName;
            DataColumn dc = new DataColumn();
            //取得欄位名稱
            //....共有多少欄位
            arrLeng = dt.Columns.Count;
            //....建暫存欄位名稱的Array
            arrFieldName = new string[arrLeng];
            for (i = 0; i < arrLeng; i++)
            {
                dc = dt.Columns[i];
                //....填入欄位名稱
                arrFieldName[i] = dc.ColumnName.ToString();
            }
            //組Insert into語句
            str_Return = "";
            str_Return = "Insert into " + TableName + " (";
            for (i = 0; i < arrLeng; i++)
            {
                if (i == arrLeng - 1)
                    str_Return += arrFieldName[i] + ") ";
                else
                    str_Return += arrFieldName[i] + ",";
            }
            str_Return += "Values (";
            //取出 Rows 值填入 Insert into 語句
            for (i = 0; i < arrLeng; i++)
            {
                if (i == arrLeng - 1)
                    str_Return += "'" + dt.Rows[RowsNo][arrFieldName[i]] + "')";
                else
                    str_Return += "'" + dt.Rows[RowsNo][arrFieldName[i]] + "',";
            }

            return str_Return;
        }
    }
}
