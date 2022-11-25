using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2214201
{
    class DealRecord
    {//專用來處理記錄檔那四份資料表
        //公用參數

        public string DGVShowSQL(string RecordName, int iRec, string[] arrDeal, string KeyValue, string PutINorOut)
        {//********************************************************************
         //專用來組顯示各記錄檔 DataGridView SQL 語法
         //輸入值：RecordName --> 記錄檔名稱 ex: Vacuum or Compress ....
         //........iRec --> 各記錄檔要組的第幾種型態
         //........arrDeal --> 記錄 DataGridViewTo 內的記錄序號
         //........KeyValue --> 記錄目前 DataGridViewTo 選定的值
         //........PutINorOut --> DataGridViewTo 是 PutIN or PutOut
         //********************************************************************
         //參數
            string strSQL, tCK001;

            if(RecordName == "Vacuum")
            {
                strSQL = "";
                strSQL += "Select CK001 as '項目代號 ',";
                strSQL += "CK002 as '項目名稱',";
                strSQL += "CK006 as '備註1',";
                strSQL += "CK007 as '備註2',";
                strSQL += "(CK003 + CK004 + CK005) as '參考值' ";
                strSQL += "From CHECKITEMS ";
                strSQL += "Where CK016 = 'A' ";
                
                if (iRec == 2)
                {
                    //將項目代號放入陣列
                    if (PutINorOut == "IN")
                        arrDeal = arrPutIn(arrDeal, KeyValue);
                    else if (PutINorOut == "OUT")
                        arrDeal = arrPutOut(arrDeal, KeyValue);
                    //將陣列串成一串文字
                    tCK001 = arrTostr(arrDeal);
                    //查詢
                    strSQL += "And CK001 in (" + tCK001 + ") ";
                }
                
                strSQL += "Order by CK001 ";
            }
        }

        public string[] arrPutIn(string[] arrDeal, string dataIn)
        {
            //確定哪個 arrDeal 位置是空白，就填進去。
            //....記錄整個陣列大小
            int arrNo = arrDeal.Length;
            //....找到哪個位置是空白
            for (int i = 0; i < arrNo; i++)
            {
                if (arrDeal[i] == dataIn)
                    break;
                else if (arrDeal[i] == null)
                {
                    arrDeal[i] = dataIn;
                    break;
                }
            }

            return arrDeal;
        }

        public string[] arrPutOut(string[] arrDeal, string dataOut)
        {
            //參數
            int i, j = 0, arrNo;

            //確定哪個 arrCGA 位置是要查的值，就填移出去。
            //....記錄整個陣列大小
            arrNo = arrDeal.Length;
            //設定暫存陣列
            string[] arrTmp = new string[arrNo];
            //清空 arrTmp
            for (i = 0; i < arrNo; i++)
                arrTmp[i] = null;
            //....找到哪個位置是空白
            for (i = 0; i < arrNo; i++)
            {
                if (arrDeal[i] != null && arrDeal[i] != dataOut)
                {
                    arrTmp[j] = arrDeal[i];
                    j++;
                }
                else if (arrDeal[i] == null)
                    break;
            }

            for (i = 0; i < arrNo; i++)
                arrDeal[i] = arrTmp[i];

            return arrDeal;
        }

        public string arrTostr(string[] arrDeal)
        {
            //參數
            int i, arrNo;
            string backDT = "";

            //串陣列值成一串字串
            //....陣列大小
            arrNo = arrDeal.Length;
            //....
            for (i = 0; i < arrNo; i++)
            {
                if (arrDeal[i] != null && i == 0)
                    backDT += "'" + arrDeal[i] + "'";
                else if (arrDeal[i] != null && i != 0)
                    backDT += "," + "'" + arrDeal[i] + "'";
                else if (arrDeal[i] == null)
                    break;
            }

            return backDT;
        }
    }
}
