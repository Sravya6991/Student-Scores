using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores_App
{
    internal class DbConnect
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-FKMC68P;Database=Student;Trusted_Connection=True;TrustServerCertificate=True");
        public SqlConnection getConn
        {
            get { return con; }
        }

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
