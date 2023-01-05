using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;
using System.Drawing;

namespace P2214201
{
    public partial class StaffInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        string UR001, UR002, UR003, UR004, UR005, UR006, UR007, UR008, UR009, UR010, UR011, UR012; //人員基本資料 欄位名
        string strDemand = "";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DealRecord drc = new DealRecord();

        public StaffInfo()
        {
            InitializeComponent();
        }

        private void StaffInfo_Resize(object sender, EventArgs e)
        {
            int NewX;

            if(oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvStaff.Width = Convert.ToInt32(x * dgvStaff.Width);
                dgvStaff.Height = Convert.ToInt32(y * dgvStaff.Height);

                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);

                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnStaffInfoAdd.Location.X * x + btnStaffInfoAdd.Width * (x - 1));
                btnStaffInfoAdd.Location = new Point(NewX, btnStaffInfoAdd.Location.Y);
                btnStaffInfoAdd.Width = Convert.ToInt32(x * btnStaffInfoAdd.Width);
                btnStaffInfoAdd.Height = Convert.ToInt32(y * btnStaffInfoAdd.Height);

                NewX = (int)(btnStaffInfoModify.Location.X * x + btnStaffInfoModify.Width * (x - 1));
                btnStaffInfoModify.Location = new Point(NewX, btnStaffInfoModify.Location.Y);
                btnStaffInfoModify.Width = Convert.ToInt32(x * btnStaffInfoModify.Width);
                btnStaffInfoModify.Height = Convert.ToInt32(y * btnStaffInfoModify.Height);

                NewX = (int)(btnStaffInfoDelete.Location.X * x + btnStaffInfoDelete.Width * (x - 1));
                btnStaffInfoDelete.Location = new Point(NewX, btnStaffInfoDelete.Location.Y);
                btnStaffInfoDelete.Width = Convert.ToInt32(x * btnStaffInfoDelete.Width);
                btnStaffInfoDelete.Height = Convert.ToInt32(y * btnStaffInfoDelete.Height);

                NewX = (int)(btnStaffInfoDemand.Location.X * x + btnStaffInfoDemand.Width * (x - 1));
                btnStaffInfoDemand.Location = new Point(NewX, btnStaffInfoDemand.Location.Y);
                btnStaffInfoDemand.Width = Convert.ToInt32(x * btnStaffInfoDemand.Width);
                btnStaffInfoDemand.Height = Convert.ToInt32(y * btnStaffInfoDemand.Height);
            }
        }

        private void StaffInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }
        
        private void StaffInfo_Load(object sender, EventArgs e)
        {
            //參數
            int i;
            string strSQL;

            //DataGridView 設定
            drc.SetDataGridView(ref dgvStaff);

            //寫入權限群組下拉選單
            strSQL = "Select * From ROLES";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            for (i = 0; i < dt.Rows.Count; i++)
                cbxRuleCode.Items.Add(dt.Rows[i]["RL002"].ToString().Trim());
            //寫入帳號狀態下拉選單
            cbxAccountStatus.Items.Add("Y:停用");
            cbxAccountStatus.Items.Add("N:啟用");
            //管理者身份可使用 新增、刪除、修改、查詢、離開
            //操作者身份可使用 查詢、離開
            if (UserRole == "OP") //操作者身份
            {
                btnStaffInfoAdd.Enabled = false;    //新增
                btnStaffInfoModify.Enabled = false; //修改
                btnStaffInfoDelete.Enabled = false; //刪除
                //btnStaffInfoStore.Enabled = false;  //儲存
            }
            //DataGridView設定
            dgvStaff.ReadOnly = true;
        }
        
        private void btnStaffInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;
            string[] arrNum = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //防呆
            //....欄位均不可空白
            if (CheckData("Y", "Y", "Y", "Y") == false)
                return;
            //....帳號必須8碼
            UR001 = tbxStaffAcount.Text; //人員帳號(UR001)
            if (UR001.Length != 8)
            {
                MessageBox.Show("薪號少於 8 碼，請再次輸入。");
                return;
            }
            //....帳號必須都是數字
            for (int i = 0; i < UR001.Length; i++)
            {
                string subUR001 = UR001.Substring(i, 1);
                if (Array.IndexOf(arrNum, subUR001) == -1)
                {
                    MessageBox.Show("不可輸入非數字，請再次輸入。");
                    return;
                }
            }

            //確定要 Insert 的帳號是否已存在資料庫
            strSQL = "Select * From USERS Where 1 = 1 And UR001 = '" + UR001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if(dt.Rows.Count > 0)
            { MessageBox.Show("要新增的帳號已存在，請確認後再執行新增作業。"); return; }

            //進資料庫確認權限代號
            strSQL = "Select * From ROLES Where RL002 = '" + cbxRuleCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            UR004 = dt.Rows[0]["RL001"].ToString().Trim(); //權限代號(UR004)

            // Insert 資料進資料庫
            UR002 = tbxStaffName.Text;                            //人員名稱(UR002)
            UR003 = cbxAccountStatus.Text.Substring(0, 1);        //狀態(停用Y、啟用N)(UR003)
            UR005 = "";                                           //備註(UR005)
            UR006 = UserName;                                     //建立者(UR006)
            UR007 = "";                                           //修改者(UR007)
            UR008 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間(UR008)
            UR009 = "";                                           //修改時間(UR009)
            UR010 = "";                                           //備用(UR010)
            UR011 = "";                                           //備用(UR011)
            UR012 = "";                                           //備用(UR012)
            
            strSQL = "Insert Into USERS (UR001,UR002,UR003,UR004,UR005,UR006,UR007,UR008,UR009,UR010,UR011,UR012) Values ('";
            strSQL += UR001 + "','" + UR002 + "','" + UR003 + "','" + UR004 + "','" + UR005 + "','" + UR006 + "','";
            strSQL += UR007 + "','" + UR008 + "','" + UR009 + "','" + UR010 + "','" + UR011 + "','" + UR012 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvStaff.ClearSelection();
                }
            }
            catch(Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }
        
        private void btnStaffInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y", "Y", "Y") == false)
                return;

            //確定要 Update 的帳號是否已存在資料庫
            UR001 = tbxStaffAcount.Text.Trim(); //人員帳號(UR001)
            strSQL = "Select * From USERS Where 1 = 1 And UR001 = '" + UR001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的帳號未存在，請確認後再執行修改作業。"); return; }

            //進資料庫確認權限代號
            strSQL = "Select * From ROLES Where RL002 = '" + cbxRuleCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            UR004 = dt.Rows[0]["RL001"].ToString().Trim(); //權限代號(UR004)

            // Update 資料進資料庫
            // PS：因帳號是唯一值，不得修改。僅可刪除後再新增。
            UR002 = tbxStaffName.Text;                     //人員名稱(UR002)
            UR003 = cbxAccountStatus.Text.Substring(0, 1); //狀態(停用Y、啟用N)(UR003)
            
            strSQL = "Update USERS Set UR002 = '" + UR002 + "',UR003 = '" + UR003 + "',UR004 = '" + UR004 + "',";
            strSQL += "UR007 = '" + UserName + "',UR009 = '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'";
            strSQL += "Where UR001 = '" + UR001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvStaff.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnStaffInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("N", "Y", "N", "N") == false)
                return;

            //確定要 Update 的帳號是否已存在資料庫
            UR001 = tbxStaffAcount.Text.Trim(); //人員帳號(UR001)
            strSQL = "Select * From USERS Where 1 = 1 And UR001 = '" + UR001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的帳號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            strSQL = "Delete From USERS Where UR001 = '" + UR001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvStaff.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnStaffInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
            UR001 = tbxStaffAcount.Text.Trim();
            UR002 = tbxStaffName.Text.Trim();

            strSQL = "";
            strSQL += "Select a.UR001 as '人員帳號',";
            strSQL += "a.UR002 as '人員名稱',";
            strSQL += "b.RL002 as '權限群組',";
            strSQL += "a.UR006 as '建立人員',";
            strSQL += "a.UR008 as '建立時間',";
            strSQL += "a.UR007 as '修改人員',";
            strSQL += "a.UR009 as '修改時間',";
            strSQL += "a.UR003 as '狀態' ";
            strSQL += "From USERS a, ROLES b ";
            strSQL += "Where a.UR004 = b.RL001 ";
            if (cbxRuleCode.Text.Trim() != "")
                strSQL += "And b.RL002 = '" + cbxRuleCode.Text.Trim() + "' ";
            if (UR001 != "")
                strSQL += "And a.UR001 = '" + UR001 + "' ";
            if (UR002 != "")
                strSQL += "And a.UR002 = '" + UR002 + "' ";
            if (cbxAccountStatus.Text.Trim() != "")
                strSQL += "And a.UR003 = '" + cbxAccountStatus.Text.Trim().Substring(0, 1) + "' ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvStaff.DataSource = dt;
            dgvStaff.ClearSelection();
            //清空所有可填入欄位
            ClearForm();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvStaff.Rows.Count > 0)
            {
                cbxRuleCode.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString().Trim();    //權限群組
                tbxStaffAcount.Text = dgvStaff.CurrentRow.Cells[0].Value.ToString().Trim(); //人員帳號
                tbxStaffName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString().Trim();   //人員名稱
                if (dgvStaff.CurrentRow.Cells[6].Value.ToString().Trim() == "Y")            //帳號狀態
                    cbxAccountStatus.Text = "Y:停用";
                else
                    cbxAccountStatus.Text = "N:啟用";
            }
        }
        private bool CheckData(string Role, string Account, string Name, string AccountStatus)
        {
            //*************************************************************************************
            //防呆專區
            //*************************************************************************************
            if(Role == "Y" && cbxRuleCode.Text == "")
            { MessageBox.Show("權限群組不可空白。"); return false; }
            if (Account == "Y" && tbxStaffAcount.Text == "")
            { MessageBox.Show("人員帳號不可空白。"); return false; }
            if (Account == "Y" && tbxStaffAcount.Text.Length < 8)
            { MessageBox.Show("人員帳號不可小於8碼。"); return false; }
            if (Name == "Y" && tbxStaffName.Text == "")
            { MessageBox.Show("人員名稱不可空白。"); return false; }
            if (AccountStatus == "Y" && cbxAccountStatus.Text == "")
            { MessageBox.Show("帳號狀態不可空白。"); return false; }

            return true;
        }
        private void ClearForm()
        {
            //*************************************************************************************
            //清空資料專區
            //*************************************************************************************
            cbxRuleCode.Text = "";
            tbxStaffAcount.Text = "";
            tbxStaffName.Text = "";
            cbxAccountStatus.Text = "";
        }
    }
}
