﻿using System;
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
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DbTransaction objTrans;
        DealRecord drc = new DealRecord();

        string FT001, CG001, CG002, MN001, MN002;
        string VMH001, VMH002, VMH003, VMH004, VMH005, VMH006, VMH007, VMH008, VMH009, VMH010, VMH011;
        string VMB001, VMB002, VMB003, VMB004, VMB005, VMB006, VMB007, VMB008, VMB009, VMB010, VMB011, VMB012, VMB013, VMB014, VMB015;
        string[] arrCGA = new string[300];

        public VacuumRep()
        {
            InitializeComponent();
        }

        private void VacuumRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //DataGridView 設定
            //....dgvVacuumFrom
            //dgvVacuumFrom.ReadOnly = true;
            dgvVacuumFrom.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvVacuumFrom.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
            dgvVacuumFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            //....dgvVacuumTo
            //dgvVacuumTo.ReadOnly = true;
            dgvVacuumTo.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            dgvVacuumTo.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 6, FontStyle.Regular);
            dgvVacuumTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "";
            strSQL += "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if(RowsNo <= 0)
            { MessageBox.Show("廠房資訊尚未建置完成，請先行建置。"); return; }

            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "";
            strSQL += "Select CG002 From CATEGORYS Where CG001 = 'A'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            if (RowsNo <= 0)
            { MessageBox.Show("類別資訊尚未建置完成，請先行建置。"); return; }
            
            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());
            cbxCategorysName.Text = dt.Rows[i - 1]["CG002"].ToString().Trim();
        }

        private void btnVacuumRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************
            //參數
            int i, MaxVMH, MaxVMB, arrNo;
            string strSQL, strMaxVMH, strMaxVMB, CK001;

            //寫入資料庫_HEADS
            strSQL = "Select ISNULL(Max(VMH001),'VMH_00000') as MaxVMH001 From VACUUM_HEADS";
            dt = USQL.SQLSelect(ref da, strSQL);
            strMaxVMH = dt.Rows[0]["MaxVMH001"].ToString();
            MaxVMH = int.Parse(strMaxVMH.Substring(4, 5)) + 1;

            VMH001 = "VMH_" + MaxVMH.ToString().PadLeft(5, '0');   //流水序號(VMH001)
            VMH002 = cbxFactoryCode.Text;                          //廠房代號(VMH002)
            VMH003 = cbxCategorysName.Text;                        //類別代號(VMH003)
            VMH004 = cbxMachineCode.Text;                          //機械編號代號 (VMH004)
            VMH005 = tbxMachineName.Text;                          //機械編號名稱(VMH005)
            VMH006 = UserName;                                     //建立者(VMH006)
            VMH007 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //建立時間(VMH007)
            VMH008 = "";                                           //備用(VMH008)
            VMH009 = "";                                           //備用(VMH009)
            VMH010 = "";                                           //備用(VMH010)
            VMH011 = "Y";                                          //是否仍然使用(VMH011)

            strSQL = "Insert into VACUUM_HEADS (VMH001,VMH002,VMH003,VMH004,VMH005,VMH006,VMH007,VMH008,VMH009,VMH010,VMH011) Values ('";
            strSQL += VMH001 + "','" + VMH002 + "','" + VMH003 + "','" + VMH004 + "','" + VMH005 + "','" + VMH006 + "','" + VMH007 + "','";
            strSQL += VMH008 + "','" + VMH009 + "','" + VMH010 + "','" + VMH011 + "')";

            try
            { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
            catch(Exception Ex)
            {
                objTrans.Rollback();
                MessageBox.Show("Insert Into VACUUM_HEADS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into VACUUM_HEADS");
                return;
            }
            
            //寫入資料庫_BODYS
            //....記錄 arrCGA 共有多少項目
            arrNo = arrCGA.Length;
            //....計算下一序號值
            strSQL = "Select ISNULL(Max(VMB001),'VMB_00000') as MaxVMB001 From VACUUM_BODYS Where VMB001 = '" + VMH001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            strMaxVMB = dt.Rows[0]["MaxVMB001"].ToString();
            MaxVMB = int.Parse(strMaxVMB.Substring(4, 5)) + 1;
            //....依序執行寫入資料庫動作
            for (i = 0; i < arrNo; i++)
            {
                if (arrCGA[i] != null)
                {
                    VMB003 = arrCGA[i]; //檢查項目代號(VMB003)
                    strSQL = "Select * From CHECKITEMS Where CK001 = '" + VMB003 + "'";
                    dt = USQL.SQLSelect(ref da, strSQL);

                    VMB001 = VMH001; //Head序號(VMB001)
                    VMB002 = "VMB_" + MaxVMB.ToString().PadLeft(5, '0'); //流水序號(VMB002)
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

                    strSQL = "Insert into VACUUM_BODYS (VMB001,VMB002,VMB003,VMB004,VMB005,VMB006,VMB007,VMB008,VMB009,VMB010,VMB011,VMB012,VMB013,VMB014,VMB015) Values ('";
                    strSQL += VMB001 + "','" + VMB002 + "','" + VMB003 + "','" + VMB004 + "','" + VMB005 + "','" + VMB006 + "','" + VMB007 + "','" + VMB008 + "','";
                    strSQL += VMB009 + "','" + VMB010 + "','" + VMB011 + "','" + VMB012 + "','" + VMB013 + "','" + VMB014 + "','" + VMB015 + "')";

                    try
                    { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                    catch (Exception Ex)
                    {
                        objTrans.Rollback();
                        MessageBox.Show("Insert Into VACUUM_BODYS 出現錯誤，請確認資料後重新執行。系統訊息：" + Ex.Message, "Inser Into VACUUM_BODYS");
                        return;
                    }
                    
                    MaxVMB++;
                }
                else
                    break;
            }

            //寫入資料庫
            if (objTrans != null)
                objTrans.Commit();
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
            strSQL = "Select VMH001 From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG002 + "' And VMH004 = '" + MN001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            VMB001 = dt.Rows[0]["VMH001"].ToString();
            //逐筆將 是否作廢 填回資料庫
            for (i = 0; i < RowNo - 1; i++)
            {
                VMB003 = dgvVacuumTo.Rows[i].Cells[1].Value.ToString(); //檢查項目代號
                VMB015 = dgvVacuumTo.Rows[i].Cells[6].Value.ToString(); //是否作廢
                strSQL = "Update VACUUM_BODYS Set VMB015 = '" + VMB015 + "' Where VMB001 = '" + VMB001 + "' And VMB003 = '" + VMB003 + "'";
                try
                { objTrans = USQL.SQLNonSelect(ref da, ref objTrans, strSQL); }
                catch(Exception Ex)
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
            strSQL = "Select VMH001 From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG002 + "' And VMH004 = '" + MN001 + "' And VMH011 = 'Y' ";
            dt = USQL.SQLSelect(ref da, strSQL);
            VMB001 = dt.Rows[0]["VMH001"].ToString();
            //標頭檔 資料作廢，但不刪除。
            strSQL = "Update VACUUM_HEADS Set VMH011 = 'N' Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG002 + "' And VMH004 = '" + MN001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);
            //標頭檔 資料作廢，但不刪除。
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
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where MN004 = '" + CG001 + "' And MN003 = '" + FT001 + "' Order by MN001 ";
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
            dgvVacuumFrom.Columns.Clear();
            dgvVacuumTo.Columns.Clear();
            //先檢查是否已做過新增並建立資料在資料庫
            strSQL = "Select * From VACUUM_HEADS Where VMH002 = '" + FT001 + "' And VMH003 = '" + CG002 + "' And VMH004 = '" + MN001 + "' And VMH011 = 'Y' "; //確認表頭檔是否有記錄
            dt = USQL.SQLSelect(ref da, strSQL);
            
            if (dt.Rows.Count > 0)
            {
                //記錄 表頭檔 序號
                VMH001 = dt.Rows[0]["VMH001"].ToString();
                //處理 dgvVacuumFrom ******************************************
                //....帶出 表頭檔 資料
                strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 1, arrCGA, "", "");
                dt = USQL.SQLSelect(ref da, strSQL);
                dgvVacuumFrom.DataSource = dt;
                //....全都 僅可讀
                for (i = 0; i < dgvVacuumFrom.Columns.Count; i++)
                    dgvVacuumFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....帶出 表身檔 資料
                strSQL = drc.DGVShowSQL("Vacuum_VACUUM_BODYS", 0, arrCGA, VMH001, "");
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 Button 欄
                DataGridViewButtonColumn colFrom = new DataGridViewButtonColumn();
                colFrom.Name = "作廢";
                colFrom.ReadOnly = false;
                dgvVacuumTo.Columns.Add(colFrom);
                //....寫入
                dgvVacuumTo.DataSource = dt;
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumTo.Columns.Count; i++)
                    dgvVacuumTo.Columns[i].ReadOnly = true;
                //隱藏 btnLeft 及 btnRight
                btnLeft.Visible = false;
                btnRight.Visible = false;
                //新增 按鈕不可按，修改、刪除 按鈕可按
                isEnable("N","Y","Y","","");
            }
            else
            {
                //處理 dgvVacuumFrom ********************************************
                //....帶出 表頭檔 資料
                strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 1, arrCGA, "", "");
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colFrom = new DataGridViewCheckBoxColumn();
                dgvVacuumFrom.Columns.Insert(0, colFrom);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                Rectangle rect = dgvVacuumFrom.GetCellDisplayRectangle(0, -1, true);
                rect.X = rect.Location.X + rect.Width / 4 - 2;
                rect.Y = rect.Location.Y + (rect.Height / 2 - 6);

                CheckBox cbHeader = new CheckBox();
                cbHeader.Size = new Size(16, 16);
                cbHeader.Name = "FromHeader";
                cbHeader.Location = rect.Location;
                //....全選要設定的事件
                cbHeader.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_From);
                dgvVacuumFrom.Controls.Add(cbHeader);
                //....寫入
                dgvVacuumFrom.DataSource = dt;
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumFrom.Columns.Count; i++)
                    dgvVacuumFrom.Columns[i].ReadOnly = true;
                //處理 dgvVacuumTo ********************************************
                //....帶出 表身檔 空白 資料
                strSQL = "";
                strSQL += "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
                dt = USQL.SQLSelect(ref da, strSQL);
                //....資料第一行放 CheckBox 欄
                DataGridViewColumn colTo = new DataGridViewCheckBoxColumn();
                dgvVacuumTo.Columns.Insert(0, colTo);
                //....建立個矩形，等下計算 CheckBox 嵌入 GridView 的位置
                rect = dgvVacuumTo.GetCellDisplayRectangle(0, -1, true);
                rect.X = rect.Location.X + rect.Width / 4 - 2;
                rect.Y = rect.Location.Y + (rect.Height / 2 - 6);

                cbHeader = new CheckBox();
                cbHeader.Size = new Size(16, 16);
                cbHeader.Name = "ToHeader";
                cbHeader.Location = rect.Location;
                //....全選要設定的事件
                cbHeader.CheckedChanged += new EventHandler(cbHeader_CheckedChanged_To);
                dgvVacuumTo.Controls.Add(cbHeader);
                dgvVacuumTo.DataSource = dt;
                //....除了第一行外，其他行都 僅可讀
                for (i = 1; i < dgvVacuumFrom.Columns.Count; i++)
                    dgvVacuumFrom.Columns[i].ReadOnly = true;
                //顯示 btnLeft 及 btnRight
                btnLeft.Visible = true;
                btnRight.Visible = true;
                //新增 按鈕可按，修改、刪除 按鈕不可按
                isEnable("Y","N","N","","");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumFrom 選至 dgvVacuumTo
            //參數
            int i, dgvFromNo;
            string strSQL, isCheck;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
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
            strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 2, arrCGA, "", "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;

            strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 2, arrCGA, "", "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumFrom.DataSource = dt;

            //新增 按鈕可按，修改、刪除 按鈕不可按
            isEnable("Y", "N", "N", "", "");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumTo 選至 dgvVacuumFrom
            //參數
            int i, dgvFromNo;
            string strSQL, strCK001 = "", isCheck;

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
            
            strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 2, arrCGA, "", "NOT");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumFrom.DataSource = dt;

            strSQL = drc.DGVShowSQL("Vacuum_CHECKITEMS", 2, arrCGA, "", "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;

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
                    grid.Rows[e.RowIndex].Cells[6].Value = "Y";
                else
                    grid.Rows[e.RowIndex].Cells[6].Value = "N";
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
            if (btnAdd == "Y")
                btnVacuumRepAdd.Enabled = true;
            else if (btnAdd == "N")
                btnVacuumRepAdd.Enabled = false;

            if (btnModify == "Y")
                btnVacuumRepModify.Enabled = true;
            else if (btnModify == "N")
                btnVacuumRepModify.Enabled = false;

            if (btnDelete == "Y")
                btnVacuumRepDelete.Enabled = true;
            else if (btnDelete == "N")
                btnVacuumRepDelete.Enabled = false;

            if (btnR == "Y")
                btnRight.Enabled = true;
            else if (btnR == "N")
                btnRight.Enabled = false;

            if (btnL == "Y")
                btnLeft.Enabled = true;
            else if (btnL == "N")
                btnLeft.Enabled = false;
        }
    }
}
