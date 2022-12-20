using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class HydropowerRep : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        int WEH001, WEB001, WEB002;
        string FT001, CG001, CG002;
        string WEH002, WEH003, WEH004, WEH005, WEH006, WEH007, WEH008, WEH009;
        string WEB003, WEB004, WEB005, WEB006, WEB007, WEB008, WEB009, WEB010, WEB011, WEB012, WEB013, WEB014, WEB015;
        string[] arrCGA = new string[300];
        CheckBox ckHeader_From = new CheckBox();
        CheckBox ckHeader_To = new CheckBox();
        Rectangle rect_From, rect_To;



        public HydropowerRep()
        {
            InitializeComponent();
        }
        private void HydropowerRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvAirConditionFrom
            dgvHydropowerFrom.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            dgvHydropowerFrom.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 6, FontStyle.Regular);
            dgvHydropowerFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //....dgvAirConditionTo
            dgvHydropowerTo.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            dgvHydropowerTo.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 6, FontStyle.Regular);
            dgvHydropowerTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("廠房資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "Select CG002 From CATEGORYS Where CG001 = 'D'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("類別資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());
            cbxCategorysName.Text = dt.Rows[i - 1]["CG002"].ToString().Trim();
        }
        private void btnHydropowerRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************
         //參數
            int i, MaxWEB, arrNo;
            string strSQL;

            //記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //取得 WATERELC_BODYS 下一序號
            strSQL = "Select ISNULL(MAX(WEB002),0) as WEB002 From WATERELC_BODYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxWEB = int.Parse(dt.Rows[0]["WEB002"].ToString()) + 1;
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    //寫入資料庫_BODYS
                    WEB003 = arrCGA[i]; //檢查項目代號(COB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + WEB003 + "' And CK017 = 'Y'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    WEB001 = MaxWEB + i;                                 //表頭流水序號(WEB001)
                    WEB002 = MaxWEB + i;                                 //流水序號(WEB002)
                    WEB004 = dt.Rows[0]["CK002"].ToString();             //檢查項目名稱(WEB004)
                    WEB005 = dt.Rows[0]["CK003"].ToString();             //參考 起(WEB005)
                    WEB006 = dt.Rows[0]["CK004"].ToString();             //中間符號(WEB006）
                    WEB007 = dt.Rows[0]["CK005"].ToString();             //參考 迄(WEB007)
                    WEB008 = dt.Rows[0]["CK006"].ToString();             //備註1(WEB008)
                    WEB009 = dt.Rows[0]["CK007"].ToString();             //備註2(WEB009)
                    WEB010 = dt.Rows[0]["CK008"].ToString();             //建立者(WEB010)
                    WEB011 = dt.Rows[0]["CK010"].ToString();             //建立時間(WEB011)
                    WEB012 = dt.Rows[0]["CK012"].ToString();             //備用(WEB012)
                    WEB013 = dt.Rows[0]["CK013"].ToString();             //備用(WEB013)
                    WEB014 = dt.Rows[0]["CK014"].ToString();             //備用(WEB014)
                    WEB015 = "N";                                        //是否作廢(WEB015)

                    strSQL = "INSERT INTO WATERELC_BODYS (WEB001,WEB002,WEB003,WEB004,WEB005,WEB006,WEB007,WEB008,WEB009,WEB010,WEB011,WEB012,WEB013,WEB014,WEB015) Values (";
                    strSQL += WEB001 + ","   + WEB002 + ",'"  + WEB003 + "','" + WEB004 + "','" + WEB005 + "','" + WEB006 + "','" + WEB007 + "','" + WEB008 + "','";
                    strSQL += WEB009 + "','" + WEB010 + "','" + WEB011 + "','" + WEB012 + "','" + WEB013 + "','" + WEB014 + "','" + WEB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        if (objTrans != null)
                            objTrans.Rollback();
                        MessageBox.Show("INSERT INTO WATERELC_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into WATERELC_BODYS");
                        return;
                    }
                    
                    //寫入資料庫_HEADS
                    WEH001 = MaxWEB + i;                                   //流水序號(WEH001)
                    WEH002 = cbxFactoryCode.Text;                          //廠房代號(WEH002)
                    WEH003 = USQL.FindCG("", cbxCategorysName.Text);       //類別代號(WEH003)
                    WEH004 = UserName;                                     //建立者(WEH004)
                    WEH005 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //建立時間(WEH005)
                    WEH006 = "";                                           //備用(WEH006)
                    WEH007 = "";                                           //備用(WEH007)
                    WEH008 = "";                                           //備用(WEH008)
                    WEH009 = "Y";                                          //是否仍然使用(WEH009)
                    
                    strSQL = "INSERT INTO WATERELC_HEADS (WEH001,WEH002,WEH003,WEH004,WEH005,WEH006,WEH007,WEH008,WEH009) Values (";
                    strSQL += WEH001 + ",'"  + WEH002 + "','" + WEH003 + "','" + WEH004 + "','" + WEH005 + "','" + WEH006 + "','" + WEH007 + "','";
                    strSQL += WEH008 + "','" + WEH009 + "');";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        if (objTrans != null)
                            objTrans.Rollback();
                        MessageBox.Show("INSERT INTO WATERELC_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into WATERELC_HEADS");
                        return;
                    }
                }
                else
                    break;
            }
            //寫入資料庫
            if (objTrans != null)
            { objTrans.Commit(); objTrans = null; }
            //新增 按鈕不可使用，修改、刪除 按鈕可使用
            isEnable("N", "Y", "Y", "", "");
            //畫面清空
            ClearForm();
            //清空 arrCGA
            Array.Clear(arrCGA, 0, arrCGA.Length);
        }
        private void btnHydropowerRepModify_Click(object sender, EventArgs e)
        {//********************************************************************
         //修改 功能
         //將所有 是否作廢 欄位值填回資料庫
         //********************************************************************
            //參數
            int i, RowNo;
            string strSQL;

            // dgvAirConditionTo 資料列數
            RowNo = dgvHydropowerTo.Rows.Count; //注意:其中包含完全無值的最後一行空白列
            //逐筆將 是否作廢 填回資料庫
            for (i = 0; i < RowNo - 1; i++)
            {
                WEB003 = dgvHydropowerTo.Rows[i].Cells[1].Value.ToString(); //檢查項目代號
                WEB015 = dgvHydropowerTo.Rows[i].Cells[6].Value.ToString(); //是否作廢
                strSQL = "Update WATERELC_BODYS Set WEB015 = '" + WEB015 + "' Where WEB003 = '" + WEB003 + "'";
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
            { objTrans.Commit(); objTrans = null; }
        }
        private void btnHydropowerRepDelete_Click(object sender, EventArgs e)
        {//********************************************************************
         //刪除 功能
         //1.WATERELC_HEADS 資料作廢，但不刪除。
         //2.WATERELC_BODYS 資料作廢，但不刪除。
         //3.單位機械編號資料 資料作廢，但不刪除。
         //4.檢查項目基本資料 資料作廢，但不刪除。
         //********************************************************************
         //參數
            string strSQL;

            //避免誤刪，請客戶重覆確認。
            DialogResult = MessageBox.Show("請確認是否執行刪除動作", "刪除動作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                return;
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update WATERELC_HEADS Set WEH011 = 'N' Where WEH002 = '" + FT001 + "' And WEH003 = '" + CG001 + "' And WEH011 = 'Y'";
            USQL.SQLNonSelect(ref da, strSQL);
            //標身檔 資料作廢，但不刪除。
            strSQL = "Update WATERELC_BODYS Set WEB015 = 'Y' Where WEB003 Like '" + FT001 + "_D%' And WEB015 = 'N'";
            USQL.SQLNonSelect(ref da, strSQL);
            //單位機械編號 資料作廢，但不刪除。
            strSQL = "Update MECHNUMBERS Set MN012 = 'N' Where MN003 = '" + FT001 + "' And MN004 = 'D'";
            USQL.SQLNonSelect(ref da, strSQL);
            //檢查項目基本資料 資料作廢，但不刪除。
            strSQL = "Update CHECKITEMS Set CK017 = 'N' Where CK015 = '" + FT001 + "' And CK016 = 'D'";
            USQL.SQLNonSelect(ref da, strSQL);
            //清空畫面
            ClearForm();
            //向左 向右 按鈕可見
            isEnable("", "", "", "Y", "Y");
        }
        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 廠房代號
            //參數
            int i;
            string strSQL;

            //記錄有 Key 值的資料
            FT001 = cbxFactoryCode.Text;
            CG002 = cbxCategorysName.Text;
            CG001 = USQL.FindCG("", CG002);
            //清空 DataGridView 資料
            ckHeader_From.Visible = false;
            dgvHydropowerFrom.Columns.Clear();
            ckHeader_To.Visible = false;
            dgvHydropowerTo.Columns.Clear();
            //先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From WATERELC_HEADS Where WEH002 = '" + FT001 + "' And WEH003 = '" + CG001 + "' And WEH009 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            {
                //記錄 表頭檔 序號
                WEH001 = int.Parse(dt.Rows[0]["WEH001"].ToString());
                //處理 dgvHydropowerFrom ******************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_From.Visible = false;
                //....2.帶出 表頭檔 資料
                //......<1>清空 arrCGA
                Array.Clear(arrCGA, 0, arrCGA.Length);
                //......<2>從 表身檔 抓出已記錄的表身資料
                strSQL = drc.DGVShowSQL("WATERELC_BODYS", FT001 + "_D%");
                dt = USQL.SQLSelect(ref da, strSQL);
                //......<3>將 表身檔 記錄的檢查項目寫入 arrCGA
                for (i = 0; i < dt.Rows.Count; i++)
                    arrCGA = drc.arrPutIn(arrCGA, dt.Rows[i]["項目代號"].ToString());
                //......<4>組出沒有 表身檔 記錄的檢查項目的 SQL 語法
                strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvHydropowerFrom.DataSource = dt;
                //....3.全都 僅可讀
                for (i = 0; i < dgvHydropowerFrom.Columns.Count; i++)
                    dgvHydropowerFrom.Columns[i].ReadOnly = true;
                //處理 dgvHydropowerTo ********************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_To.Visible = false;
                //....2.帶出 表身檔 資料
                strSQL = drc.DGVShowSQL("WATERELC_BODYS", FT001 + "_D%"); //從 表身檔 抓出已記錄的表身資料的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....3.資料第一行放 Button 欄
                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvHydropowerTo.Columns.Add(colFrom);
                //....4.寫入
                dgvHydropowerTo.DataSource = dt;
                //....5.除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvHydropowerTo.Columns.Count; i++)
                    dgvHydropowerTo.Columns[i].ReadOnly = true;
                //隱藏 btnLeft 及 btnRight
                btnLeft.Visible = false;
                btnRight.Visible = false;
                //新增 按鈕不可按，修改、刪除 按鈕可按
                isEnable("N", "Y", "Y", "", "");
            }
            else
            {
                //處理 dgvHydropowerFrom ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_From.Visible = true;
                //....帶出 表頭檔 資料
                strSQL = drc.DGVShowSQL(CG001, 1, arrCGA, FT001, ""); //組出顯示所有檢查項目的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colFrom = new DataGridViewCheckBoxColumn();
                dgvHydropowerFrom.Columns.Insert(0, colFrom);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_From.IsEmpty == true)
                {
                    rect_From = dgvHydropowerFrom.GetCellDisplayRectangle(0, -1, true);
                    rect_From.X = rect_From.Location.X + rect_From.Width / 4 - 2;
                    rect_From.Y = rect_From.Location.Y + (rect_From.Height / 2 - 6);
                }

                ckHeader_From.Size = new Size(16, 16);
                ckHeader_From.Name = "FromHeader";
                ckHeader_From.Location = rect_From.Location;
                //....全選要設定的事件
                ckHeader_From.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_From);

                dgvHydropowerFrom.Controls.Add(ckHeader_From);
                //....寫入
                dgvHydropowerFrom.DataSource = dt;

                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvHydropowerFrom.Columns.Count; i++)
                    dgvHydropowerFrom.Columns[i].ReadOnly = true;
                //處理 dgvHydropowerTo ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_To.Visible = true;
                //....帶出 表身檔 空白 資料
                strSQL = "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colTo = new DataGridViewCheckBoxColumn();
                dgvHydropowerTo.Columns.Insert(0, colTo);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_To.IsEmpty == true)
                {
                    rect_To = dgvHydropowerTo.GetCellDisplayRectangle(0, -1, true);
                    rect_To.X = rect_To.Location.X + rect_To.Width / 4 - 2;
                    rect_To.Y = rect_To.Location.Y + (rect_To.Height / 2 - 6);
                }

                ckHeader_To.Size = new Size(16, 16);
                ckHeader_To.Name = "ToHeader";
                ckHeader_To.Location = rect_To.Location;
                //....全選要設定的事件
                ckHeader_To.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_To);

                dgvHydropowerTo.Controls.Add(ckHeader_To);
                dgvHydropowerTo.DataSource = dt;
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvHydropowerTo.Columns.Count; i++)
                    dgvHydropowerTo.Columns[i].ReadOnly = true;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //新增 按鈕可按，修改、刪除 按鈕不可按
                isEnable("Y", "N", "N", "", "");
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvHydropowerFrom 選至 dgvHydropowerTo
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvHydropowerFrom 選取的資料移到 dgvHydropowerTo
            dgvFromNo = dgvHydropowerFrom.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvHydropowerFrom.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvHydropowerFrom.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutIn(arrCGA, dgvHydropowerFrom.Rows[i].Cells[1].Value.ToString());
                }
            }
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvHydropowerTo.DataSource = dt;

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvHydropowerFrom.DataSource = dt;

            //新增 按鈕可按，修改、刪除 按鈕不可按
            isEnable("Y", "N", "N", "", "");
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvHydropowerTo 選至 dgvHydropowerFrom
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvHydropowerTo 選取的資料移到 dgvHydropowerFrom
            dgvFromNo = dgvHydropowerTo.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvHydropowerTo.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvHydropowerTo.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutOut(arrCGA, dgvHydropowerTo.Rows[i].Cells[1].Value.ToString());
                }
            }

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvHydropowerFrom.DataSource = dt;

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvHydropowerTo.DataSource = dt;

            //DataGridView To 回傳值到 DataGridView From，並且 DataGridView To 已沒有值時，新增按鈕消失
            if (dt.Rows.Count == 0)
                btnHydropowerRepAdd.Enabled = false;
            //修改、刪除 按鈕不可按
            isEnable("", "N", "N", "", "");

        }
        private void dgvHydropowerTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//處理 dgvVacuumTo 作廢 按鈕執行狀況
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
                return;
            else if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                WEB015 = grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (WEB015 == "N")
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                else
                    grid.Rows[e.RowIndex].Cells[6].Value = "N";
            }

        }
        private void cbHeader_CheckedChanged_From(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvHydropowerFrom.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvHydropowerFrom.Controls.Find("FromHeader", true)[0]).Checked;
        }

        private void cbHeader_CheckedChanged_To(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvHydropowerTo.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvHydropowerTo.Controls.Find("ToHeader", true)[0]).Checked;
        }
        private void ClearForm()
        {//用來清空畫面
            cbxFactoryCode.Text = "";
            dgvHydropowerFrom.Columns.Clear();
            dgvHydropowerTo.Columns.Clear();
        }
        private void isEnable(string btnAdd, string btnModify, string btnDelete, string btnR, string btnL)
        {
            if (UserRole == "OP")
                btnHydropowerRepAdd.Enabled = false;
            else if (btnAdd == "Y")
                btnHydropowerRepAdd.Enabled = true;
            else if (btnAdd == "N")
                btnHydropowerRepAdd.Enabled = false;

            if (UserRole == "OP")
                btnHydropowerRepModify.Enabled = false;
            else if (btnModify == "Y")
                btnHydropowerRepModify.Enabled = true;
            else if (btnModify == "N")
                btnHydropowerRepModify.Enabled = false;

            if (UserRole == "OP")
                btnHydropowerRepDelete.Enabled = false;
            else if (btnDelete == "Y")
                btnHydropowerRepDelete.Enabled = true;
            else if (btnDelete == "N")
                btnHydropowerRepDelete.Enabled = false;

            if (UserRole == "OP")
                btnRight.Enabled = false;
            else if (btnR == "Y")
                btnRight.Enabled = true;
            else if (btnR == "N")
                btnRight.Enabled = false;

            if (UserRole == "OP")
                btnLeft.Enabled = false;
            else if (btnL == "Y")
                btnLeft.Enabled = true;
            else if (btnL == "N")
                btnLeft.Enabled = false;
        }
    }
}
