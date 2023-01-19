using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores_App
{
    internal class StudentsScore
    {
        public bool insertStudent(string colgId, string fname, string lname, int math, int phy, int chem, int eng, float total, float avg, string grade)
        {
            DbConnect connect = new DbConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO Student.dbo.studentsScore(CollegeId, FirstName, LastName, Maths, Physics, Chemistry, English, TotalMarks, AvgMarks, Grade) VALUES(@Id,@fn,@ln,@math,@phy,@chem,@eng,@tot,@avg,@gd)", connect.getConn);
            
            cmd.CommandType = CommandType.Text;

            // @Id,@fn,@ln,@math,@phy,@chem,@eng,@tot,@avg,@gd
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = colgId;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@math", SqlDbType.Int).Value = math;
            cmd.Parameters.Add("@phy", SqlDbType.Int).Value = phy;
            cmd.Parameters.Add("@chem", SqlDbType.Int).Value = chem;
            cmd.Parameters.Add("@eng", SqlDbType.Int).Value = eng;
            cmd.Parameters.Add("@tot", SqlDbType.Float).Value = total;
            cmd.Parameters.Add("@avg", SqlDbType.Float).Value = avg;
            cmd.Parameters.Add("@gd", SqlDbType.VarChar).Value = grade;

            connect.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }

        // get student score from database

        public DataTable getStudentList()
        {
            DbConnect connect = new DbConnect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student.dbo.studentsScore", connect.getConn);
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        // to update students score

        public bool updateStudent(string colgId, string fname, string lname, int math, int phy, int chem, int eng, float total, float avg, string grade)
        {
            DbConnect connect = new DbConnect();
            SqlCommand cmd = new SqlCommand("UPDATE Student.dbo.studentsScore SET CollegeId=@Id, FirstName=@fn, LastName=@ln, Maths=@math, Physics=@phy, Chemistry=@chem, English=@eng, TotalMarks=@tot, AvgMarks=@avg, Grade=@gd WHERE CollegeId=@Id", connect.getConn);

            cmd.CommandType = CommandType.Text;

            // @Id,@fn,@ln,@math,@phy,@chem,@eng,@tot,@avg,@gd
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = colgId;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@math", SqlDbType.Int).Value = math;
            cmd.Parameters.Add("@phy", SqlDbType.Int).Value = phy;
            cmd.Parameters.Add("@chem", SqlDbType.Int).Value = chem;
            cmd.Parameters.Add("@eng", SqlDbType.Int).Value = eng;
            cmd.Parameters.Add("@tot", SqlDbType.Float).Value = total;
            cmd.Parameters.Add("@avg", SqlDbType.Float).Value = avg;
            cmd.Parameters.Add("@gd", SqlDbType.VarChar).Value = grade;

            connect.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }
    }
}
