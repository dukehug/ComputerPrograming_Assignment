using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_LAB_Activity_3_M
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //  explain content
 
        string forLoop = "The for statement executes a statement or a block of statements while a specified Boolean expression evaluates to true.\n " +
            "\nStatement 1 is executed (one time) before the execution of the code block.\r\n\r\nStatement 2 defines the condition for executing the code block.\r\n\r\nStatement 3 is executed (every time) after the code block has been executed."+
            "\n\nIn this example, 10 loop operations are performed. ";


        string foreachLoop = "The foreach statement provides a simple, clean way to iterate through the elements of an array.\n"+
               "\nIn this example ,Frist initializes a two-dimensional string array called \"parts\" with two rows and three columns, and fills it with the names of different phone brands.\r\n\r\nThen, it clears the items of a list box called \"listExample\" and adds a string to it indicating that a foreach loop will be demonstrated.\r\n\r\nThe foreach loop iterates over each element in the \"parts\" array and adds each element as a string to the list box.\r\n";


        string whileLoop = "The while loop loops through a block of code as long as a specified condition is \"True\".\n" +
            "\n In this example, the variable \" num\" is initialized as 10, and the while loop's condition is \"num<=20\" which is initially evaluated as \"True\". Within the code block of the while loop, \"num++\" is executed, causing the loop to repeat 11 times until the condition is evaluated as\" False\", at which point the loop will terminate.";


        string doWhileLoop = "The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true."+
            "\n\n In this example , the variable  \"num \" is initialized as 30,  then the program enters the do-while loop, which will execute 10 increments with the variable \"num\"  from 30 to 40, inclusive of 40. The condition for the do-while loop is num <= 40. ";


        string singleArrays = "Single-Dimensional Arrays in C# are data structures that store a collection of elements of the same type in a linear sequence, where each element can be accessed by its index.\n"+
            "\nIn this example, an array named 'classmates' of type string is first created to store the names of classmates. Then a 'for' loop is used to display the value and index of each element in the 'classmates' array";


        string twoArrays = "Two-dimensional arrays or multi-dimensional arrays are arrays where the data element's position is referred to, by two indices. The name specifies two dimensions, that is, row and column.\n ";


        string mulipArrays = "In C#, a multidimensional array is an array that contains more than one dimension or index. It can be two-dimensional, three-dimensional, or even more. Each dimension of the array is also called a rank. A multidimensional array is created by specifying the size of each dimension in the array declaration. The elements in a multidimensional array are accessed using multiple indexes that correspond to each dimension of the array.\n"+
            " \n string[,,] companies = new string[2, 2, 3] { { { \"Google\", \"Yahoo\", \"Biadu\" }, { \"Apple\", \"Xiaomi\", \"Samsung\" } },\r\n   { {\"Microsoft\",\"Meta\",\"Tencent\"},{ \"Amazon\",\"Tesla\",\"TSMC\"} } };\r\n\r\n           ";
        string morenoted = "\n  In this example, an array called \"companies\" is created. The three nested for loops are used to go through each element in the array, displaying both its value and index. ";


        //background color change
        private void backGroundColorChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorChange = new ColorDialog();
            colorChange.AllowFullOpen = false;
            colorChange.Color = listExample.FillColor;

            if (colorChange.ShowDialog() == DialogResult.OK)
            {

                listExample.FillColor = colorChange.Color;  //listbox background color change
                labelExplain.BackColor = colorChange.Color; //lable background color change


            }
        }

        
        //change listbox text color
        private void textColorChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorChange = new ColorDialog();
            colorChange.AllowFullOpen = false;
            colorChange.Color = listExample.ForeColor;

            if (colorChange.ShowDialog() == DialogResult.OK)
            {

                listExample.ForeColor = colorChange.Color;  //listbox text color change
                labelExplain.ForeColor = colorChange.Color; //lable text color change


            }
        }

        //exit program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        //messagebox about program
        private void aboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "This program provides a better understanding of the usage of loops and arrays through examples and explanations.";
            string title = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, title, buttons, icon);
        }


        //visit adamson website
        private void visitADUWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.adamson.edu.ph");
        }



        //for looping
        private void forLoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();
            listExample.Items.Add(string.Format("For loop\t  for (int i = 1; i <= 10; i++) \n"));
            for (int i = 1; i <= 10; i++)
            { 
                
                listExample.Items.Add(string.Format("{0}",i));
            
            
            }

            labelExplain.Text = string.Empty;
            labelExplain.Text = forLoop;

        }


        //back to login
        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }



        //clear all content
        private void clearAllContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();
            labelExplain.Text= string.Empty;
        }


        //foreach loop
        private void foreachLoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string[,] parts = new string[2, 3] { { "iPhone","Xiaomi","Huawei"}, {"Samsung", "Vivo", "Nokia" } };

            listExample.Items.Clear();

            listExample.Items.Add(string.Format("Foreach Loop example: \n"));

            foreach (var item in parts)
            { 
            
                listExample.Items.Add((string)item);
            
            }

            labelExplain.Text = string.Empty;
            labelExplain.Text = foreachLoop;

        }

        //while loop
        private void whileLoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();
            listExample.Items.Add(string.Format("While Loop example: \n "));
            listExample.Items.Add(string.Format("int num = 10 while (num <=20);"));
            

            int num = 10;
            while (num <= 20)
            { 
                listExample.Items.Add(((int)num).ToString());
                num++;
            
            }

            labelExplain.Text = string.Empty;
            labelExplain.Text = whileLoop;
        }

        //do while loop
        private void doWhileLoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            listExample.Items.Clear();

            listExample.Items.Add(string.Format("Do While Loop example: \n "));
            int num = 30;
            do
            {
                listExample.Items.Add(((int)num).ToString());
                num++;


            }
            while (num <= 40);
            labelExplain.Text = string.Empty;
            labelExplain.Text = doWhileLoop;
        }

        //single dimensional arrays
        private void arraysToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();
            string[] classmates = { "Ryan", "Pilpa", "Ervin", "Kobi", "Duke", "Soliman" };

            listExample.Items.Add(string.Format("Single-Dimensional Arrays example: \n "));
            for (int i = 0; i < classmates.Length; i++)
            {

                listExample.Items.Add(string.Format("Index: [{0,2}],Value: {1}", i, classmates[i]));

            }

            labelExplain.Text = string.Empty;
            labelExplain.Text = singleArrays;


        }

        // two dimensional arrays
        private void twoDimensionalArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();

            string[,] matrix = new string[2, 2] { { "Apple", "Xiaomi" }, { "Samsung", "Nokia"}, };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    listExample.Items.Add(string.Format($"Index: [{row},{col}],Value: {matrix[row,col]}"));
                }
             
            }

            labelExplain.Text = string.Empty;
            labelExplain.Text = twoArrays;
        }


        //multiple arrays
        private void multidimensionalArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listExample.Items.Clear();
            string[,,] companies = new string[2, 2, 3] { { { "Google", "Yahoo", "Biadu" }, { "Apple", "Xiaomi", "Samsung" } },
                                                            { {"Microsoft","Meta","Tencent"},{ "Amazon","Tesla","TSMC"} } };

            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 2; j++)
                {

                    for (int k = 0; k < 3; k++)
                    {

                        listExample.Items.Add(string.Format($"Index: [{i},{j},{k}],Value: {companies[i,j,k]}"));

                    }
                }

            }
            
            labelExplain.Text = string.Empty;
            labelExplain.Text = mulipArrays + morenoted;

        }
    }
}
