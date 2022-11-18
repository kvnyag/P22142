using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTranferTool
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //匯入檔案類型
            txtFileType.Text = ConfigurationManager.AppSettings["inputFileType"];

            //匯出資料庫名稱
            string DBName = ConfigurationManager.AppSettings["outputDBName"];
            if (DBName != "" && DBName.Contains("."))
            {
                txtDBName.Text = DBName.Split('.')[0];
                cmbDBType.Text = DBName.Split('.')[1];
            }

            //匯出資料夾位置
            string OutputFolder = ConfigurationManager.AppSettings["outputPath"];
            if (OutputFolder != "")
            {
                txtOutputFolder.Text = OutputFolder;
                folderBrowserDialog1.SelectedPath = OutputFolder;
            }

            //啟用匯入轉檔程式
            ckbInput.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertInput"]);
            if(ckbInput.Checked)
                txtInputConvert.Text = ConfigurationManager.AppSettings["convertInputPath"];
            btnSelInput.Enabled = ckbInput.Checked;

            //啟用匯出轉檔程式
            ckbOutput.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertOutput"]);
            if(ckbOutput.Checked)
               txtOutputConvert.Text = ConfigurationManager.AppSettings["convertOutputPath"];
            btnSelOutput.Enabled = ckbOutput.Checked;
        }

        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowDialog();
            txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSelInput_Click(object sender, EventArgs e)
        {
            if (txtInputConvert.Text != "")
                openFileDialog1.InitialDirectory = txtInputConvert.Text.Substring(0, txtInputConvert.Text.LastIndexOf("\\") + 1);
            else
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            openFileDialog1.Filter = "應用程式(*.exe)|*.exe";
            openFileDialog1.FileName = txtInputConvert.Text.Substring(txtInputConvert.Text.LastIndexOf("\\") + 1);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtInputConvert.Text = openFileDialog1.FileName;
        }

        private void btnSelOutput_Click(object sender, EventArgs e)
        {
            if (txtOutputConvert.Text != "")
                openFileDialog1.InitialDirectory = txtOutputConvert.Text.Substring(0, txtOutputConvert.Text.LastIndexOf("\\") + 1);
            else
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            openFileDialog1.Filter = "應用程式(*.exe)|*.exe";
            openFileDialog1.FileName = txtOutputConvert.Text.Substring(txtOutputConvert.Text.LastIndexOf("\\") + 1);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtOutputConvert.Text = openFileDialog1.FileName;
        }

        private void ckbInput_CheckedChanged(object sender, EventArgs e)
        {
            btnSelInput.Enabled = ckbInput.Checked;
        }

        private void ckbOutput_CheckedChanged(object sender, EventArgs e)
        {
            btnSelOutput.Enabled = ckbOutput.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + "\\" + Application.ProductName + ".exe");
            config.AppSettings.Settings["inputFileType"].Value = txtFileType.Text;
            config.AppSettings.Settings["outputDBName"].Value = txtDBName.Text + "." + cmbDBType.Text;
            config.AppSettings.Settings["outputPath"].Value = txtOutputFolder.Text;
            config.AppSettings.Settings["enableConvertInput"].Value = ckbInput.Checked.ToString();
            config.AppSettings.Settings["convertInputPath"].Value = txtInputConvert.Text;
            config.AppSettings.Settings["enableConvertOutput"].Value = ckbOutput.Checked.ToString();
            config.AppSettings.Settings["convertOutputPath"].Value = txtOutputConvert.Text;
            config.Save();
            MessageBox.Show("儲存成功!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ConfigurationManager.RefreshSection("appSettings");
            DialogResult = DialogResult.OK;
        }
    }
}
