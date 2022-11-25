using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        DealRecord drc = new DealRecord();

        string FT001, CG001, CG002, MN001, MN002;
        string[] arrCGA = new string[100];
        string[] arrTmp = new string[100];


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
            dgvVacuumFrom.ReadOnly = true;
            dgvVacuumFrom.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvVacuumFrom.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 7, FontStyle.Regular);
            dgvVacuumFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //DataGridViewCheckBoxColumn colFrom = new DataGridViewCheckBoxColumn();
            //colFrom.Name = "";
            //colFrom.ReadOnly = false;
            //dgvVacuumFrom.Columns.Add(colFrom);
            //....dgvVacuumTo
            dgvVacuumTo.ReadOnly = true;
            dgvVacuumTo.RowsDefaultCellStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            dgvVacuumTo.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 7, FontStyle.Regular);
            dgvVacuumTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "";
            strSQL += "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "";
            strSQL += "Select CG002 From CATEGORYS Where CG001 = 'A'";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());
            cbxCategorysName.Text = dt.Rows[i - 1]["CG002"].ToString().Trim();
        }
        
        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 廠房代號
            //參數
            int i, RowsNo;
            string strSQL;

            FT001 = cbxFactoryCode.Text;
            CG002 = cbxCategorysName.Text;
            CG001 = USQL.FindCG("", CG002);

            //填入 機械編號(cbxMachineCode)
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where MN004 = '" + CG001 + "' And MN003 = '" + FT001 + "' Order by MN001 ";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            cbxMachineCode.Items.Clear();
            for (i = 0; i < RowsNo; i++)
                cbxMachineCode.Items.Add(dt.Rows[i]["MN001"].ToString().Trim());
            //清空
            cbxMachineCode.Text = "";
            tbxMachineName.Text = "";
        }
        
        private void cbxMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 機械編號，並寫入 機械名稱(tbxMachineName)
            //參數
            string strSQL;
            
            MN001 = cbxMachineCode.Text;
            MN002 = USQL.FindMN(MN001, "");
            tbxMachineName.Text = MN002;

            //列出所有檢查項目
            //....dgvVacuumFrom
            strSQL = drc.DGVShowSQL("Vacuum", 1, arrCGA, "","");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumFrom.DataSource = dt;
            //....dgvVacuumTo
            strSQL = "";
            strSQL += "Select '' as '項目代號 ','' as '項目名稱','' as '備註1','' as '備註2','' as '參考值' Where 1 = 1";
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumFrom 選至 dgvVacuumTo
            //參數
            string tCK001, strSQL;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
            //....目前選到的值的項目代號
            string KeyValue = dgvVacuumFrom.CurrentRow.Cells[0].Value.ToString();
            //....利用串出的文字組成 SQL 填入 dgvVacuumTo
            strSQL = drc.DGVShowSQL("Vacuum", 2, arrCGA, KeyValue, "IN");
            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvVacuumTo 選至 dgvVacuumFrom
            //參數
            string tCK001, strSQL;

            //將 dgvVacuumFrom 選取的資料移到 dgvVacuumTo
            //....目前選到的值的項目代號
            string KeyValue = dgvVacuumTo.CurrentRow.Cells[0].Value.ToString();
            //....利用串出的文字組成 SQL 填入 dgvVacuumTo
            strSQL = drc.DGVShowSQL("Vacuum", 2, arrCGA, KeyValue, "OUT");

            dt = USQL.SQLSelect(ref da, strSQL);
            dgvVacuumTo.DataSource = dt;
        }
    }
}
