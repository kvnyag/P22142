using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static RegalScan.AndroidTransfer;

namespace AndroidTranferTool
{
    public partial class Main : Form
    {
        bool connectionResult = false;
        RegalScan.AndroidTransfer Transfer;
        string androidPlatformPath = "com.regalscan.platform";
        //string outputPath = ConfigurationManager.AppSettings["outputPath"];
        string outputPath = Application.StartupPath + "\\SQLDB";
        string convertInputPath = ConfigurationManager.AppSettings["convertInputPath"];
        string convertOutputPath = ConfigurationManager.AppSettings["convertOutputPath"];
        string PdaToPC = ConfigurationManager.AppSettings["PdatoPC"] + ConfigurationManager.AppSettings["outputDBName"];
        bool enableInConvert = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertInput"]);
        bool enableOutConvert = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertOutput"]);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Transfer = new RegalScan.AndroidTransfer();
                labelVersion.Text = this.GetType().Assembly.GetName().Version.ToString();
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "/platform-tools"))
                {
                    MessageBox.Show("核心檔案遺失(platform-tools)請洽系統管理員", "platform-tools 檔案遺失", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Close();
                }
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                if (!outputPath.EndsWith("\\"))
                    outputPath = outputPath + "\\";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        //連接檢查
        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Waitting waitting = new Waitting();
            waitting.Show();
            ThreadPool.QueueUserWorkItem(o =>
            {
                connectionResult = Transfer.checkIsConnected();
                BeginInvoke(new Action(() =>
                 {
                     waitting.Close();
                     this.Enabled = true;
                     this.BringToFront();
                     if (!connectionResult)
                     {
                         showConnectionFailedDialog();
                     }
                     else
                     {
                         pnlConnect.Visible = false;
                     }
                 }));
            });
        }

        //呼叫執行Console轉檔
        //converType 自定義 1:ExceltoDB3   2:DB3toExcel   .....
        private string RunConvertEXE(int converType, string args)
        {
            Process process = new Process();
            string convertConsolePath = "";
            string output = "";
            try
            {
                if (converType == 1)
                    convertConsolePath = convertInputPath;
                else
                    convertConsolePath = convertOutputPath;
                if (!File.Exists(convertConsolePath))
                {
                    return "轉檔程式不存在，請確認路徑是否正確\n" + convertConsolePath;
                }

                process.StartInfo.FileName = convertConsolePath;
                process.StartInfo.Arguments = converType + "^" + args; //傳遞參數
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;  //重定向輸出流 
                process.StartInfo.UseShellExecute = false;
                process.Start();
                output = process.StandardOutput.ReadToEnd();//獲取exe處理之後的輸出資訊到output
                if (output.Contains("@"))
                {
                    string[] data = output.Split('@');
                    if (data.Length == 2 && data[0].ToString().Equals("輸出路徑"))
                    {
                        return data[1].ToString().Replace(Environment.NewLine, "");
                    }
                }
            }
            catch (Exception ex)
            {
                output = ex.ToString();
            }
            finally
            {
                process.Close();
            }

            return output;
        }

        //手持裝置 -> 電腦
        private void btnPDAtoPC_Click(object sender, EventArgs e)
        {
            PDAToPC pp = new PDAToPC();
            pp.UsePDAToPC();

            btnPDAtoPC.Enabled = false;
            Waitting waitting = new Waitting();
            waitting.Show();
            
            this.Cursor = Cursors.WaitCursor;//漏斗指標
            ThreadPool.QueueUserWorkItem(o =>
            {
                connectionResult = Transfer.checkIsConnected();
                BeginInvoke(new Action(() =>
                {
                    if (!connectionResult)
                    {
                        this.Cursor = Cursors.Default;
                        showConnectionFailedDialog();
                    }
                    else
                    {
                        ResultInfo resultInfo = Transfer.adbPull(PdaToPC + "-journal", outputPath);
                        resultInfo = Transfer.adbPull(PdaToPC, outputPath);


                        if (resultInfo.resultCode == 0)
                        {
                            //if (enableOutConvert)
                            //{
                            //   outputPath = RunConvertEXE(2, outputPath + PdaToPC.Replace(@"sdcard/Download/", "")); //啟用轉檔
                            //    if (!outputPath.EndsWith("\\"))
                            //        outputPath = outputPath + "\\";
                            //}
                            this.Cursor = Cursors.Default;
                            if (!Directory.Exists(outputPath))
                            {
                                MessageBox.Show("轉檔失敗，請確認來源資料是否正確\n錯誤：" + outputPath, "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                return;
                            }

                            MessageBox.Show(resultInfo.resultMessage, "匯出成功", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Process.Start("EXPLORER", outputPath);
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(resultInfo.resultMessage, "匯出失敗", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }));
            });
        }

        //電腦 -> 手持裝置 
        private void btnPCtoPDA_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                connectionResult = Transfer.checkIsConnected();
                BeginInvoke(new Action(() =>
                {
                    if (!connectionResult)
                    {
                        showConnectionFailedDialog();
                    }
                    else
                    {
                        OpenFileDialog file = new OpenFileDialog();
                        //匯入檔案類型
                        string FileType = ConfigurationManager.AppSettings["inputFileType"];
                        if(FileType != "")
                        {
                            foreach(string type in FileType.Split(';'))
                            {
                                if (type.Trim() == "")
                                    continue;
                                switch (type)
                                {
                                    case "csv":
                                        if (file.Filter == "")
                                            file.Filter = "CSV文字檔(*.csv)|*.csv";
                                        else
                                            file.Filter += "|CSV文字檔(*.csv)|*.csv";
                                        break;
                                    case "txt":
                                        if (file.Filter == "")
                                            file.Filter = "文字檔(*.txt)|*.txt";
                                        else
                                            file.Filter += "|文字檔(*.txt)|*.txt";
                                        break;
                                    case "xls":
                                        if (file.Filter == "")
                                            file.Filter = "Excel 97-2003 活頁簿(*.xls)|*.xls";
                                        else
                                            file.Filter += "|Excel 97-2003 活頁簿(*.xls)|*.xls";
                                        break;
                                    case "xlsx":
                                        if (file.Filter == "")
                                            file.Filter = "Excel 活頁簿(*.xlsx)|*.xlsx";
                                        else
                                            file.Filter += "|Excel 活頁簿(*.xlsx)|*.xlsx";
                                        break;
                                    default:
                                        if (file.Filter == "")
                                            file.Filter = "SQLite 資料庫檔案(*." + type + ")|*." + type;
                                        else
                                            file.Filter += "|SQLite 資料庫檔案(*." + type + ")|*." + type;
                                        break;
                                }
                            }
                        }
                        ResultInfo resultInfo = new ResultInfo();
                        DialogResult result = file.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.Cursor = Cursors.WaitCursor;//漏斗指標
                            string convertedPath = file.FileName.ToString();
                            if (enableInConvert)
                            {
                                convertedPath = RunConvertEXE(1, convertedPath); //啟用轉檔
                            }

                            if (!File.Exists(convertedPath))
                            {
                                if (!Directory.Exists(convertedPath))
                                {
                                    this.Cursor = Cursors.Default;
                                    MessageBox.Show("轉檔失敗，請確認來源資料是否正確\n錯誤：" + convertedPath, "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    return;
                                }
                                else
                                {
                                    resultInfo = Transfer.adbPush(file.FileName.ToString(), "sdcard/Download/");
                                    Transfer.scanSDCARD();
                                }
                            }
                            else
                            {
                                resultInfo = Transfer.adbPush(convertedPath, "sdcard/Download/");
                                Transfer.scanSDCARD();
                            }
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(resultInfo.resultMessage, "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }

                        Transfer.adbCommand("adb shell rm -rf " + @"/sdcard/Download/Transfer.txt");
                        Transfer.scanSDCARD();

                    }
                }));
            });
        }

        //手持裝置LOG 匯出
        private void btnLogExport_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;//漏斗指標
            ThreadPool.QueueUserWorkItem(o =>
            {
                connectionResult = Transfer.checkIsConnected();
                BeginInvoke(new Action(() =>
                {
                    if (!connectionResult)
                    {
                        this.Cursor = Cursors.Default;
                        showConnectionFailedDialog();
                    }
                    else
                    {
                        ResultInfo resultInfo = Transfer.adbPull("sdcard/Download/Log/", outputPath + "Log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                        this.Cursor = Cursors.Default;
                        if (resultInfo.resultCode == 0)
                        {
                            MessageBox.Show(resultInfo.resultMessage, "匯出成功", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Process.Start("EXPLORER", outputPath);
                        }
                        else
                        {
                            MessageBox.Show(resultInfo.resultMessage, "匯出失敗", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }

                    Transfer.adbCommand("adb shell rm -rf " + @"/sdcard/Download/Transfer.txt");
                    Transfer.scanSDCARD();


                }));
            });
        }

        private void showConnectionFailedDialog()
        {
            MessageBox.Show("設備連線失敗：請確認PDA是否已進入傳輸模式 !", "設備連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        //插件更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //確認資料夾目錄是否存在
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Plugin"))
            {
                MessageBox.Show("請確認本機端Plugin存在狀態。\r=====================\r請確認路徑" + Application.StartupPath + "\r具有 Plugin路徑", "Confirm Message", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                return;
            }
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Platform"))
            {
                MessageBox.Show("請確認本機端Platform存在狀態。\r=====================\r請確認路徑" + Application.StartupPath + "\r具有 Platform路徑", "Confirm Message", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                return;
            }

            //取得目錄下全部文件
            List<string> FileList = new List<string>();
            string folderName = Application.StartupPath + @"\Plugin\";
            List<string> FileListPlatform = new List<string>();
            string folderNamePlatform = Application.StartupPath + @"\Platform\";

            foreach (string fname in Directory.GetFiles(folderName))
            {
                FileList.Add(fname.Trim());
            }
            foreach (string fname in Directory.GetFiles(folderNamePlatform))
            {
                FileListPlatform.Add(fname.Trim());
            }

            //確認更新
            if (FileList.Count == 0 && FileListPlatform.Count == 0)
            {
                MessageBox.Show("查無更新檔案，請確認是否放入資料夾內", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            string sMessageInfo = "預計更新檔案數量 (" + FileList.Count.ToString() + ")\r更新平台數量 (" + FileListPlatform.Count.ToString() + ") \r請確認是否更新?";
            if (MessageBox.Show(sMessageInfo, "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }

            ThreadPool.QueueUserWorkItem(o =>
            {
                connectionResult = Transfer.checkIsConnected();
                BeginInvoke(new Action(() =>
                {
                    if (!connectionResult)
                    {
                        showConnectionFailedDialog();
                    }
                    else
                    {

                        Waitting waitting = new Waitting();
                        this.Enabled = false;
                        waitting.Show();
                        Task.Factory.StartNew(() =>
                        {
                            //發送檔案
                            string message = "";
                            Transfer.adbCommand("adb shell rm -rf " + @"/sdcard/Download/apk/" + androidPlatformPath + "/*");
                            foreach (string file in FileList)
                            {
                                ResultInfo resultInfo = Transfer.adbPush(file.Trim(), @"/sdcard/Download/apk/" + file.Substring(file.LastIndexOf("\\") + 1));
                                if (resultInfo.resultCode == 0)
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..成功\n";
                                }
                                else
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..失敗\n";
                                }
                            }
                            foreach (string file in FileListPlatform)
                            {
                                ResultInfo resultInfo = Transfer.adbInstall(file.ToString());
                                if (resultInfo.resultCode == 0)
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..成功\n";
                                }
                                else
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..失敗\n";
                                }
                            }
                            foreach (string file in FileList)
                            {
                                ResultInfo resultInfo = Transfer.adbInstall(file.ToString());
                                if (resultInfo.resultCode == 0)
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..成功\n";
                                }
                                else
                                {
                                    message += Path.GetFileNameWithoutExtension(file.ToString()) + "..失敗\n";
                                }
                            }
                            Transfer.adbCommand("adb shell rm -rf " + @"/sdcard/Download/Transfer.txt");
                            Transfer.scanSDCARD();

                            waitting.BeginInvoke(new Action(() =>
                            {
                                waitting.Close();
                                this.Enabled = true;
                                this.BringToFront();
                                MessageBox.Show(message, "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }));
                        });
                    }
                }));
            });
        }
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Transfer.adbCommand("adb kill-server");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
            //20201222 補上更新主頁參數值
            outputPath = ConfigurationManager.AppSettings["outputPath"];
            if (!outputPath.EndsWith("\\"))
                outputPath = outputPath + "\\";
            convertInputPath = ConfigurationManager.AppSettings["convertInputPath"];
            convertOutputPath = ConfigurationManager.AppSettings["convertOutputPath"];
            PdaToPC = ConfigurationManager.AppSettings["PdatoPC"] + ConfigurationManager.AppSettings["outputDBName"];
            enableInConvert = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertInput"]);
            enableOutConvert = Convert.ToBoolean(ConfigurationManager.AppSettings["enableConvertOutput"]);
        }
    }
}
