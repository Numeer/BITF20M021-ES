using System.Text.RegularExpressions;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double operand1;
        double operand2;
        double result = 0;
        bool notDivideByZero = false;
        string sign;
        private List<string> history1 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            History_click(sender, e);
            this.Focus();
            this.KeyPreview = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sign = string.Empty;
            result = 0; notDivideByZero = false;
            notDivideByZero = false;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (result != 0 || notDivideByZero)
            {
                textBox1.Text = "";
                result = 0; notDivideByZero = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                result = 0;
            }
            operand1 = Convert.ToDouble(textBox1.Text);
            sign = "+";
            textBox1.Text = textBox1.Text + sign;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                result = 0;
            }
            operand1 = Convert.ToDouble(textBox1.Text);
            sign = "-";
            textBox1.Text = textBox1.Text + sign;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                result = 0;
            }
            operand1 = Convert.ToDouble(textBox1.Text);
            sign = "/";
            textBox1.Text = textBox1.Text + sign;
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                result = 0;
            }
            operand1 = Convert.ToDouble(textBox1.Text);
            sign = "*";
            textBox1.Text = textBox1.Text + sign;
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
                string newText = currentText.Substring(0, currentText.Length - 1);
                textBox1.Text = newText;
            }
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sign) && textBox1.Text.Contains(sign))
            {
                string[] numbers = textBox1.Text.Split(new char[] { '+', '-', '*', '/' });

                if (numbers.Length == 2)
                {
                    operand2 = Convert.ToDouble(numbers[1]);

                    switch (sign)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            if (operand2 == 0)
                            {
                                notDivideByZero = true;
                            }

                            else
                                result = (double)operand1 / operand2;
                            break;
                    }
                    if (notDivideByZero == false)
                    {
                        textBox1.Text = result.ToString();
                        history1.Add($"{operand1} {sign} {operand2} = {result}");
                        History_click(sender, e);
                    }
                    else
                        textBox1.Text = "Cannot divide by zero";
                }
            }

        }

        private void History_click(object sender, EventArgs e)
        {
            History.Items.Clear();
            History.Items.Add("History ");
            foreach (var equation in history1)
            {
                History.Items.Add(equation);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (result != 0 || notDivideByZero)
                {
                    result = 0; notDivideByZero = false;
                    textBox1.Text = "";
                }
                if (textBox1.Text == "0" && textBox1.Text != null)
                    textBox1.Text = e.KeyChar.ToString();
                else
                    textBox1.Text += e.KeyChar;
            }
            else if (e.KeyChar == '\b')
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
            else if (e.KeyChar == '.')
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".";
                }
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                if (result != 0)
                    result = 0;
                if (textBox1.Text.Length > 0)
                {
                    operand1 = Convert.ToDouble(textBox1.Text);
                    sign = e.KeyChar.ToString();
                    textBox1.Text = textBox1.Text + sign;
                }
            }
            else if (e.KeyChar == 3)
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
            else if (e.KeyChar == 22)
            {
                string clipboardText = Clipboard.GetText();
                string[] parts = Regex.Split(clipboardText, @"([+\-*/])");

                if (parts.Length >= 1)
                {
                    operand1 = Convert.ToDouble(parts[0]);

                    if (parts.Length >= 2)
                    {
                        sign = parts[1];

                        if (parts.Length >= 3)
                        {
                            operand2 = Convert.ToDouble(parts[2]);
                        }
                    }

                    textBox1.Text += clipboardText;
                }
            }
            else if (e.KeyChar == '\r')
            {
                if (textBox1.Text.Contains(sign))
                {
                    string[] numbers = textBox1.Text.Split(new char[] { '+', '-', '*', '/' });

                    if (numbers.Length == 2)
                    {
                        operand2 = Convert.ToDouble(numbers[1]);

                        switch (sign)
                        {
                            case "+":
                                result = operand1 + operand2;
                                break;
                            case "-":
                                result = operand1 - operand2;
                                break;
                            case "*":
                                result = operand1 * operand2;
                                break;
                            case "/":
                                if (operand2 == 0)
                                {
                                    notDivideByZero = true;
                                }
                                else
                                {
                                    result = (double)operand1 / operand2;
                                }
                                break;
                        }

                        if (notDivideByZero == false)
                        {
                            textBox1.Text = result.ToString();
                            history1.Add($"{operand1} {sign} {operand2} = {result}");
                            History_click(sender, e);
                        }
                        else
                        {
                            textBox1.Text = "Cannot divide by zero";
                        }
                    }
                }
            }

            e.Handled = true;
        }
    }
}