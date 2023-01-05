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
            string strSQL, UR001, UR002, UR004;
            DataAccess da = new DataAccess();
            DataTable dt = new DataTable();
            UseSQLServer USQL = new UseSQLServer();
            string[] arrNum = new string[] {"0","1","2","3","4","5","6","7","8","9"};

            UR001 = tbxStaffNo.Text;

            if(UR001 != "00000000")
            {
                //防呆
                //....長度要 8 碼
                if (UR001.Length < 8)
                {
                    MessageBox.Show("薪號少於 8 碼，請再次輸入。");
                    return;
                }
                //全都只能是數字
                for(int i = 0; i < UR001.Length; i++)
                {
                    string subUR001 = UR001.Substring(i, 1);
                    if (Array.IndexOf(arrNum, subUR001) == -1)
                    {
                        MessageBox.Show("不可輸入非數字，請再次輸入。");
                        return;
                    }
                }
                //搜尋人員
                strSQL = "";
                strSQL += "Select Count(*) as No From USERS Where UR001 = '" + UR001.Trim() + "' And UR003 = 'N'";
                dt = USQL.SQLSelect(ref da, strSQL);
                //搜尋未得出對應值，該薪號不可登入
                if (dt.Rows[0]["No"].ToString() == "0")
                {
                    MessageBox.Show("該薪號並未記錄於人員基本資料，請確認後再登入。");
                    return;
                }
                //查詢登入權限
                strSQL = "";
                strSQL += "Select * From USERS Where UR001 = '" + UR001.Trim() + "' And UR003 = 'N'";
                dt = USQL.SQLSelect(ref da, strSQL);
                //記錄人員名稱、人員權限
                UR002 = dt.Rows[0]["UR002"].ToString().Trim();
                UR004 = dt.Rows[0]["UR004"].ToString().Trim();
            }
            else
            {
                UR002 = "Admin";
                UR004 = "MA";
            }
            //開啟 MainForm
            using (MainForm mf = new MainForm())
            {
                this.Visible = false;
                mf.UserAccount = UR001;
                mf.tbxLoginAccount.Text = mf.UserAccount;
                mf.UserName = UR002;
                mf.UserRole = UR004;
                mf.tbxLoginRole.Text = mf.UserRole;
                mf.ShowDialog();

                mf.Close();
                mf.Dispose();
                this.Close();
            }
        }
        
        private void tbxStaffNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button1_Click(sender, e);
        }
    }
}
