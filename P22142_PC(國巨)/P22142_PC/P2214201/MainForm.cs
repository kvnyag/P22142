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
        public string UserAccount, UserName, UserRole;
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
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    StaffInfo sfInfo = new StaffInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "FactoryInfo")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    FactoryInfo sfInfo = new FactoryInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "ReportInfo")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    ReportInfo sfInfo = new ReportInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "MachineInfo")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    MachineInfo sfInfo = new MachineInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "CheckInfo")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    CheckInfo sfInfo = new CheckInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "VacuumRep")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("真空機運轉記錄表");
                }
                else if (e.Node.Name == "CompressRep")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("空壓機運轉記錄表");
                }
                else if (e.Node.Name == "AirConditionRep")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("冷氣運轉記錄表");
                }
                else if (e.Node.Name == "HydropowerRep")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("水電運轉記錄表");
                }
                else if (e.Node.Name == "VacuumDem")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("查詢真空機巡檢記錄");
                }
                else if (e.Node.Name == "CompressDem")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("查詢空壓機巡檢記錄");
                }
                else if (e.Node.Name == "AirConditionDem")
                {
                    splitContainer1.Panel2.Controls.Clear();
                    MessageBox.Show("查詢冷氣巡檢記錄");
                }
                else if (e.Node.Name == "HydropowerDem")
                {
                    splitContainer1.Panel2.Controls.Clear();
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
                    Environment.Exit(0);
                }
            }
        }
    }
}
