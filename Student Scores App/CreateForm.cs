using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;

namespace Student_Scores_App
{
    public partial class CreateForm : Form
    {
        StudentsScore student = new StudentsScore();
        public CreateForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string colgId = textBox_Id.Text;
            string fname = textBox_Fname.Text;  
            string lname = textBox_Lname.Text;
            int math = Convert.ToInt32(textBox_Math.Text);
            int phy = Convert.ToInt32(textBox_Phy.Text);
            int chem = Convert.ToInt32(textBox_Chem.Text);
            int eng = Convert.ToInt32(textBox_Eng.Text);
            float total = math + phy + chem + eng;
            textBox_Total.Text = total.ToString();
            float avg = total / 4;
            textBox_Avg.Text = avg.ToString();
            string grade = "";

            string gradeMarks(float ag)
            {
                if (ag >= 90)
                {
                    grade = "Excellent";
                }
                else if ((ag >= 70 && ag < 90))
                {
                    grade = "Very Good";
                }
                else if ((ag >= 60 && ag < 70))
                {
                    grade = "Good";
                }
                else if ((ag >= 40 && ag < 60))
                {
                    grade = "Fair";
                }
                else
                {
                    grade = "Failed!";
                }
                return grade;
            }
            textBox_Grade.Text = gradeMarks(avg);

            if (verify())
            {
                try
                {
                    if(student.insertStudent(colgId, fname, lname, math, phy, chem, eng, total, avg, grade))
                    {
                        showTable();
                        MessageBox.Show("Student score is added!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        bool verify()
        {
            if((textBox_Id.Text=="")||(textBox_Fname.Text=="")||(textBox_Lname.Text=="")||
                (textBox_Math.Text == "") || (textBox_Phy.Text == "") || (textBox_Chem.Text == "") || (textBox_Eng.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        // Show data on form
       
        private void showTable()
        {
            dataGridView_student.DataSource = student.getStudentList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = "";
            textBox_Fname.Text = "";
            textBox_Lname.Text = "";
            textBox_Math.Text = "";
            textBox_Phy.Text = "";
            textBox_Chem.Text = "";
            textBox_Eng.Text = "";
            textBox_Total.Text = "";
            textBox_Avg.Text = "";
            textBox_Grade.Text = "";
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
}
