using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class CompressRep : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        string FT001, CG001, CG002, MN001, MN002;
        string CAH001, CAH002, CAH003, CAH004, CAH005, CAH006, CAH007, CAH008, CAH009, CAH010, CAH011;
        string CAB001, CAB002, CAB003, CAB004, CAB005, CAB006, CAB007, CAB008, CAB009, CAB010, CAB011, CAB012, CAB013, CAB014, CAB015;
        string[] arrCGA = new string[300];

        public CompressRep()
        {
            InitializeComponent();
        }

        private void CompressRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvCompressFrom
            dgvCompressFrom.ReadOnly = true;
            dgvCompressFrom.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvCompressFrom.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
            dgvCompressFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //....dgvCompressTo
            dgvCompressTo.ReadOnly = true;
            dgvCompressTo.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            dgvCompressTo.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 6, FontStyle.Regular);
            dgvCompressTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("廠房資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "Select CG002 From CATEGORYS Where CG001 = 'B'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("類別資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());
            cbxCategorysName.Text = dt.Rows[i - 1]["CG002"].ToString().Trim();
        }

        private void btnCompressRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************
         //參數
            int i, MaxCAH, MaxCAB, arrNo;
            string strSQL, strMaxCAH, strMaxCAB, CK001;

            //寫入資料庫_HEADS
            strSQL = "Select ISNULL(Max(CAH001),'CAH_00000') as MaxCAH001 From COMPRESSEDAIR_HEADS";
            dt = USQL.SQLSelect(ref da, strSQL);
            strMaxCAH = dt.Rows[0]["MaxCAH001"].ToString();
            MaxCAH = int.Parse(strMaxCAH.Substring(4, 5)) + 1;

            CAH001 = "CAH_" + MaxCAH.ToString().PadLeft(5, '0');   //流水序號(CAH001)
            CAH002 = cbxFactoryCode.Text;                          //廠房代號(CAH002)
            CAH003 = cbxCategorysName.Text;                        //類別代號(CAH003)
            CAH004 = cbxMachineCode.Text;                          //機械編號代號 (CAH004)
            CAH005 = tbxMachineName.Text;                          //機械編號名稱(CAH005)
            CAH006 = UserName;                                     //建立者(CAH006)
            CAH007 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //建立時間(CAH007)
            CAH008 = "";                                           //備用(CAH008)
            CAH009 = "";                                           //備用(CAH009)
            CAH010 = "";                                           //備用(CAH010)
            CAH011 = "Y";                                          //是否仍然使用(CAH011)

            strSQL = "Insert into COMPRESSEDAIR_HEADS (CAH001,CAH002,CAH003,CAH004,CAH005,CAH006,CAH007,CAH008,CAH009,CAH010,CAH011) Values ('";
            strSQL += CAH001 + "','" + CAH002 + "','" + CAH003 + "','" + CAH004 + "','" + CAH005 + "','" + CAH006 + "','" + CAH007 + "','";
            strSQL += CAH008 + "','" + CAH009 + "','" + CAH010 + "','" + CAH011 + "')";

            try
            { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
            catch (Exception Ex)
            {
                objTrans.Rollback();
                MessageBox.Show("Insert Into COMPRESSEDAIR_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COMPRESSEDAIR_HEADS");
                return;
            }

            //寫入資料庫_BODYS
            //....記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //....計算下一序號值
            strSQL = "Select ISNULL(Max(CAB001),'CAB_00000') as MaxCAB001 From COMPRESSEDAIR_BODYS Where CAB001 = '" + CAH001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            strMaxCAB = dt.Rows[0]["MaxCAB001"].ToString();
            MaxCAB = int.Parse(strMaxCAB.Substring(4, 5)) + 1;
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    CAB003 = arrCGA[i]; //檢查項目代號(VMB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + CAB003 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    CAB001 = CAH001; //Head序號(VMB001)
                    CAB002 = "CAB_" + MaxCAB.ToString().PadLeft(5, '0'); //流水序號(VMB002)
                    CAB004 = dt.Rows[0]["CK002"].ToString(); //檢查項目名稱(VMB004)
                    CAB005 = dt.Rows[0]["CK003"].ToString(); //參考 起(VMB005)
                    CAB006 = dt.Rows[0]["CK004"].ToString(); //中間符號(VMB006）
                    CAB007 = dt.Rows[0]["CK005"].ToString(); //參考 迄(VMB007)
                    CAB008 = dt.Rows[0]["CK006"].ToString(); //備註1(VMB008)
                    CAB009 = dt.Rows[0]["CK007"].ToString(); //備註2(VMB009)
                    CAB010 = dt.Rows[0]["CK008"].ToString(); //建立者(VMB010)
                    CAB011 = dt.Rows[0]["CK010"].ToString(); //建立時間(VMB011)
                    CAB012 = dt.Rows[0]["CK012"].ToString(); //備用(VMB012)
                    CAB013 = dt.Rows[0]["CK013"].ToString(); //備用(VMB013)
                    CAB014 = dt.Rows[0]["CK014"].ToString(); //備用(VMB014)
                    CAB015 = "N";                            //是否作廢(VMB015)

                    strSQL = "Insert into COMPRESSEDAIR_BODYS (CAB001,CAB002,CAB003,CAB004,CAB005,CAB006,CAB007,CAB008,CAB009,CAB010,CAB011,CAB012,CAB013,CAB014,CAB015) Values ('";
                    strSQL += CAB001 + "','" + CAB002 + "','" + CAB003 + "','" + CAB004 + "','" + CAB005 + "','" + CAB006 + "','" + CAB007 + "','" + CAB008 + "','";
                    strSQL += CAB009 + "','" + CAB010 + "','" + CAB011 + "','" + CAB012 + "','" + CAB013 + "','" + CAB014 + "','" + CAB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        objTrans.Rollback();
                        MessageBox.Show("Insert Into COMPRESSEDAIR_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COMPRESSEDAIR_BODYS");
                        return;
                    }

                    MaxCAB++;
                }
                else
                    break;
            }

            //寫入資料庫
            if (objTrans != null)
                objTrans.Commit();
            //新增按鈕 Enable = false
            btnCompressRepAdd.Enabled = false;
            //畫面清空
            cbxFactoryCode.Text = "";
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
            dgvCompressFrom.Columns.Clear();
            dgvCompressTo.Columns.Clear();
        }

        private void btnCompressRepModify_Click(object sender, EventArgs e)
        {//********************************************************************
         //修改 功能
         //將所有 是否作廢 欄位值填回資料庫
         //********************************************************************
         //參數
            int i, RowNo;
            string strSQL;

            // dgvCompressTo 資料列數
            RowNo = dgvCompressTo.Rows.Count; //注意:其中包含完全無值的最後一行空白列
            //找出 標頭 檔編號
            strSQL = "Select CAH001 From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG002 + "' And CAH004 = '" + MN001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            CAB001 = dt.Rows[0]["CAH001"].ToString();
            //逐筆將 是否作廢 填回資料庫
            for (i = 0; i < RowNo - 1; i++)
            {
                CAB003 = dgvCompressTo.Rows[i].Cells[1].Value.ToString(); //檢查項目代號
                CAB015 = dgvCompressTo.Rows[i].Cells[6].Value.ToString(); //是否作廢
                strSQL = "Update COMPRESSEDAIR_BODYS Set CAB015 = '" + CAB015 + "' Where CAB001 = '" + CAB001 + "' And CAB003 = '" + CAB003 + "'";
                try
                { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                catch (Exception Ex)
                {
                    objTrans.Rollback();
                    MessageBox.Show("修改作廢資料變更有誤，請確認後重新執行。系統錯誤訊息：" + Ex.Message, "修改作廢資料變更");
                    return;
                }
            }
            MessageBox.Show("資料修改完成。");
            //寫入資料庫
            if (objTrans != null)
                objTrans.Commit();
        }

        private void btnCompressRepDelete_Click(object sender, EventArgs e)
        {//********************************************************************
         //刪除 功能
         //1.VACUUM_HEADS 資料作廢，但不刪除。
         //2.VACUUM_BODYS 資料不變動。
         //3.單位機械編號資料 資料作廢，但不刪除。
         //********************************************************************
            //參數
            string strSQL;

            //避免誤刪，請客戶重覆確認。
            DialogResult = MessageBox.Show("請確認是否執行刪除動作", "刪除動作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                return;
            //找出 標頭 檔編號
            strSQL = "Select CAH001 From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG002 + "' And CAH004 = '" + MN001 + "' And CAH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            CAB001 = dt.Rows[0]["CAH001"].ToString();
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update COMPRESSEDAIR_HEADS Set CAH011 = 'N' Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG002 + "' And CAH004 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update MECHNUMBERS Set MN012 = 'N' Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);
            //清空畫面
            tbxMachineName.Text = "";
            cbxMachineCode.Text = "";
            cbxFactoryCode.Text = "";
            dgvCompressTo.Columns.Clear();
            dgvCompressFrom.Columns.Clear();
            //向左 向右 按鈕可見
            btnRight.Visible = true;
            btnLeft.Visible = true;
        }
        
        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 廠房代號
            //參數
            int i, RowsNo;
            string strSQL;

            //記錄有 Key 值的資料
            FT001 = cbxFactoryCode.Text;
            CG002 = cbxCategorysName.Text;
            CG001 = USQL.FindCG("", CG002);
            //填入 機械編號(cbxMachineCode)
            strSQL = "Select * From MECHNUMBERS Where MN004 = '" + CG001 + "' And MN003 = '" + FT001 + "' Order by MN001 ";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("機械資訊尚未建置完成，請先行建置。"); return; }

            cbxMachineCode.Items.Clear();
            for (i = 0; i < RowsNo; i++)
                cbxMachineCode.Items.Add(dt.Rows[i]["MN001"].ToString().Trim());
            //清空
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 機械編號，並寫入 機械名稱(tbxMachineName)
            //參數
            string strSQL;

            //記錄有 Key 值的資料
            MN001 = cbxMachineCode.Text;
            MN002 = USQL.FindMN(MN001, "");
            tbxMachineName.Text = MN002;
            //列出所有檢查項目
            //....dgvCompressFrom
            strSQL = drc.DGVShowSQL("Compress_CHECKITEMS", 1, arrCGA, "", "");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressFrom.DataSource = dt;
            //....dgvCompressTo
            //........先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG002 + "' And CAH004 = '" + MN001 + "' And CAH011 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);
            //清空 dgvVacuumTo
            dgvCompressTo.Columns.Clear();
            if (dt.Rows.Count > 0)
            {
                //帶出 表身檔 資料
                CAH001 = dt.Rows[0]["CAH001"].ToString();
                strSQL = drc.DGVShowSQL("Compress_COMPRESSEDAIR_BODYS", 0, arrCGA, CAH001, "");
                dt = USQL.SQLSelect(ref da, strSQL);

                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvCompressTo.Columns.Add(colFrom);

                dgvCompressTo.DataSource = dt;

                //隱藏 btnLeft 及 btnRight
                btnLeft.Visible = false;
                btnRight.Visible = false;
                //刪除 按鈕可按
                btnCompressRepDelete.Enabled = true;
            }
            else
            {
                //帶出 空白 資料
                strSQL = "";
                strSQL += "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvCompressTo.DataSource = dt;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //刪除 按鈕不可按
                btnCompressRepDelete.Enabled = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvCompressFrom 選至 dgvCompressTo
            //參數
            string strSQL;

            //將 dgvCompressFrom 選取的資料移到 dgvCompressTo
            //....目前選到的值的項目代號
            string KeyValue = dgvCompressFrom.CurrentRow.Cells[0].Value.ToString();
            //....利用串出的文字組成 SQL 填入 dgvCompressTo
            strSQL = drc.DGVShowSQL("Compress_CHECKITEMS", 2, arrCGA, KeyValue, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressTo.DataSource = dt;
            //dgvCompressFrom 往 dgvCompressTo 丟值時，新增按鈕可使用
            btnCompressRepAdd.Enabled = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvCompressTo 選至 dgvCompressFrom
            //參數
            string strSQL;

            //將 dgvCompressFrom 選取的資料移到 dgvCompressTo
            //....目前選到的值的項目代號
            string KeyValue = dgvCompressTo.CurrentRow.Cells[0].Value.ToString();
            //....利用串出的文字組成 SQL 填入 dgvCompressTo
            strSQL = drc.DGVShowSQL("Compress_CHECKITEMS", 2, arrCGA, KeyValue, "OUT");

            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressTo.DataSource = dt;
            //dgvCompressTo 回傳值到 dgvCompressFrom，並且 dgvCompressTo 已沒有值時，新增按鈕消失
            if (dt.Rows.Count == 0)
                btnCompressRepAdd.Enabled = false;
        }

        private void dgvCompressTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//處理 dgvVacuumTo 作廢 按鈕執行狀況
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
                return;
            else if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                CAB015 = grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (CAB015 == "N")
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                else
                    grid.Rows[e.RowIndex].Cells[6].Value = "N";
            }
            //修改 按鈕可使用
            btnCompressRepModify.Enabled = true;
        }
    }
}
