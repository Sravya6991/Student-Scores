namespace Student_Scores_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateForm());
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateForm());
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateForm());
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintForm());
        }
    }
}