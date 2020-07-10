using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Test_1.Business_Layer
{
    class Accounts
    {
        
        public DataTable GET_NAME_category(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_category", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_system()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_system", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_telecom()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];



            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_telecom", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_category_Table(int ID_system )
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_category_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_slice_Table(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_slice_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_telephone_Table(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_telephone_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_water_And_Electricity_Table(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_water_And_Electricity_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_bunch_Table(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_bunch_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_bunch(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_bunch", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_Account_Table(string ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.VarChar,50);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_Account_Table_manth()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table_manth", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_category_row(int ID_system, string NAME_category)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_category", SqlDbType.VarChar, 50);
            param[1].Value = NAME_category;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_category_row", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_telephone_row(int ID_system, string NAME_telephone)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_telephone", SqlDbType.VarChar, 50);
            param[1].Value = NAME_telephone;
        
            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_telephone_row", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_WandE_row(int ID_system, string NAME_WandE)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_WandE", SqlDbType.VarChar, 50);
            param[1].Value = NAME_WandE;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_WandE_row", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_bunch_row(int ID_system, string NAME_bunch)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_bunch", SqlDbType.VarChar, 50);
            param[1].Value = NAME_bunch;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_bunch_row", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_slice_row(int ID_system, string NAME_slice)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            param[1] = new SqlParameter("@NAME_slice", SqlDbType.VarChar, 50);
            param[1].Value = NAME_slice;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_slice_row", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_client_list()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_client_list", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_user_list()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_user_list", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_REC_EXH()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_REC_EXH", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_ID_client()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_ID_client", null);
            dal.close();

            return Dt;
        }

        public DataTable IF_ID_debt_existent(int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[0].Value = ID_Account;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("IF_ID_debt_existent", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_BALANCE_debt( int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = ID_client;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_BALANCE_debt", param);
            dal.close();

            return Dt;
        }


        public void ADD_Account_Table(DateTime date, string time, string proces, string move, int REC_tx, int EXH_tx, string text, 
            int ID_client, int ID_user, string ID_telecom, string ID_system , String TYPE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[12];


            param[0] = new SqlParameter("@DATE_Account", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_Account", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@PROCESS_Account", SqlDbType.VarChar, 50);
            param[2].Value = proces;

            param[3] = new SqlParameter("@MOVE_Account", SqlDbType.VarChar, 10);
            param[3].Value = move;

            param[4] = new SqlParameter("@REC_Account", SqlDbType.Int);
            param[4].Value = REC_tx;

            param[5] = new SqlParameter("@EXH_Account", SqlDbType.Int);
            param[5].Value = EXH_tx;

            param[6] = new SqlParameter("@TEXT_Account", SqlDbType.VarChar, 50);
            param[6].Value = text;

            param[7] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[7].Value = ID_client;

            param[8] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[8].Value = ID_user;

            param[9] = new SqlParameter("@ID_telecom", SqlDbType.VarChar, 50);
            param[9].Value = ID_telecom;

            param[10] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[10].Value = ID_system;

            param[11] = new SqlParameter("@TYPE_Account", SqlDbType.VarChar, 10);
            param[11].Value = TYPE_Account;


            dal.executeCommand("ADD_Account_Table", param);
            dal.close();
        }

        public void ADD_Account_Table_Without_ID_Client(DateTime date, string time, string proces, string move, int REC_tx, int EXH_tx, string text,
             int ID_user, string ID_telecom, string ID_system, String TYPE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[11];


            param[0] = new SqlParameter("@DATE_Account", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_Account", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@PROCESS_Account", SqlDbType.VarChar, 50);
            param[2].Value = proces;

            param[3] = new SqlParameter("@MOVE_Account", SqlDbType.VarChar, 10);
            param[3].Value = move;

            param[4] = new SqlParameter("@REC_Account", SqlDbType.Int);
            param[4].Value = REC_tx;

            param[5] = new SqlParameter("@EXH_Account", SqlDbType.Int);
            param[5].Value = EXH_tx;

            param[6] = new SqlParameter("@TEXT_Account", SqlDbType.VarChar, 50);
            param[6].Value = text;

            param[7] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[7].Value = ID_user;

            param[8] = new SqlParameter("@ID_telecom", SqlDbType.VarChar, 50);
            param[8].Value = ID_telecom;

            param[9] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[9].Value = ID_system;

            param[10] = new SqlParameter("@TYPE_Account", SqlDbType.VarChar, 10);
            param[10].Value = TYPE_Account;


            dal.executeCommand("ADD_Account_Table_Without_ID_Client", param);
            dal.close();
        }

        public void DELETE_Account_Table(int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[0].Value = ID_Account;

            dal.executeCommand("DELETE_Account_Table", param);
            dal.close();
        }

        public void DELETE_debt_Table_and_ID_Account(int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID_Account;

            dal.executeCommand("DELETE_debt_Table_and_ID_Account", param);
            dal.close();
        }

        public void DELETE_deposit_Table_and_ID_Account(int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID_Account;

            dal.executeCommand("DELETE_deposit_Table_and_ID_Account", param);
            dal.close();
        }

        //public void ADD_Account_Table(DateTime date, string time, string proces, string move, int REC_tx, int EXH_tx, string text,
        //    int ID_client, int ID_user, int ID_system, String TYPE_Account)
        //{
        //    Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
        //    dal.open();

        //    SqlParameter[] param = new SqlParameter[12];


        //    param[0] = new SqlParameter("@DATE_Account", SqlDbType.Date);
        //    param[0].Value = date;

        //    param[1] = new SqlParameter("@TIME_Account", SqlDbType.VarChar, 15);
        //    param[1].Value = time;

        //    param[2] = new SqlParameter("@PROCESS_Account", SqlDbType.VarChar, 50);
        //    param[2].Value = proces;

        //    param[3] = new SqlParameter("@MOVE_Account", SqlDbType.VarChar, 10);
        //    param[3].Value = move;

        //    param[4] = new SqlParameter("@REC_Account", SqlDbType.Int);
        //    param[4].Value = REC_tx;

        //    param[5] = new SqlParameter("@EXH_Account", SqlDbType.Int);
        //    param[5].Value = EXH_tx;

        //    param[6] = new SqlParameter("@TEXT_Account", SqlDbType.VarChar, 50);
        //    param[6].Value = text;

        //    param[7] = new SqlParameter("@ID_client", SqlDbType.Int);
        //    param[7].Value = ID_client;

        //    param[8] = new SqlParameter("@ID_user", SqlDbType.Int);
        //    param[8].Value = ID_user;

        //    param[10] = new SqlParameter("@ID_system", SqlDbType.Int);
        //    param[10].Value = ID_system;

        //    param[11] = new SqlParameter("@TYPE_Account", SqlDbType.VarChar, 10);
        //    param[11].Value = TYPE_Account;


        //    dal.executeCommand("ADD_Account_Table", param);
        //    dal.close();
        //}

        public void ADD_NEW_debt_Table(DateTime date, string time, string PROCESS_debt, string move, int FOR, int ON, int BALANCE_debt, string TEXT_debt,
                                        int ID_client, int ID_user, string TYPE_debt, string ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[13];


            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_debt", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@PROCESS_debt", SqlDbType.VarChar, 50);
            param[2].Value = PROCESS_debt;

            param[3] = new SqlParameter("@MOVE_debt", SqlDbType.VarChar, 10);
            param[3].Value = move;

            param[4] = new SqlParameter("@FOR_debt", SqlDbType.Int);
            param[4].Value = FOR;

            param[5] = new SqlParameter("@ON_debt", SqlDbType.Int);
            param[5].Value = ON;

            param[6] = new SqlParameter("@BALANCE_debt", SqlDbType.Int);
            param[6].Value = BALANCE_debt;

            param[7] = new SqlParameter("@TEXT_debt", SqlDbType.VarChar, 50);
            param[7].Value = TEXT_debt;

            param[8] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[8].Value = ID_client;

            param[9] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[9].Value = ID_user;

            param[10] = new SqlParameter("@TYPE_debt", SqlDbType.VarChar, 50);
            param[10].Value = TYPE_debt;

            param[11] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[11].Value = ID_system;

            param[12] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[12].Value = ID_Account;

            dal.executeCommand("ADD_NEW_debt_Table", param);
            dal.close();
        }
        
        public void EDIT_debt_Table(int ID_debt, string MOVE_debt, int FOR_debt, int ON_debt,  string TEXT_debt, int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID_debt", SqlDbType.Int);
            param[0].Value = ID_debt;

            param[1] = new SqlParameter("@MOVE_debt", SqlDbType.VarChar, 10);
            param[1].Value = MOVE_debt;

            param[2] = new SqlParameter("@FOR_debt", SqlDbType.Int);
            param[2].Value = FOR_debt;

            param[3] = new SqlParameter("@ON_debt", SqlDbType.Int);
            param[3].Value = ON_debt;

            param[4] = new SqlParameter("@TEXT_debt", SqlDbType.VarChar, 50);
            param[4].Value = TEXT_debt;

            param[5] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[5].Value = ID_client;

            dal.executeCommand("EDIT_debt_Table", param);
            dal.close();
        }

        public void ADD_debt_Table(DateTime date, string time, string PROCESS, string move, int FOR, int ON, int BALANCE_debt, string TEXT, int ID_client, int ID_user, string TYPE_debt , int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[12];


            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_debt", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@PROCESS_debt", SqlDbType.VarChar, 50);
            param[2].Value = PROCESS;

            param[3] = new SqlParameter("@MOVE_debt", SqlDbType.VarChar, 10);
            param[3].Value = move;

            param[4] = new SqlParameter("@FOR_debt", SqlDbType.Int);
            param[4].Value = FOR;

            param[5] = new SqlParameter("@ON_debt", SqlDbType.Int);
            param[5].Value = ON;

            param[6] = new SqlParameter("@BALANCE_debt", SqlDbType.Int);
            param[6].Value = BALANCE_debt;

            param[7] = new SqlParameter("@TEXT_debt", SqlDbType.VarChar, 50);
            param[7].Value = TEXT;

            param[8] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[8].Value = ID_client;
            
            param[9] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[9].Value = ID_user;

            param[10] = new SqlParameter("@TYPE_debt", SqlDbType.VarChar, 10);
            param[10].Value = TYPE_debt;

            param[11] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[11].Value = ID_system;

            dal.executeCommand("ADD_debt_Table", param);
            dal.close();
        }

        public void ADD_debt_Table_and_ID_Account(DateTime date, string time, string PROCESS, string move, int FOR, int ON, int BALANCE_debt, string TEXT, int ID_client, int ID_user, string TYPE_debt, string ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[13];


            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_debt", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@PROCESS_debt", SqlDbType.VarChar, 50);
            param[2].Value = PROCESS;

            param[3] = new SqlParameter("@MOVE_debt", SqlDbType.VarChar, 10);
            param[3].Value = move;

            param[4] = new SqlParameter("@FOR_debt", SqlDbType.Int);
            param[4].Value = FOR;

            param[5] = new SqlParameter("@ON_debt", SqlDbType.Int);
            param[5].Value = ON;

            param[6] = new SqlParameter("@BALANCE_debt", SqlDbType.Int);
            param[6].Value = BALANCE_debt;

            param[7] = new SqlParameter("@TEXT_debt", SqlDbType.VarChar, 50);
            param[7].Value = TEXT;

            param[8] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[8].Value = ID_client;

            param[9] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[9].Value = ID_user;

            param[10] = new SqlParameter("@TYPE_debt", SqlDbType.VarChar, 10);
            param[10].Value = TYPE_debt;

            param[11] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[11].Value = ID_system;

            param[12] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[12].Value = ID_Account;

            dal.executeCommand("ADD_debt_Table_and_ID_Account", param);
            dal.close();
        }

        public void EDIT_debt_Table_and_ID_Account(string PROCESS, string move, int FOR, int ON, int BALANCE_debt, string TEXT, int ID_client, string TYPE_debt, string ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@PROCESS_debt", SqlDbType.VarChar, 50);
            param[0].Value = PROCESS;

            param[1] = new SqlParameter("@MOVE_debt", SqlDbType.VarChar, 10);
            param[1].Value = move;

            param[2] = new SqlParameter("@FOR_debt", SqlDbType.Int);
            param[2].Value = FOR;

            param[3] = new SqlParameter("@ON_debt", SqlDbType.Int);
            param[3].Value = ON;

            param[4] = new SqlParameter("@BALANCE_debt", SqlDbType.Int);
            param[4].Value = BALANCE_debt;

            param[5] = new SqlParameter("@TEXT_debt", SqlDbType.VarChar, 50);
            param[5].Value = TEXT;

            param[6] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[6].Value = ID_client;

            param[7] = new SqlParameter("@TYPE_debt", SqlDbType.VarChar, 10);
            param[7].Value = TYPE_debt;

            param[8] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[8].Value = ID_system;

            param[9] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[9].Value = ID_Account;

            dal.executeCommand("EDIT_debt_Table_and_ID_Account", param);
            dal.close();
        }

        public DataTable SUM_BALANCE_deposit()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_BALANCE_deposit", null);
            dal.close();

            return Dt;
        }

        public DataTable SUM_FOR_deposit(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;
            
            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_FOR_deposit", param);
            dal.close();

            return Dt;
        }

        public DataTable SUN_ON_deposit(int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUN_ON_deposit", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_REC_Account(string ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_REC_Account", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_no_debe(string ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_no_debe", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_EXH_Account(string ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[0].Value = ID_system;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_EXH_Account", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_REC_Account_ALL()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_REC_Account_ALL", null);
            dal.close();

            return Dt;
        }

        public DataTable SUM_EXH_Account_ALL()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_EXH_Account_ALL", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_ID_Account()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_ID_Account", null);
            dal.close();

            return Dt;
        }

        public DataTable GET_NAME_client(int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = ID_client;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_NAME_client", param);
            dal.close();

            return Dt;
        }

        public void ADD_FOR_deposit(DateTime date, string time, int FOR_deposit, string text, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@DATE_deposit", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_deposit", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@FOR_deposit", SqlDbType.Int);
            param[2].Value = FOR_deposit;

            param[3] = new SqlParameter("@TEXT_deposit", SqlDbType.VarChar, 50);
            param[3].Value = text;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            dal.executeCommand("ADD_FOR_deposit", param);
            dal.close();
        }

        public void EDIT_Account_Table( int ID_Account, string PROCESS_Account, string MOVE_Account, int REC_Account, int EXH_Account, string TEXT_Account,
                                        int ID_client, string ID_telecom, string ID_system, String TYPE_Account )
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[0].Value = ID_Account;

            param[1] = new SqlParameter("@PROCESS_Account", SqlDbType.VarChar, 50);
            param[1].Value = PROCESS_Account;

            param[2] = new SqlParameter("@MOVE_Account", SqlDbType.VarChar, 10);
            param[2].Value = MOVE_Account;

            param[3] = new SqlParameter("@REC_Account", SqlDbType.Int);
            param[3].Value = REC_Account;

            param[4] = new SqlParameter("@EXH_Account", SqlDbType.Int);
            param[4].Value = EXH_Account;

            param[5] = new SqlParameter("@TEXT_Account", SqlDbType.VarChar, 50);
            param[5].Value = TEXT_Account;

            param[6] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[6].Value = ID_client;

            param[7] = new SqlParameter("@ID_telecom", SqlDbType.VarChar, 50);
            param[7].Value = ID_telecom;

            param[8] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[8].Value = ID_system;

            param[9] = new SqlParameter("@TYPE_Account", SqlDbType.VarChar, 10);
            param[9].Value = TYPE_Account;

            dal.executeCommand("EDIT_Account_Table", param);
            dal.close();
        }

        public void EDIT_Account_Table_Wihtout_ID_client(int ID_Account, string PROCESS_Account, string MOVE_Account, int REC_Account, int EXH_Account, string TEXT_Account,
                                         string ID_telecom, string ID_system, String TYPE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[0].Value = ID_Account;

            param[1] = new SqlParameter("@PROCESS_Account", SqlDbType.VarChar, 50);
            param[1].Value = PROCESS_Account;

            param[2] = new SqlParameter("@MOVE_Account", SqlDbType.VarChar, 10);
            param[2].Value = MOVE_Account;

            param[3] = new SqlParameter("@REC_Account", SqlDbType.Int);
            param[3].Value = REC_Account;

            param[4] = new SqlParameter("@EXH_Account", SqlDbType.Int);
            param[4].Value = EXH_Account;

            param[5] = new SqlParameter("@TEXT_Account", SqlDbType.VarChar, 50);
            param[5].Value = TEXT_Account;

            param[6] = new SqlParameter("@ID_telecom", SqlDbType.VarChar, 50);
            param[6].Value = ID_telecom;

            param[7] = new SqlParameter("@ID_system", SqlDbType.VarChar, 50);
            param[7].Value = ID_system;

            param[8] = new SqlParameter("@TYPE_Account", SqlDbType.VarChar, 10);
            param[8].Value = TYPE_Account;

            dal.executeCommand("EDIT_Account_Table_Wihtout_ID_client", param);
            dal.close();
        }

        public void ADD_ON_deposit(DateTime date, string time, int ON_deposit, string text, int ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@DATE_deposit", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_deposit", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@ON_deposit", SqlDbType.Int);
            param[2].Value = ON_deposit;

            param[3] = new SqlParameter("@TEXT_deposit", SqlDbType.VarChar, 50);
            param[3].Value = text;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            param[5] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[5].Value = ID_Account;

            

            dal.executeCommand("ADD_NO_deposit", param);
            dal.close();
        }

        public void EDIT_ON_deposit(int ON_deposit, string text, int ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ON_deposit", SqlDbType.Int);
            param[0].Value = ON_deposit;

            param[1] = new SqlParameter("@TEXT_deposit", SqlDbType.VarChar, 50);
            param[1].Value = text;

            param[2] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[2].Value = ID_system;

            param[3] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[3].Value = ID_Account;

            dal.executeCommand("ADD_NO_deposit", param);
            dal.close();
        }

        public void ADD_NEW_client_Table(string NAME, string MOBILE, string TELEPHONE, string EMAIL, string ADRESS)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@NAME_client", SqlDbType.VarChar, 50);
            param[0].Value = NAME;

            param[1] = new SqlParameter("@MOBILE_client", SqlDbType.VarChar, 50);
            param[1].Value = MOBILE;

            param[2] = new SqlParameter("@TELEPHONE_client", SqlDbType.VarChar, 50);
            param[2].Value = TELEPHONE;

            param[3] = new SqlParameter("@EMAIL_client", SqlDbType.VarChar, 50);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@ADRESS_client", SqlDbType.VarChar, 50);
            param[4].Value = ADRESS;

            dal.executeCommand("ADD_NEW_client_Table", param);
            dal.close();
        }

        public void ADD_NO_deposit_direct(DateTime date, string time, int ON_deposit, string text, int ID_system)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@DATE_deposit", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@TIME_deposit", SqlDbType.VarChar, 15);
            param[1].Value = time;

            param[2] = new SqlParameter("@ON_deposit", SqlDbType.Int);
            param[2].Value = ON_deposit;

            param[3] = new SqlParameter("@TEXT_deposit", SqlDbType.VarChar, 50);
            param[3].Value = text;

            param[4] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[4].Value = ID_system;

            dal.executeCommand("ADD_NO_deposit_direct", param);
            dal.close();
        }

        public void EDIT_NO_deposit( int ON_deposit, string text, int ID_system, int ID_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ON_deposit", SqlDbType.Int);
            param[0].Value = ON_deposit;

            param[1] = new SqlParameter("@TEXT_deposit", SqlDbType.VarChar, 50);
            param[1].Value = text;

            param[2] = new SqlParameter("@ID_system", SqlDbType.Int);
            param[2].Value = ID_system;

            param[3] = new SqlParameter("@ID_Account", SqlDbType.Int);
            param[3].Value = ID_Account;


            dal.executeCommand("EDIT_NO_deposit", param);
            dal.close();
        }

        public DataTable SEARCH_Account_Table_manth(String ID, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SEARCH_Account_Table_manth", param);
            dal.close();

            return Dt;
        }

        public DataTable SEARCH_Account_Table_manth_Where_UserID(String ID, DateTime date1, DateTime date2, int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            param[3] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[3].Value = ID_user;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SEARCH_Account_Table_manth_Where_UserID", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_Catch_Exchange(String ID, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_Catch_Exchange", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_Account_Table_Where_DATE_Account(DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Date);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_Account_Table_Where_DATE_Account", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt(DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Date);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt( DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Date);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_Account_Table_Where_DATE_Account_Month(int date1, int date2, int date3)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            param[2] = new SqlParameter("@date3", SqlDbType.Int);
            param[2].Value = date3;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_Account_Table_Where_DATE_Account_Month", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt_Month(int date1, int date2, int date3)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            param[2] = new SqlParameter("@date3", SqlDbType.Int);
            param[2].Value = date3;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt_Month", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Month(int date1, int date2, int date3)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            param[2] = new SqlParameter("@date3", SqlDbType.Int);
            param[2].Value = date3;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Month", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_Account_Table_Where_DATE_Account_Year(int date1, int date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_Account_Table_Where_DATE_Account_Year", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt_Year(int date1, int date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt_Year", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Year(int date1, int date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Int);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Int);
            param[1].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Year", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_Account_Table_Where_DATE_Account(DateTime DATE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_Account", SqlDbType.Date);
            param[0].Value = DATE_Account;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table_Where_DATE_Account", param);
            dal.close();

            return Dt;
        }
        
        public DataTable GET_Account_Table_Where_DATE_Account_INT_MONTH(int DATE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_Account", SqlDbType.Int);
            param[0].Value = DATE_Account;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table_Where_DATE_Account_INT_MONTH", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_Account_Table_Where_DATE_Account_INT_YEAR(int DATE_Account)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_Account", SqlDbType.Int);
            param[0].Value = DATE_Account;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table_Where_DATE_Account_INT_YEAR", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_debt_Table_Where_DATE_debt(DateTime DATE_debt)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Date);
            param[0].Value = DATE_debt;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_debt_Table_Where_DATE_debt", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_debt_Table_Where_DATE_debt_INT_MONTH(int DATE_debt)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Int);
            param[0].Value = DATE_debt;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_debt_Table_Where_DATE_debt_INT_MONTH", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_debt_Table_Where_DATE_debt_INT_YEAR(int DATE_debt)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DATE_debt", SqlDbType.Int);
            param[0].Value = DATE_debt;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_debt_Table_Where_DATE_debt_INT_YEAR", param);
            dal.close();

            return Dt;
        }


        public DataTable Search_debt_Table(String ID, DateTime date1, DateTime date2, int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            param[3] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[3].Value = ID_client;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_debt_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_REC_and_EXH_Where_UserID_only(String ID, int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[1].Value = ID_user;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_REC_and_EXH_Where_UserID_only", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_REC_and_EXH_Where_UserID(String ID, DateTime date1, DateTime date2, int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            param[3] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[3].Value = ID_user;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_REC_and_EXH_Where_UserID", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_no_debe_Where_UserID(String ID, DateTime date1, DateTime date2, int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            param[3] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[3].Value = ID_user;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_no_debe_Where_UserID", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_debt_Table_Where_Catch_Exchange(String ID, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_debt_Table_Where_Catch_Exchange", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_debt_Table_Where_clientID(String ID, DateTime date1, DateTime date2, int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            param[3] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[3].Value = ID_client;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_debt_Table_Where_clientID", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_REC_and_EXH_Account(String ID, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_REC_and_EXH_Account", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_no_debe_Account_manth(String ID, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_no_debe_Account_manth", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_no_debe_GET_Account_manth()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_no_debe_GET_Account_manth", null);
            dal.close();

            return Dt;
        }

        public DataTable SUM_Account_ALL_String (String ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_Account_ALL_String", param);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_user_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_user_Table", null);
            dal.close();

            return Dt;
        }

        public void ADD_NEW_user_Table(string USERNAME, string PASSWORD, string FULLNAME, int MOBILE, string tyap_com)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = USERNAME;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = PASSWORD;

            param[2] = new SqlParameter("@fullName", SqlDbType.VarChar, 50);
            param[2].Value = FULLNAME;

            param[3] = new SqlParameter("@mobil", SqlDbType.Int);
            param[3].Value = MOBILE;

            param[4] = new SqlParameter("@tyap", SqlDbType.VarChar, 50);
            param[4].Value = tyap_com;

            dal.executeCommand("ADD_user_Table", param);
            dal.close();
        }

        public void DELETE_user_Table(int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[0].Value = ID_user;

            dal.executeCommand("DELETE_user_Table", param);
            dal.close();
        }

        public void DELETE_client_Table(int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = ID_client;

            dal.executeCommand("DELETE_client_Table", param);
            dal.close();
        }

        public void DELETE_debt(int ID_debt)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ID_debt", SqlDbType.Int);
            param[0].Value = ID_debt;

            dal.executeCommand("DELETE_debt", param);
            dal.close();
        }

        public void EDIT_user_Table(int ID_user, string USERNAME, string PASSWORD, string FULLNAME, int MOBILE, string tyap_com)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[0].Value = ID_user;

            param[1] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[1].Value = USERNAME;

            param[2] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[2].Value = PASSWORD;

            param[3] = new SqlParameter("@fullName", SqlDbType.VarChar, 50);
            param[3].Value = FULLNAME;

            param[4] = new SqlParameter("@mobil", SqlDbType.Int);
            param[4].Value = MOBILE;

            param[5] = new SqlParameter("@tyap", SqlDbType.VarChar, 50);
            param[5].Value = tyap_com;

            dal.executeCommand("EDIT_user_Table", param);
            dal.close();
        }

        public void EDIT_client_Table(int ID_client, string NAME, string MOBILE, string TELEPHONE, string EMAIL, string ADRESS)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = ID_client;

            param[1] = new SqlParameter("@NAME_client", SqlDbType.VarChar, 50);
            param[1].Value = NAME;

            param[2] = new SqlParameter("@MOBILE_client", SqlDbType.VarChar, 50);
            param[2].Value = MOBILE;

            param[3] = new SqlParameter("@TELEPHONE_client", SqlDbType.VarChar, 50);
            param[3].Value = TELEPHONE;

            param[4] = new SqlParameter("@EMAIL_client", SqlDbType.VarChar, 50);
            param[4].Value = EMAIL;

            param[5] = new SqlParameter("@ADRESS_client", SqlDbType.VarChar, 50);
            param[5].Value = ADRESS;

            dal.executeCommand("EDIT_client_Table", param);
            dal.close();
        }

        public DataTable Search_user_Table(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_user_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_user(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_user", param);
            dal.close();

            return Dt;
        }

        public DataTable Search_Account_Table_manth_string(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 100);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_Account_Table_manth_string", param);
            dal.close();

            return Dt;
        }

        public DataTable GET_Account_Table_All_Where_UserID(int ID_user)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[0].Value = ID_user;


            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Account_Table_All_Where_UserID", param);
            dal.close();

            return Dt;
        }

    }
}
