using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores_App
{
    public partial class UpdateForm : Form
    {
        StudentsScore student = new StudentsScore();    
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_student_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = dataGridView1_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = dataGridView1_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = dataGridView1_student.CurrentRow.Cells[2].Value.ToString();
            textBox_Math.Text = dataGridView1_student.CurrentRow.Cells[3].Value.ToString();
            textBox_Phy.Text = dataGridView1_student.CurrentRow.Cells[4].Value.ToString();
            textBox_Chem.Text = dataGridView1_student.CurrentRow.Cells[5].Value.ToString();
            textBox_Eng.Text = dataGridView1_student.CurrentRow.Cells[6].Value.ToString();
            textBox_Total.Text = dataGridView1_student.CurrentRow.Cells[7].Value.ToString();
            textBox_Avg.Text = dataGridView1_student.CurrentRow.Cells[8].Value.ToString();
            textBox_Grade.Text = dataGridView1_student.CurrentRow.Cells[9].Value.ToString();
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

        private void button_update_Click(object sender, EventArgs e)
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

            string gradeMarks(float ag) {
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
                else if((ag >=40 && ag < 60))
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
                    if (student.updateStudent(colgId, fname, lname, math, phy, chem, eng, total, avg, grade))
                    {
                        showTable();
                        MessageBox.Show("Student score is added!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        bool verify()
        {
            if ((textBox_Id.Text == "") || (textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_Math.Text == "") || (textBox_Phy.Text == "") || (textBox_Chem.Text == "") || (textBox_Eng.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void showTable()
        {
            dataGridView1_student.DataSource = student.getStudentList();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
