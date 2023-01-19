using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Scores_App.DGVPrinterHelper;

namespace Student_Scores_App
{
    
    public partial class PrintForm : Form
    {
        StudentsScore student = new StudentsScore();
        DGVPrinter printer = new DGVPrinter();

        public PrintForm()
        {
            InitializeComponent();
        }
   
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Student Scores";
            printer.SubTitle = String.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "ScoresApp";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView2_student);
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            dataGridView2_student.DataSource = student.getStudentList();
        }
    }
}
