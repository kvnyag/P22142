using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tool
{
    internal class OpenXML
    {
        public static void ReadXML()
        {//讀取XML檔
            //參數集中
            bool isCanSelect = false;
            string xmlPath, PrintName;
            XmlDocument doc;
            XmlNode node;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出XML檔
                //....範例1
                node = doc.SelectSingleNode("/settings/DataBase/PrintName");
                PrintName = node.InnerText;
                //....範例2
                node = doc.SelectSingleNode("/settings/DataBase/Car_Type_CanSelect");
                if (node.InnerText == "False")
                    isCanSelect = false;
                else
                    isCanSelect = true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
            }
        }

        public static void WriteXML()
        {//寫入XML檔
            //參數集中
            bool isCanSelect = false;
            string xmlPath, PrintName = "Printer No 1";
            XmlDocument doc;
            XmlNode node;

            try
            {
                //取得XML檔位置
                xmlPath = System.Windows.Forms.Application.StartupPath + "\\Config.xml";
                //開啟檔案塞入文件儲存器(doc)中
                doc = new XmlDocument();
                doc.Load(xmlPath);
                //取出XML檔
                //....範例1
                node = doc.SelectSingleNode("/settings/DataBase/PrintName");
                node.InnerText = PrintName;
                //....範例2
                node = doc.SelectSingleNode("/settings/DataBase/Car_Type_CanSelect");
                node.InnerText = isCanSelect.ToString();
                //寫入XML檔
                doc.Save(xmlPath);

                MessageBox.Show("設定存檔成功!!", "設置資訊");
            }
            catch(Exception Ex)
            {
                MessageBox.Show("讀取XML檔發生不可預期錯誤：\r\n" + Ex.Message, "讀取XML檔");
            }
        }
    }
}
