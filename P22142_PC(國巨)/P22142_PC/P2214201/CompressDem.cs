using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Common;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class CompressDem : Form
    {
        //公用變數
        public string StartDate, EndDate, UserAccount, UserName, UserRole;
        int RowsNo;
        string strSQL, CheckDate;
        string FT001, FT002, CG001, CG002, MN001, MN002, CK001;
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans = null;
        UseSQLServer USQL = new UseSQLServer();

        public CompressDem()
        {
            InitializeComponent();
        }

        private void CompressDem_Load(object sender, EventArgs e)
        {
            //DataGridView 設定
            //....dgvCompressFrom
            dgvCompressFrom.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvCompressFrom.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvCompressFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //....dgvCompressTo
            dgvCompressTo.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvCompressTo.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvCompressTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //廠房名稱 下拉資料填入
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (int i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT002"].ToString().Trim());

            //類別名稱 下拉資料填入
            strSQL = "SELECT * FROM CATEGORYS WHERE CG001 = 'B'";
            dt = USQL.SQLSelect(ref da, strSQL);
            cbxCategorysName.Text = dt.Rows[0]["CG002"].ToString().Trim();
            CG001 = "B";
            CG002 = cbxCategorysName.Text;

            //dgvCompressFrom 所有欄位均不可編輯
            dgvCompressFrom.ReadOnly = true;
        }

        private void btnCompressDemModify_Click(object sender, EventArgs e)
        {//修改 功能區
            //參數
            int RDH001, dgvToNo;
            string ChangeValue;

            //dgvCompressTo 若沒有值，不可按此鈕。
            if (dgvCompressTo.Rows.Count <= 0)
                return;
            //記錄有Key值的變數
            FT002 = cbxFactoryCode.Text;
            CG002 = cbxCategorysName.Text;
            MN001 = cbxMachineCode.Text;
            //取得 RECORDS_HEADS 的表頭序號
            strSQL = "SELECT RDH001 FROM RECORDS_HEADS WHERE RDH003 = '" + FT002 + "' AND RDH005 = '" + CG002 + "' AND RDH006 = '" + MN001 + "' AND RDH008 = '" + CheckDate + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            for(int j = 0; j < dt.Rows.Count; j++)
            {
                RDH001 = int.Parse(dt.Rows[j]["RDH001"].ToString());
                //抓取 dgvCompressTo 資料，逐筆記錄修改值。
                dgvToNo = dgvCompressTo.Rows.Count;
                for (int i = 0; i < dgvToNo - 1; i++)
                {
                    CK001 = dgvCompressTo.Rows[i].Cells[0].Value.ToString().Trim();
                    ChangeValue = dgvCompressTo.Rows[i].Cells[5].Value.ToString().Trim();
                    //抓取 RECORDS_BODYS 資料，逐筆修改數值。
                    strSQL = "UPDATE RECORDS_BODYS SET RDB010 = '" + ChangeValue + "' WHERE RDB001 = " + RDH001 + " AND RDB003 = '" + CK001 + "'";

                    try
                    {
                        objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL);
                    }
                    catch (Exception Ex)
                    {
                        if (objTrans != null) objTrans.Rollback();
                        MessageBox.Show("更新修改數值出現問題，請確認後重新執行。系統訊息：" + Ex.Message, "更新修改數值");
                        return;
                    }
                }
            }
            if (objTrans != null) objTrans.Commit();
            MessageBox.Show("修改完成。");
            objTrans = null;
        }

        private void btnCompressDemDemand_Click(object sender, EventArgs e)
        {//查詢 功能區

            //防呆
            if (cbxFactoryCode.Text == "")
            { MessageBox.Show("請選擇廠房名稱。"); return; }
            if (cbxMachineCode.Text == "")
            { MessageBox.Show("請選擇機械代號。"); return; }
            //資料清空 & 選擇顯示
            ClearForm("", "", "Y", "Y");
            isEnable("N", "Y", "Y");
            //從外部取得搜尋起訖日期
            using (Query_Interval qi = new Query_Interval())
            {
                this.Visible = false;
                qi.Owner = this;
                qi.ShowDialog();

                StartDate = qi.StartDate;
                EndDate = qi.EndDate;

                qi.Close();
                qi.Dispose();
                this.Visible = true;
            }
            //透過區間抓取歷程記錄
            strSQL = "Select RDH008 as '巡檢日期',RDH003 as '廠房',RDH005 as '類別',RDH006 as '機械編號',RDH007 as '機械名稱' ";
            strSQL += "From RECORDS_HEADS ";
            strSQL += "Where RDH002 = '" + FT001 + "' And RDH004 = '" + CG001 + "' And RDH006 = '" + MN001 + "' ";
            if (StartDate != "" && EndDate != "")
                strSQL += "And RDH008 Between '" + StartDate + "' And '" + EndDate + "' ";
            strSQL += "GROUP BY RDH008,RDH003,RDH005,RDH006,RDH007 ";
            strSQL += "ORDER BY RDH008 ";

            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressFrom.DataSource = dt;
        }

        private void btnCompressDemExport_Click(object sender, EventArgs e)
        {//匯出Excel 功能區
            //參數
            //UseMicrosoftExcel UMEx = new UseMicrosoftExcel();
            UseNPOI NPOI = new UseNPOI();

            //從外部取得搜尋起訖日期
            using (Query_Interval qi = new Query_Interval())
            {
                this.Visible = false;
                qi.Owner = this;
                qi.ShowDialog();

                StartDate = qi.StartDate;
                EndDate = qi.EndDate;

                qi.Close();
                qi.Dispose();
                this.Visible = true;
            }

            //UMEx.RepRuning(StartDate, EndDate, "Compress");
            NPOI.RepRuning(StartDate, EndDate, "Compress");
            MessageBox.Show("報表匯出完成。");
        }

        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//廠房名稱下拉 功能區

            //資料清空 & 選擇顯示
            ClearForm("", "Y", "Y", "Y");
            isEnable("N", "Y", "Y");

            //廠房資訊記錄
            FT002 = cbxFactoryCode.Text.Trim();
            FT001 = USQL.FindFT("", FT002);
            //機械編號下拉 資料填入
            strSQL = "Select MN001 From MECHNUMBERS Where MN003 = '" + FT001 + "' And MN004 = 'B'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (int i = 0; i < RowsNo; i++)
                cbxMachineCode.Items.Add(dt.Rows[i]["MN001"].ToString().Trim());
        }

        private void cbxMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {//機械編號下拉 功能區

            //資料清空 & 選擇顯示
            ClearForm("", "", "Y", "Y");
            isEnable("N", "Y", "Y");

            //機械資訊記錄
            MN001 = cbxMachineCode.Text.Trim();
            MN002 = USQL.FindMN(MN001, "");
            //填入機械名稱
            tbxMachineName.Text = MN002;
        }

        private void dgvCompressFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //參數
            int RDH001, dgvToNo;

            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvCompressFrom.Rows.Count > 0)
            {
                CheckDate = dgvCompressFrom.CurrentRow.Cells[0].Value.ToString().Trim(); //巡檢日期
                FT002 = dgvCompressFrom.CurrentRow.Cells[1].Value.ToString().Trim();     //廠房名稱
                CG002 = dgvCompressFrom.CurrentRow.Cells[2].Value.ToString().Trim();     //類別名稱
                MN001 = dgvCompressFrom.CurrentRow.Cells[3].Value.ToString().Trim();     //機械代號
                if (CheckDate != "")
                {
                    //....取得 RECORDS_BODYS 資訊填入 dgvVacuumTo
                    strSQL = "SELECT b.RDB003 as '系統代號',b.RDB004 as '檢查項目名稱',b.RDB008 as '備註1',b.RDB009 as '備註2',(b.RDB005 + b.RDB006 + b.RDB007) as '參考值起訖',b.RDB010 as '記錄資料' ";
                    strSQL += "FROM RECORDS_HEADS a,RECORDS_BODYS b ";
                    strSQL += "WHERE a.RDH001 = b.RDB001 ";
                    strSQL += "AND a.RDH008 = '" + CheckDate + "' AND a.RDH003 = '" + FT002 + "' AND RDH005 = '" + CG002 + "' AND RDH006 = '" + MN001 + "'";
                    strSQL += "GROUP BY b.RDB003,b.RDB004,b.RDB008,b.RDB009,b.RDB005,b.RDB006,b.RDB007,b.RDB010 ";
                    dt = USQL.SQLSelect(ref da, strSQL);
                    dgvCompressTo.DataSource = dt;
                    //dgvVacuumTo 僅 記錄資料 可供修改，其餘欄位均不可變更。
                    if (dgvCompressTo.Rows.Count > 0)
                    {
                        dgvToNo = dgvCompressTo.ColumnCount;
                        for (int i = 0; i < dgvToNo - 1; i++)
                            dgvCompressTo.Columns[i].ReadOnly = true;
                    }
                    //修改、匯出 可按，查詢 不可按
                    isEnable("Y", "Y", "Y");
                }
            }
        }

        private void ClearForm(string FT, string MN, string dgvF, string dgvT)
        {//用來清空畫面
            if (FT == "Y")
                cbxFactoryCode.Text = ""; //廠房名稱
            if (MN == "Y")
            {
                cbxMachineCode.Text = ""; //機械編號
                cbxMachineCode.Items.Clear();
                tbxMachineName.Text = ""; //機械名稱
            }
            if (dgvF == "Y")
                dgvCompressFrom.Columns.Clear(); //dgvVacuumFrom
            if (dgvT == "Y")
                dgvCompressTo.Columns.Clear(); //dgvVacuumFrom
        }

        private void isEnable(string btnModify, string btnDemand, string btnExport)
        {//OP可使用 查詢、匯出Excel
            if (UserRole == "OP")
                btnCompressDemModify.Enabled = false;
            else if (btnModify == "Y")
                btnCompressDemModify.Enabled = true;
            else if (btnModify == "N")
                btnCompressDemModify.Enabled = false;

            if (btnDemand == "Y")
                btnCompressDemDemand.Enabled = true;
            else if (btnDemand == "N")
                btnCompressDemDemand.Enabled = false;

            if (btnExport == "Y")
                btnCompressDemExport.Enabled = true;
            else if (btnExport == "N")
                btnCompressDemExport.Enabled = false;
        }
    }
}
