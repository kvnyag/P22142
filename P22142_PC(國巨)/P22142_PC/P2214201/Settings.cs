using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2214201
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            ReadSetting(); //讀取 XML 檔把所有值寫入設定檔中
        }

        private void ReadSetting()
        {
            //參數
            string SQLServer;
            string[] arrSettingPath, arrSettingValue;

            //記錄Setting所有記錄值位置
            SQLServer = "/settings/SQLServer/";
            arrSettingPath = new string[]
            {
                SQLServer + "IP",
                SQLServer + "DBName",
                SQLServer + "UserID",
                SQLServer + "Password"
            };
            //取回所有 Setting 各記錄值
            UseXML UXML = new UseXML();
            arrSettingValue = UXML.ReadAllXML(arrSettingPath);
            //填入對應欄位
            tbxSQLServerIP.Text = arrSettingValue[0];
            tbxSQLDBName.Text = arrSettingValue[1];
            tbxSQLUserID.Text = arrSettingValue[2];
            tbxSQLPassword.Text = arrSettingValue[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //參數
            string SQLServer;
            string[] arrSettingPath, arrSettingValue;

            //記錄Setting所有記錄值位置
            SQLServer = "/settings/SQLServer/";
            arrSettingPath = new string[] 
            {
                SQLServer + "IP",
                SQLServer + "DBName",
                SQLServer + "UserID",
                SQLServer + "Password"
            };
            //記錄所有要寫入Setting內的值
            arrSettingValue = new string[]
            {
                tbxSQLServerIP.Text.Trim(),
                tbxSQLDBName.Text.Trim(),
                tbxSQLUserID.Text.Trim(),
                tbxSQLPassword.Text.Trim()
            };
            //完整寫入XML檔中
            UseXML UXML = new UseXML();
            UXML.WriteAllXML(arrSettingPath, arrSettingValue);
            //關閉視窗
            DialogResult = DialogResult.OK;
        }
    }
}
