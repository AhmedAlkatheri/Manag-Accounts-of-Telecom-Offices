using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_1.Business_Layer
{
    class Settings
    {
        public DataTable SHOW_system_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_system_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_system_Table(String NAME_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@NAME_system", SqlDbType.VarChar);
            param[0].Value = NAME_system;

            dal.executeCommand("ADD_system_Table", param);
            dal.close();
        }

        public void DELETE_system_Table(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            dal.executeCommand("DELETE_system_Table", param);
            dal.close();
        }

        public void UPDATE_system_Table(int ID_system, string NAME_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];
            
            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_system", SqlDbType.VarChar);
            param[1].Value = NAME_system;

            dal.executeCommand("UPDATE_system_Table", param);
            dal.close();
        }

        public DataTable Search_system_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_system_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_telecom_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_telecom_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_telecom_Table(String NAME_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@NAME_telecom", SqlDbType.VarChar);
            param[0].Value = NAME_telecom;

            dal.executeCommand("ADD_telecom_Table", param);
            dal.close();
        }

        public void DELETE_telecom_Table(int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[0].Value = ID_telecom;

            dal.executeCommand("DELETE_telecom_Table", param);
            dal.close();
        }

        public void EDIT_telecom_Table(int ID_telecom, string NAME_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[0].Value = ID_telecom;

            param[1] = new SqlParameter("@NAME_telecom", SqlDbType.VarChar);
            param[1].Value = NAME_telecom;

           
            dal.executeCommand("EDIT_telecom_Table", param);
            dal.close();
        }

        public DataTable Search_telecom_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_telecom_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_bunch_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_bunch_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_bunch_Table(String NAME_bunch, int REC_bunch, int EXH_bunch, int REC_WITH_bunch, int EXH_WITH_bunch, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@NAME_bunch", SqlDbType.VarChar);
            param[0].Value = NAME_bunch;

            param[1] = new SqlParameter("@REC_bunch", SqlDbType.Int);
            param[1].Value = REC_bunch;

            param[2] = new SqlParameter("@EXH_bunch", SqlDbType.Int);
            param[2].Value = EXH_bunch;

            param[3] = new SqlParameter("@REC_WITH_bunch", SqlDbType.Int);
            param[3].Value = REC_WITH_bunch;

            param[4] = new SqlParameter("@EXH_WITH_bunch", SqlDbType.Int);
            param[4].Value = EXH_WITH_bunch;

            param[5] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[5].Value = ID_system;

            param[6] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[6].Value = ID_telecom;

            dal.executeCommand("ADD_bunch_Table", param);
            dal.close();
        }

        public void DELETE_bunch_Table(int ID_bunch)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_bunch", SqlDbType.Int);
            param[0].Value = ID_bunch;

            dal.executeCommand("DELETE_bunch_Table", param);
            dal.close();
        }

        public void EDIT_bunch_Table(int ID_bunch, String NAME_bunch, int REC_bunch, int EXH_bunch, int REC_WITH_bunch, int EXH_WITH_bunch, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ID_bunch", SqlDbType.Int);
            param[0].Value = ID_bunch;

            param[1] = new SqlParameter("@NAME_bunch", SqlDbType.VarChar);
            param[1].Value = NAME_bunch;

            param[2] = new SqlParameter("@REC_bunch", SqlDbType.Int);
            param[2].Value = REC_bunch;

            param[3] = new SqlParameter("@EXH_bunch", SqlDbType.Int);
            param[3].Value = EXH_bunch;

            param[4] = new SqlParameter("@REC_WITH_bunch", SqlDbType.Int);
            param[4].Value = REC_WITH_bunch;

            param[5] = new SqlParameter("@EXH_WITH_bunch", SqlDbType.Int);
            param[5].Value = EXH_WITH_bunch;

            param[6] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[6].Value = ID_system;

            param[7] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[7].Value = ID_telecom;

            dal.executeCommand("EDIT_bunch_Table", param);
            dal.close();
        }

        public DataTable Search_bunch_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_bunch_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_category_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_category_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_category_Table(String NAME_category, int REC_category, int EXH_category, int REC_WITH_category, int EXH_WITH_category, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@NAME_category", SqlDbType.VarChar);
            param[0].Value = NAME_category;

            param[1] = new SqlParameter("@REC_category", SqlDbType.Int);
            param[1].Value = REC_category;

            param[2] = new SqlParameter("@EXH_category", SqlDbType.Int);
            param[2].Value = EXH_category;

            param[3] = new SqlParameter("@REC_WITH_category", SqlDbType.Int);
            param[3].Value = REC_WITH_category;

            param[4] = new SqlParameter("@EXH_WITH_category", SqlDbType.Int);
            param[4].Value = EXH_WITH_category;

            param[5] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[5].Value = ID_system;

            param[6] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[6].Value = ID_telecom;

            dal.executeCommand("ADD_category_Table", param);
            dal.close();
        }

        public void DELETE_category_Table(int ID_category)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_category", SqlDbType.Int);
            param[0].Value = ID_category;

            dal.executeCommand("DELETE_category_Table", param);
            dal.close();
        }

        public void EDIT_category_Table(int ID_category, String NAME_category, int REC_category, int EXH_category, int REC_WITH_category, int EXH_WITH_category, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ID_category", SqlDbType.Int);
            param[0].Value = ID_category;

            param[1] = new SqlParameter("@NAME_category", SqlDbType.VarChar);
            param[1].Value = NAME_category;

            param[2] = new SqlParameter("@REC_category", SqlDbType.Int);
            param[2].Value = REC_category;

            param[3] = new SqlParameter("@EXH_category", SqlDbType.Int);
            param[3].Value = EXH_category;

            param[4] = new SqlParameter("@REC_WITH_category", SqlDbType.Int);
            param[4].Value = REC_WITH_category;

            param[5] = new SqlParameter("@EXH_WITH_category", SqlDbType.Int);
            param[5].Value = EXH_WITH_category;

            param[6] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[6].Value = ID_system;

            param[7] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[7].Value = ID_telecom;

            dal.executeCommand("EDIT_category_Table", param);
            dal.close();
        }

        public DataTable Search_category_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_category_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_slice_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_slice_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_slice_Table(String NAME_slice, int REC_slice, int EXH_slice, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@NAME_slice", SqlDbType.VarChar);
            param[0].Value = NAME_slice;

            param[1] = new SqlParameter("@REC_slice", SqlDbType.Int);
            param[1].Value = REC_slice;

            param[2] = new SqlParameter("@EXH_slice", SqlDbType.Int);
            param[2].Value = EXH_slice;

            param[3] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[3].Value = ID_system;

            param[4] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[4].Value = ID_telecom;

            dal.executeCommand("ADD_slice_Table", param);
            dal.close();
        }

        public void DELETE_slice_Table(int ID_slice)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_slice", SqlDbType.Int);
            param[0].Value = ID_slice;

            dal.executeCommand("DELETE_slice_Table", param);
            dal.close();
        }

        public void EDIT_slice_Table(int ID_slice, String NAME_slice, int REC_slice, int EXH_slice, int ID_system, int ID_telecom)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID_slice", SqlDbType.Int);
            param[0].Value = ID_slice;

            param[1] = new SqlParameter("@NAME_slice", SqlDbType.VarChar);
            param[1].Value = NAME_slice;

            param[2] = new SqlParameter("@REC_slice", SqlDbType.Int);
            param[2].Value = REC_slice;

            param[3] = new SqlParameter("@EXH_slice", SqlDbType.Int);
            param[3].Value = EXH_slice;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            param[5] = new SqlParameter("@ID_telecom", SqlDbType.Int);
            param[5].Value = ID_telecom;

            dal.executeCommand("EDIT_slice_Table", param);
            dal.close();
        }

        public DataTable Search_slice_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_slice_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_deposit_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_deposit_Table", null);
            dal.close();

            return Dt;
        }

        public void DELETE_deposit_Table(int ID_deposit)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_deposit", SqlDbType.Int);
            param[0].Value = ID_deposit;

            dal.executeCommand("DELETE_deposit_Table", param);
            dal.close();
        }

        //public void EDIT_slice_Table(int ID_slice, String NAME_slice, int REC_slice, int EXH_slice, int ID_system, int ID_telecom)
        //{
        //    Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
        //    dal.open();

        //    SqlParameter[] param = new SqlParameter[6];

        //    param[0] = new SqlParameter("@ID_slice", SqlDbType.Int);
        //    param[0].Value = ID_slice;

        //    param[1] = new SqlParameter("@NAME_slice", SqlDbType.VarChar);
        //    param[1].Value = NAME_slice;

        //    param[2] = new SqlParameter("@REC_slice", SqlDbType.Int);
        //    param[2].Value = REC_slice;

        //    param[3] = new SqlParameter("@EXH_slice", SqlDbType.Int);
        //    param[3].Value = EXH_slice;

        //    param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
        //    param[4].Value = ID_system;

        //    param[5] = new SqlParameter("@ID_telecom", SqlDbType.Int);
        //    param[5].Value = ID_telecom;

        //    dal.executeCommand("EDIT_slice_Table", param);
        //    dal.close();
        //}

        public DataTable Search_deposit_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_deposit_Table", param);
            dal.close();

            return Dt;
        }


        public DataTable Search_telephone_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_telephone_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_telephone_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_telephone_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_telephone_Table(String NAME_telephone, int REC_telephone, int EXH_telephone, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@NAME_telephone", SqlDbType.VarChar);
            param[0].Value = NAME_telephone;

            param[1] = new SqlParameter("@REC_telephone", SqlDbType.Int);
            param[1].Value = REC_telephone;

            param[2] = new SqlParameter("@EXH_telephone", SqlDbType.Int);
            param[2].Value = EXH_telephone;

            param[3] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[3].Value = ID_system;

            dal.executeCommand("ADD_telephone_Table", param);
            dal.close();
        }

        public void DELETE_telephone_Table(int ID_slice)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_telephone", SqlDbType.Int);
            param[0].Value = ID_slice;

            dal.executeCommand("DELETE_telephone_Table", param);
            dal.close();
        }

        public void EDIT_telephone_Table(int ID_telephone, String NAME_telephone, int REC_telephone, int EXH_telephone, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ID_telephone", SqlDbType.Int);
            param[0].Value = ID_telephone;

            param[1] = new SqlParameter("@NAME_telephone", SqlDbType.VarChar);
            param[1].Value = NAME_telephone;

            param[2] = new SqlParameter("@REC_telephone", SqlDbType.Int);
            param[2].Value = REC_telephone;

            param[3] = new SqlParameter("@EXH_telephone", SqlDbType.Int);
            param[3].Value = EXH_telephone;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            dal.executeCommand("EDIT_telephone_Table", param);
            dal.close();
        }

        public DataTable Search_water_And_Electricity_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_water_And_Electricity_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_water_And_Electricity_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_water_And_Electricity_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_water_And_Electricity_Table(String NAME_WandE, int REC_WandE, int EXH_WandE, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@NAME_WandE", SqlDbType.VarChar);
            param[0].Value = NAME_WandE;

            param[1] = new SqlParameter("@REC_WandE", SqlDbType.Int);
            param[1].Value = REC_WandE;

            param[2] = new SqlParameter("@EXH_WandE", SqlDbType.Int);
            param[2].Value = EXH_WandE;

            param[3] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[3].Value = ID_system;

            dal.executeCommand("ADD_water_And_Electricity_Table", param);
            dal.close();
        }

        public void DELETE_water_And_Electricity_Table(int ID_WandE)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_WandE", SqlDbType.Int);
            param[0].Value = ID_WandE;

            dal.executeCommand("DELETE_water_And_Electricity_Table", param);
            dal.close();
        }

        public void EDIT_water_And_Electricity_Table(int ID_WandE, String NAME_WandE, int REC_WandE, int EXH_WandE, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ID_WandE", SqlDbType.Int);
            param[0].Value = ID_WandE;

            param[1] = new SqlParameter("@NAME_WandE", SqlDbType.VarChar, 50);
            param[1].Value = NAME_WandE;

            param[2] = new SqlParameter("@REC_WandE", SqlDbType.Int);
            param[2].Value = REC_WandE;

            param[3] = new SqlParameter("@EXH_WandE", SqlDbType.Int);
            param[3].Value = EXH_WandE;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            dal.executeCommand("EDIT_water_And_Electricity_Table", param);
            dal.close();
        }

        public DataTable VERIFY_NAME_category(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_category", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_system(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_system", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_telecom(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_telecom", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_bunch(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_bunch", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_slice(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_slice", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_telephone(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_telephone", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_WandE(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_WandE", param);
            dal.close();

            return Dt;
        }
    }
}
