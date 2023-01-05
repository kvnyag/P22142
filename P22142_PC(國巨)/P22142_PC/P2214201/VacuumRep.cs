using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using REGAL.Data.DataAccess;

namespace P2214201
{
    public partial class VacuumRep : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        int VMH001, VMB001, VMB002;
        string FT001, CG001, CG002, MN001, MN002;
        string VMH002, VMH003, VMH004, VMH005, VMH006, VMH007, VMH008, VMH009, VMH010, VMH011;
        string VMB003, VMB004, VMB005, VMB006, VMB007, VMB008, VMB009, VMB010, VMB011, VMB012, VMB013, VMB014, VMB015;
        string[] arrCGA = new string[300];
        CheckBox ckHeader_From = new CheckBox();
        CheckBox ckHeader_To = new CheckBox();
        Rectangle rect_From, rect_To;

        public VacuumRep()
        {
            InitializeComponent();
        }
        
        private void VacuumRep_Resize(object sender, EventArgs e)
        {
            int NewX;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvVacuumFrom.Width = Convert.ToInt32(x * dgvVacuumFrom.Width);
                dgvVacuumFrom.Height = Convert.ToInt32(y * dgvVacuumFrom.Height);

                btnLeft.Width = Convert.ToInt32(x * btnLeft.Width);
                btnLeft.Height = Convert.ToInt32(y * btnLeft.Height);
                NewX = (int)(dgvVacuumFrom.Width + 6 * x);
                btnLeft.Location = new Point(NewX, btnLeft.Location.Y);

                btnRight.Width = Convert.ToInt32(x * btnRight.Width);
                btnRight.Height = Convert.ToInt32(y * btnRight.Height);
                btnRight.Location = new Point(NewX, btnRight.Location.Y);
                
                dgvVacuumTo.Width = Convert.ToInt32(x * dgvVacuumTo.Width);
                dgvVacuumTo.Height = Convert.ToInt32(y * dgvVacuumTo.Height);
                NewX += (int)(btnRight.Width + 6 * x);
                dgvVacuumTo.Location = new Point(NewX, dgvVacuumTo.Location.Y);


                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);
                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnVacuumRepAdd.Location.X * x + btnVacuumRepAdd.Width * (x - 1));
                btnVacuumRepAdd.Location = new Point(NewX, btnVacuumRepAdd.Location.Y);
                btnVacuumRepAdd.Width = Convert.ToInt32(x * btnVacuumRepAdd.Width);
                btnVacuumRepAdd.Height = Convert.ToInt32(y * btnVacuumRepAdd.Height);

                NewX = (int)(btnVacuumRepModify.Location.X * x + btnVacuumRepModify.Width * (x - 1));
                btnVacuumRepModify.Location = new Point(NewX, btnVacuumRepModify.Location.Y);
                btnVacuumRepModify.Width = Convert.ToInt32(x * btnVacuumRepModify.Width);
                btnVacuumRepModify.Height = Convert.ToInt32(y * btnVacuumRepModify.Height);

                NewX = (int)(btnVacuumRepDelete.Location.X * x + btnVacuumRepDelete.Width * (x - 1));
                btnVacuumRepDelete.Location = new Point(NewX, btnVacuumRepDelete.Location.Y);
                btnVacuumRepDelete.Width = Convert.ToInt32(x * btnVacuumRepDelete.Width);
                btnVacuumRepDelete.Height = Convert.ToInt32(y * btnVacuumRepDelete.Height);
            }
        }

        private void VacuumRep_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void VacuumRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvVacuumFrom
            drc.SetDataGridView(ref dgvVacuumFrom);

            //....dgvVacuumTo
            drc.SetDataGridView(ref dgvVacuumTo);

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if(RowsNo <= 0)
            { MessageBox.Show("廠房資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            cbxCategorysName.Text = USQL.FindCG("A", "");
        }

        private void btnVacuumRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************
            //參數
            int i, arrNo, MaxVMH, MaxVMB;
            string strSQL;

            //寫入資料庫_HEADS
            //....取得 VACUUM_HEADS 下一序號
            strSQL = "SELECT ISNULL(MAX(VMH001),0) as VMH001 FROM VACUUM_HEADS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxVMH = int.Parse(dt.Rows[0]["VMH001"].ToString());

            VMH001 = MaxVMH + 1;                                   //流水序號(VMH001)
            VMH002 = cbxFactoryCode.Text;                          //廠房代號(VMH002)
            VMH003 = USQL.FindCG("", cbxCategorysName.Text);       //類別代號(VMH003)
            VMH004 = cbxMachineCode.Text;                          //機械編號代號 (VMH004)
            VMH005 = tbxMachineName.Text;                          //機械編號名稱(VMH005)
            VMH006 = UserName;                                     //建立者(VMH006)
            VMH007 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間(VMH007)
            VMH008 = "";                                           //備用(VMH008)
            VMH009 = "";                                           //備用(VMH009)
            VMH010 = "";                                           //備用(VMH010)
            VMH011 = "Y";                                          //是否仍然使用(VMH011)

            strSQL = "Insert Into VACUUM_HEADS (VMH001,VMH002,VMH003,VMH004,VMH005,VMH006,VMH007,VMH008,VMH009,VMH010,VMH011) Values (";
            strSQL += VMH001 + ",'"  + VMH002 + "','" + VMH003 + "','" + VMH004 + "','" + VMH005 + "','" + VMH006 + "','" + VMH007 + "','";
            strSQL += VMH008 + "','" + VMH009 + "','" + VMH010 + "','" + VMH011 + "')";

            try
            { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
            catch (Exception Ex)
            {
                if (objTrans != null)
                    objTrans.Rollback();
                MessageBox.Show("Insert Into VACUUM_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into VACUUM_HEADS");
                return;
            }
            
            //寫入資料庫_BODYS
            //....記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //....取得 VACUUM_BODYS 下一序號
            strSQL = "SELECT ISNULL(MAX(VMB002),0) as VMB002 FROM VACUUM_BODYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            MaxVMB = int.Parse(dt.Rows[0]["VMB002"].ToString());
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    VMB003 = arrCGA[i]; //檢查項目代號(VMB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + VMB003 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    VMB001 = MaxVMH + 1;                     //Head序號(VMB001)
                    VMB002 = MaxVMB + (i + 1);               //流水序號(VMB002)
                    VMB004 = dt.Rows[0]["CK002"].ToString(); //檢查項目名稱(VMB004)
                    VMB005 = dt.Rows[0]["CK003"].ToString(); //參考 起(VMB005)
                    VMB006 = dt.Rows[0]["CK004"].ToString(); //中間符號(VMB006）
                    VMB007 = dt.Rows[0]["CK005"].ToString(); //參考 迄(VMB007)
                    VMB008 = dt.Rows[0]["CK006"].ToString(); //備註1(VMB008)
                    VMB009 = dt.Rows[0]["CK007"].ToString(); //備註2(VMB009)
                    VMB010 = dt.Rows[0]["CK008"].ToString(); //建立者(VMB010)
                    VMB011 = dt.Rows[0]["CK010"].ToString(); //建立時間(VMB011)
                    VMB012 = dt.Rows[0]["CK012"].ToString(); //備用(VMB012)
                    VMB013 = dt.Rows[0]["CK013"].ToString(); //備用(VMB013)
                    VMB014 = dt.Rows[0]["CK014"].ToString(); //備用(VMB014)
                    VMB015 = "N";                            //是否作廢(VMB015)

                    strSQL = "Insert into VACUUM_BODYS (VMB001,VMB002,VMB003,VMB004,VMB005,VMB006,VMB007,VMB008,VMB009,VMB010,VMB011,VMB012,VMB013,VMB014,VMB015) Values (";
                    strSQL += VMB001 + ","   + VMB002 + ",'"  + VMB003 + "','" + VMB004 + "','" + VMB005 + "','" + VMB006 + "','" + VMB007 + "','" + VMB008 + "','";
                    strSQL += VMB009 + "','" + VMB010 + "','" + VMB011 + "','" + VMB012 + "','" + VMB013 + "','" + VMB014 + "','" + VMB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        if(objTrans != null)
                            objTrans.Rollback();
                        MessageBox.Show("Insert Into VACUUM_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into VACUUM_BODYS");
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

        private void btnVacuumRepModify_Click(object sender, EventArgs e)
        {//********************************************************************
         //修改 功能
         //將所有 是否作廢 欄位值填回資料庫
         //********************************************************************
            //參數
            int i, RowNo;
            string strSQL;

            // dgvVacuumTo 資料列數
            RowNo = dgvVacuumTo.Rows.Count; //注意:其中包含完全無值的最後一行空白列
            //找出 標頭 檔編號
            strSQL = "Select VMH001 From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG001 + "' And VMH004 = '" + MN001 + "' And VMH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            VMB001 = int.Parse(dt.Rows[0]["VMH001"].ToString());
            //逐筆將 是否作廢 填回資料庫
            for (i = 0; i < RowNo - 1; i++)
            {
                VMB003 = dgvVacuumTo.Rows[i].Cells[1].Value.ToString(); //檢查項目代號
                VMB015 = dgvVacuumTo.Rows[i].Cells[6].Value.ToString(); //是否作廢
                strSQL = "Update VACUUM_BODYS Set VMB015 = '" + VMB015 + "' Where VMB001 = '" + VMB001 + "' And VMB003 = '" + VMB003 + "'";
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

        private void btnVacuumRepDelete_Click(object sender, EventArgs e)
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
            strSQL = "Select VMH001 From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG001 + "' And VMH004 = '" + MN001 + "' And VMH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            VMH001 = int.Parse(dt.Rows[0]["VMH001"].ToString());
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update VACUUM_HEADS Set VMH011 = 'N' Where VMH001 = '" + VMH001 + "' And VMH011 = 'Y' ";
            USQL.SQLNonSelect(ref da, strSQL);
            //單位機械編號 資料作廢，但不刪除。
            strSQL = "Update MECHNUMBERS Set MN012 = 'N' Where MN001 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);
            //清空畫面
            ClearForm();
            //向左 向右 按鈕可見
            isEnable("","","","Y","Y");
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
            //清空 DataGridView 資料，畫在 DataGridView 上的 CheckBox 也隱藏。
            ckHeader_From.Visible = false; 
            dgvVacuumFrom.Columns.Clear();
            ckHeader_To.Visible = false;
            dgvVacuumTo.Columns.Clear();
            //先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG001 + "' And VMH004 = '" + MN001 + "' And VMH011 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);
            
            if (dt.Rows.Count > 0)
            {
                //記錄 表頭檔 序號
                VMH001 = int.Parse(dt.Rows[0]["VMH001"].ToString());
                //處理 dgvVacuumFrom ******************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_From.Visible = false;
                //....2.帶出 表頭檔 資料
                //......<1>清空 arrCGA
                Array.Clear(arrCGA, 0, arrCGA.Length);
                //......<2>從 表身檔 抓出已記錄的表身資料
                strSQL = drc.DGVShowSQL("VACUUM_BODYS", VMH001);
                dt = USQL.SQLSelect(ref da, strSQL);
                //......<3>將 表身檔 記錄的檢查項目寫入 arrCGA
                for (i = 0; i < dt.Rows.Count; i++)
                    arrCGA = drc.arrPutIn(arrCGA, dt.Rows[i]["項目代號"].ToString());
                //......<4>組出沒有 表身檔 記錄的檢查項目的 SQL 語法
                strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvVacuumFrom.DataSource = dt;
                dgvVacuumFrom.ClearSelection();
                //....3.全都 僅可讀
                for (i = 0; i < dgvVacuumFrom.Columns.Count; i++)
                    dgvVacuumFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....1.畫出來的打勾圖示 不可見
                ckHeader_To.Visible = false;
                //....2.帶出 表身檔 資料
                strSQL = drc.DGVShowSQL("VACUUM_BODYS", VMH001); //從 表身檔 抓出已記錄的表身資料的 SQL 語法
                dt = USQL.SQLSelect(ref da, strSQL);
                //....3.資料第一行放 Button 欄
                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvVacuumTo.Columns.Add(colFrom);
                //....4.寫入
                dgvVacuumTo.DataSource = dt;
                dgvVacuumTo.ClearSelection();
                //....5.除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumTo.Columns.Count; i++)
                    dgvVacuumTo.Columns[i].ReadOnly = true;
                //....6.若該筆為"作廢"，按鈕反黑。
                for(i = 0; i < dgvVacuumTo.Rows.Count - 1; i++)
                {
                    var cell = ((DataGridViewButtonCell)dgvVacuumTo.Rows[i].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    if(dgvVacuumTo.Rows[i].Cells[6].Value.ToString() == "Y")
                        dgvVacuumTo.Rows[i].Cells[0].Style.BackColor = Color.Black;
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
                dgvVacuumFrom.Columns.Insert(0, colFrom);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if (rect_From.IsEmpty == true)
                {
                    rect_From = dgvVacuumFrom.GetCellDisplayRectangle(0, -1, true);
                    rect_From.X = rect_From.Location.X + rect_From.Width / 4 - 2;
                    rect_From.Y = rect_From.Location.Y + (rect_From.Height / 2 - 6);
                }
                ckHeader_From.Size = new Size(16, 16);
                ckHeader_From.Name = "FromHeader";
                ckHeader_From.Location = rect_From.Location;
                //....全選要設定的事件
                ckHeader_From.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_From);
                
                dgvVacuumFrom.Controls.Add(ckHeader_From);
                //....寫入
                dgvVacuumFrom.DataSource = dt;
                dgvVacuumFrom.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumFrom.Columns.Count; i++)
                    dgvVacuumFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....畫出來的打勾圖示 可見
                ckHeader_To.Visible = true;
                //....帶出 表身檔 空白 資料
                strSQL = "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colTo = new DataGridViewCheckBoxColumn();
                dgvVacuumTo.Columns.Insert(0, colTo);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                if(rect_To.IsEmpty == true)
                {
                    rect_To = dgvVacuumTo.GetCellDisplayRectangle(0, -1, true);
                    rect_To.X = rect_To.Location.X + rect_To.Width / 4 - 2;
                    rect_To.Y = rect_To.Location.Y + (rect_To.Height / 2 - 6);
                }
                ckHeader_To.Size = new Size(16, 16);
                ckHeader_To.Name = "ToHeader";
                ckHeader_To.Location = rect_To.Location;
                //....全選要設定的事件
                ckHeader_To.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_To);
                
                dgvVacuumTo.Controls.Add(ckHeader_To);
                dgvVacuumTo.DataSource = dt;
                dgvVacuumTo.ClearSelection();
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumTo.Columns.Count; i++)
                    dgvVacuumTo.Columns[i].ReadOnly = true;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //新增 按鈕可按，修改、刪除 按鈕不可按
                isEnable("Y", "N", "N", "", "");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumFrom 選至 dgvVacuumTo
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
            //....取得 dgvVacuumFrom 勾選了哪些值
            dgvFromNo = dgvVacuumFrom.RowCount;
            for(i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvVacuumFrom.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvVacuumFrom.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutIn(arrCGA, dgvVacuumFrom.Rows[i].Cells[1].Value.ToString());
                }
            }
            //....dgvVacuumFrom 勾選的值取出，填入 dgvVacuumTo
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;
            //....dgvVacuumFrom 顯示除了勾選外的值
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumFrom.DataSource = dt;
            dgvVacuumFrom.ClearSelection();
            //新增 按鈕可按，修改、刪除 按鈕不可按
            isEnable("Y", "N", "N", "", "");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumTo 選至 dgvVacuumFrom
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumTo 選取的資料移到 dgvVacuumFrom
            dgvFromNo = dgvVacuumTo.RowCount;
            for (i = 0; i < dgvFromNo - 1; i++)
            {
                if (dgvVacuumTo.Rows[i].Cells[0].Value != null)
                {
                    isCheck = dgvVacuumTo.Rows[i].Cells[0].Value.ToString();
                    if (isCheck == "True")
                        arrCGA = drc.arrPutOut(arrCGA, dgvVacuumTo.Rows[i].Cells[1].Value.ToString());
                }
            }
            
            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumFrom.DataSource = dt;

            strSQL = drc.DGVShowSQL(CG001, 2, arrCGA, FT001, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;
            dgvVacuumTo.ClearSelection();
            //DataGridView To 回傳值到 DataGridView From，並且 DataGridView To 已沒有值時，新增按鈕消失
            if (dt.Rows.Count == 0)
                btnVacuumRepAdd.Enabled = false;
            //修改、刪除 按鈕不可按
            isEnable("", "N", "N", "", "");
        }

        private void dgvVacuumTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//處理 dgvVacuumTo 作廢 按鈕執行狀況
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
                return;
            else if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                VMB015 = grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (VMB015 == "N")
                {
                    var cell = ((DataGridViewButtonCell)grid.Rows[e.RowIndex].Cells[0]);
                    cell.FlatStyle = FlatStyle.Flat;
                    grid.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Black;
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                }
                else if (VMB015 == "Y")
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
            foreach (DataGridViewRow dr in dgvVacuumFrom.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvVacuumFrom.Controls.Find("FromHeader", true)[0]).Checked;
        }

        private void cbHeader_CheckedChanged_To(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvVacuumTo.Rows)
                dr.Cells[0].Value = ((CheckBox)dgvVacuumTo.Controls.Find("ToHeader", true)[0]).Checked;
        }
        private void ClearForm()
        {//用來清空畫面
            cbxFactoryCode.Text = "";
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
            dgvVacuumFrom.Columns.Clear();
            dgvVacuumTo.Columns.Clear();
        }
        private void isEnable(string btnAdd, string btnModify, string btnDelete, string btnR, string btnL)
        {
            if (UserRole == "OP")
                btnVacuumRepAdd.Enabled = false;
            else if (btnAdd == "Y")
                btnVacuumRepAdd.Enabled = true;
            else if (btnAdd == "N")
                btnVacuumRepAdd.Enabled = false;

            if (UserRole == "OP")
                btnVacuumRepModify.Enabled = false;
            else if (btnModify == "Y")
                btnVacuumRepModify.Enabled = true;
            else if (btnModify == "N")
                btnVacuumRepModify.Enabled = false;

            if (UserRole == "OP")
                btnVacuumRepDelete.Enabled = false;
            else if (btnDelete == "Y")
                btnVacuumRepDelete.Enabled = true;
            else if (btnDelete == "N")
                btnVacuumRepDelete.Enabled = false;

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
