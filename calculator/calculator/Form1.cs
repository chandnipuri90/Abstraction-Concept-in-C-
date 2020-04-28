using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;

        
        public Form1()
        {
            InitializeComponent();

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";

            }
            else
                textBox1.Text = textBox1.Text + "2";

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";

            }
            else
                textBox1.Text = textBox1 .Text+ "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";

            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";

            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";

            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";

            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";

            }
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";

            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void badd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (operation == "+")
            {
                Result = (firstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (operation == "-")
            {
                Result = (firstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (operation == "*")
            {
                Result = (firstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (firstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
    

