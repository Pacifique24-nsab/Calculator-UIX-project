using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_UIX__project
{
    public partial class Form1 : Form
    {
        // let's declare variables here
        string currentInput = "";
        double result = 0; // initialize the result to zero
        string operation = "";
        bool operationPending = false;

        // connecting the form1 to form 2
        public static Form1 instance;
        public TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void digit1Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;    
        }

        private void digit2Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit4Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit5Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit6Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit7Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit8Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void digit9Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {

            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Evaluate(); 

            
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {

            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void digit0Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        // now let's create a method to evaluate and make decisions based on the solutions
        private void Evaluate()
        {
            double secondNumber = double.Parse(currentInput);
            switch (operation)
            {
                case "+":
                    result += secondNumber; break;

                case "-":
                    result -= secondNumber; break;

                case "*":
                    result *= secondNumber; break;

                case "/":
                    if (secondNumber != 0)
                    {
                        result /= secondNumber; break;
                    }
                    else
                    {
                        textBox1.Text = "Error: you can't divide by zero";
                        return;

                    }
                    break;
            }

            textBox1.Text = result.ToString();
            currentInput = "";
            operationPending =false;

        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;

        }

        private void digit3Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void appDescriptionButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:paccynsabumukiza24@gmail.com");
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();

        }
    }
}
