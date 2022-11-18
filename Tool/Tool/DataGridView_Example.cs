using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class DataGridView_Example : Form
    {
        //公用變數
        DataSet ds = new DataSet();
        DataTable dt;

        public DataGridView_Example()
        {
            InitializeComponent();
        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {//建立資料表
            //建一個名User的Table
            dt = new DataTable("User");
            ds.Tables.Add(dt);
            //加入表頭資訊
            dt.Columns.Add("user_name", typeof(string));
            dt.Columns.Add("user_password", typeof(string));
            dt.Columns.Add("user_age", typeof(int));
            //將DataTable指給DataGridView
            dgvDataGridView.DataSource = dt;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {//新增資料
            DateTime dtime = DateTime.Now;
            int Sec = dtime.Second;

            //新增一筆DataRow，依3個表頭原故，加入3個值。
            for(int i = 0; i < 5; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "User" + i.ToString().PadLeft(2,'0');
                dr[1] = Sec.ToString().PadLeft(2,'0') + Math.Abs(Sec  - 10).ToString().PadLeft(2, '0') + Math.Abs(Sec + 10).ToString().PadLeft(2, '0');
                dr[2] = i + 25;
                //將值塞進DataTable中，DataGridView即會同步更新。
                dt.Rows.Add(dr);
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {//修改資料
            dgvDataGridView.Rows[2].ReadOnly = false;

            int i = dgvDataGridView.CurrentRow.Index;
            DataRow dr = dt.Rows[i];
            dr.BeginEdit();
            dr[0] = "John";
            dr[1] = "123456";
            dr[2] = 31;
            dr.EndEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//刪除資料
            int i = dgvDataGridView.CurrentRow.Index;
            DataRow dr = dt.Rows[i];
            dt.Rows.Remove(dr);
        }

        private void btnDataGridViewSet_Click(object sender, EventArgs e)
        {//DataGridView設定
            dgvDataGridView.EditMode = DataGridViewEditMode.EditOnEnter; //單擊單元格編輯
        }

        private void button1_Click(object sender, EventArgs e)
        {//僅可修改某一欄資料
            MessageBox.Show("DataGridView共有" + dgvDataGridView.Columns.Count.ToString() + "行");
            MessageBox.Show("僅可修改第2行的資料");
            //設定ReagOney的範圍
            dgvDataGridView.Columns[0].ReadOnly = true;
            dgvDataGridView.Columns[1].ReadOnly = true;
            dgvDataGridView.Columns[2].ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {//取得點選格資訊
            //目前點選的是第幾行
            int idxCell = dgvDataGridView.CurrentCell.ColumnIndex;
            MessageBox.Show("目前點選的是第 " + idxCell.ToString() + " 行");
            //目前點選的值是什麼
            string NowValue = dgvDataGridView.CurrentCell.Value.ToString();
            MessageBox.Show("目前點選的值是：" + NowValue);
            //目前點選的行的標頭名稱
            string Header = dgvDataGridView.Columns[idxCell].HeaderText;
            MessageBox.Show("目前點選的行的標頭名稱：" + Header);
            //目前點選的列的第1個值(假設第1個值為Key值)
            string KeyValue = dgvDataGridView.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("目前點選的列的第1個值：" + KeyValue);
        }
    }
}
