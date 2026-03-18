namespace My_Type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Calculate();
        }

        private void Calculate()
        {
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

                switch (cmbOperation.Text)
                {
                    case "+":
                        resFraction = firstFraction + secondFraction;
                        isOperator = true;
                        break;
                    case "-":
                        resFraction = firstFraction - secondFraction;
                        isOperator = true;
                        break;
                    case "*":
                        resFraction = firstFraction * secondFraction;
                        isOperator = true;
                        break;
                    case "/":
                        resFraction = firstFraction / secondFraction;
                        isOperator = true;
                        break;
                    case ">":
                        Fraction.IsFirstFractionGreater(firstFraction, secondFraction);
                        isOperator = false;
                        break;
                    case "<":
                        Fraction.IsFirstFractionLess(firstFraction, secondFraction);
                        isOperator = false;
                        break;
                    case "=":
                        Fraction.AreFractionsEqual(firstFraction, secondFraction);
                        isOperator = false;
                        break;
                    case "^":
                        Fraction.ReduceFraction(firstFraction);
                        isOperator = false; // тут убрать потом
                        break;
                    default:
                        resFraction = new Fraction(0, 0);
                        break;
                }

                textResultNum.Text = resFraction.numerator.ToString();
                textResultDenum.Text = resFraction.denumerator.ToString();

                var resNum = int.Parse(textResultNum.Text);
                var resDenum = int.Parse(textResultDenum.Text);
                if (resDenum != 0 && isOperator == true)
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
            catch (FormatException)
            {

            }
        }

    }
}
