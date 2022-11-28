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
    public partial class AirConditionRep : Form
    {
        //公用變數
        public string UserAccount, UserName, UserRole;

        

        public AirConditionRep()
        {
            InitializeComponent();
        }

        private void AirConditionRep_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAirConditionRepAdd_Click(object sender, EventArgs e)
        {//********************************************************************
         //新增 功能
         //********************************************************************

        }
        private void btnAirConditionRepModify_Click(object sender, EventArgs e)
        {//********************************************************************
         //修改 功能
         //將所有 是否作廢 欄位值填回資料庫
         //********************************************************************

        }
        private void btnAirConditionRepDelete_Click(object sender, EventArgs e)
        {//********************************************************************
         //刪除 功能
         //1.VACUUM_HEADS 資料作廢，但不刪除。
         //2.VACUUM_BODYS 資料不變動。
         //3.單位機械編號資料 資料作廢，但不刪除。
         //********************************************************************

        }
        private void cbxFactoryCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 廠房代號

        }
        private void cbxMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {//記錄選取的 機械編號，並寫入 機械名稱(tbxMachineName)

        }
        private void btnRight_Click(object sender, EventArgs e)
        {//資料由 dgvAirConditionFrom 選至 dgvAirConditionTo

        }
        private void btnLeft_Click(object sender, EventArgs e)
        {//資料由 dgvAirConditionTo 選至 dgvAirConditionFrom

        }
        private void dgvAirConditionTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//處理 dgvVacuumTo 作廢 按鈕執行狀況

        }
    }
}
