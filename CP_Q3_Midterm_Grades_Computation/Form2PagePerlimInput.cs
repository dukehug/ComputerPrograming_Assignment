using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLabrotaryActivity_3
{



    public partial class Form2PagePerlimInput : Form
    {

        public Form2PagePerlimInput()
        {
            InitializeComponent();
        }

        //variable

        double assignment, attendance, aveclasstanding;
        double q1, q2,q3, avequizzes;
        double lab1, lab2,lab3, avela;
        double midtermscore,midtermResult, midtermgrade;
        string Passed = "Great! You Passed!",
               Failed = "You Failed! Don't give up!";

        
        //method to calculate Quizzes 
        public double QuizzesAve()
        {
            q1 = Convert.ToDouble(textBoxQz1.Text);
            q2 = Convert.ToDouble(textBoxQz2.Text);      
            q3 = Convert.ToDouble(textBoxQz3.Text);

            avequizzes = (q1 + q2 + q3) / 120 * 100;
            
            avequizzes = Math.Round(avequizzes);

            return avequizzes;

        }


        //method to calculate Lab Activities
        public double LabAverage()
        {
            lab1 = Convert.ToDouble(textBoxla1.Text);
            lab2 = Convert.ToDouble(textBoxLa2.Text);
            lab3 = Convert.ToDouble(textBoxla3.Text);
            avela = (lab1 + lab2 + lab3) / 3;

            avela = Math.Round(avela);
            return avela;
        
        
        }

        //method to calculate Midterm Exam
        public double MidtermExam()
        {
            midtermscore = Convert.ToDouble(textBoxMex.Text);

            midtermResult = midtermscore / 50 * 100;

            midtermResult = Math.Round(midtermResult);
            return midtermResult;

        }

        //method to calculate Class Standing
        public double ClassStanding()
        {
            assignment = Convert.ToDouble(textBoxAs1.Text);
            attendance = Convert.ToDouble(textBoxAt1.Text);

            aveclasstanding = (assignment + attendance) / 2;

            aveclasstanding = Math.Round(aveclasstanding);

            return aveclasstanding;

        }

        //method to calculate Midterm Grade
        public double midtermgrades()
        {

            midtermgrade = (QuizzesAve() * 0.25) + (LabAverage() * 0.25) + (ClassStanding() * 0.2) + (MidtermExam() * 0.3) ;

            midtermgrade = Math.Round(midtermgrade);

            return midtermgrade;

        }

        // menustrip to back login 
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this program!");
            formLogin bakcing = new formLogin();
            bakcing.Show();
            this.Hide();
        }

        // menustrip about
        private void aboutThisProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string message = "This program is used to calculate my midterm grades.";
            string title = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, title, buttons, icon);

        }

        // menustrip adamson website
        private void visitAduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.adamson.edu.ph");
        }

        // menustrip exit program 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
       
        //link label  visit duke blog
        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            this.uiLinkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.itiohub.com");
        }


        //label clear
        private void labelClear_1_Click(object sender, EventArgs e)
        {
            textBoxAs1.Clear();
            textBoxAt1.Clear();
            textBoxla1.Clear();
            textBoxLa2.Clear();
            textBoxla3.Clear();
            textBoxMex.Clear();
            textBoxQz1.Clear();
            textBoxQz2.Clear();
            textBoxQz3.Clear();

            labelQzave.Text = string.Empty;
            labelMidGrade.Text = string.Empty;
            labelLabave.Text = string.Empty;
            labelStave.Text = string.Empty;
            labelMES.Text = string.Empty;

            textBoxQz1.Focus();

        }


        //button to calculate all grades
        private void btnComputer_Click(object sender, EventArgs e)
        {
            try
            {

                //output Grades
                labelQzave.Text = "" + QuizzesAve();
                labelLabave.Text = "" + LabAverage();
                labelStave.Text = "" + ClassStanding();
                labelMES.Text = "" + MidtermExam();
                labelMidGrade.Text = "" + midtermgrades();

                //conditional statement, determine whether the grades is passed or failed  
                if (midtermgrade > 70)
                {
                    labelMidGrade.ForeColor = Color.Green;
                    labelGradeResult.Text = Passed;
                    labelGradeResult.ForeColor = Color.Green;
                }

                else
                {
                    labelMidGrade.ForeColor = Color.Red;
                    labelGradeResult.Text = Failed;
                    labelGradeResult.ForeColor = Color.Red;
                }

            }
            catch
            {

                string  message ="Invalid Input , Please try again !";
                string title = "Waring";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
            }
        }
		
		    //button color change 
        private void btnColorchange_Click(object sender, EventArgs e)
        {

            string message = "This button has a limited function and is designed only to modify the border color of the GroupBox and the color of certain Label text.";
            string title = "Waring";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(message, title, buttons, icon);

            ColorDialog colorChange = new ColorDialog();
            colorChange.AllowFullOpen = false;
            colorChange.Color = uiGroupBox2.RectColor = Color.Green;

            if (colorChange.ShowDialog() == DialogResult.OK)
            {

                uiGroupBox1.RectColor = colorChange.Color;
                uiGroupBox2.RectColor = colorChange.Color;
                uiGroupBox3.RectColor = colorChange.Color;
                midExam.RectColor = colorChange.Color;
                midgrade.RectColor = colorChange.Color;
                uiGroupBox6.RectColor = colorChange.Color;

                labelQz1.ForeColor = colorChange.Color;
                labelQz2.ForeColor = colorChange.Color;
                labelQz3.ForeColor = colorChange.Color;
                labelL1.ForeColor = colorChange.Color;
                labelL2.ForeColor = colorChange.Color;
                labelL3.ForeColor = colorChange.Color;
                labelAS1.ForeColor = colorChange.Color;
                labelAT1.ForeColor = colorChange.Color;
                labelMEX.ForeColor = colorChange.Color;
                labelMG.ForeColor = colorChange.Color;

            }
        }
    }
}
