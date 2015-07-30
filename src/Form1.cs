using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float op1 = 0, op2 = 0;
        bool signFlag = false;
        string operation;
        float result;

        public Form1()
        {
            InitializeComponent();
            //draw screen border
            this.Paint += new PaintEventHandler(Form1_Paint);
            //add key events
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 42 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 27)
            {
                switch(e.KeyChar)
                {
                    case (char)8: delete.PerformClick(); break;
                    case (char)27: clear.PerformClick(); break;
                    case (char)42: multiply.PerformClick(); break;
                    case (char)43: add.PerformClick(); break;
                    case (char)45: subtract.PerformClick(); break;
                    case (char)46: dot.PerformClick(); break;
                    case (char)47: divide.PerformClick(); break;
                    case (char)48: zero.PerformClick();  break;
                    case (char)49: one.PerformClick();  break;
                    case (char)50: two.PerformClick(); break;
                    case (char)51: three.PerformClick(); break;
                    case (char)52: four.PerformClick(); break;
                    case (char)53: five.PerformClick(); break;
                    case (char)54: six.PerformClick(); break;
                    case (char)55: seven.PerformClick(); break;
                    case (char)56: eight.PerformClick(); break;
                    case (char)57: nine.PerformClick(); break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equal.PerformClick();
            } else if (e.KeyCode == Keys.Delete)
            {
                delete.PerformClick();
            }
        }        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen p = new Pen(Color.LightGray, 3);
            Rectangle r = new Rectangle(displayTop.Location.X, displayTop.Location.Y, displayTop.Width-1, 53); 
            g.DrawRectangle(p, r);
        }

        private void checkDisplay()
        {
            if (signFlag == true)
            {
                displayBottom.Text = "";
                signFlag = false;
            }
            if (displayBottom.Text == "0")
                displayBottom.Text = "";
            
        }        

        private void one_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (displayBottom.Text.Length > 14 || displayBottom.Text.Contains("."))
                System.Media.SystemSounds.Exclamation.Play();
            else
            {
                if (displayBottom.Text == "" || displayBottom.Text == null)
                    displayBottom.Text += "0.";
                else
                    displayBottom.Text += ".";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (displayBottom.Text.Length > 0)
                displayBottom.Text = displayBottom.Text.Substring(0,displayBottom.Text.Length-1);
        }

        private void displayHistory(string sign)
        {
            displayTop.Text += " " + displayBottom.Text + " " + sign;
        }        

        private void changeSign(string sign)
        {
            string display = displayTop.Text;
            if (display == null || display == "")
                displayHistory(sign);
            else
                displayTop.Text = display.Substring(0, display.Length-1) + sign;
        }

        private void calculate()
        {            
            if(operation == "+")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 + op2;                
                displayBottom.Text = result.ToString();
                op1 = result;

            }
            else if (operation == "-")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 - op2;
                displayBottom.Text = result.ToString();
                op1 = result;
            }
            else if (operation == "/")
            {
                op2 = float.Parse(displayBottom.Text);
                if (op2 == 0)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    displayBottom.Text = "DIV/ZERO!";
                }
                else
                {
                    result = op1 / op2;
                    displayBottom.Text = result.ToString();
                    op1 = result;
                }
            }
            else if (operation == "*")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 * op2;
                displayBottom.Text = result.ToString();
                op1 = result;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (signFlag == true)
                changeSign("+");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("+");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("+");
                    calculate();
                }
            }
            operation = "+";
            signFlag = true;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (signFlag == true)
                changeSign("-");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("-");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("-");
                    calculate();
                }
            }
            operation = "-";
            signFlag = true;
            
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (operation != "/" && signFlag == true)
                changeSign("/");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("/");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("/");
                    calculate();
                }
            }
            operation = "/";           
            signFlag = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operation != "*" && signFlag == true)
                changeSign("*");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("*");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("*");
                    calculate();
                }
            }
            operation = "*";
            signFlag = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (displayTop.Text != "")
            {
                op2 = float.Parse(displayBottom.Text);
                calculate();
            }
            displayTop.Text = "";            
            signFlag = true;   
        }

        private void clear_Click(object sender, EventArgs e)
        {
            displayTop.Text = "";
            displayBottom.Text = "0";
            op1 = 0;
            op2 = 0;
            
        }        
    }
}
