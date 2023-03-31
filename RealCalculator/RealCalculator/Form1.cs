using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealCalculator
{
    public partial class Form1 : Form
    {

        double num1 = 0;
        string op;
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            num1 = 0;
            op = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            Result.Text += buttonDot.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(Result.Text);

            switch (op)
            {
                case "+":
                    num1 += num2;
                    break;
                case "-":
                    num1 -= num2;
                    break;
                case "/":
                    num1 /= num2;
                    break;
                case "*":
                    num1 *= num2;
                    break;

            }

            Result.Text = num1.ToString();
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            Result.Text += ((Button)sender).Text;
        }


        private void Opbtn(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Result.Text);
            Result.Text = "";
            op = ((Button)sender).Text;
        }
    }
}
