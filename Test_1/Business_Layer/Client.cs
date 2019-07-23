using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_1.Business_Layer
{
    class Client
    {
        public DataTable SHOW_client_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_client_Table", null);
            dal.close();

            return Dt;
        }

        public DataTable SHOW_debt_Table(int ID_client)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = ID_client;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SHOW_debt_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable Search_client_Table( string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_client_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable SUM_for_client_debe()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_for_client_debe", null);
            dal.close();

            return Dt;
        }

        public DataTable SUM_no_client_debe()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("SUM_no_client_debe", null);
            dal.close();

            return Dt;
        }

        public DataTable VERIFY_NAME_client(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("VERIFY_NAME_client", param);
            dal.close();

            return Dt;
        }



    }
}
