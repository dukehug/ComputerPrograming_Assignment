using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Activity_No_2M
{
    public partial class MainForm : Form
    {
        //define helpform variable
        private HelpForm helpform;


        //define variable
        string firstName, lastName, testContent;

        string greetings = "\nHow are you !I love you ! have nice day!";

        //define separator array
        char[] separators = { ' ', '.', ',', ';', ':', '\t', '!' }; 


        public MainForm()
        {
            InitializeComponent();
        }

        //button MainHelp 
        private void bthMainHelp_Click(object sender, EventArgs e)
        {
            if (btnHelp.Enabled && btnHelp2.Enabled == true)
            {
                string message = "The Help Button is already  Enabled!";
                string title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, title, buttons, icon);

            }
            else
            {

                btnHelp.Enabled = true;
                btnHelp2.Enabled = true;
            }


        }

        //button HelpClose
        public void btnHelpClose_Click(object sender, EventArgs e)
        {
            //conditional statements

                if (btnHelp.Enabled && btnHelp2.Enabled == true)
                {
                    if (helpform != null)
                    {
                    helpform.Close();
                    helpform.Dispose();
                    }

                    btnHelp.Enabled = false;
                    btnHelp2.Enabled = false;
                }
                else
                {
                    string message = "The Help Button is already Disable";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(message, title, buttons, icon);

                }

        }

        //date picker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You choice:  " + dateTimePicker1.Text);
        }

        // change output text color
        private void btnColorChange_Click(object sender, EventArgs e)
        {
            ColorDialog colorChange = new ColorDialog();

            colorChange.AllowFullOpen = false;
            colorChange.Color = textFstName.ForeColor;

            //conditional statements
            if (colorChange.ShowDialog() == DialogResult.OK)
            { 
                textFstName.ForeColor =colorChange.Color;
                textLstName.ForeColor = colorChange.Color;
                textString.ForeColor = colorChange.Color;
                labelOutput1.ForeColor = colorChange.Color;
                labelOutput2.ForeColor = colorChange.Color;
            
            
            }       
                    
        }


        #region Concatenated Strings
        //concatenate button
        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            firstName = textFstName.Text;
            lastName = textLstName.Text;

            //conditional statements
            if (firstName.Length > 0 && lastName.Length > 0)
            {
                //Concatenate the strings using 'Concat' function and display the output.
                labelOutput1.Text = string.Concat(firstName, lastName, greetings, "\nToday is: ", dateTimePicker1.Text);

            }
            else
            {

                string message = "First name and Last name cannot be empty! please enter again!";
                string title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, title, buttons, icon);

            }


        }
        //button help1 
        private void btnHelp_Click(object sender, EventArgs e)
        {

            //messagebox  help
            /*string message = "Concatenate the strings using 'String.Concat(str1,str2,str3);';";
            string title = "Concat Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(message, title, buttons, icon);
            */


            //display HelpForm
            helpform = new HelpForm();
            helpform.StartPosition = FormStartPosition.CenterParent; // form Position
            helpform.Show();

        }

        #endregion

        #region Show Length,ToUpper,ToLower,WordCount
        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            textFstName.Clear();
            textLstName.Clear();    
            textString.Clear();
            textString.Focus();
            labelOutput2.Text = string.Empty;
            labelOutput1.Text = string.Empty;
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //link label 
        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            this.uiLinkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.itiohub.com");
        }

        //clear button
        private void uiButton1_Click(object sender, EventArgs e)
        {
            textFstName.Clear();
            textLstName.Clear();
            labelOutput1.Text = string.Empty;
            textFstName.Focus();
        }





        //button help2
        private void btnHelp2_Click(object sender, EventArgs e)
        {
            /*
            string message = "String.Length(): Gets the number of characters in the current String object.\n" +
                              "String.ToUpper(): Returns a copy of this string converted to uppercase.\n" +
                              "String.ToLower(): Returns a copy of this string converted to lowercase.\n" +
                              "";
            string title = "String Property,and Methods Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(message, title, buttons, icon);*/

            //call buttonhelp event
            btnHelp_Click(sender, e);
            
  


        }

        //button Perops
        private void btnPerOps_Click(object sender, EventArgs e)
        {   
            testContent = textString.Text;
            int  length = testContent.Length;

            //split the text into an array of words
            string[] words = testContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            //define variable for output2
            string str1 = "Slogan Length is: " + length + " characters";
            string str2 = "\nToUpper:  " + testContent.ToUpper();
            string str3 = "\nToLower:  " + testContent.ToLower();
            string str4 = "\nWords count:  " + wordCount;


            //conditional statements
            if (length > 0)
            {

                labelOutput2.Text = String.Concat(str1, str2, str3, str4);

            }
            else
            {

                string message = "Slogan Content cannot be empty! please enter again!";
                string title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, title, buttons, icon);

            }
        }
        #endregion

    }
}
