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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //參數
            string strSQL;
            DataAccess da = new DataAccess();
            DataTable dt = new DataTable();
            UseSQLServer USQL = new UseSQLServer();

            //防呆
            //....長度要 8 碼
            if (tbxStaffNo.Text.Length < 8)
            {
                MessageBox.Show("薪號少於 8 碼，請再次輸入。");
                return;
            }
            //搜尋人員
            strSQL = "";
            strSQL += "Select Count(*) as No From USERS Where UR001 = '" + tbxStaffNo.Text.Trim() + "' And UR003 = 'N'";
            dt = USQL.SQLSelect(ref da, strSQL);
            //搜尋未得出對應值，該薪號不可登入
            if(dt.Rows[0]["No"].ToString() == "0")
            {
                MessageBox.Show("該薪號並未記錄於人員基本資料，請確認後再登入。");
                return;
            }
            //查詢登入權限
            strSQL = "";
            strSQL += "Select * From USERS Where UR001 = '" + tbxStaffNo.Text.Trim() + "' And UR003 = 'N'";
            dt = USQL.SQLSelect(ref da, strSQL);
            //開啟 MainForm
            using (MainForm mf = new MainForm())
            {
                this.Visible = false;
                mf.UserAccount = tbxStaffNo.Text.Trim();
                mf.tbxLoginAccount.Text = mf.UserAccount;
                mf.UserName = dt.Rows[0]["UR002"].ToString().Trim();
                mf.UserRole = dt.Rows[0]["UR004"].ToString().Trim();
                mf.tbxLoginRole.Text = mf.UserRole;
                mf.ShowDialog();
                
                mf.Close();
                mf.Dispose();
                this.Close();
            }
        }
    }
}
