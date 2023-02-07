namespace Basic_Caluclator
{
    public partial class Form1 : Form
    {
        //variable
        public double num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Multiplication
        private void btMultiplication_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textNumber1.Text);
            num2 = Convert.ToDouble(textNumber2.Text);

            result = num1 * num2;

            textResult.Text = result.ToString();
        }
        // Division
        private void btDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textNumber1.Text);
            num2 = Convert.ToDouble(textNumber2.Text);

            result = num1 / num2;

            textResult.Text = result.ToString();
        }
        //clear 
        private void btClear_Click(object sender, EventArgs e)
        {
            textNumber1.Text = "";
            textNumber2.Text = "";
            textResult.Text = "";

        }
        //plus
        private void btPlus_Click(object sender, EventArgs e)
        {
           

            num1 = Convert.ToDouble(textNumber1.Text);
            num2 = Convert.ToDouble(textNumber2.Text);

            result = num1 + num2;

            textResult.Text = result.ToString();

        }
        //Subtraction
        private void btSubtraction_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textNumber1.Text);
            num2 = Convert.ToDouble(textNumber2.Text);

            result = num1 - num2;

            textResult.Text = result.ToString();
        }
    }
}
