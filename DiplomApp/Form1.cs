using System.Windows.Forms;

namespace DiplomApp
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "akkulenok" && passswordTextBox.Text == "daud24akkulov")
            {   
                new main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid info, try again");
                usernameTextBox.Clear();
                passswordTextBox.Clear();
                usernameTextBox.Focus();
            }
            
        }
    }
}
