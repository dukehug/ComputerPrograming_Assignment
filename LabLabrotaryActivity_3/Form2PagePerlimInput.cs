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
        double assignment, attendance, aveclasstanding;
        double q1, q2, avequizzes;
        double lab1, lab2, avela;
        double prelimscore,perlimResult, prelimgrade;

        public double QuizzesAve()
        {
            q1 = Convert.ToDouble(textBoxQz1.Text);
            q2 = Convert.ToDouble(textBoxQz2.Text);

            avequizzes = (q1 + q2 + 5) / 90 * 100;
            
            avequizzes = Math.Round(avequizzes);

            return avequizzes;

        }
        public double LabAverage()
        {
            lab1 = Convert.ToDouble(textBoxla1.Text);
            lab2 = Convert.ToDouble(textBoxLa2.Text);
            avela = (lab1 + lab2) / 2;

            avela = Math.Round(avela);
            return avela;
        
        
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        public double ClassStanding()
        {
            assignment = Convert.ToDouble(textBoxAs1.Text);
            attendance = Convert.ToDouble(textBoxAt1.Text);

            aveclasstanding = (assignment + attendance) / 2;

            aveclasstanding = Math.Round(aveclasstanding);
            return aveclasstanding;

        }
        public double PerlimExam()
        {
            prelimscore = Convert.ToDouble(textBoxPes.Text);

            perlimResult = prelimscore / 60 * 100;

            perlimResult = Math.Round(perlimResult);
            return perlimResult;

        }
        public double PrelimGrades()
        {

            prelimgrade = (QuizzesAve()*0.25) + (PerlimExam()*0.3) + (LabAverage()*0.25) + (ClassStanding()*0.2);

            prelimgrade = Math.Round(prelimgrade);
            return prelimgrade;

        }

        public Form2PagePerlimInput()
        {
            InitializeComponent();
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            this.uiLinkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.itiohub.com");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this program!");
            formLogin bakcing = new formLogin();
            bakcing.Show();
            this .Hide();
        }

        private void labelClear_1_Click(object sender, EventArgs e)
        {
            textBoxAs1.Clear();
            textBoxAt1.Clear();
            textBoxla1.Clear();
            textBoxLa2.Clear();
            textBoxPes.Clear();
            textBoxQz1.Clear();
            textBoxQz2.Clear();

            labelQzave.Text = string.Empty;
            labelPrelimGrade.Text = string.Empty;
            labelLabave.Text = string.Empty;
            labelStave.Text = string.Empty;
            labelPES.Text = string.Empty;

            textBoxQz1.Focus();

        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            try
            {


                labelQzave.Text = "" + QuizzesAve();
                labelLabave.Text = "" + LabAverage();
                labelStave.Text = "" + ClassStanding();
                labelPES.Text = "" + PerlimExam();
                labelPrelimGrade.Text = "" + PrelimGrades();

                if (prelimgrade > 70)
                {
                    labelPrelimGrade.ForeColor = Color.Green;
                }

                else
                {
                    labelPrelimGrade.ForeColor = Color.Red;
                }

            }
            catch
            {

                MessageBox.Show("Invalid Input , Please try again !");

            }



        }
    }
}
