using System;
using System.Windows.Forms;
using System.Drawing;

namespace P2214201
{
    public partial class MainForm : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public static MainForm mfm;
        double oldWidth, oldHeight, newWidth, newHeight;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int NewX, NewY;

            if (oldHeight > 0 && oldWidth > 0)
            {
                // 把Form本來大小值設為目前大小值
                newHeight = this.Height;
                newWidth = this.Width;

                NewX = (splitContainer1.Panel1.Width - trvSelectFn.Width) / 2;
                trvSelectFn.Location = new Point(NewX, 62);

                NewX = (splitContainer1.Panel1.Width - label1.Width) / 2;
                label1.Location = new Point(NewX, 10);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            trvSelectFn.ExpandAll();
            //紀錄Form本來的大小(長與寬)
            oldHeight = this.Height;
            oldWidth = this.Width;
            //調整大小
            trvSelectFn.Width = 300;
            trvSelectFn.Height = 715;
        }

        private void trvSelectFn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if(e.Action == TreeViewAction.ByMouse)
            {
                if(e.Node.Name == "StaffInfo")
                {//人員基本資料
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    StaffInfo sfInfo = new StaffInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "FactoryInfo")
                {//廠房基本資料
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    FactoryInfo sfInfo = new FactoryInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "ReportInfo")
                {//類別基本資料
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    ReportInfo sfInfo = new ReportInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "MachineInfo")
                {//單位機械編號資料
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    MachineInfo sfInfo = new MachineInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "CheckInfo")
                {//檢查項目資料
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    CheckInfo sfInfo = new CheckInfo();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "VacuumRep")
                {//真空機運轉記錄表
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    VacuumRep sfInfo = new VacuumRep();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "CompressRep")
                {//空壓機運轉記錄表
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    CompressRep sfInfo = new CompressRep();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "AirConditionRep")
                {//冷氣機運轉記錄表
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    AirConditionRep sfInfo = new AirConditionRep();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "HydropowerRep")
                {//水電運轉記錄表
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    HydropowerRep sfInfo = new HydropowerRep();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "VacuumDem")
                {//真空機巡檢記錄
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    VacuumDem sfInfo = new VacuumDem();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "CompressDem")
                {//空壓機巡檢記錄
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    CompressDem sfInfo = new CompressDem();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "AirConditionDem")
                {//冷氣機巡檢記錄
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    AirConditionDem sfInfo = new AirConditionDem();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "HydropowerDem")
                {//水電巡檢記錄
                    splitContainer1.Panel2.Controls.Clear();
                    this.IsMdiContainer = true;                    //設置 MainForm 為父視窗
                    HydropowerDem sfInfo = new HydropowerDem();
                    sfInfo.MdiParent = this;                       //設置視窗的父子關係
                    sfInfo.Parent = splitContainer1.Panel2;        //子視窗的容器是父視窗的 Panel2
                    sfInfo.TopLevel = false;                       //必須關閉否則會衝突
                    sfInfo.FormBorderStyle = FormBorderStyle.None; //視窗右上角(放大、縮小、關閉)功能拿掉
                    sfInfo.WindowState = FormWindowState.Maximized;//視窗最大化
                    splitContainer1.Panel2.Controls.Add(sfInfo);   //將子視窗放入 Panel2 中
                    sfInfo.UserAccount = this.UserAccount;         //傳回人員帳號
                    sfInfo.UserName = this.UserName;               //傳回人員姓名
                    sfInfo.UserRole = this.UserRole;               //傳回人員權限
                    sfInfo.oldWidth = oldWidth;
                    sfInfo.oldHeight = oldHeight;
                    sfInfo.newWidth = newWidth;
                    sfInfo.newHeight = newHeight;
                    sfInfo.Show();
                    sfInfo.BringToFront();
                }
                else if (e.Node.Name == "TransportData")
                {//傳輸
                    splitContainer1.Panel2.Controls.Clear();
                    using (AndroidTranferTool.Main _AndroidTranferTool = new AndroidTranferTool.Main())
                    {
                        this.Visible = false;

                        _AndroidTranferTool.Owner = this;
                        _AndroidTranferTool.ShowDialog();

                        _AndroidTranferTool.Close();
                        _AndroidTranferTool.Dispose();

                        this.Visible = true;
                    }
                }
                else if (e.Node.Name == "Setting")
                {//設定
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
                {//離開
                    Environment.Exit(0);
                }
            }
        }
    }
}
