namespace Kalkulačka
{
    public partial class Form1 : Form
    {

        UserInputs num = new UserInputs();
        public Form1()
        {
            InitializeComponent();
            result.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "1";
                num.Add("1");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "2";
                num.Add("2");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "3";
                num.Add("3");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "4";
                num.Add("4");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "5";
                num.Add("5");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "6";
                num.Add("6");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "7";
                num.Add("7");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "8";
                num.Add("8");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "9";
                num.Add("9");
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                result.Text += "0";
                num.Add("0");
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (result.Text.Length < 5)
            {
                if (result.Text.Length == 0)
                {
                    result.Text += "0.";
                    num.Add("0,");
                }
                else
                {
                    result.Text += ",";
                    num.Add(".");
                }
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num.Plus();
            result.Text = "";
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num.Minus();
            result.Text = "";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num.Multiply();
            result.Text = "";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num.Divide();
            result.Text = "";
        }
        private void resultButton_Click(object sender, EventArgs e)
        {
            result.Text = num.Final_result();
        }
        private void clearButton_Click(Object sender, EventArgs e)
        {
            num.Clear();
            result.Text = "";

        }
    }
}