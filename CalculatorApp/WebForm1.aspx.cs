using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = CalcOperations.Addition(num1, num2);
            txtResult.Text = Convert.ToString(result);
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = CalcOperations.Subtraction(num1, num2);
            txtResult.Text = Convert.ToString(result);
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = CalcOperations.Multiplication(num1, num2);
            txtResult.Text = Convert.ToString(result);
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = CalcOperations.Division(num1, num2);
            if (double.IsNaN(result))
            {
                txtResult.Text = Convert.ToString("Undefind value");
            }
            else if (double.IsPositiveInfinity(result)||double.IsNegativeInfinity(result))
            {
                txtResult.Text = Convert.ToString("Infinity");
            }
            else
            {
                txtResult.Text = Convert.ToString(result);
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
        }
    }
}