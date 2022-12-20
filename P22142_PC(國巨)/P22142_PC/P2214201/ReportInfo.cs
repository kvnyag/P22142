using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class ReportInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        string CG001, CG002, CG003, CG004, CG005, CG006, CG007, CG008, CG009; //類別基本資料 欄位名
        string strDemand = "";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public ReportInfo()
        {
            InitializeComponent();
        }

        private void ReportInfo_Load(object sender, EventArgs e)
        {
            //參數

            if (UserRole == "OP") //操作者身份
            {
                //管理者身份可使用 新增、刪除、修改、查詢、離開
                //操作者身份可使用 查詢、離開
                btnReportInfoAdd.Enabled = false;    //新增
                btnReportInfoModify.Enabled = false; //修改
                btnReportInfoDelete.Enabled = false; //刪除
                //btnStaffInfoStore.Enabled = false;  //儲存
            }
            //DataGridView設定
            dgvReport.ReadOnly = true;
        }

        private void btnReportInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y") == false)
                return;

            //確定要 Insert 的帳號是否已存在資料庫
            CG001 = tbxReportCode.Text.Trim(); //廠房代號(CG001)
            strSQL = "Select * From CATEGORYS Where 1 = 1 And CG001 = '" + CG001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            { MessageBox.Show("要新增的類別代號已存在，請確認後再執行新增作業。"); return; }
            
            // Insert 資料進資料庫
            CG002 = tbxReportName.Text;                           //廠房名稱(CG002)
            CG003 = UserName;                                     //建立者(CG003)
            CG004 = "";                                           //修改者(CG004)
            CG005 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間(CG005)
            CG006 = "";                                           //修改時間(CG006)
            CG007 = "";                                           //備用(CG007)
            CG008 = "";                                           //備用(CG008)
            CG009 = "";                                           //備用(CG009)
            
            strSQL = "Insert Into CATEGORYS (CG001,CG002,CG003,CG004,CG005,CG006,CG007,CG008,CG009) Values ('";
            strSQL += CG001 + "','" + CG002 + "','" + CG003 + "','" + CG004 + "','" + CG005 + "','" + CG006 + "','";
            strSQL += CG007 + "','" + CG008 + "','" + CG009 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvReport.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnReportInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y") == false)
                return;

            //確定要 Update 的帳號是否已存在資料庫
            CG001 = tbxReportCode.Text.Trim(); //類別代號(Ft001)
            strSQL = "Select * From CATEGORYS Where 1 = 1 And CG001 = '" + CG001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的類別代號未存在，請確認後再執行修改作業。"); return; }

            // Update 資料進資料庫
            // PS：因類別代號 是唯一值，不得修改。僅可刪除後再新增
            CG002 = tbxReportName.Text; //類別名稱(FT002)
            
            strSQL = "Update CATEGORYS Set CG002 = '" + CG002 + "',CG004 = '" + UserName + "',";
            strSQL += "CG006 = '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'";
            strSQL += "Where CG001 = '" + CG001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvReport.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnReportInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "N") == false)
                return;

            //確定要 Delete 的帳號是否已存在資料庫
            CG001 = tbxReportCode.Text.Trim(); //類別代號(CG001)
            strSQL = "Select * From CATEGORYS Where 1 = 1 And CG001 = '" + CG001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的類別未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            strSQL = "Delete From CATEGORYS Where CG001 = '" + CG001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvReport.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnReportInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL, CG001;

            //搜尋結果填入 DataGridView
            CG001 = tbxReportCode.Text.Trim();
            CG002 = tbxReportName.Text.Trim();
            
            strSQL = "Select CG001 as '類別代號',";
            strSQL += "CG002 as '類別名稱',";
            strSQL += "CG003 as '建立人員',";
            strSQL += "CG005 as '建立時間',";
            strSQL += "CG004 as '修改人員',";
            strSQL += "CG006 as '修改時間' ";
            strSQL += "From CATEGORYS ";
            strSQL += "Where 1 = 1 ";
            if (CG001 != "")
                strSQL += "And CG001 = '" + CG001 + "' ";
            if (CG002 != "")
                strSQL += "And CG002 = '" + CG002 + "' ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvReport.DataSource = dt;

            //清空所有可填入欄位
            ClearForm();
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvReport.Rows.Count > 0)
            {
                tbxReportCode.Text = dgvReport.CurrentRow.Cells[0].Value.ToString().Trim(); //廠房代號 
                tbxReportName.Text = dgvReport.CurrentRow.Cells[1].Value.ToString().Trim(); //廠房名稱
            }
        }
        private bool CheckData(string CG001, string CG002)
        {
            //*************************************************************************************
            //防呆專區
            //*************************************************************************************
            if (CG001 == "Y" && tbxReportCode.Text == "")
            { MessageBox.Show("類別代號不可空白。"); return false; }
            if (CG002 == "Y" && tbxReportName.Text == "")
            { MessageBox.Show("類別名稱不可空白。"); return false; }

            return true;
        }
        private void ClearForm()
        {
            //*************************************************************************************
            //清空資料專區
            //*************************************************************************************
            tbxReportCode.Text = "";
            tbxReportName.Text = "";
        }
    }
}
