using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Common;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class HydropowerDem : Form
    {
        //公用變數
        public string StartDate, EndDate, UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        int RowsNo;
        string strSQL, CheckDate;
        string FT001, FT002, CG001, CG002, CK001;
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans = null;
        UseSQLServer USQL = new UseSQLServer();
        DealRecord drc = new DealRecord();
        
        public HydropowerDem()
        {
            InitializeComponent();
        }

        private void HydropowerDem_Resize(object sender, EventArgs e)
        {
            int NewX, NewY;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvHydropowerFrom.Width = Convert.ToInt32(x * dgvHydropowerFrom.Width);
                dgvHydropowerFrom.Height = Convert.ToInt32(y * dgvHydropowerFrom.Height);

                dgvHydropowerTo.Width = Convert.ToInt32(x * dgvHydropowerTo.Width);
                dgvHydropowerTo.Height = Convert.ToInt32(y * dgvHydropowerTo.Height);

                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);

                gbxShow1.Width = Convert.ToInt32(x * gbxShow1.Width);
                gbxShow1.Height = Convert.ToInt32(y * gbxShow1.Height);
                NewY = gbxFun.Height;
                gbxShow1.Location = new Point(gbxShow1.Location.X, NewY);

                gbxShow2.Width = Convert.ToInt32(x * gbxShow2.Width);
                gbxShow2.Height = Convert.ToInt32(y * gbxShow2.Height);
                NewY = gbxFun.Height + gbxShow1.Height;
                gbxShow2.Location = new Point(gbxShow2.Location.X, NewY);

                NewX = (int)(btnHydropowerDemModify.Location.X * x + btnHydropowerDemModify.Width * (x - 1));
                btnHydropowerDemModify.Location = new Point(NewX, btnHydropowerDemModify.Location.Y);
                btnHydropowerDemModify.Width = Convert.ToInt32(x * btnHydropowerDemModify.Width);
                btnHydropowerDemModify.Height = Convert.ToInt32(y * btnHydropowerDemModify.Height);

                NewX = (int)(btnHydropowerDemDemand.Location.X * x + btnHydropowerDemDemand.Width * (x - 1));
                btnHydropowerDemDemand.Location = new Point(NewX, btnHydropowerDemDemand.Location.Y);
                btnHydropowerDemDemand.Width = Convert.ToInt32(x * btnHydropowerDemDemand.Width);
                btnHydropowerDemDemand.Height = Convert.ToInt32(y * btnHydropowerDemDemand.Height);

                NewX = (int)(btnHydropowerDemExport.Location.X * x + btnHydropowerDemExport.Width * (x - 1));
                btnHydropowerDemExport.Location = new Point(NewX, btnHydropowerDemExport.Location.Y);
                btnHydropowerDemExport.Width = Convert.ToInt32(x * btnHydropowerDemExport.Width);
                btnHydropowerDemExport.Height = Convert.ToInt32(y * btnHydropowerDemExport.Height);
            }
        }

        private void HydropowerDem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void HydropowerDem_Load(object sender, EventArgs e)
        {
            //DataGridView 設定
            //....dgvAirConditionFrom
            drc.SetDataGridView(ref dgvHydropowerFrom);

            //....dgvAirConditionTo
            drc.SetDataGridView(ref dgvHydropowerTo);

            //廠房名稱 下拉資料填入
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (int i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT002"].ToString().Trim());

            //類別名稱 下拉資料填入
            strSQL = "SELECT * FROM CATEGORYS WHERE CG001 = 'D'";
            dt = USQL.SQLSelect(ref da, strSQL);
            cbxCategorysName.Text = dt.Rows[0]["CG002"].ToString().Trim();
            CG001 = "D";
            CG002 = cbxCategorysName.Text;

            //dgvCompressFrom 所有欄位均不可編輯
            dgvHydropowerFrom.ReadOnly = true;
        }

        private void btnHydropowerDemModify_Click(object sender, EventArgs e)
        {//修改 功能區
            //參數
            int RDH001, dgvToNo;
            string ChangeValue;

            //dgvCompressTo 若沒有值，不可按此鈕。
            if (dgvHydropowerTo.Rows.Count <= 0)
                return;
            //記錄有Key值的變數.
            FT002 = dgvHydropowerFrom.CurrentRow.Cells[1].Value.ToString().Trim();     //廠房名稱
            CG002 = dgvHydropowerFrom.CurrentRow.Cells[2].Value.ToString().Trim();     //類別名稱
            //取得 RECORDS_HEADS 的表頭序號
            strSQL = "SELECT RDH001 FROM RECORDS_HEADS WHERE RDH003 = '" + FT002 + "' AND RDH005 = '" + CG002 + "' AND RDH008 = '" + CheckDate + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                RDH001 = int.Parse(dt.Rows[j]["RDH001"].ToString());
                //抓取 dgvHydropowerTo 資料，逐筆記錄修改值。
                dgvToNo = dgvHydropowerTo.Rows.Count;
                for (int i = 0; i < dgvToNo - 1; i++)
                {
                    CK001 = dgvHydropowerTo.Rows[i].Cells[0].Value.ToString().Trim();
                    ChangeValue = dgvHydropowerTo.Rows[i].Cells[5].Value.ToString().Trim();
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

        private void btnHydropowerDemDemand_Click(object sender, EventArgs e)
        {//查詢 功能區
            
            //資料清空 & 選擇顯示
            ClearForm("", "Y", "Y");
            isEnable("N", "Y", "Y");
            //記錄時間區間
            StartDate = dtpStart.Value.ToString("yyyy/MM/dd");
            EndDate = dtpEnd.Value.ToString("yyyy/MM/dd");
            //填入 KEY 值
            FT002 = cbxFactoryCode.Text.Trim();
            //透過區間抓取歷程記錄
            strSQL = "Select RDH008 as '巡檢日期',RDH003 as '廠房',RDH005 as '類別' ";
            strSQL += "From RECORDS_HEADS ";
            strSQL += "WHERE RDH008 Between '" + StartDate + "' And '" + EndDate + "' ";
            strSQL += "AND RDH004 = '" + CG001 + "' ";
            if (FT002 != "")
                strSQL += "AND RDH002 = '" + FT001 + "' ";
            strSQL += "GROUP BY RDH008,RDH003,RDH005 ";
            strSQL += "ORDER BY RDH008 ";

            dt = USQL.SQLSelect(ref da, strSQL);
            dgvHydropowerFrom.DataSource = dt;
            dgvHydropowerFrom.ClearSelection();
        }

        private void btnHydropowerDemExport_Click(object sender, EventArgs e)
        {//匯出Excel 功能區
            //參數
            string NewStartDate = "";
            UseNPOI NPOI = new UseNPOI();

            //從外部取得搜尋起訖日期
            using (Query_Interval qi = new Query_Interval())
            {
                this.Visible = false;
                qi.Owner = this;
                qi.ShowDialog();

                StartDate = qi.StartDate;
                EndDate = qi.EndDate;

                if(qi.DialogResult == DialogResult.OK)
                {
                    //取得起始日期往前最近的一天
                    strSQL = "SELECT ISNULL(MAX(RDH008),null) as MAXRDH008 ";
                    strSQL += "FROM RECORDS_HEADS ";
                    strSQL += "WHERE RDH008 < '" + StartDate + "' AND RDH004 = 'D' ";
                    dt = USQL.SQLSelect(ref da, strSQL);
                    NewStartDate = dt.Rows[0]["MAXRDH008"].ToString();
                    if (NewStartDate != "")
                    {
                        StartDate = NewStartDate;
                        NPOI.RepHydropower(StartDate, EndDate, "Y");
                    }
                    else
                        NPOI.RepHydropower(StartDate, EndDate, "N");
                    MessageBox.Show("報表匯出完成。");
                }

                qi.Close();
                qi.Dispose();
                this.Visible = true;
            }
        }

        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//廠房名稱下拉 功能區

            //資料清空 & 選擇顯示
            ClearForm("", "Y", "Y");
            isEnable("N", "Y", "Y");

            //廠房資訊記錄
            FT002 = cbxFactoryCode.Text.Trim();
            FT001 = USQL.FindFT("", FT002);
        }
        

        private void dgvVacuumFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //參數
            int i, dgvToNo;

            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvHydropowerFrom.Rows.Count > 0)
            {
                CheckDate = dgvHydropowerFrom.CurrentRow.Cells[0].Value.ToString().Trim(); //巡檢日期
                FT002 = dgvHydropowerFrom.CurrentRow.Cells[1].Value.ToString().Trim();     //廠房名稱
                CG002 = dgvHydropowerFrom.CurrentRow.Cells[2].Value.ToString().Trim();     //類別名稱
                if (CheckDate != "")
                {
                    //....取得 RECORDS_BODYS 資訊填入 dgvHydropowerTo
                    strSQL = "SELECT b.RDB003 as '系統代號',b.RDB004 as '檢查項目名稱',b.RDB008 as '備註1',b.RDB009 as '備註2',(b.RDB005 + b.RDB006 + b.RDB007) as '參考值起訖',b.RDB010 as '記錄資料' ";
                    strSQL += "FROM RECORDS_HEADS a,RECORDS_BODYS b ";
                    strSQL += "WHERE a.RDH001 = b.RDB001 ";
                    strSQL += "AND a.RDH008 = '" + CheckDate + "' AND a.RDH003 = '" + FT002 + "' AND RDH005 = '" + CG002 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);
                    dgvHydropowerTo.DataSource = dt;
                    dgvHydropowerTo.ClearSelection();
                    //dgvHydropowerTo 僅 記錄資料 可供修改，其餘欄位均不可變更。
                    if (dgvHydropowerTo.Rows.Count > 0)
                    {
                        dgvToNo = dgvHydropowerTo.ColumnCount;
                        for (i = 0; i < dgvToNo - 1; i++)
                            dgvHydropowerTo.Columns[i].ReadOnly = true;
                    }
                    //修改、匯出 可按，查詢 不可按
                    isEnable("Y", "Y", "Y");
                }
            }
        }

        private void ClearForm(string FT, string dgvF, string dgvT)
        {//用來清空畫面
            if (FT == "Y")
                cbxFactoryCode.Text = ""; //廠房名稱
            if (dgvF == "Y")
                dgvHydropowerFrom.Columns.Clear(); //dgvVacuumFrom
            if (dgvT == "Y")
                dgvHydropowerTo.Columns.Clear(); //dgvVacuumFrom
        }

        private void isEnable(string btnModify, string btnDemand, string btnExport)
        {//OP可使用 查詢、匯出Excel
            if (UserRole == "OP")
                btnHydropowerDemModify.Enabled = false;
            else if (btnModify == "Y")
                btnHydropowerDemModify.Enabled = true;
            else if (btnModify == "N")
                btnHydropowerDemModify.Enabled = false;

            if (btnDemand == "Y")
                btnHydropowerDemDemand.Enabled = true;
            else if (btnDemand == "N")
                btnHydropowerDemDemand.Enabled = false;

            if (btnExport == "Y")
                btnHydropowerDemExport.Enabled = true;
            else if (btnExport == "N")
                btnHydropowerDemExport.Enabled = false;
        }
    }
}
