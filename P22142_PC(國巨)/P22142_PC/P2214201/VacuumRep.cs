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
        string FT001, CG001, CG002, MN001, MN002;

        public VacuumRep()
        {
            InitializeComponent();
        }

        private void VacuumRep_Load(object sender, EventArgs e)
        {
            //參數
            int i, RowsNo;
            string strSQL;

            //填入 廠房代號(cbxFactoryCode)
            strSQL = "";
            strSQL += "Select * From FACTORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (i = 0; i < RowsNo; i++)
                cbxFactoryCode.Items.Add(dt.Rows[i]["FT001"].ToString().Trim());

            //填入 類別名稱(cbxCategorysName)
            strSQL = "";
            strSQL += "Select * From CATEGORYS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (i = 0; i < RowsNo; i++)
                cbxCategorysName.Items.Add(dt.Rows[i]["CG002"].ToString().Trim());

            //填入 機械編號(cbxMachineCode)
            strSQL = "";
            strSQL += "Select * From MECHNUMBERS";
            dt = USQL.SQLSelect(ref da, strSQL);
            RowsNo = dt.Rows.Count;
            for (i = 0; i < RowsNo; i++)
                cbxMachineCode.Items.Add(dt.Rows[i]["MN001"].ToString().Trim());
        }
        
        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 廠房代號
            FT001 = cbxFactoryCode.Text;
        }

        private void cbxCategorysName_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 類別名稱
            CG002 = cbxCategorysName.Text;
            string strSQL = "";
            strSQL += "Select * From CATEGORYS Where CG002 = '" + CG002 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            CG001 = dt.Rows[0]["CG001"].ToString().Trim();
        }

        private void cbxMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 機械編號，並寫入 機械名稱(tbxMachineName)
            MN001 = cbxMachineCode.Text;
            string strSQL = "";
            strSQL += "Select * From MECHNUMBERS Where MN001 = '" + MN001 + "'";
            dt = USQL.SQLSelect(ref da, strSQL);
            MN002 = dt.Rows[0]["MN002"].ToString().Trim();
            tbxMachineName.Text = MN002;
        }
    }
}
