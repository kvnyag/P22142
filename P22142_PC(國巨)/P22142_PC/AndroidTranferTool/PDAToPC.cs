using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System;
using REGAL.Data.DataAccess;

namespace AndroidTranferTool
{
    public partial class PDAToPC
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
            int i, j, RowsNo_pda, RowsNo_pc, MaxRDH001, MaxRDB002, idxKEY;
            int MH001 = 0, MB001 = 0, MB002 = 0, RDH001 = 0, RDB001 = 0, RDB002 = 0;
            string DBPath, strSQL_pda, strSQL_pc;
            string FT001 = "", CG001 = "", MN001 = "", CK001 = "";
            string MH002, MH003, MH004, MH005, MH006, MH007; //PDA端 MAINS_HEADS 欄位名
            string MB003, MB004, MB005, MB006, MB007, MB008, MB009, MB010; //PDA端 MAINS_BODYS 欄位名
            string US001, US002, US003, US004, US005, US006, US007, US008; //PDA端 USERS 欄位名
            string RDH002, RDH003, RDH004, RDH005, RDH006, RDH007, RDH008, RDH009, RDH010, RDH011, RDH012 = "", RDH013, RDH014 = "", RDH015, RDH016, RDH017, RDH018; //PC端 RECORDS_HEADS 欄位名
            string RDB003, RDB004, RDB005, RDB006, RDB007, RDB008, RDB009, RDB010, RDB011, RDB012, RDB013, RDB014, RDB015, RDB016, RDB017, RDB018; //PC端 RECORDS_BODYS 欄位名
            string[] arrKEY;
            DbTransaction objTrans_pc = null;
            DbTransaction objTrans_pda = null;
            DataTable dt_pda = new DataTable();
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
                //....取得PC端 RECORDS_HEADS 下一序號
                strSQL_pc = "Select ISNULL(MAX(RDH001),0) as RDH001 From RECORDS_HEADS";
                dt_pc = USQL.SQLSelect(ref da_pc, strSQL_pc);
                MaxRDH001 = int.Parse(dt_pc.Rows[0]["RDH001"].ToString());
                //....頭表序號(RDH001) & (RDB001)
                RDH001 = MaxRDH001;
                RDB001 = MaxRDH001;
                //....取得PC端 RECORDS_BODYS 下一序號
                strSQL_pc = "SELECT ISNULL(MAX(RDB002),0) as RDB002 FROM RECORDS_BODYS";
                dt_pc = USQL.SQLSelect(ref da_pc, strSQL_pc);
                MaxRDB002 = int.Parse(dt_pc.Rows[0]["RDB002"].ToString());
                //....表身序號(RDB002)
                RDB002 = MaxRDB002;
                //....記錄PC端 KEY值，以避免 PDA端 資料寫入重覆資料
                strSQL_pc = "SELECT (RDH002 + RDH004 + RDH008) as KEYValue FROM RECORDS_HEADS GROUP BY RDH002,RDH004,RDH008";
                dt_pc = USQL.SQLSelect(ref da_pc, strSQL_pc);
                arrKEY = new string[dt_pc.Rows.Count];
                for(i = 0; i < dt_pc.Rows.Count; i++)
                {
                    arrKEY[i] = dt_pc.Rows[i]["KEYValue"].ToString().Trim();
                }
                //....取出所有 PDA端 RECORDS_HEADS & RECORDS_BODYS 組合的資料
                strSQL_pda = "SELECT a.RH003,a.RH004,a.RH005,a.RH006,a.RH007,a.RH008,a.RH009,a.RH010,a.RH011,b.RB004,b.RB005,b.RB006,b.RB007,b.RB008,b.RB009,b.RB010,b.RB012,b.RB013 ";
                strSQL_pda += "FROM RECORDS_HEADS a,RECORDS_BODYS b ";
                strSQL_pda += "WHERE a.RH002 = b.RB002 AND a.RH009 = b.RB011 ";
                strSQL_pda += "ORDER BY a.RH005,a.RH003,a.RH007,b.RB004 ";
                dt_pda = da_pda.ExecuteDataTable(strSQL_pda);
                RowsNo_pda = dt_pda.Rows.Count;
                //....逐筆取出 PDA端 RECORDS_HEADS & RECORDS_BODYS 組合的資料 寫入 PC端 RECORDS_HEADS & RECORDS_BODYS
                for (i = 0; i < RowsNo_pda; i++)
                {
                    //***************************************************************************************
                    try
                    {
                        //PDA端 RECORDS_HEADS 資料寫入 PC端 RECORDS_HEADS
                        //....PC端 RECORDS_HEADS
                        RDH002 = dt_pda.Rows[i]["RH003"].ToString().Trim(); //廠房代號(RDH002)
                        RDH003 = dt_pda.Rows[i]["RH004"].ToString().Trim(); //廠房名稱(RDH003)
                        RDH004 = dt_pda.Rows[i]["RH005"].ToString().Trim(); //類別代號(RDH004)
                        RDH005 = dt_pda.Rows[i]["RH006"].ToString().Trim(); //類別名稱(RDH005)
                        RDH006 = dt_pda.Rows[i]["RH007"].ToString().Trim(); //機械編號代號(RDH006)
                        RDH007 = dt_pda.Rows[i]["RH008"].ToString().Trim(); //機械編號名稱(RDH007)
                        RDH008 = dt_pda.Rows[i]["RH009"].ToString().Trim(); //紀錄日期(RDH008)
                        RDH009 = dt_pda.Rows[i]["RH010"].ToString().Trim(); //機號(RDH009)
                        RDH010 = dt_pda.Rows[i]["RH011"].ToString().Trim(); //人員ID(RDH010)
                        RDH011 = "0";                                        //次數(RDH011)
                        RDH012 = dt_pda.Rows[i]["RH011"].ToString().Trim(); //建立者(RDH012)
                        RDH013 = "";                                         //修改者(RDH013)
                        RDH014 = dt_pda.Rows[i]["RH009"].ToString().Trim(); //建立時間(RDH014)
                        RDH015 = "";                                         //修改時間(RDH015)
                        RDH016 = "";                                         //備用(RDH016)
                        RDH017 = "";                                         //備用(RDH017)
                        RDH018 = "";                                         //備用(RDH018)
                        //PDA端 RECORDS_BODYS 資料寫入 PC端 RECORDS_BODYS
                        //....PC端 RECORDS_BODYS
                        RDB003 = dt_pda.Rows[i]["RB004"].ToString().Trim(); //檢查項目代號(RDB003)
                        RDB004 = dt_pda.Rows[i]["RB005"].ToString().Trim(); //檢查項目名稱(RDB004)
                        RDB005 = dt_pda.Rows[i]["RB006"].ToString().Trim(); //參考 起(RDB005)
                        RDB006 = dt_pda.Rows[i]["RB007"].ToString().Trim(); //中間符號(RDB006)
                        RDB007 = dt_pda.Rows[i]["RB008"].ToString().Trim(); //參考 迄(RDB007)
                        RDB008 = dt_pda.Rows[i]["RB009"].ToString().Trim(); //備註1(RDB008)
                        RDB009 = dt_pda.Rows[i]["RB010"].ToString().Trim(); //備註2(RDB009)
                        RDB010 = dt_pda.Rows[i]["RB012"].ToString().Trim(); //數值(RDB010)
                        RDB011 = RDH012;                                     //建立者(RDB011)
                        RDB012 = "";                                         //修改者(RDB012)
                        RDB013 = RDH014;                                     //建立時間(RDB013)
                        RDB014 = "";                                         //修改時間(RDB014)
                        RDB015 = "";                                         //備用(RDB015)
                        RDB016 = "";                                         //備用(RDB016)
                        RDB017 = "";                                         //備用(RDB017)
                        RDB018 = dt_pda.Rows[i]["RB013"].ToString().Trim(); //是否作廢(RDB018)

                        //利用紀錄日期、廠房代號、類別代號來確認PDA端資料是否有重覆寫入PC端現象
                        idxKEY = Array.IndexOf(arrKEY, (RDH002 + RDH004 + RDH008));
                        if (idxKEY != -1) continue;

                        if (FT001 != RDH002 || CG001 != RDH004 || MN001 != RDH006)
                        {
                            //若 暫存的 FT001 or CG001 or MN001 與 廠房代號(RDH002) or 類別代號(RDH004) or 機械編號代號(RDH006) 不同
                            //1.資料庫抓取的值寫入暫存
                            //2.表頭序號 及 表身序號 都 +1
                            //3.新增一筆 RECORDS_HEADS 及 新增一筆 RECORDS_BODYS

                            FT001 = RDH002; CG001 = RDH004; MN001 = RDH006;
                            RDH001++; RDB001++; RDB002++;

                            //....新增至 PC端 RECORDS_HEADS
                            strSQL_pc = "Insert Into RECORDS_HEADS (RDH001,RDH002,RDH003,RDH004,RDH005,RDH006,RDH007,RDH008,RDH009,RDH010,RDH011,RDH012,RDH013,RDH014,RDH015,RDH016,RDH017,RDH018) Values (";
                            strSQL_pc += RDH001 + ",'" + RDH002 + "','" + RDH003 + "','" + RDH004 + "','" + RDH005 + "','" + RDH006 + "','";
                            strSQL_pc += RDH007 + "','" + RDH008 + "','" + RDH009 + "','" + RDH010 + "','" + RDH011 + "','" + RDH012 + "','";
                            strSQL_pc += RDH013 + "','" + RDH014 + "','" + RDH015 + "','" + RDH016 + "','" + RDH017 + "','" + RDH018 + "')";

                            try
                            {
                                objTrans_pc = USQL.SQLNonSelect(ref da_pc, ref objTrans_pc, strSQL_pc);
                            }
                            catch (Exception Ex)
                            {
                                if (objTrans_pc != null)
                                    objTrans_pc.Rollback();
                                MessageBox.Show("PDA端 RECORDS_HEADS 資料寫入 PC端 RECORDS_HEADS 有誤，系統訊息：" + Ex.Message, "RECORDS_HEADS 寫入作業");
                                return false;
                            }
                        }
                        else if (FT001 == RDH002 && CG001 == RDH004 && MN001 == RDH006 && CK001 != RDB003)
                        {
                            //若 暫存的 FT001 and CG001 and MN001 與 廠房代號(RDH002) and 類別代號(RDH004) and 機械編號代號(RDH006) 相同，但 CK001 與 檢查項目代號(RDB003) 不同
                            //1.資料庫抓取的值寫入暫存
                            //2.表身序號 +1
                            //3.新增一筆 RECORDS_BODYS

                            CK001 = RDB003;
                            RDB002++;
                        }
                        else
                            continue;
                        
                        //....新增至 PC端 RECORDS_BODYS
                        strSQL_pc = "Insert Into RECORDS_BODYS (RDB001,RDB002,RDB003,RDB004,RDB005,RDB006,RDB007,RDB008,RDB009,RDB010,RDB011,RDB012,RDB013,RDB014,RDB015,RDB016,RDB017,RDB018) Values (";
                        strSQL_pc += RDB001 + ","   + RDB002 + ",'"  + RDB003 + "','" + RDB004 + "','" + RDB005 + "','" + RDB006 + "','";
                        strSQL_pc += RDB007 + "','" + RDB008 + "','" + RDB009 + "','" + RDB010 + "','" + RDB011 + "','" + RDB012 + "','";
                        strSQL_pc += RDB013 + "','" + RDB014 + "','" + RDB015 + "','" + RDB016 + "','" + RDB017 + "','" + RDB018 + "')";

                        try
                        {
                            objTrans_pc = USQL.SQLNonSelect(ref da_pc, ref objTrans_pc, strSQL_pc);
                        }
                        catch (Exception Ex)
                        {
                            if (objTrans_pc != null)
                                objTrans_pc.Rollback();
                            MessageBox.Show("PDA端 RECORDS_BODYS 資料寫入 PC端 RECORDS_BODYS 有誤，系統訊息：" + Ex.Message, "RECORDS_BODYS 寫入作業");
                            return false;
                        }
                    }
                    catch (Exception Ex)
                    {
                        if (objTrans_pc != null)
                            objTrans_pc.Rollback();
                        MessageBox.Show("PDA端 RECORDS_HEADS & RECORDS_BODYS 組合的資料 寫入 PC端 RECORDS_HEADS & RECORDS_BODYS 有誤，系統訊息：" + Ex.Message, "RECORDS_HEADS & RECORDS_BODYS 寫入作業");
                        return false;
                    }
                }
                //清空暫存
                FT001 = ""; CG001 = ""; MN001 = ""; CK001 = "";

                //PC端 資料寫入
                //if (objTrans != null)
                //    objTrans.Commit();

                //清空 PDA端 資料庫，再將 PC端 的新資料寫入 PDA端
                //....1.清空 PDA端 資料庫
                //........清空 PDA端 RECORDS_HEADS
                strSQL_pda = "Delete From RECORDS_HEADS";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //........清空 PDA端 RECORDS_BODYS
                strSQL_pda = "Delete From RECORDS_BODYS";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //........清空 PDA端 MAINS_HEADS
                strSQL_pda = "Delete From MAINS_HEADS";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //........清空 PDA端 MAINS_BODYS
                strSQL_pda = "Delete From MAINS_BODYS";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //........清空 PDA端 USERS
                strSQL_pda = "Delete From USERS";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //........清空 PDA端 SETTINGS
                strSQL_pda = "UPDATE SETTINGS SET Value = ''";
                da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                //....2.將 PC端 的新資料寫入 PDA端
                //........寫入 PDA端 MAINS_HEADS 及 MAINS_BODYS
                dt_pc = USQL.PCToPDA_MA(ref da_pc); //PC端 組出 PDA端 MAINS_HEADS 及 MAINS_BODYS 所需資料
                RowsNo_pc = dt_pc.Rows.Count;
                for (i = 0; i < RowsNo_pc; i++)
                {
                    //PC端 表頭及表身檔的集合資料寫入 PDA端 MAINS_HEADS 及 MAINS_BODYS
                    MH002 = dt_pc.Rows[i]["MH002"].ToString().Trim(); //廠房代號(MH002)
                    MH003 = dt_pc.Rows[i]["MH003"].ToString().Trim(); //廠房名稱(MH003)
                    MH004 = dt_pc.Rows[i]["MH004"].ToString().Trim(); //類別代號(MH004)
                    MH005 = dt_pc.Rows[i]["MH005"].ToString().Trim(); //類別名稱(MH005)
                    MH006 = dt_pc.Rows[i]["MH006"].ToString().Trim(); //機械編號代號(MH006)
                    MH007 = dt_pc.Rows[i]["MH007"].ToString().Trim(); //機械編號名稱(MH007)
                    
                    MB003 = dt_pc.Rows[i]["MB003"].ToString().Trim(); //檢查項目代號(MB003)
                    MB004 = dt_pc.Rows[i]["MB004"].ToString().Trim(); //檢查項目名稱(MB004)
                    MB005 = dt_pc.Rows[i]["MB005"].ToString().Trim(); //參考 起(MB005)
                    MB006 = dt_pc.Rows[i]["MB006"].ToString().Trim(); //中間符號(MB006)
                    MB007 = dt_pc.Rows[i]["MB007"].ToString().Trim(); //參考 迄(MB007)
                    MB008 = dt_pc.Rows[i]["MB008"].ToString().Trim(); //備註1(MB008)
                    MB009 = dt_pc.Rows[i]["MB009"].ToString().Trim(); //備註2(MB009)
                    MB010 = dt_pc.Rows[i]["MB010"].ToString().Trim(); //是否作廢(MB010)

                    if (FT001 != MH002 || CG001 != MH004 || MN001 != MH006)
                    {
                        //若 暫存的 FT001 or CG001 or MN001 與 廠房代號(MH002) or 類別代號(MH004) or 機械編號代號(MH006) 不同
                        //1.資料庫抓取的值寫入暫存
                        //2.表頭序號 及 表身序號 都 +1
                        //3.新增一筆 MAINS_HEADS 及 新增一筆 MAINS_BODYS

                        FT001 = MH002; CG001 = MH004; MN001 = MH006;
                        MH001++; MB001++; MB002++;

                        //PC端 資料寫回 PDA端 MAINS_HEADS
                        strSQL_pda = "Insert into MAINS_HEADS (MH001,MH002,MH003,MH004,MH005,MH006,MH007) Values (";
                        strSQL_pda += MH001 + ",'" + MH002 + "','" + MH003 + "','" + MH004 + "','" + MH005 + "','" + MH006 + "','";
                        strSQL_pda += MH007 + "')";

                        try
                        {
                            da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                        }
                        catch (Exception Ex)
                        {
                            if (objTrans_pda != null)
                                objTrans_pda.Rollback();
                            MessageBox.Show("PC端 MAINS_HEADS 資料寫入 PDA端 MAINS_HEADS 有誤，系統訊息：" + Ex.Message, "MAINS_HEADS寫入作業");
                            return false;
                        }
                    }
                    else if (FT001 == MH002 && CG001 == MH004 && MN001 == MH006 && CK001 != MB003)
                    {
                        //若 暫存的 FT001 and CG001 and MN001 與 廠房代號(MH002) and 類別代號(MH004) and 機械編號代號(MH006) 相同，但 CK001 與 檢查項目代號(MB003) 不同
                        //1.資料庫抓取的值寫入暫存
                        //2.表身序號 +1
                        //3.新增一筆 MAINS_BODYS

                        CK001 = MB003;
                        MB002++;
                    }
                    else
                        continue;
                    
                    //PC端 資料寫回 PDA端 MAINS_BODYS
                    strSQL_pda = "Insert into MAINS_BODYS (MB001,MB002,MB003,MB004,MB005,MB006,MB007,MB008,MB009,MB010) Values (";
                    strSQL_pda += MB001 + ","   + MB002 + ",'"  + MB003 + "','" + MB004 + "','" + MB005 + "','" + MB006 + "','";
                    strSQL_pda += MB007 + "','" + MB008 + "','" + MB009 + "','" + MB010 + "')";

                    try
                    {
                        da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                    }
                    catch (Exception Ex)
                    {
                        if (objTrans_pda != null)
                            objTrans_pda.Rollback();
                        MessageBox.Show("PC端 MAINS_BODYS 資料寫入 PDA端 MAINS_BODYS 有誤，MB001 = " + MB001 + "，系統訊息：" + Ex.Message, "MAINS_BODYS寫入作業");
                        return false;
                    }
                }
                //清空暫存
                FT001 = ""; CG001 = ""; MN001 = ""; CK001 = "";

                //........寫入 PDA端 USERS
                dt_pc = USQL.PCToPDA_US(ref da_pc);
                RowsNo_pc = dt_pc.Rows.Count;
                for (i = 0; i < RowsNo_pc; i++)
                {
                    US001 = dt_pc.Rows[i]["US001"].ToString().Trim(); //人員帳號(US001)
                    US002 = dt_pc.Rows[i]["US002"].ToString().Trim(); //人員名稱(US002)
                    US003 = dt_pc.Rows[i]["US003"].ToString().Trim(); //狀態(US003)
                    US004 = dt_pc.Rows[i]["US004"].ToString().Trim(); //權限代號(US004)
                    US005 = dt_pc.Rows[i]["US005"].ToString().Trim(); //權限名稱(US005)
                    US006 = dt_pc.Rows[i]["US006"].ToString().Trim(); //備用(US006)
                    US007 = dt_pc.Rows[i]["US007"].ToString().Trim(); //備用(US007)
                    US008 = dt_pc.Rows[i]["US008"].ToString().Trim(); //備用(US008)

                    strSQL_pda = "Insert into USERS (US001,US002,US003,US004,US005,US006,US007,US008) Values ('";
                    strSQL_pda += US001 + "','" + US002 + "','" + US003 + "','" + US004 + "','" + US005 + "','" + US006 + "','";
                    strSQL_pda += US007 + "','" + US008 + "')";

                    try
                    {
                        da_pda.ExecuteNonQuery(strSQL_pda, objTrans_pda);
                    }
                    catch (Exception Ex)
                    {
                        if (objTrans_pda != null)
                            objTrans_pda.Rollback();
                        MessageBox.Show("PC端 USERS 資料寫入 PDA端 USERS 有誤，系統訊息：" + Ex.Message, "USERS寫入作業");
                        return false;
                    }
                }
                //PC端 & PDA端 資料寫入
                if (objTrans_pc != null) objTrans_pc.Commit();
                if (objTrans_pda != null) objTrans_pda.Commit();
                
                return true;
            }
            catch (Exception ex)
            {
                if (objTrans_pc != null) objTrans_pc.Rollback();
                if (objTrans_pda != null) objTrans_pda.Rollback();
                MessageBox.Show("PDAToPC 執行作業有誤，系統訊息：" + ex.Message, "PDAToPC 執行作業");
                return false;
            }
            finally
            {
                if (objTrans_pc != null) objTrans_pc.Dispose();
                if (objTrans_pda != null) objTrans_pda.Dispose();
            }
        }
    }
}
