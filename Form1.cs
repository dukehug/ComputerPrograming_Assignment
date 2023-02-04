namespace ComputerPrograming_Actvity_1_Prelim
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            //student name output 
            nameResult.Text = txtName.Text;
            
            //address
            addressResult.Text = txtAd.Text;

            //phone
            phoneResult.Text = txtCp.Text;

            //birthday
            brithdayResult.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //place of birth
            placeBrithResult.Text = txtPd.Text;

            //education information
            eloutput.Text = txtEl.Text;

            hsoutput.Text = txtHs.Text;

            cloutput.Text = txtCl.Text;

            //Date Attended
            daEl.Text = dateTimePicker2.Value.ToString("yyyy-MM");
            daHs.Text = dateTimePicker3.Value.ToString("yyyy-MM");
            daCl.Text = dateTimePicker4.Value.ToString("yyyy-MM");




            //message box
            string message = "Successful";
            string title = "TIPS";
            MessageBox.Show(message,title);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Activate();
            }
        }
    }
}