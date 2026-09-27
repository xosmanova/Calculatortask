namespace CalculatorDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);

            double result = 0;

            if (comboBox1.Text == "+")
            {
                result = number1 + number2;
            }
            else if (comboBox1.Text == "-")
            {
                result = number1 - number2;
            }
            else if (comboBox1.Text == "*")
            {
                result = number1 * number2;
            }
            else if (comboBox1.Text == "/")
            {
                result = number1 / number2;
            }

            label5.Text = result.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            comboBox1.SelectedIndex = -1;
            label5.Text = "0";
        }
    }

}
