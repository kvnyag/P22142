using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace P2214201
{
    public partial class UseXML
    {//所有使用 XML 的事都呼叫這個類別
        //公用變數
        string xmlPath;
        XmlDocument doc;
        XmlNode node;

        public string ReadXML(string DataPath)
        {//********************************************************************
         //輸入XML欲查詢欄位的儲存值後，回傳XML所記錄的值。
         //....傳入值：
         //...........DataPath：要查詢的值的路徑
         //********************************************************************
            //參數
            string strBack;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出記錄的值
                node = doc.SelectSingleNode(DataPath);
                strBack = node.InnerText;
                //回傳
                return strBack;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
                return "False";
            }
        }

        public string[] ReadXML(string[] arrDataPath)
        {//********************************************************************
         //輸入XML欲查詢欄位的儲存值後，回傳XML所記錄的值。
         //....傳入值：
         //...........arrDataPath：要查詢的值的路徑的集合
         //********************************************************************
         //參數
            int i, arrNo;
            string[] arrBack;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出記錄的值
                arrNo = arrDataPath.Length;
                arrBack = new string[arrNo];
                for (i = 0; i < arrNo; i++)
                {
                    node = doc.SelectSingleNode(arrDataPath[i]);
                    arrBack[i] = node.InnerText;
                }
                //回傳
                return arrBack;
            }
            catch (Exception Ex)
            {
                string[] arrError = new string[] {"False"};
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
                return arrError;
            }
        }
        
        public string[] ReadAllXML(string[] arrDataPath)
        {//********************************************************************
         //輸入XML欲查詢欄位的儲存值後，回傳XML所記錄的值。
         //....傳入值：
         //...........arrDataPath：要查詢的值的路徑的集合
         //********************************************************************
         //參數
            int i, arrNo;
            string[] arrBack;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出記錄的值
                arrNo = arrDataPath.Length;
                arrBack = new string[arrNo];
                for (i = 0; i < arrNo; i++)
                {
                    node = doc.SelectSingleNode(arrDataPath[i]);
                    arrBack[i] = node.InnerText;
                }
                //回傳
                return arrBack;
            }
            catch (Exception Ex)
            {
                string[] arrError = new string[] { "False" };
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
                return arrError;
            }
        }

        public void WriteXML(string DataPath, string StoreValue)
        {//********************************************************************
         //輸入XML欲查詢欄位的儲存值後，儲存。
         //....傳入值：
         //...........DataPath：要查詢的值的路徑
         //...........StoreValue：要儲存的值
         //********************************************************************
            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出記錄的值
                node = doc.SelectSingleNode(DataPath);
                node.InnerText = StoreValue;
                //寫入XML檔
                doc.Save(xmlPath);

                MessageBox.Show("設定存檔成功!!", "設置資訊");
            }
            catch(Exception Ex)
            {
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
            }
        }

        public void WriteAllXML(string[] arrDataPath, string[] arrStoreValue)
        {//********************************************************************
         //輸入XML欲查詢欄位的儲存值後，儲存。
         //....傳入值：
         //...........arrDataPath：要查詢的值的路徑
         //...........arrStoreValue：要儲存的值
         //********************************************************************
            //參數
            int i, arrNo;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出記錄的值
                arrNo = arrDataPath.Length;
                for(i = 0; i < arrNo; i++)
                {
                    node = doc.SelectSingleNode(arrDataPath[i]);
                    node.InnerText = arrStoreValue[i];
                }
                //寫入XML檔
                doc.Save(xmlPath);

                MessageBox.Show("設定存檔成功!!", "設置資訊");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
            }
        }
    }
}
