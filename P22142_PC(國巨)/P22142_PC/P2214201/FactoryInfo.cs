using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class FactoryInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        string FT001, FT002, FT003, FT004, FT005, FT006, FT007, FT008, FT009; //廠房基本資料 欄位名
        string strDemand = "";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public FactoryInfo()
        {
            InitializeComponent();
        }

        private void FactoryInfo_Load(object sender, EventArgs e)
        {
            if (UserRole == "OP") //操作者身份
            {
                //管理者身份可使用 新增、刪除、修改、查詢、離開
                //操作者身份可使用 查詢、離開
                btnFactoryInfoAdd.Enabled = false;    //新增
                btnFactoryInfoModify.Enabled = false; //修改
                btnFactoryInfoDelete.Enabled = false; //刪除
                //btnStaffInfoStore.Enabled = false;  //儲存
            }
            //DataGridView設定
            dgvFactory.ReadOnly = true;
        }

        private void btnFactoryInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y") == false)
                return;

            //確定要 Insert 的帳號是否已存在資料庫
            FT001 = tbxFactoryCode.Text.Trim(); //廠房代號(FT001)
            strSQL = "Select * From FACTORYS Where 1 = 1 And FT001 = '" + FT001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            { MessageBox.Show("要新增的廠房代號已存在，請確認後再執行新增作業。"); return; }
            

            // Insert 資料進資料庫
            FT002 = tbxFactoryName.Text;                          //廠房名稱(FT002)
            FT003 = UserName;                                     //建立者(FT003)
            FT004 = "";                                           //修改者(FT004)
            FT005 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間(UR008)
            FT006 = "";                                           //修改時間(UR009)
            FT007 = "";                                           //備用(UR010)
            FT008 = "";                                           //備用(UR011)
            FT009 = "";                                           //備用(UR012)
            
            strSQL = "Insert Into FACTORYS (FT001,FT002,FT003,FT004,FT005,FT006,FT007,FT008,FT009) Values ('";
            strSQL += FT001 + "','" + FT002 + "','" + FT003 + "','" + FT004 + "','" + FT005 + "','" + FT006 + "','";
            strSQL += FT007 + "','" + FT008 + "','" + FT009 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvFactory.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnFactoryInfoModify_Click_1(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y") == false)
                return;

            //確定要 Update 的帳號是否已存在資料庫
            FT001 = tbxFactoryCode.Text.Trim(); //廠房代號(Ft001)
            strSQL = "Select * From FACTORYS Where 1 = 1 And FT001 = '" + FT001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的廠房代號未存在，請確認後再執行修改作業。"); return; }

            // Update 資料進資料庫
            // PS：因廠房代號 是唯一值，不得修改。僅可刪除後再新增。
            FT002 = tbxFactoryName.Text;  //廠房名稱(FT002)
            
            strSQL = "Update FACTORYS Set FT002 = '" + FT002 + "',FT004 = '" + UserName + "',";
            strSQL += "FT006 = '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'";
            strSQL += "Where FT001 = '" + FT001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvFactory.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnFactoryInfoDelete_Click_1(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "N") == false)
                return;

            //確定要 Delete 的帳號是否已存在資料庫
            FT001 = tbxFactoryCode.Text.Trim(); //廠房代號(FT001)
            strSQL = "Select * From FACTORYS Where 1 = 1 And FT001 = '" + FT001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的帳號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            strSQL = "Delete From FACTORYS Where FT001 = '" + FT001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                    dgvFactory.DataSource = USQL.SQLSelect(ref da, strDemand);
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnFactoryInfoDemand_Click_1(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
            FT001 = tbxFactoryCode.Text.Trim();
            FT002 = tbxFactoryName.Text.Trim();

            strSQL = "Select FT001 as '廠房代號',";
            strSQL += "FT002 as '廠房名稱',";
            strSQL += "FT003 as '建立人員',";
            strSQL += "FT005 as '建立時間',";
            strSQL += "FT004 as '修改人員',";
            strSQL += "FT006 as '修改時間' ";
            strSQL += "From FACTORYS ";
            strSQL += "Where 1 = 1 ";
            if (FT001 != "")
                strSQL += "And FT001 = '" + FT001 + "' ";
            if (FT002 != "")
                strSQL += "And FT002 = '" + FT002 + "' ";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvFactory.DataSource = dt;

            //清空所有可填入欄位
            ClearForm();
        }

        private void dgvFactory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvFactory.Rows.Count > 0)
            {
                tbxFactoryCode.Text = dgvFactory.CurrentRow.Cells[0].Value.ToString().Trim(); //廠房代號 
                tbxFactoryName.Text = dgvFactory.CurrentRow.Cells[1].Value.ToString().Trim(); //廠房名稱
            }
        }
        private bool CheckData(string FT001, string FT002)
        {
            //*************************************************************************************
            //防呆專區
            //*************************************************************************************
            if (FT001 == "Y" && tbxFactoryCode.Text == "")
            { MessageBox.Show("廠房代號不可空白。"); return false; }
            if (FT002 == "Y" && tbxFactoryName.Text == "")
            { MessageBox.Show("廠房名稱不可空白。"); return false; }

            return true;
        }
        private void ClearForm()
        {
            //*************************************************************************************
            //清空資料專區
            //*************************************************************************************
            tbxFactoryCode.Text = "";
            tbxFactoryName.Text = "";
        }
    }
}
