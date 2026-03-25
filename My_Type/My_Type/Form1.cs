using System;

namespace My_Type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textFirstNum_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textFirstDenum_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecondNum_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecondDenum_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperation.Text != "^" && textSecondNum.Text == "0" && textSecondDenum.Text == "0")
            {
                textSecondNum.Text = "";
                textSecondDenum.Text = "";
            }

            if (cmbOperation.Text == "^")
            {
                ChangeGUI(false, "^");
            }
            else
            {
                ChangeGUI(false, "=");
            }

            Calculate();
        }

        private void Calculate()
        {
            if ((cmbOperation.Text == "" || textSecondDenum.Text == "") && cmbOperation.Text != "^")
            {
                ChangeGUI(false, "=");
                textFinResNum.Text = "";
                textFinResDenum.Text = "";
            }
            try
            {
                var firstNum = int.Parse(textFirstNum.Text);
                var firstDenum = int.Parse(textFirstDenum.Text);
                var secondNum = int.Parse(textSecondNum.Text);
                var secondDenum = int.Parse(textSecondDenum.Text);

                var firstFraction = new Fraction(firstNum, firstDenum);
                var secondFraction = new Fraction(secondNum, secondDenum);

                Fraction resFraction = new Fraction(0, 0);

                bool isOperator = true;

                if (isOperator)
                {
                    ChangeGUI(!isOperator, "=");
                }

                switch (cmbOperation.Text)
                {
                    case "+":
                        resFraction = firstFraction + secondFraction;
                        isOperator = true;
                        ChangeGUI(isOperator, "+");
                        WriteFinResult(resFraction);
                        break;
                    case "-":
                        resFraction = firstFraction - secondFraction;
                        isOperator = true;
                        ChangeGUI(isOperator, "-");
                        WriteFinResult(resFraction);
                        break;
                    case "*":
                        resFraction = firstFraction * secondFraction;
                        isOperator = true;
                        ChangeGUI(isOperator, "*");
                        WriteFinResult(resFraction);
                        break;
                    case "/":
                        resFraction = firstFraction / secondFraction;
                        isOperator = true;
                        ChangeGUI(isOperator, "/");
                        WriteFinResult(resFraction);
                        break;
                    case ">":
                        if (firstFraction > secondFraction)
                        {
                            textFinResNum.Text = "True";
                        }
                        else
                        {
                            textFinResNum.Text = "False";
                        }
                        isOperator = false;
                        ChangeGUI(isOperator, ">");
                        break;
                    case "<":
                        if (firstFraction < secondFraction)
                        {
                            textFinResNum.Text = "True";
                        }
                        else
                        {
                            textFinResNum.Text = "False";
                        }
                        isOperator = false;
                        ChangeGUI(isOperator, "<");
                        break;
                    case "=":
                        if (firstFraction == secondFraction)
                        {
                            textFinResNum.Text = "True";
                        }
                        else
                        {
                            textFinResNum.Text = "False";
                        }
                        isOperator = false;
                        ChangeGUI(isOperator, "=");
                        break;
                    case "^":
                        var reducedResFraction = Fraction.ReduceFraction(firstFraction);
                        textFinResNum.Text = reducedResFraction.numerator.ToString();
                        textFinResDenum.Text = reducedResFraction.denumerator.ToString();
                        isOperator = false;
                        ChangeGUI(isOperator, "^");
                        break;
                    default:
                        resFraction = new Fraction(0, 0);
                        break;
                }
            }
            catch (FormatException)
            {

            }
        }

        private void ChangeGUI(bool isOperator, string strOperator)
        {
            labelEqual.Visible = isOperator;
            textResultNum.Visible = isOperator;
            textResultDenum.Visible = isOperator;
            if (strOperator == "^")
            {
                textFinResDenum.Visible = true;
                textSecondNum.Visible = false;
                textSecondDenum.Visible = false;
                textSecondNum.Text = "0";
                textSecondDenum.Text = "0";
            }
            else if (strOperator == ">" || strOperator == "<" || strOperator == "=")
            {
                textFinResDenum.Visible = false;
                textSecondNum.Visible = true;
                textSecondDenum.Visible = true;
            }
            else
            {
                textFinResDenum.Visible = true;
                textSecondNum.Visible = true;
                textSecondDenum.Visible = true;
            }
        }

        private void WriteFinResult(Fraction resFraction)
        {
            textResultNum.Text = resFraction.numerator.ToString();
            textResultDenum.Text = resFraction.denumerator.ToString();

            var resNum = int.Parse(textResultNum.Text);
            var resDenum = int.Parse(textResultDenum.Text);

            if (resDenum != 0)
            {
                var reducedResFraction = Fraction.ReduceFraction(new Fraction(resNum, resDenum));
                textFinResNum.Text = reducedResFraction.numerator.ToString();
                textFinResDenum.Text = reducedResFraction.denumerator.ToString();
            }
            else
            {
                textFinResNum.Text = "";
                textFinResDenum.Text = "";
            }
        }
    }
}
