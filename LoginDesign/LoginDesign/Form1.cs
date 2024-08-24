namespace LoginDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Bushry" && txtPassword.Text == "1111")
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inavlid Username OR PassWord");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}