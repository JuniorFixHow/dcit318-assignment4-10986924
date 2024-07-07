namespace AddressBook
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


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void clear()
        {
            nameTxt.Clear();
            emailTxt.Clear();
            phoneTxt.Clear();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Visible=false;
            if(nameTxt.Text !="" && emailTxt.Text != "" && phoneTxt.Text != "")
            {
                Address address = new Address(nameTxt.Text, emailTxt.Text, phoneTxt.Text);
                bool savedAddress = address.Save();
                if (savedAddress) 
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Green;
                    errorLbl.Text = "Contact saved successfully";
                    clear();
                }
                else
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Crimson;
                    errorLbl.Text = "Error occured trying to save contact.";
                }
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Crimson;
                errorLbl.Text = "Please complete the form";
            }
        }
    }
}
