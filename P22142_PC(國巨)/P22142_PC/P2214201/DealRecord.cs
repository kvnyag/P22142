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

        public string DGVShowSQL(string RecordName, int iRec, string[] arrDeal, string KeyValue, string INorNot)
        {//********************************************************************
         //專用來組顯示各記錄檔 DataGridView SQL 語法
         //輸入值：RecordName --> 記錄檔名稱 ex: Vacuum or Compress ....
         //........iRec --> 各記錄檔要組的第幾種型態
         //........arrDeal --> 記錄 DataGridViewTo 內的記錄序號
         //........KeyValue --> 記錄檔表頭編號
         //********************************************************************
         //參數
            string strSQL = "", tCK001;

            if(RecordName == "Vacuum_CHECKITEMS" || RecordName == "Compress_CHECKITEMS")
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
                    tCK001 = arrTostr(arrDeal);
                    //查詢
                    if (INorNot == "IN")
                    {
                        if (tCK001 != "")
                            strSQL += "And CK001 in (" + tCK001 + ") ";
                        else
                            strSQL += "And CK001 = '" + tCK001 + "' ";
                    }
                    else
                    {
                        if (tCK001 != "")
                            strSQL += "And CK001 not in (" + tCK001 + ") ";
                        else
                            strSQL += "";
                    }
                }         
                strSQL += "Order by CK001 ";
            }
            else if(RecordName == "Vacuum_VACUUM_BODYS")
            {
                strSQL = "";
                strSQL += "Select VMB003 as '項目代號 ',";
                strSQL += "VMB004 as '項目名稱',";
                strSQL += "VMB008 as '備註1',";
                strSQL += "VMB009 as '備註2',";
                strSQL += "(VMB005 + VMB006 + VMB007) as '參考值',";
                strSQL += "VMB015 as '是否作廢' ";
                strSQL += "From VACUUM_BODYS ";
                strSQL += "Where VMB001 = '" + KeyValue + "' ";
                //strSQL += "And VMB015 = 'N' ";
            }
            else if(RecordName == "Compress_COMPRESSEDAIR_BODYS")
            {
                strSQL = "";
                strSQL += "Select CAB003 as '項目代號 ',";
                strSQL += "CAB004 as '項目名稱',";
                strSQL += "CAB008 as '備註1',";
                strSQL += "CAB009 as '備註2',";
                strSQL += "(CAB005 + CAB006 + CAB007) as '參考值',";
                strSQL += "CAB015 as '是否作廢' ";
                strSQL += "From COMPRESS_BODYS ";
                strSQL += "Where CAB001 = '" + KeyValue + "' ";
                //strSQL += "And CAB015 = 'N' ";
            }

            return strSQL;
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
