using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class StaffInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        string UR001, UR002, UR003, UR004, UR005, UR006, UR007, UR008, UR009, UR010, UR011, UR012; //人員基本資料 欄位名
        string strDemand = "";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public StaffInfo()
        {
            InitializeComponent();
            
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            //參數
            int i, dtRowsNo;
            string strSQL, strError;
            
            //寫入權限群組下拉選單
            strSQL = "";
            strSQL += "Select * From ROLES";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            dtRowsNo = dt.Rows.Count;
            for (i = 0; i < dtRowsNo; i++)
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

            //防呆
            if (cbxRuleCode.Text == "")
            { MessageBox.Show("權限群組不可空白。"); return; }
            if (tbxStaffAcount.Text == "")
            { MessageBox.Show("人員帳號不可空白。"); return; }
            if (tbxStaffName.Text == "")
            { MessageBox.Show("人員名稱不可空白。"); return; }
            if (cbxAccountStatus.Text == "")
            { MessageBox.Show("帳號狀態不可空白。"); return; }

            //確定要 Insert 的帳號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From USERS Where 1 = 1 And UR001 = '" + tbxStaffAcount.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if(dt.Rows.Count > 0)
            { MessageBox.Show("要新增的帳號已存在，請確認後再執行新增作業。"); return; }

            //進資料庫確認權限代號
            strSQL = "";
            strSQL += "Select * From ROLES Where RL002 = '" + cbxRuleCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            UR004 = dt.Rows[0]["RL001"].ToString().Trim(); //權限代號(UR004)

            // Insert 資料進資料庫
            UR001 = tbxStaffAcount.Text;                          //人員帳號(UR001)
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

            strSQL = "";
            strSQL += "Insert Into USERS (UR001,UR002,UR003,UR004,UR005,UR006,UR007,UR008,UR009,UR010,UR011,UR012) Values ('";
            strSQL += UR001 + "','" + UR002 + "','" + UR003 + "','" + UR004 + "','" + UR005 + "','" + UR006 + "','";
            strSQL += UR007 + "','" + UR008 + "','" + UR009 + "','" + UR010 + "','" + UR011 + "','" + UR012 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch(Exception Ex)
            { }
            
            //清空所有可填入欄位
            cbxRuleCode.Text = "";
            tbxStaffAcount.Text = "";
            tbxStaffName.Text = "";
            cbxAccountStatus.Text = "";
        }
        
        private void btnStaffInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (cbxRuleCode.Text == "")
            { MessageBox.Show("權限群組不可空白。"); return; }
            if (tbxStaffAcount.Text == "")
            { MessageBox.Show("人員帳號不可空白。"); return; }
            if (tbxStaffName.Text == "")
            { MessageBox.Show("人員名稱不可空白。"); return; }
            if (cbxAccountStatus.Text == "")
            { MessageBox.Show("帳號狀態不可空白。"); return; }
            
            //確定要 Update 的帳號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From USERS Where 1 = 1 And UR001 = '" + tbxStaffAcount.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的帳號未存在，請確認後再執行修改作業。"); return; }

            //進資料庫確認權限代號
            strSQL = "";
            strSQL += "Select * From ROLES Where RL002 = '" + cbxRuleCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            UR004 = dt.Rows[0]["RL001"].ToString().Trim(); //權限代號(UR004)

            // Update 資料進資料庫
            // PS：因帳號是唯一值，不得修改。僅可刪除後再新增。
            UR001 = tbxStaffAcount.Text;                   //人員帳號(UR001)
            UR002 = tbxStaffName.Text;                     //人員名稱(UR002)
            UR003 = cbxAccountStatus.Text.Substring(0, 1); //狀態(停用Y、啟用N)(UR003)

            strSQL = "";
            strSQL += "Update USERS Set UR002 = '" + UR002 + "',UR003 = '" + UR003 + "',UR004 = '" + UR004 + "',";
            strSQL += "UR007 = '" + UserName + "',UR009 = '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'";
            strSQL += "Where UR001 = '" + UR001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            cbxRuleCode.Text = "";
            tbxStaffAcount.Text = "";
            tbxStaffName.Text = "";
            cbxAccountStatus.Text = "";
        }

        private void btnStaffInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (tbxStaffAcount.Text == "")
            { MessageBox.Show("人員帳號不可空白。"); return; }

            //確定要 Update 的帳號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From USERS Where 1 = 1 And UR001 = '" + tbxStaffAcount.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的帳號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            UR001 = tbxStaffAcount.Text;                   //人員帳號(UR001)

            strSQL = "";
            strSQL += "Delete From USERS Where UR001 = '" + UR001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvStaff.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            cbxRuleCode.Text = "";
            tbxStaffAcount.Text = "";
            tbxStaffName.Text = "";
            cbxAccountStatus.Text = "";
        }

        private void btnStaffInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
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
            if (tbxStaffAcount.Text.Trim() != "")
                strSQL += "And a.UR001 = '" + tbxStaffAcount.Text.Trim() + "' ";
            if (tbxStaffName.Text.Trim() != "")
                strSQL += "And a.UR002 = '" + tbxStaffName.Text.Trim() + "' ";
            if (cbxAccountStatus.Text.Trim() != "")
                strSQL += "And a.UR003 = '" + cbxAccountStatus.Text.Trim().Substring(0, 1) + "' ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvStaff.DataSource = dt;

            //清空所有可填入欄位
            cbxRuleCode.Text = "";
            tbxStaffAcount.Text = "";
            tbxStaffName.Text = "";
            cbxAccountStatus.Text = "";
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
        
    }
}
