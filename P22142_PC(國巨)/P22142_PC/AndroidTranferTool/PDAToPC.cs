using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System;

namespace AndroidTranferTool
{
    class PDAToPC
    {
        //**********************************************************************************
        //執行 PDA端 資料傳入 PC端所有作業。
        //....1.取得 PDA端 資料，寫入 PC端 對應的資料庫
        //....2.清空 PDA端 資料，由 PC端 塞入 PDA端 所需基本資料
        //**********************************************************************************
        //公用變數

        public bool UsePDAToPC()
        {
            //參數
            int i, j, RowsNo_Hpda, RowsNo_Bpda, RowsNo_pc, MaxRDH;
            string DBPath, strSQL_pda, strSQL_pc, strMaxRDH, pdaHSel;
            string RDH001, RDH002, RDH003, RDH004, RDH005, RDH006, RDH007, RDH008, RDH009, RDH010, RDH011, RDH012, RDH013, RDH014, RDH015, RDH016, RDH017, RDH018; //PC端 RECORDS_HEADS 欄位名
            string RDB001, RDB002, RDB003, RDB004, RDB005, RDB006, RDB007, RDB008, RDB009, RDB010, RDB011, RDB012, RDB013, RDB014, RDB015, RDB016, RDB017; //PC端 RECORDS_BODYS 欄位名
            DbTransaction objTrans = null;
            DataTable dt_Hpda = new DataTable();
            DataTable dt_Bpda = new DataTable();
            DataTable dt_pc = new DataTable();
            P2214201.UseSQLServer USQL = new P2214201.UseSQLServer();

            //SQLite設定
            REGAL.Data.DataAccess.SQLite.DataAccess da_pda = new REGAL.Data.DataAccess.SQLite.DataAccess();
            DBPath = "Data Source=" + Application.StartupPath + "\\SQLDB\\P22142.db3";
            da_pda.ConnectionString = DBPath;
            //SQL Server參數部份
            REGAL.Data.DataAccess.DataAccess da_pc = new REGAL.Data.DataAccess.DataAccess();

            try
            {
                //逐筆取出 PDA端 資料庫資料填入 PC端
                //....抓出 PC端 RECORDS_HEADS 最後的編號
                strSQL_pc = "Select ISNULL(Max(RDH001),'RDH_000000') as MaxRDH001 From RECORDS_HEADS";
                dt_pc = USQL.SQLSelect(ref da_pc, strSQL_pc);
                strMaxRDH = dt_pc.Rows[0]["MaxRDH001"].ToString();
                MaxRDH = int.Parse(strMaxRDH.Substring(4, 6)) + 1;
                //....取出所有 PDA端 RECORDS_HEADS 資料
                strSQL_pda = "Select * From RECORDS_HEADS";
                dt_Hpda = da_pda.ExecuteDataTable(strSQL_pda);
                RowsNo_Hpda = dt_Hpda.Rows.Count;
                for (i = 0; i < RowsNo_Hpda; i++)
                {
                    pdaHSel = dt_Hpda.Rows[i]["RH001"].ToString().Trim();
                    //PDA端 RECORDS_HEADS 資料寫入 PC端 RECORDS_HEADS ***************************************
                    //....PC端 RECORDS_HEADS
                    RDH001 = "RDH_" + MaxRDH.ToString().PadLeft(6, '0'); //流水序號(RDH001)
                    RDH002 = dt_Hpda.Rows[i]["RH002"].ToString().Trim(); //廠房代號(RDH002)
                    RDH003 = dt_Hpda.Rows[i]["RH003"].ToString().Trim(); //廠房名稱(RDH003)
                    RDH004 = dt_Hpda.Rows[i]["RH004"].ToString().Trim(); //類別代號(RDH004)
                    RDH005 = dt_Hpda.Rows[i]["RH005"].ToString().Trim(); //類別名稱(RDH005)
                    RDH006 = dt_Hpda.Rows[i]["RH006"].ToString().Trim(); //機械編號代號(RDH006)
                    RDH007 = dt_Hpda.Rows[i]["RH007"].ToString().Trim(); //機械編號名稱(RDH007)
                    RDH008 = dt_Hpda.Rows[i]["RH008"].ToString().Trim(); //紀錄日期(RDH008)
                    RDH009 = dt_Hpda.Rows[i]["RH009"].ToString().Trim(); //機號(RDH009)
                    RDH010 = dt_Hpda.Rows[i]["RH010"].ToString().Trim(); //人員ID(RDH010)
                    RDH011 = "0";                                        //次數(RDH011)
                    RDH012 = dt_Hpda.Rows[i]["RH010"].ToString().Trim(); //建立者(RDH012)
                    RDH013 = "";                                         //修改者(RDH013)
                    RDH014 = dt_Hpda.Rows[i]["RH008"].ToString().Trim(); //建立時間(RDH014)
                    RDH015 = "";                                         //修改時間(RDH015)
                    RDH016 = "";                                         //備用(RDH016)
                    RDH017 = "";                                         //備用(RDH017)
                    RDH018 = "";                                         //備用(RDH018)
                    //....組 Insert into 語法
                    strSQL_pc = "Insert Into RECORDS_HEADS (RDH001,RDH002,RDH003,RDH004,RDH005,RDH006,RDH007,RDH008,RDH009,RDH010,RDH011,RDH012,RDH013,RDH014,RDH015,RDH016,RDH017,RDH018) Values ('";
                    strSQL_pc = RDH001 + "','" + RDH002 + "','" + RDH003 + "','" + RDH004 + "','" + RDH005 + "','" + RDH006 + "','";
                    strSQL_pc = RDH007 + "','" + RDH008 + "','" + RDH009 + "','" + RDH010 + "','" + RDH011 + "','" + RDH012 + "','";
                    strSQL_pc = RDH013 + "','" + RDH014 + "','" + RDH015 + "','" + RDH016 + "','" + RDH017 + "','" + RDH018 + "')";
                    //....新增至 PC端 RECORDS_HEADS
                    objTrans = USQL.SQLNonSelect(ref da_pc, ref objTrans, strSQL_pc);
                    //***************************************************************************************
                    //取出所有 PDA端 RECORDS_BODYS 資料
                    strSQL_pda = "Select * From RECORDS_BODYS Where RDB001 = '" + pdaHSel + "'";
                    dt_Bpda = da_pda.ExecuteDataTable(strSQL_pda);
                    RowsNo_Bpda = dt_Bpda.Rows.Count;
                    for (j = 0; j < RowsNo_Bpda; j++)
                    {
                        //PDA端 RECORDS_BODYS 資料寫入 PC端 RECORDS_BODYS
                        //....PC端 RECORDS_BODYS
                        RDB001 = RDH001;                                     //表頭流水序號(RDB001)
                        RDB002 = "RDH_" + j.ToString().PadLeft(6, '0');      //表身流水序號(RDB002)
                        RDB003 = dt_Bpda.Rows[j]["RB003"].ToString().Trim(); //檢查項目代號(RDB003)
                        RDB004 = dt_Bpda.Rows[j]["RB004"].ToString().Trim(); //檢查項目名稱(RDB004)
                        RDB005 = dt_Bpda.Rows[j]["RB005"].ToString().Trim(); //參考 起(RDB005)
                        RDB006 = dt_Bpda.Rows[j]["RB006"].ToString().Trim(); //中間符號(RDB006)
                        RDB007 = dt_Bpda.Rows[j]["RB007"].ToString().Trim(); //參考 迄(RDB007)
                        RDB008 = dt_Bpda.Rows[j]["RB008"].ToString().Trim(); //備註1(RDB008)
                        RDB009 = dt_Bpda.Rows[j]["RB009"].ToString().Trim(); //備註2(RDB009)
                        RDB010 = dt_Bpda.Rows[j]["RB010"].ToString().Trim(); //數值(RDB010)
                        RDB011 = RDH012;                                     //建立者(RDB011)
                        RDB012 = "";                                         //修改者(RDB012)
                        RDB013 = RDH014;                                     //建立時間(RDB013)
                        RDB014 = "";                                         //修改時間(RDB014)
                        RDB015 = "";                                         //備用(RDB015)
                        RDB016 = "";                                         //備用(RDB016)
                        RDB017 = "";                                         //備用(RDB017)
                        //....組 Insert into 語法
                        strSQL_pc = "Insert Into RECORDS_BODYS (RDB001,RDB002,RDB003,RDB004,RDB005,RDB006,RDB007,RDB008,RDB009,RDB010,RDB011,RDB012,RDB013,RDB014,RDB015,RDB016,RDB017) Values ('";
                        strSQL_pc = RDB001 + "','" + RDB002 + "','" + RDB003 + "','" + RDB004 + "','" + RDB005 + "','" + RDB006 + "','";
                        strSQL_pc = RDB007 + "','" + RDB008 + "','" + RDB009 + "','" + RDB010 + "','" + RDB011 + "','" + RDB012 + "','";
                        strSQL_pc = RDB013 + "','" + RDB014 + "','" + RDB015 + "','" + RDB016 + "','" + RDB017 + "')";
                        //....新增至 PC端 RECORDS_HEADS
                        objTrans = USQL.SQLNonSelect(ref da_pc, ref objTrans, strSQL_pc);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                if (objTrans != null)
                    objTrans.Rollback();
                MessageBox.Show("PDAToPC 執行作業有誤，系統訊息：" + ex.Message, "PDAToPC 執行作業");
                return false;
            }
            finally
            {
                if (objTrans != null)
                    objTrans.Dispose();
            }
        }
    }
}
