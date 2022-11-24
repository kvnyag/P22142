using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class MachineInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        string MN001, MN002, MN003, MN004, MN005, MN006, MN007, MN008, MN009, MN010, MN011; //單位機械編號資料 欄位名
        string strDemand = "";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public MachineInfo()
        {
            InitializeComponent();
        }

        private void MachineInfo_Load(object sender, EventArgs e)
        {
            //參數
            int i, dtRowsNo;
            string strSQL;

            //寫入廠房名稱下拉選單
            strSQL = "";
            strSQL += "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);

            dtRowsNo = dt.Rows.Count;
            for (i = 0; i < dtRowsNo; i++)
                cbxFactoryName.Items.Add(dt.Rows[i]["FT002"].ToString().Trim());

            // 寫入類別名稱下拉選單
            strSQL = "";
            strSQL += "Select * From CATEGORYS";
            dt = USQL.SQLSelect(ref da, strSQL);

            dtRowsNo = dt.Rows.Count;
            for (i = 0; i < dtRowsNo; i++)
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
            string strSQL;

            strSQL = "";
            strSQL += "Select * From FACTORYS Where FT002 = '" + cbxFactoryName.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            tbxFactoryName.Text = dt.Rows[0]["FT001"].ToString().Trim();
        }

        private void btnMachineInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;

            //防呆
            if (cbxFactoryName.Text == "")
            { MessageBox.Show("廠房名稱不可空白。"); return; }
            if (cbxReportName.Text == "")
            { MessageBox.Show("類別名稱不可空白。"); return; }
            if (tbxMachineCode.Text == "")
            { MessageBox.Show("機械編號不可空白。"); return; }
            if (tbxMachineName.Text == "")
            { MessageBox.Show("機械名稱不可空白。"); return; }

            //確定要 Insert 的機械編號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + tbxMachineCode.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            { MessageBox.Show("要新增的機械編號已存在，請確認後再執行新增作業。"); return; }

            //廠房代號抓取
            strSQL = "";
            strSQL += "Select FT001 From FACTORYS Where FT002 = '" + cbxFactoryName.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            MN003 = dt.Rows[0]["FT001"].ToString().Trim();        //廠房代號(MN003)

            //類別代號抓取
            strSQL = "";
            strSQL += "Select CG001 From CATEGORYS Where CG002 = '" + cbxReportName.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            MN004 = dt.Rows[0]["CG001"].ToString().Trim();        //類別代號 (MN004)

            // Insert 資料進資料庫
            MN001 = tbxFactoryName.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)
            MN002 = tbxMachineName.Text;                             //機械名稱(MN002)
            MN005 = UserName;                                        //建立者(MN005)
            MN006 = "";                                              //修改者(MN006)
            MN007 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");    //建立時間(MN007)
            MN008 = "";                                              //修改時間(MN008)
            MN009 = "";                                              //備用(MN009)
            MN010 = tbxMachineCode.Text;                             //備用(MN010)
            MN011 = "";                                              //備用(MN011)

            strSQL = "";
            strSQL += "Insert Into MECHNUMBERS (MN001,MN002,MN003,MN004,MN005,MN006,MN007,MN008,MN009,MN010,MN011) Values ('";
            strSQL += MN001 + "','" + MN002 + "','" + MN003 + "','" + MN004 + "','" + MN005 + "','" + MN006 + "','";
            strSQL += MN007 + "','" + MN008 + "','" + MN009 + "','" + MN010 + "','" + MN011 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            cbxFactoryName.Text = "";
            cbxReportName.Text = "";
            tbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }

        private void btnMachineInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (cbxFactoryName.Text == "")
            { MessageBox.Show("廠房名稱不可空白。"); return; }
            if (cbxReportName.Text == "")
            { MessageBox.Show("類別名稱不可空白。"); return; }
            if (tbxMachineCode.Text == "")
            { MessageBox.Show("機械編號不可空白。"); return; }
            if (tbxMachineName.Text == "")
            { MessageBox.Show("機械名稱不可空白。"); return; }

            //確定要 Update 的帳號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + tbxFactoryName.Text + "_" + tbxMachineCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的機械編號未存在，請確認後再執行修改作業。"); return; }

            //廠房代號抓取
            strSQL = "";
            strSQL += "Select FT001 From FACTORYS Where FT002 = '" + cbxFactoryName.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            MN003 = dt.Rows[0]["FT001"].ToString().Trim();        //廠房代號(MN003)

            //類別代號抓取
            strSQL = "";
            strSQL += "Select CG001 From CATEGORYS Where CG002 = '" + cbxReportName.Text.Trim() + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            MN004 = dt.Rows[0]["CG001"].ToString().Trim();        //類別代號 (MN004)

            // Update 資料進資料庫
            MN001 = tbxFactoryName.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)
            MN002 = tbxMachineName.Text;                             //機械名稱(MN002)
            MN010 = tbxMachineCode.Text;                             //備存(MN010)

            strSQL = "";
            strSQL += "Update MECHNUMBERS Set MN002 = '" + MN002 + "',MN003 = '" + MN003 + "',MN004 = '" + MN004 + "',MN010 = '" + MN010 + "' ";
            strSQL += "Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            cbxFactoryName.Text = "";
            cbxReportName.Text = "";
            tbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }

        private void btnMachineInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (tbxMachineCode.Text == "")
            { MessageBox.Show("機械編號不可空白。"); return; }

            //確定要 Delete 的帳號是否已存在資料庫
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where 1 = 1 And MN001 = '" + tbxFactoryName.Text + "_" + tbxMachineCode.Text + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的機械編號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            MN001 = tbxFactoryName.Text + "_" + tbxMachineCode.Text; //機械編號(MN001)

            strSQL = "";
            strSQL += "Delete From MECHNUMBERS Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvMachine.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            cbxFactoryName.Text = "";
            cbxReportName.Text = "";
            tbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }

        private void btnMachineInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
            strSQL = "";
            strSQL += "Select b.FT002 as '廠房名稱',";
            strSQL += "c.CG002 as '類別名稱',";
            strSQL += "a.MN010 as '機械編號',";
            strSQL += "a.MN002 as '機械名稱',";
            strSQL += "a.MN005 as '建立人員' ";
            strSQL += "From MECHNUMBERS a,FACTORYS b,CATEGORYS c ";
            strSQL += "Where a.MN003 = b.FT001 ";
            strSQL += "And a.MN004 = c.CG001 ";
            if (cbxFactoryName.Text.Trim() != "")
                strSQL += "And b.FT002 = '" + cbxFactoryName.Text.Trim() + "' ";
            if (cbxReportName.Text.Trim() != "")
                strSQL += "And c.CG002 = '" + cbxReportName.Text.Trim() + "' ";
            if (tbxMachineCode.Text.Trim() != "")
                strSQL += "And a.MN010 = '" + tbxMachineCode.Text.Trim() + "' ";
            if (tbxMachineName.Text.Trim() != "")
                strSQL += "And a.MN002 = '" + tbxMachineName.Text.Trim() + "' ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvMachine.DataSource = dt;

            //清空所有可填入欄位
            cbxFactoryName.Text = "";
            cbxReportName.Text = "";
            tbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }

        private void dgvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvMachine.Rows.Count > 0)
            {
                cbxFactoryName.Text = dgvMachine.CurrentRow.Cells[0].Value.ToString().Trim(); //廠房名稱
                cbxReportName.Text = dgvMachine.CurrentRow.Cells[1].Value.ToString().Trim();  //類別名稱
                tbxMachineCode.Text = dgvMachine.CurrentRow.Cells[2].Value.ToString().Trim(); //機械編號
                tbxMachineName.Text = dgvMachine.CurrentRow.Cells[3].Value.ToString().Trim(); //機械名稱
            }
        }
        
    }
}
