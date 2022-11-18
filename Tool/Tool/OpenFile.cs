using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    class OpenFile
    {
        public string btnSelectFileExample1()
        {
            //開啟選擇檔案視窗
            OpenFileDialog dialog = new OpenFileDialog();
            //限制開啟的檔案類型
            dialog.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";
            //確定已選擇
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fName = dialog.FileName;
                return "OK";
            }
            else
            {
                return "False";
            }
        }
    }
}
