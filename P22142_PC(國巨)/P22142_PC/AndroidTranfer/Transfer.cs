using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RegalScan
{
    public class AndroidTransfer
    {
        #region 核心原始碼請勿變更

        //檢測Transfer.txt是否存在，存在才可進入傳輸
        public bool checkIsConnected()
        {
            try
            {
                ResultInfo resultInfo = adbPull("sdcard/Download/Transfer.txt", Directory.GetCurrentDirectory());
                if (resultInfo.resultCode == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }

        public ResultInfo adbPull(string padPath, string pcPath)
        {
            if (pcPath != "" && !Directory.Exists(pcPath))
            {
                Directory.CreateDirectory(@pcPath);   //新增資料夾
            }
            string result = adbCommand("adb pull \"" + padPath + "\" " + pcPath);
            return parseMessage(result);
        }

        public ResultInfo adbPush(string pcPath, string padPath)
        {
            try
            {
                if (!File.Exists(pcPath))
                {
                    return new ResultInfo { resultCode = -1, resultMessage = "匯入失敗 " + pcPath + " 檔案不存在 !" };
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            string result = adbCommand("adb push \"" + pcPath + "\" " + padPath);
            return parseMessage(result);
        }

        public ResultInfo adbInstall(string apkPtah)
        {
            try
            {
                if (!File.Exists(apkPtah))
                {
                    return new ResultInfo { resultCode = -1, resultMessage = "匯入失敗 " + apkPtah + " 檔案不存在 !" };
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            string result = adbCommand("adb install -r " + apkPtah);
            return parseMessage(result);
        }

        //解析回傳資訊
        public ResultInfo parseMessage(string result)
        {
            if (result.Contains("pulled,"))
            {
                return new ResultInfo { resultCode = 0, resultMessage = "匯出成功 !" };
            }
            else if (result.Contains("pushed,"))
            {
                return new ResultInfo { resultCode = 0, resultMessage = "匯入成功 !" };
            }
            else if (result.Contains("Success"))
            {
                return new ResultInfo { resultCode = 0, resultMessage = "APK 安裝成功 !" };
            }
            else
            {
                string errorMessage = "傳輸失敗 ! ";
                string[] strSplit = result.Split('\n');
                for (int i = 0; i < strSplit.Length; i++)
                {
                    if (strSplit[i].Contains("error:"))
                    {
                        if (strSplit[i].Contains("no devices/emulators found"))
                        {
                            errorMessage = errorMessage + "PDA設備尚未連接，請接上USB傳輸線並進入傳輸模式";
                        }
                        else if (strSplit[i].Contains("more than one device/emulator"))
                        {
                            errorMessage = errorMessage + "偵測到多台設備同時連接，請保持一台設備連接";
                        }
                        else
                        {
                            errorMessage = errorMessage + strSplit[i];
                            return new ResultInfo { resultCode = -1, resultMessage = errorMessage };
                        }
                        break;
                    }
                    else if (strSplit[i].Contains("failed to install"))
                    {
                        errorMessage = "APK 安裝失敗";
                        break;
                    }
                }
                return new ResultInfo { resultCode = -1, resultMessage = errorMessage };
            }
        }

        public string adbCommand(string command)
        {
            string str = "";
            try
            {
                Process p = new Process();

                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.Start();
                p.StandardInput.WriteLine("cd platform-tools/");
                p.StandardInput.WriteLine(command);
                Thread.Sleep(500);
                p.StandardInput.WriteLine("exit");

                str = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();

                Console.WriteLine(str);
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return str;
        }

        public void scanSDCARD()
        {
            try
            {
                ProcessStartInfo Info2 = new ProcessStartInfo();
                Info2.FileName = "RescanSD.bat";//執行的檔案名稱
                Info2.WorkingDirectory = Directory.GetCurrentDirectory();//檔案所在的目錄
                Process.Start(Info2);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void scanSDCARD_A()
        {
            try
            {
                ProcessStartInfo Info2 = new ProcessStartInfo();
                Info2.FileName = "RescanSD_A.bat";//執行的檔案名稱
                Info2.WorkingDirectory = Directory.GetCurrentDirectory();//檔案所在的目錄
                Process.Start(Info2);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void scanSDCARD_B()
        {
            try
            {
                ProcessStartInfo Info2 = new ProcessStartInfo();
                Info2.FileName = "RescanSD_B.bat";//執行的檔案名稱
                Info2.WorkingDirectory = Directory.GetCurrentDirectory();//檔案所在的目錄
                Process.Start(Info2);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public class ResultInfo
        {
            public int resultCode { get; set; }

            public string resultMessage { get; set; }
        }
        #endregion
    }
}