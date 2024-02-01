namespace calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
            button0.Click += new EventHandler(button_Click);
            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
            button6.Click += new EventHandler(button_Click);
            button7.Click += new EventHandler(button_Click);
            button8.Click += new EventHandler(button_Click);
            button9.Click += new EventHandler(button_Click);

            button_Add.Click += new EventHandler(operationButton_Click);
            button_Subtract.Click += new EventHandler(operationButton_Click);

            button_Equals.Click += new EventHandler(buttonEquals_Click);
            button_Clear.Click += new EventHandler(buttonClear_Click);
            button_Negative.Click += new EventHandler(button_Negative_Click);
            button_Delete.Click += new EventHandler(button_Delete_Click);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((textBox_Result.Text == "0") || isOperationPerformed)
            {
                textBox_Result.Clear();
            }

            if (operationPerformed == "=")
            {
                textBox_Result.Text = "";
                operationPerformed = "";
            }

            isOperationPerformed = false;
            textBox_Result.Text += button.Text;
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            if (resultValue != 0 && !isOperationPerformed)
            {
                button_Equals.PerformClick();
            }
            else
            {
                resultValue = Double.Parse(textBox_Result.Text);
            }

            Button button = (Button)sender;
            operationPerformed = button.Text;
            isOperationPerformed = true;
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            operationPerformed = "";
            operationPerformed = "=";
            isOperationPerformed = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            isOperationPerformed = false;
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1, 1);
            }
            if (textBox_Result.Text == "")
            {
                textBox_Result.Text = "0";
            }
        }
        private void button_Negative_Click(object sender, EventArgs e)
        {
            if (!textBox_Result.Text.StartsWith("-"))
            {
                textBox_Result.Text = "-" + textBox_Result.Text;
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text.TrimStart('-');
            }
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            if (resultValue != 0 && !isOperationPerformed)
            {

                button_Equals.PerformClick();
            }
            else
            {
                resultValue = Double.Parse(textBox_Result.Text);
            }

            Button button = (Button)sender;
            operationPerformed = "*";
            isOperationPerformed = true;
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (resultValue != 0 && !isOperationPerformed)
            {

                button_Equals.PerformClick();
            }
            else
            {
                resultValue = Double.Parse(textBox_Result.Text);
            }

            Button button = (Button)sender;
            operationPerformed = "/";
            isOperationPerformed = true;
        }
    }
}