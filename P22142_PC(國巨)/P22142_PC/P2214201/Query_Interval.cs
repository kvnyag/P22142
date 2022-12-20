using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2214201
{
    public partial class Query_Interval : Form
    {
        //公用變數
        public string StartDate, EndDate;
        
        public Query_Interval()
        {
            InitializeComponent();
        }

        private void btnVacuumDemAdd_Click(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value.ToString("yyyy/MM/dd");
            EndDate = dtpEnd.Value.ToString("yyyy/MM/dd");

            DialogResult = DialogResult.OK;
        }
    }
}
