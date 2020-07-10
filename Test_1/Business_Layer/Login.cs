using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Test_1.Business_Layer
{
    class Login
    {
        public DataTable login(string ID, String PWD)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.selectData("SP_LODIN", param);
            dal.close();

            return Dt;
        }
    }
}
