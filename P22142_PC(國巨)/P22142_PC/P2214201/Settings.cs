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
        //公用變數
        string SQLServer, Report;
        string[] arrSettingPath, arrSettingValue;

        public Settings()
        {
            InitializeComponent();
            ReadSetting(); //讀取 XML 檔把所有值寫入設定檔中
        }

        private void ReadSetting()
        {
            //記錄Setting所有記錄值位置
            SQLServer = "/settings/SQLServer/";
            Report = "/settings/Report/";
            arrSettingPath = new string[]
            {
                SQLServer + "IP",
                SQLServer + "DBName",
                SQLServer + "UserID",
                SQLServer + "Password",
                Report + "ReportAdr",
                Report + "VacuumName",
                Report + "CompressName",
                Report + "AirConditionName",
                Report + "HydropowerName"
            };
            //取回所有 Setting 各記錄值
            UseXML UXML = new UseXML();
            arrSettingValue = UXML.ReadAllXML(arrSettingPath);
            //填入對應欄位
            tbxSQLServerIP.Text = arrSettingValue[0];
            tbxSQLDBName.Text = arrSettingValue[1];
            tbxSQLUserID.Text = arrSettingValue[2];
            tbxSQLPassword.Text = arrSettingValue[3];
            tbxReportAdr.Text = arrSettingValue[4];
            tbxVacuum.Text = arrSettingValue[5];
            tbxCompress.Text = arrSettingValue[6];
            tbxAirCondition.Text = arrSettingValue[7];
            tbxHydropower.Text = arrSettingValue[8];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //記錄Setting所有記錄值位置
            SQLServer = "/settings/SQLServer/";
            Report = "/settings/Report/";
            arrSettingPath = new string[] 
            {
                SQLServer + "IP",
                SQLServer + "DBName",
                SQLServer + "UserID",
                SQLServer + "Password",
                Report + "ReportAdr",
                Report + "VacuumName",
                Report + "CompressName",
                Report + "AirConditionName",
                Report + "HydropowerName"
            };
            //記錄所有要寫入Setting內的值
            arrSettingValue = new string[]
            {
                tbxSQLServerIP.Text.Trim(),
                tbxSQLDBName.Text.Trim(),
                tbxSQLUserID.Text.Trim(),
                tbxSQLPassword.Text.Trim(),
                tbxReportAdr.Text.Trim(),
                tbxVacuum.Text.Trim(),
                tbxCompress.Text.Trim(),
                tbxAirCondition.Text.Trim(),
                tbxHydropower.Text.Trim()
            };
            //完整寫入XML檔中
            UseXML UXML = new UseXML();
            UXML.WriteAllXML(arrSettingPath, arrSettingValue);
            //關閉視窗
            DialogResult = DialogResult.OK;
        }
    }
}
