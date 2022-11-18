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
    public partial class MainForm : Form
    {
        //公用變數
        public string UserAccount, UserRole;
        public static MainForm mfm;

        public MainForm()
        {
            InitializeComponent();
            trvSelectFn.ExpandAll();
        }

        private void trvSelectFn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if(e.Action == TreeViewAction.ByMouse)
            {
                if(e.Node.Name == "StaffInfo")
                {
                    MessageBox.Show("人員基本資料");
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    StaffInfo stInfo = new StaffInfo();
                    stInfo.MdiParent = this;                       //設置視窗的父子關係
                    stInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    stInfo.TopLevel = false;                       //必須關閉否則會衝突
                    stInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(stInfo);   //將子視窗放入 Panel2 中
                    stInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    stInfo.UserRole = this.UserRole;               //傳回人員權限
                    stInfo.Show();
                    stInfo.BringToFront();
                }
                else if (e.Node.Name == "FactoryInfo")
                {
                    MessageBox.Show("廠房基本資料");
                }
                else if (e.Node.Name == "ReportInfo")
                {
                    MessageBox.Show("類別基本資料");
                }
                else if (e.Node.Name == "MachineInfo")
                {
                    MessageBox.Show("單位機械編號資料");
                }
                else if (e.Node.Name == "CheckInfo")
                {
                    MessageBox.Show("檢查項目資料");
                }
                else if (e.Node.Name == "VacuumRep")
                {
                    MessageBox.Show("真空機運轉記錄表");
                }
                else if (e.Node.Name == "CompressRep")
                {
                    MessageBox.Show("空壓機運轉記錄表");
                }
                else if (e.Node.Name == "AirConditionRep")
                {
                    MessageBox.Show("冷氣運轉記錄表");
                }
                else if (e.Node.Name == "HydropowerRep")
                {
                    MessageBox.Show("水電運轉記錄表");
                }
                else if (e.Node.Name == "VacuumDem")
                {
                    MessageBox.Show("查詢真空機巡檢記錄");
                }
                else if (e.Node.Name == "CompressDem")
                {
                    MessageBox.Show("查詢空壓機巡檢記錄");
                }
                else if (e.Node.Name == "AirConditionDem")
                {
                    MessageBox.Show("查詢冷氣巡檢記錄");
                }
                else if (e.Node.Name == "HydropowerDem")
                {
                    MessageBox.Show("查詢水電巡檢記錄");
                }
                else if (e.Node.Name == "TransportData")
                {
                    MessageBox.Show("傳輸資料");
                }
                else if (e.Node.Name == "Setting")
                {
                    using (Settings mf = new Settings())
                    {
                        this.Visible = false;
                        mf.Owner = this;
                        mf.ShowDialog();

                        mf.Close();
                        mf.Dispose();
                        this.Visible = true;
                    }
                }
                else if (e.Node.Name == "Exit")
                {
                    MessageBox.Show("離開");
                    Environment.Exit(0);
                }
            }
        }
    }
}
