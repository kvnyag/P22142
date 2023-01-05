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
        public double oldWidth, oldHeight, newWidth, newHeight;
        int RowsNo;
        string strSQL, CheckDate;
        string FT001, FT002, CG001, CG002, MN001, MN002, CK001;
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans = null;
        UseSQLServer USQL = new UseSQLServer();
        DealRecord drc = new DealRecord();

        public CompressDem()
        {
            InitializeComponent();
        }
        
        private void CompressDem_Resize(object sender, EventArgs e)
        {
            int NewX, NewY;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvCompressFrom.Width = Convert.ToInt32(x * dgvCompressFrom.Width);
                dgvCompressFrom.Height = Convert.ToInt32(y * dgvCompressFrom.Height);

                dgvCompressTo.Width = Convert.ToInt32(x * dgvCompressTo.Width);
                dgvCompressTo.Height = Convert.ToInt32(y * dgvCompressTo.Height);

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

                NewX = (int)(btnCompressDemModify.Location.X * x + btnCompressDemModify.Width * (x - 1));
                btnCompressDemModify.Location = new Point(NewX, btnCompressDemModify.Location.Y);
                btnCompressDemModify.Width = Convert.ToInt32(x * btnCompressDemModify.Width);
                btnCompressDemModify.Height = Convert.ToInt32(y * btnCompressDemModify.Height);

                NewX = (int)(btnCompressDemDemand.Location.X * x + btnCompressDemDemand.Width * (x - 1));
                btnCompressDemDemand.Location = new Point(NewX, btnCompressDemDemand.Location.Y);
                btnCompressDemDemand.Width = Convert.ToInt32(x * btnCompressDemDemand.Width);
                btnCompressDemDemand.Height = Convert.ToInt32(y * btnCompressDemDemand.Height);

                NewX = (int)(btnCompressDemExport.Location.X * x + btnCompressDemExport.Width * (x - 1));
                btnCompressDemExport.Location = new Point(NewX, btnCompressDemExport.Location.Y);
                btnCompressDemExport.Width = Convert.ToInt32(x * btnCompressDemExport.Width);
                btnCompressDemExport.Height = Convert.ToInt32(y * btnCompressDemExport.Height);
            }
        }

        private void CompressDem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void CompressDem_Load(object sender, EventArgs e)
        {
            //DataGridView 設定
            //....dgvCompressFrom
            drc.SetDataGridView(ref dgvCompressFrom);

            //....dgvCompressTo
            drc.SetDataGridView(ref dgvCompressTo);

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
            FT002 = dgvCompressFrom.CurrentRow.Cells[1].Value.ToString().Trim();     //廠房名稱
            CG002 = dgvCompressFrom.CurrentRow.Cells[2].Value.ToString().Trim();     //類別名稱
            MN001 = dgvCompressFrom.CurrentRow.Cells[3].Value.ToString().Trim();     //機械代號
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
            
            //資料清空 & 選擇顯示
            ClearForm("", "", "Y", "Y");
            isEnable("N", "Y", "Y");
            //記錄時間區間
            StartDate = dtpStart.Value.ToString("yyyy/MM/dd");
            EndDate = dtpEnd.Value.ToString("yyyy/MM/dd");
            //填入 KEY 值
            FT002 = cbxFactoryCode.Text.Trim();
            MN001 = cbxMachineCode.Text.Trim();
            //透過區間抓取歷程記錄
            strSQL = "Select RDH008 as '巡檢日期',RDH003 as '廠房',RDH005 as '類別',RDH006 as '機械編號',RDH007 as '機械名稱' ";
            strSQL += "From RECORDS_HEADS ";
            strSQL += "WHERE RDH008 Between '" + StartDate + "' And '" + EndDate + "' ";
            strSQL += "AND RDH004 = '" + CG001 + "' ";
            if (FT002 != "")
                strSQL += "AND RDH002 = '" + FT001 + "'";
            if (MN001 != "")
                strSQL += "AND RDH006 = '" + MN001 + "' ";
            strSQL += "GROUP BY RDH008,RDH003,RDH005,RDH006,RDH007 ";
            strSQL += "ORDER BY RDH008 ";

            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressFrom.DataSource = dt;
            dgvCompressFrom.ClearSelection();
        }

        private void btnCompressDemExport_Click(object sender, EventArgs e)
        {//匯出Excel 功能區
            //參數
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
                    NPOI.RepRuning(StartDate, EndDate, "Compress");
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
                    dgvCompressTo.ClearSelection();
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
