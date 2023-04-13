using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLabrotaryActivity_3
{

    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        // User login
        private void uiButton1_Click(object sender, EventArgs e)
        {

            //variable
            string username, password;

            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            //conditional statement, determine whether the user and password match
            if (username == "duke" && password == "123456")
            {
                MessageBox.Show("Welcome to computation of grades!");

                Form2PagePerlimInput form2 = new Form2PagePerlimInput();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User and password incorrect! try again");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();

            }
        }

        //lableclear function 
        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }
    }
}
