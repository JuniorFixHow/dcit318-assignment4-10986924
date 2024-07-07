namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(userText.Text == "" || pwdText.Text == "")
            {
                MessageBox.Show("Both username and password are required");
            }
            else
            {
                MessageBox.Show("Username: " + userText.Text+"\nPassword: "+pwdText.Text);
            }
        }
    }
}
