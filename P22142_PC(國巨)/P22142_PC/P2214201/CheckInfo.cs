using System;
using System.Data;
using System.Windows.Forms;
using REGAL.Data.DataAccess;
using System.Drawing;

namespace P2214201
{
    public partial class CheckInfo : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;
        public double oldWidth, oldHeight, newWidth, newHeight;
        string MN001, MN002, MN003, MN004, MN005, MN006, MN007, MN008, MN009, MN010, MN011, MN012; //單位機械編號資料 欄位名
        string CK001, CK002, CK003, CK004, CK005, CK006, CK007, CK008, CK009, CK010, CK011, CK012, CK013, CK014, CK015, CK016; //檢查項目基本資料 欄位名
        string CG001, CG002, FT001;
        string strDemand = "", isDGVUse = "N";
        UseSQLServer USQL = new UseSQLServer();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DealRecord drc = new DealRecord();

        public CheckInfo()
        {
            InitializeComponent();
        }

        private void CheckInfo_Resize(object sender, EventArgs e)
        {
            int NewX, NewY;

            if (oldWidth > 0 && oldHeight > 0 && newWidth > 0 && newHeight > 0)
            {
                double x = (newWidth / oldWidth);
                double y = (newHeight / oldHeight);

                dgvCheck.Width = Convert.ToInt32(x * dgvCheck.Width);
                dgvCheck.Height = Convert.ToInt32(y * dgvCheck.Height);

                gbxFun.Width = Convert.ToInt32(x * gbxFun.Width);
                gbxFun.Height = Convert.ToInt32(y * gbxFun.Height);

                gbxShow.Width = Convert.ToInt32(x * gbxShow.Width);
                gbxShow.Height = Convert.ToInt32(y * gbxShow.Height);

                NewX = (int)(btnCheckInfoAdd.Location.X * x + btnCheckInfoAdd.Width * (x - 1));
                btnCheckInfoAdd.Location = new Point(NewX, btnCheckInfoAdd.Location.Y);
                btnCheckInfoAdd.Width = Convert.ToInt32(x * btnCheckInfoAdd.Width);
                btnCheckInfoAdd.Height = Convert.ToInt32(y * btnCheckInfoAdd.Height);

                NewX = (int)(btnCheckInfoModify.Location.X * x + btnCheckInfoModify.Width * (x - 1));
                btnCheckInfoModify.Location = new Point(NewX, btnCheckInfoModify.Location.Y);
                btnCheckInfoModify.Width = Convert.ToInt32(x * btnCheckInfoModify.Width);
                btnCheckInfoModify.Height = Convert.ToInt32(y * btnCheckInfoModify.Height);

                NewX = (int)(btnCheckInfoDelete.Location.X * x + btnCheckInfoDelete.Width * (x - 1));
                btnCheckInfoDelete.Location = new Point(NewX, btnCheckInfoDelete.Location.Y);
                btnCheckInfoDelete.Width = Convert.ToInt32(x * btnCheckInfoDelete.Width);
                btnCheckInfoDelete.Height = Convert.ToInt32(y * btnCheckInfoDelete.Height);

                NewX = (int)(btnCheckInfoDemand.Location.X * x + btnCheckInfoDemand.Width * (x - 1));
                btnCheckInfoDemand.Location = new Point(NewX, btnCheckInfoDemand.Location.Y);
                btnCheckInfoDemand.Width = Convert.ToInt32(x * btnCheckInfoDemand.Width);
                btnCheckInfoDemand.Height = Convert.ToInt32(y * btnCheckInfoDemand.Height);
            }
        }

        private void CheckInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(this.DisplayRectangle, Color.Linen, Color.DarkTurquoise, 45);
            g.FillRectangle(lb, this.DisplayRectangle);
        }

        private void CheckInfo_Load(object sender, EventArgs e)
        {
            //參數
            int i;
            string strSQL;

            //DataGridView 設定
            drc.SetDataGridView(ref dgvCheck);

            //寫入類別名稱下拉選單
            strSQL = "Select * From CATEGORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            for (i = 0; i < dt.Rows.Count; i++)
                cbxReportName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());

            //寫入參考項目值2
            cbxRefer2.Items.Add(">");
            cbxRefer2.Items.Add("<");
            cbxRefer2.Items.Add("~");

            //寫入廠房代號下拉選單
            strSQL = "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            
            for (i = 0; i < dt.Rows.Count; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //管理者身份可使用 新增、刪除、修改、查詢、離開
            //操作者身份可使用 查詢、離開
            if (UserRole == "OP") //操作者身份
            {
                btnCheckInfoAdd.Enabled = false;    //新增
                btnCheckInfoModify.Enabled = false; //修改
                btnCheckInfoDelete.Enabled = false; //刪除
                //btnStaffInfoStore.Enabled = false;  //儲存
            }
            //DataGridView設定
            dgvCheck.ReadOnly = true;
        }

        private void cbxReportCode_SelectedIndexChanged(object sender, EventArgs e)
        {//類別名稱改變後，直接找出最新的一組檢查項目號碼，填入檢查項目代號
            //參數
            int maxNo;
            string strSQL;
            
            //檢查項目代號(CK001)
            //....查目前類別名稱，找出目前類別代號
            CG002 = cbxReportName.Text;
            CG001 = USQL.FindCG("", CG002);
            //....若類別代號是 D(水電機械指數表)，需多填入 廠房代號
            if(CG001 == "D")
            { label7.Visible = true; cbxFactoryCode.Visible = true; }
            else
            { label7.Visible = false; cbxFactoryCode.Visible = false; }
            //....找出目前資料庫中該類別代號的最大值
            /*
            if (CG001 != "D")
            {
                strSQL = "Select ISNULL(Max(CK001),'0000000') as MaxCK001 From CHECKITEMS Where CK016 = '" + CG001 + "'";
                dt = USQL.SQLSelect(ref da, strSQL);
                string MaxCK001 = dt.Rows[0]["MaxCK001"].ToString().Trim();
                int lenMaxCK001 = MaxCK001.Length;
                maxNo = int.Parse(MaxCK001.Substring((lenMaxCK001 - 5), 5));
                //....建出檢查項目代號
                tbxCheckCode.Text = CG001 + (maxNo + 1).ToString().PadLeft(5, '0');
            }
            */
            //清空
            if (isDGVUse != "Y")
            {
                ClearForm();
                dgvCheck.DataSource = null;
                dgvCheck.ClearSelection();
            }
        }

        private void cbxFactoryName_SelectedIndexChanged(object sender, EventArgs e)
        {//廠房代號改變後，直接找出最新的一組檢查項目號碼，填入檢查項目代號
            int noFT001, maxNo;
            string strSQL;

            //檢查項目代號(CK001)
            //....找出目前資料庫中該類別代號的最大值
            /*
            FT001 = cbxFactoryCode.Text;
            noFT001 = FT001.Length;
            strSQL = "Select ISNULL(Max(CK001),'0000000') as MaxCK001 From CHECKITEMS Where CK016 = 'D' And CK015 = '" + FT001 + "'";

            dt = USQL.SQLSelect(ref da, strSQL);
            string MaxCK001 = dt.Rows[0]["MaxCK001"].ToString().Trim();
            int lenMaxCK001 = MaxCK001.Length;
            maxNo = int.Parse(MaxCK001.Substring((lenMaxCK001 - 5), 5));
            //....建出檢查項目代號
            tbxCheckCode.Text = CG001 + (maxNo + 1).ToString().PadLeft(5, '0');
            */
            //清空
            if (isDGVUse != "Y")
            {
                tbxCheckCode.Text = "";
                tbxCheckName.Text = "";
                tbxMemo1.Text = "";
                tbxMemo2.Text = "";
                tbxRefer1.Text = "";
                cbxRefer2.Text = "";
                tbxRefer3.Text = "";
                dgvCheck.DataSource = null;
            }
        }

        private void btnCheckInfoAdd_Click(object sender, EventArgs e)
        {//執行"新增"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y", "Y", "Y") == false) return;

            //確定要 Insert 的檢查項目代號是否已存在資料庫
            if (CG001 == "D")
                CK001 = FT001 + "_" + tbxCheckCode.Text;          //檢查項目代號(CK001)
            else
                CK001 = tbxCheckCode.Text;                        //檢查項目代號(CK001)
            
            strSQL = "Select * From CHECKITEMS Where 1 = 1 And CK001 = '" + CK001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if(dt.Rows.Count > 0)
            { MessageBox.Show("要新增的檢查項目代號已存在，請確認後再執行新增作業。"); return; }

            // Insert 資料進資料庫
            CK002 = tbxCheckName.Text;                            //檢查項目名稱(CK002)
            CK003 = tbxRefer1.Text;                               //參考 起(CK003)
            CK004 = cbxRefer2.Text;                               //中間符號(CK004)
            CK005 = tbxRefer3.Text;                               //參考 迄(CK005)
            CK006 = tbxMemo1.Text;                                //備註1(CK006)
            CK007 = tbxMemo2.Text;                                //備註2(CK007)
            CK008 = UserName;                                     //建立者(CK008)
            CK009 = "";                                           //修改者(CK009)
            CK010 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間(CK010)
            CK011 = "";                                           //修改時間(CK011)
            CK012 = "";                                           //備用(CK012)
            CK013 = "";                                           //備用(CK013)
            CK014 = "";                                           //備用(CK014)
            CK015 = FT001;                                        //廠房代號(CK015)
            CK016 = CG001;                                        //類別代號(CK016)
            
            strSQL = "Insert Into CHECKITEMS (CK001,CK002,CK003,CK004,CK005,CK006,CK007,CK008,CK009,CK010,CK011,CK012,CK013,CK014,CK015,CK016) Values ('";
            strSQL += CK001 + "','" + CK002 + "','" + CK003 + "','" + CK004 + "','" + CK005 + "','" + CK006 + "','";
            strSQL += CK007 + "','" + CK008 + "','" + CK009 + "','" + CK010 + "','" + CK011 + "','" + CK012 + "','";
            strSQL += CK013 + "','" + CK014 + "','" + CK015 + "','" + CK016 + "')";
            USQL.SQLNonSelect(ref da, strSQL);

            //若填寫 類別代號為 D(水電機械指數表)，要回填 單位機械編號資料
            if (CG001 == "D")
            {
                MN001 = CK001;                                        //機械編號
                MN002 = CK002;                                        //機械名稱
                MN003 = FT001;                                        //廠房代號 
                MN004 = CG001;                                        //類別代號 
                MN005 = UserName;                                     //建立者
                MN006 = "";                                           //修改者
                MN007 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //建立時間
                MN008 = "";                                           //修改時間
                MN009 = "";                                           //備用
                MN010 = tbxCheckCode.Text;                            //備用
                MN011 = "";                                           //備用
                MN012 = "Y";                                          //是否仍然使用
                
                strSQL = "Insert Into MECHNUMBERS (MN001,MN002,MN003,MN004,MN005,MN006,MN007,MN008,MN009,MN010,MN011,MN012) Values ('";
                strSQL += MN001 + "','" + MN002 + "','" + MN003 + "','" + MN004 + "','" + MN005 + "','" + MN006 + "','";
                strSQL += MN007 + "','" + MN008 + "','" + MN009 + "','" + MN010 + "','" + MN011 + "','" + MN012 + "')";

                USQL.SQLNonSelect(ref da, strSQL);
            }
            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvCheck.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvCheck.ClearSelection();
                }
            }
            catch(Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }
        
        private void btnCheckInfoModify_Click(object sender, EventArgs e)
        {//執行"修改"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("Y", "Y", "Y", "Y") == false) return;


            //確定要 Update 的檢查項目代號是否已存在資料庫
            if (CG001 == "D")
                CK001 = FT001 + "_" + tbxCheckCode.Text.Trim();
            else
                CK001 = tbxCheckCode.Text.Trim();
            
            strSQL = "Select * From CHECKITEMS Where 1 = 1 And CK001 = '" + CK001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的檢查項目代號未存在，請確認後再執行修改作業。"); return; }
            
            // Update 資料進資料庫
            // PS：因帳號是唯一值，不得修改。僅可刪除後再新增。
            CK002 = tbxCheckName.Text;                     //檢查項目名稱(CK002)
            CK003 = tbxRefer1.Text;                        //參考 起(CK003)
            CK004 = cbxRefer2.Text;                        //中間符號(CK004)
            CK005 = tbxRefer3.Text;                        //參考 迄(CK005)
            CK006 = tbxMemo1.Text;                         //備註1(CK006)
            CK007 = tbxMemo2.Text;                         //備註2(CK007)

            strSQL = "";
            strSQL += "Update CHECKITEMS Set CK002 = '" + CK002 + "',CK003 = '" + CK003 + "',CK004 = '" + CK004 + "',";
            strSQL += "CK005 = '" + CK005 + "',CK006 = '" + CK006 + "',CK007 = '" + CK007 + "',";
            strSQL += "CK009 = '" + UserName + "',CK011 = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'";
            strSQL += "Where CK001 = '" + CK001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //若填寫 類別代號為 D(水電機械指數表)，要回填 單位機械編號資料
            if (CG001 == "D")
            {
                MN001 = CK001;                                        //機械編號
                MN002 = CK002;                                        //機械名稱
                MN006 = UserName;                                     //修改者
                MN008 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); //修改時間
                
                strSQL = "Update MECHNUMBERS Set MN002 = '" + MN002 + "',MN006 = '" + MN006 + "',MN008 = '" + MN008 + "' ";
                strSQL += "Where MN001 = '" + MN001 + "'";
                USQL.SQLNonSelect(ref da, strSQL);
            }
            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvCheck.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvCheck.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnCheckInfoDelete_Click(object sender, EventArgs e)
        {//執行"刪除"動作
            //參數
            string strSQL;

            //防呆
            if (CheckData("N", "N", "Y", "N") == false) return;

            //確定要 Update 的帳號是否已存在資料庫
            if (CG001 == "D")
                CK001 = FT001 + tbxCheckCode.Text.Trim();
            else
                CK001 = tbxCheckCode.Text.Trim();

            strSQL = "Select * From CHECKITEMS Where 1 = 1 And CK001 = '" + CK001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
            { MessageBox.Show("要修改的檢查項目代號未存在，請確認後再執行刪除作業。"); return; }

            // Delete 資料庫
            CK001 = tbxCheckCode.Text;                   //檢查項目代號 (CK001)
            
            strSQL = "Delete From CHECKITEMS Where CK001 = '" + CK001 + "'";
            USQL.SQLNonSelect(ref da, strSQL);

            //重整 DataGridView 顯示
            try
            {
                if (strDemand != "")
                {
                    dgvCheck.DataSource = USQL.SQLSelect(ref da, strDemand);
                    dgvCheck.ClearSelection();
                }
            }
            catch (Exception Ex)
            { }

            //清空所有可填入欄位
            ClearForm();
        }

        private void btnCheckInfoDemand_Click(object sender, EventArgs e)
        {//執行"查詢"動作
            //參數
            string strSQL;

            //搜尋結果填入 DataGridView
            CG001 = USQL.FindCG("", cbxReportName.Text.Trim());
            FT001 = cbxFactoryCode.Text.Trim();
            CK001 = tbxCheckCode.Text.Trim();
            CK002 = tbxCheckName.Text.Trim();

            strSQL = "Select CK001 as '檢查項目代號',";
            strSQL += "CK002 as '檢查項目名稱',";
            strSQL += "CK006 as '備註1',";
            strSQL += "CK007 as '備註2',";
            strSQL += "CK003 as '參考起值',";
            strSQL += "CK004 as '符號',";
            strSQL += "CK005 as '參考訖值',";
            strSQL += "CK015 as '廠房代號',";
            strSQL += "CK016 as '類別代號 ',";
            strSQL += "CK008 as '建立人員' ";
            strSQL += "From CHECKITEMS ";
            strSQL += "Where 1 = 1 ";
            if (FT001 != "")
                strSQL += "AND CK015 = '" + FT001 + "' ";
            if(CG001 != "")
                strSQL += "AND CK016 = '" + CG001 + "' ";
            if (CK001 != "")
                strSQL += "And CK001 = '" + CK001 + "' ";
            if (CK002 != "")
                strSQL += "And CK002 = '" + CK002 + "' ";
            if (tbxMemo1.Text.Trim() != "")
                strSQL += "And CK006 = '" + tbxMemo1.Text.Trim().Substring(0, 1) + "' ";
            if (tbxMemo2.Text.Trim() != "")
                strSQL += "And CK007 = '" + tbxMemo2.Text.Trim().Substring(0, 1) + "' ";
            if (tbxRefer1.Text.Trim() != "")
                strSQL += "And CK003 = '" + tbxRefer1.Text.Trim().Substring(0, 1) + "' ";
            if (cbxRefer2.Text.Trim() != "")
                strSQL += "And CK004 = '" + cbxRefer2.Text.Trim().Substring(0, 1) + "' ";
            if (tbxRefer1.Text.Trim() != "")
                strSQL += "And CK005 = '" + tbxMemo1.Text.Trim().Substring(0, 1) + "' ";
            strSQL += "Order By CK001";

            strDemand = strSQL; //記錄查詢過的語句，方便新增、修改、刪除後重整 DataGridView 顯示

            dt = USQL.SQLSelect(ref da, strSQL);

            if (dt.Rows.Count == 0)
                MessageBox.Show("輸入條件未查詢到任何資料。");

            dgvCheck.DataSource = dt;
            dgvCheck.ClearSelection();
            //清空所有可填入欄位
            ClearForm();
        }

        private void dgvCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView 任意點選，代入值進畫面。
            //....確定DataGridView有值
            if (dgvCheck.Rows.Count > 0)
            {
                isDGVUse = "Y";

                tbxCheckCode.Text = dgvCheck.CurrentRow.Cells[0].Value.ToString().Trim(); //檢查項目代號
                tbxCheckName.Text = dgvCheck.CurrentRow.Cells[1].Value.ToString().Trim();   //檢查項目名稱
                tbxMemo1.Text = dgvCheck.CurrentRow.Cells[2].Value.ToString().Trim();       //備註1
                tbxMemo2.Text = dgvCheck.CurrentRow.Cells[3].Value.ToString().Trim();       //備註2
                tbxRefer1.Text = dgvCheck.CurrentRow.Cells[4].Value.ToString().Trim();      //參考 起
                cbxRefer2.Text = dgvCheck.CurrentRow.Cells[5].Value.ToString().Trim();      //中間符號
                tbxRefer3.Text = dgvCheck.CurrentRow.Cells[6].Value.ToString().Trim();      //參考 訖
                cbxFactoryCode.Text = dgvCheck.CurrentRow.Cells[7].Value.ToString().Trim(); //廠房代號
                CG001 = dgvCheck.CurrentRow.Cells[8].Value.ToString().Trim();
                CG002 = USQL.FindCG(CG001, "");
                cbxReportName.Text = CG002;                                                 //廠房代號

                isDGVUse = "N";
            }
        }

        private bool CheckData(string bCG002, string bFT001, string bCK001, string bCK002)
        {
            //*************************************************************************************
            //防呆專區
            //*************************************************************************************
            FT001 = cbxFactoryCode.Text.Trim();
            CG002 = cbxReportName.Text.Trim();
            if (CG002 != "") CG001 = USQL.FindCG("", CG002);
            CK001 = tbxCheckCode.Text.Trim();
            CK002 = tbxCheckName.Text.Trim();

            if (bCG002 == "Y" && CG002 == "")
            { MessageBox.Show("類別名稱不可空白。"); return false; }
            if (bFT001 == "Y" && CG001 == "D" && FT001 == "")
            { MessageBox.Show("廠房名稱不可空白。"); return false; }
            if(bCK001 == "Y" && CK001 == "")
            { MessageBox.Show("檢查項目代號不可空白。"); return false; }
            if (bCK002 == "Y" && CK002 == "")
            { MessageBox.Show("檢查項目名稱不可空白。"); return false; }

            return true;
        }
        private void ClearForm()
        {
            //*************************************************************************************
            //清空資料專區
            //*************************************************************************************
            cbxReportName.Text = "";
            tbxCheckCode.Text = "";
            tbxCheckName.Text = "";
            tbxMemo1.Text = "";
            tbxMemo2.Text = "";
            tbxRefer1.Text = "";
            cbxRefer2.Text = "";
            tbxRefer3.Text = "";
            cbxFactoryCode.Text = "";
        }
    }
}
