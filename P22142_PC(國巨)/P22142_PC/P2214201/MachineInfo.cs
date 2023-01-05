using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;
using System.Drawing;

namespace P2214201
{
    public partial class MachineInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        string MN001, MN002, MN003, MN004, MN005, MN006, MN007, MN008, MN009, MN010, MN011, MN012; //單位機械編號資料 欄位名
        string FT001, FT002, CG001, CG002;
        string strDemand = "", isDGVUse = "N";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DealRecord drc = new DealRecord();

        public MachineInfo()
        {
            InitializeComponent();
        }
        
        private void MachineInfo_Resize(object sender, EventArgs e)
        {
            int NewX;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvMachine.Width = Convert.ToInt32(x * dgvMachine.Width);
                dgvMachine.Height = Convert.ToInt32(y * dgvMachine.Height);

                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);

                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnMachineInfoAdd.Location.X * x + btnMachineInfoAdd.Width * (x - 1));
                btnMachineInfoAdd.Location = new Point(NewX, btnMachineInfoAdd.Location.Y);
                btnMachineInfoAdd.Width = Convert.ToInt32(x * btnMachineInfoAdd.Width);
                btnMachineInfoAdd.Height = Convert.ToInt32(y * btnMachineInfoAdd.Height);

                NewX = (int)(btnMachineInfoModify.Location.X * x + btnMachineInfoModify.Width * (x - 1));
                btnMachineInfoModify.Location = new Point(NewX, btnMachineInfoModify.Location.Y);
                btnMachineInfoModify.Width = Convert.ToInt32(x * btnMachineInfoModify.Width);
                btnMachineInfoModify.Height = Convert.ToInt32(y * btnMachineInfoModify.Height);

                NewX = (int)(btnMachineInfoDelete.Location.X * x + btnMachineInfoDelete.Width * (x - 1));
                btnMachineInfoDelete.Location = new Point(NewX, btnMachineInfoDelete.Location.Y);
                btnMachineInfoDelete.Width = Convert.ToInt32(x * btnMachineInfoDelete.Width);
                btnMachineInfoDelete.Height = Convert.ToInt32(y * btnMachineInfoDelete.Height);

                NewX = (int)(btnMachineInfoDemand.Location.X * x + btnMachineInfoDemand.Width * (x - 1));
                btnMachineInfoDemand.Location = new Point(NewX, btnMachineInfoDemand.Location.Y);
                btnMachineInfoDemand.Width = Convert.ToInt32(x * btnMachineInfoDemand.Width);
                btnMachineInfoDemand.Height = Convert.ToInt32(y * btnMachineInfoDemand.Height);
            }
        }

        private void MachineInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void MachineInfo_Load(object sender, EventArgs e)
        {
            //參數
            int i;
            string strSQL;

            //DataGridView 設定
            drc.SetDataGridView(ref dgvMachine);

            //寫入廠房名稱下拉選單
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            for (i = 0; i < dt.Rows.Count; i++)
                cbxFactoryName.Items.Add(dt.Rows[i]["FT002"].ToString().Trim());

            // 寫入類別名稱下拉選單
            strSQL = "SELECT * FROM CATEGORYS WHERE CG001 NOT IN ('D')";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            for (i = 0; i < dt.Rows.Count; i++)
                cbxReportName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());

            if (UserRole == "OP") //操作者身份
            {
                //管理者身份可使用 新增、刪除、修改、查詢、離開
                //操作者身份可使用 查詢、離開
                btnMachineInfoAdd.Enabled = false;    //新增
                btnMachineInfoModify.Enabled = false; //修改
                btnMachineInfoDelete.Enabled = false; //刪除
                //btnStaffInfoStore.Enabled = false;  //儲存
            }
            //DataGridView設定
            dgvMachine.ReadOnly = true;
        }

        private void cbxFactoryName_SelectedIndexChanged(object sender, EventArgs e)
        {//廠房名稱下拉後代入機械編號
            FT002 = cbxFactoryName.Text;
            FT001 = USQL.FindFT("", FT002);
            tbxFactoryCode.Text = FT001;
            //清空
            if (isDGVUse != "Y")
            {
                cbxReportName.Text = "";
                tbxMachineCode.Text = "";
                tbxMachineName.Text = "";
                tbxFactoryCode.Text = "";
                dgvMachine.DataSource = null;
            }
        }

        private void cbxReportName_SelectedIndexChanged(object sender, EventArgs e)
        {//類別名稱下拉後記錄相關資訊
            CG002 = cbxReportName.Text;
            //清空
            if (isDGVUse != "Y")
            {
                tbxMachineCode.Text = "";
                tbxMachineName.Text = "";
                tbxFactoryCode.Text = "";
                dgvMachine.DataSource = null;
            }
        }

        private void btnMachineInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y", "Y", "Y") == false)
                return;

            //確定要 Insert 的機械編號是否已存在資料庫
            MN001 = tbxFactoryCode.Text + "_" + tbxMachineCode.Text;
            
            strSQL = "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + MN001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            { MessageBox.Show("要新增的機械編號已存在，請確認後再執行新增作業。"); return; }

            //廠房代號抓取
            MN003 = tbxFactoryCode.Text.Trim(); //廠房代號(MN003)

            //類別代號抓取
            CG002 = cbxReportName.Text.Trim();
            MN004 = USQL.FindCG("", CG002);        //類別代號 (MN004)

            // Insert 資料進資料庫
            MN001 = tbxFactoryCode.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)
            MN002 = tbxMachineName.Text;                             //機械名稱(MN002)
            MN005 = UserName;                                        //建立者(MN005)
            MN006 = "";                                              //修改者(MN006)
            MN007 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");    //建立時間(MN007)
            MN008 = "";                                              //修改時間(MN008)
            MN009 = "";                                              //備用(MN009)
            MN010 = tbxMachineCode.Text;                             //備用(MN010)
            MN011 = "";                                              //備用(MN011)
            MN012 = "Y";                                             //是否仍然使用(MN012)
            
            strSQL = "Insert Into MECHNUMBERS (MN001,MN002,MN003,MN004,MN005,MN006,MN007,MN008,MN009,MN010,MN011,MN012) Values ('";
            strSQL += MN001 + "','" + MN002 + "','" + MN003 + "','" + MN004 + "','" + MN005 + "','" + MN006 + "','";
            strSQL += MN007 + "','" + MN008 + "','" + MN009 + "','" + MN010 + "','" + MN011 + "','" + MN012 + "')";
            USQL.SQLNonSelect(ref da, strSQL);
            
            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvMachine.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnMachineInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y", "Y", "Y") == false)
                return;

            //確定要 Update 的帳號是否已存在資料庫
            MN001 = tbxFactoryCode.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)

            strSQL = "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + MN001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的機械編號未存在，請確認後再執行修改作業。"); return; }

            //廠房代號抓取
            MN003 = tbxFactoryCode.Text.Trim(); //廠房代號(MN003)

            //類別代號抓取
            CG002 = cbxReportName.Text.Trim();
            MN004 = USQL.FindCG("", CG002); //類別代號 (MN004)

            // Update 資料進資料庫
            MN002 = tbxMachineName.Text; //機械名稱(MN002)
            MN010 = tbxMachineCode.Text; //備存(MN010)

            strSQL = "";
            strSQL += "Update MECHNUMBERS Set MN002 = '" + MN002 + "',MN003 = '" + MN003 + "',MN004 = '" + MN004 + "',MN010 = '" + MN010 + "' ";
            strSQL += "Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvMachine.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnMachineInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("N", "N", "Y", "N") == false)
                return;

            //確定要 Delete 的帳號是否已存在資料庫
            strSQL = "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + tbxFactoryCode.Text + "_" + tbxMachineCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的機械編號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            MN001 = tbxFactoryCode.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)
            
            strSQL = "Delete From MECHNUMBERS Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvMachine.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnMachineInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
            FT002 = cbxFactoryName.Text.Trim();
            CG002 = cbxReportName.Text.Trim();
            MN002 = tbxMachineName.Text.Trim();
            MN010 = tbxMachineCode.Text.Trim();
            
            strSQL = "Select b.FT002 as '廠房名稱',";
            strSQL += "c.CG002 as '類別名稱',";
            strSQL += "a.MN010 as '機械編號',";
            strSQL += "a.MN002 as '機械名稱',";
            strSQL += "a.MN005 as '建立人員',";
            strSQL += "a.MN007 as '建立時間',";
            strSQL += "a.MN006 as '修改人員',";
            strSQL += "a.MN008 as '修改時間',";
            strSQL += "a.MN012 as '是否仍然使用' ";
            strSQL += "From MECHNUMBERS a,FACTORYS b,CATEGORYS c ";
            strSQL += "Where a.MN003 = b.FT001 ";
            strSQL += "And a.MN004 = c.CG001 ";
            strSQL += "And c.CG001 not in ('D')";
            if (FT002 != "")
                strSQL += "And b.FT002 = '" + FT002 + "' ";
            if (CG002 != "")
                strSQL += "And c.CG002 = '" + CG002 + "' ";
            if (MN010 != "")
                strSQL += "And a.MN010 = '" + MN010 + "' ";
            if (MN002 != "")
                strSQL += "And a.MN002 = '" + MN002 + "' ";
            strSQL += "Order By MN004,MN001 ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvMachine.DataSource = dt;
            dgvMachine.ClearSelection();
            //清空所有可填入欄位
            ClearForm();
        }

        private void dgvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tFT002, tCG002, tMN001, tMN002;

            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvMachine.Rows.Count > 0)
            {
                isDGVUse = "Y";
                tFT002 = dgvMachine.CurrentRow.Cells[0].Value.ToString().Trim(); //廠房名稱
                cbxFactoryName.Text = tFT002;

                tCG002 = dgvMachine.CurrentRow.Cells[1].Value.ToString().Trim(); //類別名稱
                cbxReportName.Text = tCG002;
                
                tMN001 = dgvMachine.CurrentRow.Cells[2].Value.ToString().Trim(); //機械編號
                tbxMachineCode.Text = tMN001;

                tMN002 = dgvMachine.CurrentRow.Cells[3].Value.ToString().Trim(); //機械名稱
                tbxMachineName.Text = tMN002;
                
                tbxFactoryCode.Text = USQL.FindFT("", FT002);   //廠房代號

                isDGVUse = "N";
            }
        }
        private bool CheckData(string FT002, string CG002, string MN001, string MN002)
        {
            //*************************************************************************************
            //防呆專區
            //*************************************************************************************
            if (FT002 == "Y" && cbxFactoryName.Text == "")
            { MessageBox.Show("廠房名稱不可空白。"); return false; }
            if (CG002 == "Y" && cbxReportName.Text == "")
            { MessageBox.Show("類別名稱不可空白。"); return false; }
            if (MN001 == "Y" && tbxMachineCode.Text == "")
            { MessageBox.Show("機械編號不可空白。"); return false; }
            if (MN002 == "Y" && tbxMachineName.Text == "")
            { MessageBox.Show("機械名稱不可空白。"); return false; }

            return true;
        }
        private void ClearForm()
        {
            //*************************************************************************************
            //清空資料專區
            //*************************************************************************************
            cbxFactoryName.Text = "";
            cbxReportName.Text = "";
            tbxMachineCode.Text = "";
            tbxMachineName.Text = "";
            tbxFactoryCode.Text = "";
        }
    }
}
