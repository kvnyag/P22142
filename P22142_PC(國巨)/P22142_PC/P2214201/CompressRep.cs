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
        public double oldWidth, oldHeight, newWidth, newHeight;
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        int CAH001, CAB001, CAB002;
        string FT001, CG001, CG002, MN001, MN002;
        string CAH002, CAH003, CAH004, CAH005, CAH006, CAH007, CAH008, CAH009, CAH010, CAH011;
        string CAB003, CAB004, CAB005, CAB006, CAB007, CAB008, CAB009, CAB010, CAB011, CAB012, CAB013, CAB014, CAB015;
        string[] arrCGA = new string[300];
        CheckBox ckHeader_From = new CheckBox();
        CheckBox ckHeader_To = new CheckBox();
        Rectangle rect_From, rect_To;

        public CompressRep()
        {
            InitializeComponent();
        }

        private void CompressRep_Resize(object sender, EventArgs e)
        {
            int NewX;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvCompressFrom.Width = Convert.ToInt32(x * dgvCompressFrom.Width);
                dgvCompressFrom.Height = Convert.ToInt32(y * dgvCompressFrom.Height);

                btnLeft.Width = Convert.ToInt32(x * btnLeft.Width);
                btnLeft.Height = Convert.ToInt32(y * btnLeft.Height);
                NewX = (int)(dgvCompressFrom.Width + 6 * x);
                btnLeft.Location = new Point(NewX, btnLeft.Location.Y);

                btnRight.Width = Convert.ToInt32(x * btnRight.Width);
                btnRight.Height = Convert.ToInt32(y * btnRight.Height);
                btnRight.Location = new Point(NewX, btnRight.Location.Y);

                dgvCompressTo.Width = Convert.ToInt32(x * dgvCompressTo.Width);
                dgvCompressTo.Height = Convert.ToInt32(y * dgvCompressTo.Height);
                NewX += (int)(btnRight.Width + 6 * x);
                dgvCompressTo.Location = new Point(NewX, dgvCompressTo.Location.Y);


                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);
                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnCompressRepAdd.Location.X * x + btnCompressRepAdd.Width * (x - 1));
                btnCompressRepAdd.Location = new Point(NewX, btnCompressRepAdd.Location.Y);
                btnCompressRepAdd.Width = Convert.ToInt32(x * btnCompressRepAdd.Width);
                btnCompressRepAdd.Height = Convert.ToInt32(y * btnCompressRepAdd.Height);

                NewX = (int)(btnCompressRepModify.Location.X * x + btnCompressRepModify.Width * (x - 1));
                btnCompressRepModify.Location = new Point(NewX, btnCompressRepModify.Location.Y);
                btnCompressRepModify.Width = Convert.ToInt32(x * btnCompressRepModify.Width);
                btnCompressRepModify.Height = Convert.ToInt32(y * btnCompressRepModify.Height);

                NewX = (int)(btnCompressRepDelete.Location.X * x + btnCompressRepDelete.Width * (x - 1));
                btnCompressRepDelete.Location = new Point(NewX, btnCompressRepDelete.Location.Y);
                btnCompressRepDelete.Width = Convert.ToInt32(x * btnCompressRepDelete.Width);
                btnCompressRepDelete.Height = Convert.ToInt32(y * btnCompressRepDelete.Height);
            }
        }

        private void CompressRep_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void CompressRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvVacuumFrom
            drc.SetDataGridView(ref dgvCompressFrom);

            //....dgvVacuumTo
            drc.SetDataGridView(ref dgvCompressTo);

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
            int i, arrNo, MaxCAH, MaxCAB;
            string strSQL;

            //寫入資料庫_HEADS
            //....取得 COMPRESSEDAIR_HEADS 下一序號
            strSQL = "SELECT ISNULL(MAX(CAH001),0) as CAH001 FROM COMPRESSEDAIR_HEADS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxCAH = int.Parse(dt.Rows[0]["CAH001"].ToString());

            CAH001 = MaxCAH + 1;                                   //流水序號(CAH001)
            CAH002 = cbxFactoryCode.Text;                          //廠房代號(CAH002)
            CAH003 = USQL.FindCG("", cbxCategorysName.Text);       //類別代號(CAH003)
            CAH004 = cbxMachineCode.Text;                          //機械編號代號 (CAH004)
            CAH005 = tbxMachineName.Text;                          //機械編號名稱(CAH005)
            CAH006 = UserName;                                     //建立者(CAH006)
            CAH007 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //建立時間(CAH007)
            CAH008 = "";                                           //備用(CAH008)
            CAH009 = "";                                           //備用(CAH009)
            CAH010 = "";                                           //備用(CAH010)
            CAH011 = "Y";                                          //是否仍然使用(CAH011)

            strSQL = "Insert into COMPRESSEDAIR_HEADS (CAH001,CAH002, CAH003, CAH004, CAH005, CAH006, CAH007, CAH008, CAH009, CAH010, CAH011) Values (";
            strSQL += CAH001 + ",'"  + CAH002 + "','" + CAH003 + "','" + CAH004 + "','" + CAH005 + "','" + CAH006 + "','" + CAH007 + "','";
            strSQL += CAH008 + "','" + CAH009 + "','" + CAH010 + "','" + CAH011 + "')";

            try
            { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
            catch (Exception Ex)
            {
                if (objTrans != null)
                    objTrans.Rollback();
                MessageBox.Show("Insert Into COMPRESSEDAIR_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COMPRESSEDAIR_HEADS");
                return;
            }

            //寫入資料庫_BODYS
            //....記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //....取得 COMPRESSEDAIR_BODYS 下一序號
            strSQL = "SELECT ISNULL(MAX(CAB002),0) as CAB002 FROM COMPRESSEDAIR_BODYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxCAB = int.Parse(dt.Rows[0]["CAB002"].ToString());
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    CAB003 = arrCGA[i]; //檢查項目代號(VMB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + CAB003 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    CAB001 = MaxCAH + 1;                                 //流水序號(CAB001)
                    CAB002 = MaxCAB + (i + 1);                           //流水序號(VMB002)
                    CAB004 = dt.Rows[0]["CK002"].ToString();             //檢查項目名稱(VMB004)
                    CAB005 = dt.Rows[0]["CK003"].ToString();             //參考 起(VMB005)
                    CAB006 = dt.Rows[0]["CK004"].ToString();             //中間符號(VMB006）
                    CAB007 = dt.Rows[0]["CK005"].ToString();             //參考 迄(VMB007)
                    CAB008 = dt.Rows[0]["CK006"].ToString();             //備註1(VMB008)
                    CAB009 = dt.Rows[0]["CK007"].ToString();             //備註2(VMB009)
                    CAB010 = dt.Rows[0]["CK008"].ToString();             //建立者(VMB010)
                    CAB011 = dt.Rows[0]["CK010"].ToString();             //建立時間(VMB011)
                    CAB012 = dt.Rows[0]["CK012"].ToString();             //備用(VMB012)
                    CAB013 = dt.Rows[0]["CK013"].ToString();             //備用(VMB013)
                    CAB014 = dt.Rows[0]["CK014"].ToString();             //備用(VMB014)
                    CAB015 = "N";                                        //是否作廢(VMB015)

                    strSQL = "Insert into COMPRESSEDAIR_BODYS (CAB001,CAB002,CAB003,CAB004,CAB005,CAB006,CAB007,CAB008,CAB009,CAB010,CAB011,CAB012,CAB013,CAB014,CAB015) Values (";
                    strSQL += CAB001 +  ","  + CAB002 +  ",'" + CAB003 + "','" + CAB004 + "','" + CAB005 + "','" + CAB006 + "','" + CAB007 + "','" + CAB008 + "','";
                    strSQL += CAB009 + "','" + CAB010 + "','" + CAB011 + "','" + CAB012 + "','" + CAB013 + "','" + CAB014 + "','" + CAB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        if (objTrans != null)
                            objTrans.Rollback();
                        MessageBox.Show("Insert Into COMPRESSEDAIR_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into COMPRESSEDAIR_BODYS");
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
            strSQL = "Select CAH001 From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG001 + "' And CAH004 = '" + MN001 + "' And CAH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            CAB001 = int.Parse(dt.Rows[0]["CAH001"].ToString());
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
            { objTrans.Commit(); objTrans = null; }
        }

        private void btnCompressRepDelete_Click(object sender, EventArgs e)
        {//********************************************************************
         //刪除 功能
         //1.COMPRESSEDAIR_HEADS 資料作廢，但不刪除。
         //2.COMPRESSEDAIR_BODYS 資料不變動。
         //3.單位機械編號資料 資料作廢，但不刪除。
         //********************************************************************
         //參數
            string strSQL;

            //避免誤刪，請客戶重覆確認。
            DialogResult = MessageBox.Show("請確認是否執行刪除動作", "刪除動作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                return;
            //找出 標頭 檔編號
            strSQL = "Select CAH001 From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG001 + "' And CAH004 = '" + MN001 + "' And CAH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            CAH001 = int.Parse(dt.Rows[0]["CAH001"].ToString());
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update COMPRESSEDAIR_HEADS Set CAH011 = 'N' Where CAH001 = '" + CAH001 + "' And CAH011 = 'Y' ";
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
            dgvCompressFrom.Columns.Clear();
            ckHeader_To.Visible = false;
            dgvCompressTo.Columns.Clear();
            //先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From COMPRESSEDAIR_HEADS Where CAH002 = '" + FT001 + "' And CAH003 = '" + CG001 + "' And CAH004 = '" + MN001 + "' And CAH011 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count > 0)
            {
                //記錄 表頭檔 序號
                CAH001 = int.Parse(dt.Rows[0]["CAH001"].ToString());
                //處理 dgvCompressFrom ******************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_From.Visible = false;
                //....2.帶出 表頭檔 資料
                //......<1>清空 arrCGA
                Array.Clear(arrCGA, 0, arrCGA.Length);
                //......<2>從 表身檔 抓出已記錄的表身資料
                strSQL = drc.DGVShowSQL("COMPRESSEDAIR_BODYS", CAH001);
                dt = USQL.SQLSelect(ref da, strSQL);
                //......<3>將 表身檔 記錄的檢查項目寫入 arrCGA
                for (i = 0; i < dt.Rows.Count; i++)
                    arrCGA = drc.arrPutIn(arrCGA, dt.Rows[i]["項目代號"].ToString());
                //......<4>組出沒有 表身檔 記錄的檢查項目的 SQL 語法
                strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvCompressFrom.DataSource = dt;
                dgvCompressFrom.ClearSelection();
                //....3.全都 僅可讀
                for (i = 0; i < dgvCompressFrom.Columns.Count; i++)
                    dgvCompressFrom.Columns[i].ReadOnly = true;
                //處理 dgvCompressTo ********************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_To.Visible = false;
                //....2.帶出 表身檔 資料
                strSQL = drc.DGVShowSQL("COMPRESSEDAIR_BODYS", CAH001); //從 表身檔 抓出已記錄的表身資料的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....3.資料第一行放 Button 欄
                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvCompressTo.Columns.Add(colFrom);
                //....4.寫入
                dgvCompressTo.DataSource = dt;
                dgvCompressTo.ClearSelection();
                //....5.除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvCompressTo.Columns.Count; i++)
                    dgvCompressTo.Columns[i].ReadOnly = true;
                //....6.若該筆為"作廢"，按鈕反黑。
                for (i = 0; i < dgvCompressTo.Rows.Count - 1; i++)
                {
                    var cell = ((DataGridViewButtonCell)dgvCompressTo.Rows[i].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    if (dgvCompressTo.Rows[i].Cells[6].Value.ToString() == "Y")
                        dgvCompressTo.Rows[i].Cells[0].Style.BackColor = Color.Black;
                }
                //隱藏 btnLeft 及 btnRight
                btnLeft.Visible = false;
                btnRight.Visible = false;
                //新增 按鈕不可按，修改、刪除 按鈕可按
                isEnable("N", "Y", "Y", "", "");
            }
            else
            {
                //處理 dgvVacuumFrom ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_From.Visible = true;
                //....帶出 表頭檔 資料
                strSQL = drc.DGVShowSQL(CG001, 1, arrCGA, FT001, ""); //組出顯示所有檢查項目的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colFrom = new DataGridViewCheckBoxColumn();
                dgvCompressFrom.Columns.Insert(0, colFrom);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_From.IsEmpty == true)
                {
                    rect_From = dgvCompressFrom.GetCellDisplayRectangle(0, -1, true);
                    rect_From.X = rect_From.Location.X + rect_From.Width / 4 - 2;
                    rect_From.Y = rect_From.Location.Y + (rect_From.Height / 2 - 6);
                }

                ckHeader_From.Size = new Size(16, 16);
                ckHeader_From.Name = "FromHeader";
                ckHeader_From.Location = rect_From.Location;
                //....全選要設定的事件
                ckHeader_From.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_From);

                dgvCompressFrom.Controls.Add(ckHeader_From);
                //....寫入
                dgvCompressFrom.DataSource = dt;
                dgvCompressFrom.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvCompressFrom.Columns.Count; i++)
                    dgvCompressFrom.Columns[i].ReadOnly = true;
                //處理 dgvCompressTo ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_To.Visible = true;
                //....帶出 表身檔 空白 資料
                strSQL = "";
                strSQL += "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colTo = new DataGridViewCheckBoxColumn();
                dgvCompressTo.Columns.Insert(0, colTo);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_To.IsEmpty == true)
                {
                    rect_To = dgvCompressTo.GetCellDisplayRectangle(0, -1, true);
                    rect_To.X = rect_To.Location.X + rect_To.Width / 4 - 2;
                    rect_To.Y = rect_To.Location.Y + (rect_To.Height / 2 - 6);
                }

                ckHeader_To.Size = new Size(16, 16);
                ckHeader_To.Name = "ToHeader";
                ckHeader_To.Location = rect_To.Location;
                //....全選要設定的事件
                ckHeader_To.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_To);

                dgvCompressTo.Controls.Add(ckHeader_To);
                dgvCompressTo.DataSource = dt;
                dgvCompressTo.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvCompressTo.Columns.Count; i++)
                    dgvCompressTo.Columns[i].ReadOnly = true;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //新增 按鈕可按，修改、刪除 按鈕不可按
                isEnable("Y", "N", "N", "", "");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvCompressFrom 選至 dgvCompressTo
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
            dgvFromNo = dgvCompressFrom.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvCompressFrom.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvCompressFrom.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutIn(arrCGA, dgvCompressFrom.Rows[i].Cells[1].Value.ToString());
                }
            }
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressTo.DataSource = dt;

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressFrom.DataSource = dt;
            dgvCompressFrom.ClearSelection();
            //新增 按鈕可按，修改、刪除 按鈕不可按
            isEnable("Y", "N", "N", "", "");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvCompressTo 選至 dgvCompressFrom
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumTo 選取的資料移到 dgvVacuumFrom
            dgvFromNo = dgvCompressTo.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvCompressTo.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvCompressTo.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutOut(arrCGA, dgvCompressTo.Rows[i].Cells[1].Value.ToString());
                }
            }

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressFrom.DataSource = dt;

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvCompressTo.DataSource = dt;
            dgvCompressTo.ClearSelection();
            //DataGridView To 回傳值到 DataGridView From，並且 DataGridView To 已沒有值時，新增按鈕消失
            if (dt.Rows.Count == 0)
                btnCompressRepAdd.Enabled = false;
            //修改、刪除 按鈕不可按
            isEnable("", "N", "N", "", "");
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
                {
                    var cell = ((DataGridViewButtonCell)grid.Rows[e.RowIndex].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    grid.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Black;
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                }
                else if (CAB015 == "Y")
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
            foreach (DataGridViewRow dr in dgvCompressFrom.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvCompressFrom.Controls.Find("FromHeader", true)[0]).Checked;
        }

        private void cbHeader_CheckedChanged_To(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvCompressTo.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvCompressTo.Controls.Find("ToHeader", true)[0]).Checked;
        }
        private void ClearForm()
        {//用來清空畫面
            cbxFactoryCode.Text = "";
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
            dgvCompressFrom.Columns.Clear();
            dgvCompressTo.Columns.Clear();
        }
        private void isEnable(string btnAdd, string btnModify, string btnDelete, string btnR, string btnL)
        {
            if (UserRole == "OP")
                btnCompressRepAdd.Enabled = false;
            else if (btnAdd == "Y")
                btnCompressRepAdd.Enabled = true;
            else if (btnAdd == "N")
                btnCompressRepAdd.Enabled = false;

            if (UserRole == "OP")
                btnCompressRepModify.Enabled = false;
            else if (btnModify == "Y")
                btnCompressRepModify.Enabled = true;
            else if (btnModify == "N")
                btnCompressRepModify.Enabled = false;

            if (UserRole == "OP")
                btnCompressRepDelete.Enabled = false;
            else if (btnDelete == "Y")
                btnCompressRepDelete.Enabled = true;
            else if (btnDelete == "N")
                btnCompressRepDelete.Enabled = false;

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
