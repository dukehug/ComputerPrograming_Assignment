using System;
using System.Reflection;
using Sunny;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public double fstNum, secNum;
        public string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sencondNumber_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btPuls_Click(object sender, EventArgs e)
        {

            
        }
        
        //button delete 
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";

            }
        }

        // buttonofnumber 
        private void uiButton7_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "1";
            }
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "2";
            }
        }

        private void uiButton9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "3";
            }
        }

        private void uiButton12_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "4";
            }
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "5";
            }
        }

        private void uiButton10_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "6";
            }
        }

        private void uiButton18_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "7";
            }
        }

        private void uiButton17_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "8";
            }
        }

        private void uiButton16_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "9";
            }
        }

        private void uiButton19_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "0";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "0";
            }
        }
        
        //button 
        private void btDec_Click(object sender, EventArgs e)
        {
            if (btDec.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                {
                    textDisplay.Text = textDisplay.Text + btDec.Text;
                }
            }
        }
        
        //button equal 
        private void btEqual_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(textDisplay.Text);
            
            //switchoper 
            switch (oper)
            {
                case "+":
                    textDisplay.Text = (fstNum + secNum).ToString();
                    break;
                case "-":
                    textDisplay.Text = (fstNum - secNum).ToString();
                    break;
                case "*":
                    textDisplay.Text = (fstNum * secNum).ToString();
                    break;
                case "/":
                    textDisplay.Text = (fstNum / secNum).ToString();
                    break;

                default:
                    break;


            }
        }

        //button of operator
        private void btPlus_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(textDisplay.Text);
            oper = "+";
            textDisplay.Text = "";
        }

        private void btSubtraction_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(textDisplay.Text);
            oper = "-";
            textDisplay.Text = "";
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(textDisplay.Text);
            oper = "*";
            textDisplay.Text = "";
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(textDisplay.Text);
            oper = "/";
            textDisplay.Text = "";
        }

        // positive and negative
        private void uiButton1_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = Convert.ToString(-1 * q);
        }
      
        //clear 
        private void btClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);

            f = "";
            s = "";
        }
    }
}
