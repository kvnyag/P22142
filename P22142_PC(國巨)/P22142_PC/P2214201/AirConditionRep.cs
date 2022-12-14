using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class AirConditionRep : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        int COH001, COB001, COB002;
        string FT001, CG001, CG002, MN001, MN002;
        string COH002, COH003, COH004, COH005, COH006, COH007, COH008, COH009, COH010, COH011;
        string COB003, COB004, COB005, COB006, COB007, COB008, COB009, COB010, COB011, COB012, COB013, COB014, COB015;
        string[] arrCGA = new string[300];
        CheckBox ckHeader_From = new CheckBox();
        CheckBox ckHeader_To = new CheckBox();
        Rectangle rect_From, rect_To;
        
        public AirConditionRep()
        {
            InitializeComponent();
        }

        private void AirConditionRep_Resize(object sender, EventArgs e)
        {
            int NewX;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvAirConditionFrom.Width = Convert.ToInt32(x * dgvAirConditionFrom.Width);
                dgvAirConditionFrom.Height = Convert.ToInt32(y * dgvAirConditionFrom.Height);

                btnLeft.Width = Convert.ToInt32(x * btnLeft.Width);
                btnLeft.Height = Convert.ToInt32(y * btnLeft.Height);
                NewX = (int)(dgvAirConditionFrom.Width + 6 * x);
                btnLeft.Location = new Point(NewX, btnLeft.Location.Y);

                btnRight.Width = Convert.ToInt32(x * btnRight.Width);
                btnRight.Height = Convert.ToInt32(y * btnRight.Height);
                btnRight.Location = new Point(NewX, btnRight.Location.Y);

                dgvAirConditionTo.Width = Convert.ToInt32(x * dgvAirConditionTo.Width);
                dgvAirConditionTo.Height = Convert.ToInt32(y * dgvAirConditionTo.Height);
                NewX += (int)(btnRight.Width + 6 * x);
                dgvAirConditionTo.Location = new Point(NewX, dgvAirConditionTo.Location.Y);
                
                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);
                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnAirConditionRepAdd.Location.X * x + btnAirConditionRepAdd.Width * (x - 1));
                btnAirConditionRepAdd.Location = new Point(NewX, btnAirConditionRepAdd.Location.Y);
                btnAirConditionRepAdd.Width = Convert.ToInt32(x * btnAirConditionRepAdd.Width);
                btnAirConditionRepAdd.Height = Convert.ToInt32(y * btnAirConditionRepAdd.Height);

                NewX = (int)(btnAirConditionRepModify.Location.X * x + btnAirConditionRepModify.Width * (x - 1));
                btnAirConditionRepModify.Location = new Point(NewX, btnAirConditionRepModify.Location.Y);
                btnAirConditionRepModify.Width = Convert.ToInt32(x * btnAirConditionRepModify.Width);
                btnAirConditionRepModify.Height = Convert.ToInt32(y * btnAirConditionRepModify.Height);

                NewX = (int)(btnAirConditionRepDelete.Location.X * x + btnAirConditionRepDelete.Width * (x - 1));
                btnAirConditionRepDelete.Location = new Point(NewX, btnAirConditionRepDelete.Location.Y);
                btnAirConditionRepDelete.Width = Convert.ToInt32(x * btnAirConditionRepDelete.Width);
                btnAirConditionRepDelete.Height = Convert.ToInt32(y * btnAirConditionRepDelete.Height);
            }
        }

        private void AirConditionRep_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }
        
        private void AirConditionRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvAirConditionFrom
            drc.SetDataGridView(ref dgvAirConditionFrom);

            //....dgvAirConditionTo
            drc.SetDataGridView(ref dgvAirConditionTo);

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("廠房資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "Select CG002 From CATEGORYS Where CG001 = 'C'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("類別資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());
            cbxCategorysName.Text = dt.Rows[i - 1]["CG002"].ToString().Trim();
        }
        
        private void btnAirConditionRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************
            //參數
            int i, arrNo, MaxCOH, MaxCOB;
            string strSQL;

            //寫入資料庫_HEADS
            //....取得 VACUUM_HEADS 下一序號
            strSQL = "SELECT ISNULL(MAX(COH001),0) as COH001 FROM COLDAIR_HEADS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxCOH = int.Parse(dt.Rows[0]["COH001"].ToString());

            COH001 = MaxCOH + 1;                                   //流水序號(COH001)
            COH002 = cbxFactoryCode.Text;                          //廠房代號(COH002)
            COH003 = USQL.FindCG("", cbxCategorysName.Text);       //類別代號(COH003)
            COH004 = cbxMachineCode.Text;                          //機械編號代號 (COH004)
            COH005 = tbxMachineName.Text;                          //機械編號名稱(COH005)
            COH006 = UserName;                                     //建立者(COH006)
            COH007 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //建立時間(COH007)
            COH008 = "";                                           //備用(COH008)
            COH009 = "";                                           //備用(COH009)
            COH010 = "";                                           //備用(COH010)
            COH011 = "Y";                                          //是否仍然使用(COH011)

            strSQL = "Insert into COLDAIR_HEADS (COH001,COH002, COH003, COH004, COH005, COH006, COH007, COH008, COH009, COH010, COH011) Values (";
            strSQL += COH001 + ",'"  + COH002 + "','" + COH003 + "','" + COH004 + "','" + COH005 + "','" + COH006 + "','" + COH007 + "','";
            strSQL += COH008 + "','" + COH009 + "','" + COH010 + "','" + COH011 + "')";

            try
            { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
            catch (Exception Ex)
            {
                if (objTrans != null)
                    objTrans.Rollback();
                MessageBox.Show("Insert Into COLDAIR_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COLDAIR_HEADS");
                return;
            }

            //寫入資料庫_BODYS
            //....記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //....取得 VACUUM_BODYS 下一序號
            strSQL = "SELECT ISNULL(MAX(COB002),0) as COB002 FROM COLDAIR_BODYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxCOB = int.Parse(dt.Rows[0]["COB002"].ToString());
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    COB003 = arrCGA[i]; //檢查項目代號(COB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + COB003 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    COB001 = MaxCOH + 1;                                 //流水序號(COB001)
                    COB002 = MaxCOB + (i + 1);                           //流水序號(COB002)
                    COB004 = dt.Rows[0]["CK002"].ToString();             //檢查項目名稱(COB004)
                    COB005 = dt.Rows[0]["CK003"].ToString();             //參考 起(COB005)
                    COB006 = dt.Rows[0]["CK004"].ToString();             //中間符號(COB006）
                    COB007 = dt.Rows[0]["CK005"].ToString();             //參考 迄(COB007)
                    COB008 = dt.Rows[0]["CK006"].ToString();             //備註1(COB008)
                    COB009 = dt.Rows[0]["CK007"].ToString();             //備註2(COB009)
                    COB010 = dt.Rows[0]["CK008"].ToString();             //建立者(COB010)
                    COB011 = dt.Rows[0]["CK010"].ToString();             //建立時間(COB011)
                    COB012 = dt.Rows[0]["CK012"].ToString();             //備用(COB012)
                    COB013 = dt.Rows[0]["CK013"].ToString();             //備用(COB013)
                    COB014 = dt.Rows[0]["CK014"].ToString();             //備用(COB014)
                    COB015 = "N";                                        //是否作廢(COB015)

                    strSQL = "Insert into COLDAIR_BODYS (COB001,COB002,COB003,COB004,COB005,COB006,COB007,COB008,COB009,COB010,COB011,COB012,COB013,COB014,COB015) Values (";
                    strSQL += COB001 +  ","  + COB002 +  ",'" + COB003 + "','" + COB004 + "','" + COB005 + "','" + COB006 + "','" + COB007 + "','" + COB008 + "','";
                    strSQL += COB009 + "','" + COB010 + "','" + COB011 + "','" + COB012 + "','" + COB013 + "','" + COB014 + "','" + COB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        if (objTrans != null)
                            objTrans.Rollback();
                        MessageBox.Show("Insert Into COLDAIR_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COLDAIR_BODYS");
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
        private void btnAirConditionRepModify_Click(object sender, EventArgs e)
        {//********************************************************************
         //修改 功能
         //將所有 是否作廢 欄位值填回資料庫
         //********************************************************************
            //參數
            int i, RowNo;
            string strSQL;

            // dgvAirConditionTo 資料列數
            RowNo = dgvAirConditionTo.Rows.Count; //注意:其中包含完全無值的最後一行空白列
            //找出 標頭 檔編號
            strSQL = "Select COH001 From COLDAIR_HEADS Where COH002 = '" + FT001 + "' And COH003 = '" + CG001 + "' And COH004 = '" + MN001 + "' And COH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            COB001 = int.Parse(dt.Rows[0]["COH001"].ToString());
            //逐筆將 是否作廢 填回資料庫
            for (i = 0; i < RowNo - 1; i++)
            {
                COB003 = dgvAirConditionTo.Rows[i].Cells[1].Value.ToString(); //檢查項目代號
                COB015 = dgvAirConditionTo.Rows[i].Cells[6].Value.ToString(); //是否作廢
                strSQL = "Update COLDAIR_BODYS Set COB015 = '" + COB015 + "' Where COB001 = '" + COB001 + "' And COB003 = '" + COB003 + "'";
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
        private void btnAirConditionRepDelete_Click(object sender, EventArgs e)
        {//********************************************************************
         //刪除 功能
         //1.COLDAIR_HEADS 資料作廢，但不刪除。
         //2.COLDAIR_BODYS 資料不變動。
         //3.單位機械編號資料 資料作廢，但不刪除。
         //********************************************************************
            //參數
            string strSQL;

            //避免誤刪，請客戶重覆確認。
            DialogResult = MessageBox.Show("請確認是否執行刪除動作", "刪除動作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                return;
            //找出 標頭 檔編號
            strSQL = "Select COH001 From COLDAIR_HEADS Where COH002 = '" + FT001 + "' And COH003 = '" + CG001 + "' And COH004 = '" + MN001 + "' And COH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            COH001 = int.Parse(dt.Rows[0]["COH001"].ToString());
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update COLDAIR_HEADS Set COH011 = 'N' Where COH001 = '" + COH001 + "' And COH011 = 'Y'";
            USQL.SQLNonSelect(ref da, strSQL);
            //單位機械編號 資料作廢，但不刪除。
            strSQL = "Update MECHNUMBERS Set MN012 = 'N' Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);
            //清空畫面
            ClearForm();
            //向左 向右 按鈕可見
            isEnable("", "", "", "Y", "Y");
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
            strSQL = "Select * From MECHNUMBERS Where MN003 = '" + FT001 + "' And MN004 = '" + CG001 + "' Order by MN001 ";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("機械資訊尚未建置完成，請先行建置。"); return; }

            cbxMachineCode.Items.Clear();
            for (i = 0; i < RowsNo; i++)
                cbxMachineCode.Items.Add(dt.Rows[i]["MN001"].ToString().Trim());
            //清空
            ClearForm();
        }
        private void cbxMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 機械編號，並寫入 機械名稱(tbxMachineName)
            //參數
            int i;
            string strSQL;

            //記錄有 Key 值的資料
            MN001 = cbxMachineCode.Text;
            MN002 = USQL.FindMN(MN001, "");
            tbxMachineName.Text = MN002;
            //清空 DataGridView 資料
            ckHeader_From.Visible = false;
            dgvAirConditionFrom.Columns.Clear();
            ckHeader_To.Visible = false;
            dgvAirConditionTo.Columns.Clear();
            //先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From COLDAIR_HEADS Where COH002 = '" + FT001 + "' And COH003 = '" + CG001 + "' And COH004 = '" + MN001 + "' And COH011 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            {
                //記錄 表頭檔 序號
                COH001 = int.Parse(dt.Rows[0]["COH001"].ToString());
                //處理 dgvVacuumFrom ******************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_From.Visible = false;
                //....2.帶出 表頭檔 資料
                //......<1>清空 arrCGA
                Array.Clear(arrCGA, 0, arrCGA.Length);
                //......<2>從 表身檔 抓出已記錄的表身資料
                strSQL = drc.DGVShowSQL("COLDAIR_BODYS", COH001);
                dt = USQL.SQLSelect(ref da, strSQL);
                //......<3>將 表身檔 記錄的檢查項目寫入 arrCGA
                for (i = 0; i < dt.Rows.Count; i++)
                    arrCGA = drc.arrPutIn(arrCGA, dt.Rows[i]["項目代號"].ToString());
                //......<4>組出沒有 表身檔 記錄的檢查項目的 SQL 語法
                strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvAirConditionFrom.DataSource = dt;
                dgvAirConditionFrom.ClearSelection();
                //....3.全都 僅可讀
                for (i = 0; i < dgvAirConditionFrom.Columns.Count; i++)
                    dgvAirConditionFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_To.Visible = false;
                //....2.帶出 表身檔 資料
                strSQL = drc.DGVShowSQL("COLDAIR_BODYS", COH001); //從 表身檔 抓出已記錄的表身資料的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....3.資料第一行放 Button 欄
                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvAirConditionTo.Columns.Add(colFrom);
                //....4.寫入
                dgvAirConditionTo.DataSource = dt;
                dgvAirConditionTo.ClearSelection();
                //....5.除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvAirConditionTo.Columns.Count; i++)
                    dgvAirConditionTo.Columns[i].ReadOnly = true;
                //....6.若該筆為"作廢"，按鈕反黑。
                for (i = 0; i < dgvAirConditionTo.Rows.Count - 1; i++)
                {
                    var cell = ((DataGridViewButtonCell)dgvAirConditionTo.Rows[i].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    if (dgvAirConditionTo.Rows[i].Cells[6].Value.ToString() == "Y")
                        dgvAirConditionTo.Rows[i].Cells[0].Style.BackColor = Color.Black;
                }
                //隱藏 btnLeft 及 btnRight
                btnLeft.Visible = false;
                btnRight.Visible = false;
                //新增 按鈕不可按，修改、刪除 按鈕可按
                isEnable("N", "Y", "Y", "", "");
            }
            else
            {
                //清空 arrCGA
                Array.Clear(arrCGA, 0, arrCGA.Length);
                //處理 dgvVacuumFrom ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_From.Visible = true;
                //....帶出 表頭檔 資料
                strSQL = drc.DGVShowSQL(CG001, 1, arrCGA, FT001, ""); //組出顯示所有檢查項目的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colFrom = new DataGridViewCheckBoxColumn();
                dgvAirConditionFrom.Columns.Insert(0, colFrom);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_From.IsEmpty == true)
                {
                    rect_From = dgvAirConditionFrom.GetCellDisplayRectangle(0, -1, true);
                    rect_From.X = rect_From.Location.X + rect_From.Width / 4 - 2;
                    rect_From.Y = rect_From.Location.Y + (rect_From.Height / 2 - 6);
                }

                ckHeader_From.Size = new Size(16, 16);
                ckHeader_From.Name = "FromHeader";
                ckHeader_From.Location = rect_From.Location;
                //....全選要設定的事件
                ckHeader_From.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_From);

                dgvAirConditionFrom.Controls.Add(ckHeader_From);
                //....寫入
                dgvAirConditionFrom.DataSource = dt;
                dgvAirConditionFrom.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvAirConditionFrom.Columns.Count; i++)
                    dgvAirConditionFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_To.Visible = true;
                //....帶出 表身檔 空白 資料
                strSQL = "";
                strSQL += "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colTo = new DataGridViewCheckBoxColumn();
                dgvAirConditionTo.Columns.Insert(0, colTo);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_To.IsEmpty == true)
                {
                    rect_To = dgvAirConditionTo.GetCellDisplayRectangle(0, -1, true);
                    rect_To.X = rect_To.Location.X + rect_To.Width / 4 - 2;
                    rect_To.Y = rect_To.Location.Y + (rect_To.Height / 2 - 6);
                }

                ckHeader_To.Size = new Size(16, 16);
                ckHeader_To.Name = "ToHeader";
                ckHeader_To.Location = rect_To.Location;
                //....全選要設定的事件
                ckHeader_To.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_To);

                dgvAirConditionTo.Controls.Add(ckHeader_To);
                dgvAirConditionTo.DataSource = dt;
                dgvAirConditionTo.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvAirConditionTo.Columns.Count; i++)
                    dgvAirConditionTo.Columns[i].ReadOnly = true;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //新增 按鈕可按，修改、刪除 按鈕不可按
                isEnable("Y", "N", "N", "", "");
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvAirConditionFrom 選至 dgvAirConditionTo
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
            dgvFromNo = dgvAirConditionFrom.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvAirConditionFrom.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvAirConditionFrom.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutIn(arrCGA, dgvAirConditionFrom.Rows[i].Cells[1].Value.ToString());
                }
            }
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvAirConditionTo.DataSource = dt;
            dgvAirConditionTo.ClearSelection();

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvAirConditionFrom.DataSource = dt;
            dgvAirConditionFrom.ClearSelection();

            //新增 按鈕可按，修改、刪除 按鈕不可按
            isEnable("Y", "N", "N", "", "");
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvAirConditionTo 選至 dgvAirConditionFrom
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumTo 選取的資料移到 dgvVacuumFrom
            dgvFromNo = dgvAirConditionTo.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvAirConditionTo.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvAirConditionTo.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutOut(arrCGA, dgvAirConditionTo.Rows[i].Cells[1].Value.ToString());
                }
            }

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvAirConditionFrom.DataSource = dt;
            dgvAirConditionFrom.ClearSelection();

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvAirConditionTo.DataSource = dt;
            dgvAirConditionTo.ClearSelection();

            //DataGridView To 回傳值到 DataGridView From，並且 DataGridView To 已沒有值時，新增按鈕消失
            if (dt.Rows.Count == 0)
                btnAirConditionRepAdd.Enabled = false;
            //修改、刪除 按鈕不可按
            isEnable("", "N", "N", "", "");
        }
        private void dgvAirConditionTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//處理 dgvVacuumTo 作廢 按鈕執行狀況
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
                return;
            else if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                COB015 = grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (COB015 == "N")
                {
                    var cell = ((DataGridViewButtonCell)grid.Rows[e.RowIndex].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    grid.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Black;
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                }
                else if (COB015 == "Y")
                {
                    var cell = ((DataGridViewButtonCell)grid.Rows[e.RowIndex].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    grid.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
                    grid.Rows[e.RowIndex].Cells[6].Value = "N";
                }
            }
        }
        private void cbHeader_CheckedChanged_From(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvAirConditionFrom.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvAirConditionFrom.Controls.Find("FromHeader", true)[0]).Checked;
        }

        private void cbHeader_CheckedChanged_To(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvAirConditionTo.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvAirConditionTo.Controls.Find("ToHeader", true)[0]).Checked;
        }
        private void ClearForm()
        {//用來清空畫面
            cbxFactoryCode.Text = "";
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
            dgvAirConditionFrom.Columns.Clear();
            dgvAirConditionTo.Columns.Clear();
        }
        private void isEnable(string btnAdd, string btnModify, string btnDelete, string btnR, string btnL)
        {
            if(UserRole == "OP")
                btnAirConditionRepAdd.Enabled = false;
            else if (btnAdd == "Y")
                btnAirConditionRepAdd.Enabled = true;
            else if (btnAdd == "N")
                btnAirConditionRepAdd.Enabled = false;

            if (UserRole == "OP")
                btnAirConditionRepModify.Enabled = false;
            else if (btnModify == "Y")
                btnAirConditionRepModify.Enabled = true;
            else if (btnModify == "N")
                btnAirConditionRepModify.Enabled = false;

            if (UserRole == "OP")
                btnAirConditionRepDelete.Enabled = false;
            else if (btnDelete == "Y")
                btnAirConditionRepDelete.Enabled = true;
            else if (btnDelete == "N")
                btnAirConditionRepDelete.Enabled = false;

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
