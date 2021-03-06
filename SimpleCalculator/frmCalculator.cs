﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtScreen.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                txtScreen.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                txtScreen.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtScreen.Text = result.ToString();
                }

                else
                {
                    txtScreen.Text = "Can't Divide By 0!";
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += ".";
            this.txtScreen.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "7";
            this.txtScreen.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "8";
            this.txtScreen.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "9";
            this.txtScreen.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "4";
            this.txtScreen.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "5";
            this.txtScreen.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "6";
            this.txtScreen.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "1";
            this.txtScreen.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "2";
            this.txtScreen.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "3";
            this.txtScreen.Text += input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "";
            input += "0";
            this.txtScreen.Text += input;
        }
    }
}
