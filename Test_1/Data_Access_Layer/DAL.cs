using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_1.Data_Access_Layer
{
    class DAL
    {
        SqlConnection sqlconnection;

        public DAL()
        {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=MOA; integrated security=true");

            //sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Director of Entry AND Exit_DB; integrated security=true; User Instance=true; Trusted_Connection=Yes");

            //string mode = Properties.Settings.Default.Mode;
            //if (mode == "SQL")
            //{
            //    sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" +
            //                                        Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
            //                                        Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");
            //}
            //else
            //{
            //    sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            //}
        }

        // TO OPEN THE connection
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        // TO CLOSE THE connection
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //to read data from database
        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //to insert, update and delete data from database
        public void executeCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }
    }
}
