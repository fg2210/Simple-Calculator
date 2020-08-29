using System;
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

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input += "0";
        }
    }
}
