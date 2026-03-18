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

                switch (cmbOperation.Text)
                {
                    case "+":
                        resFraction = firstFraction + secondFraction;
                        break;
                    case "-":
                        resFraction = firstFraction - secondFraction;
                        break;
                    case "*":
                        resFraction = firstFraction * secondFraction;
                        break;
                    case "/":
                        resFraction = firstFraction / secondFraction;
                        break;
                    case ">":
                        Fraction.IsFirstFractionGreater(firstFraction, secondFraction);
                        break;
                    case "<":
                        Fraction.IsFirstFractionLess(firstFraction, secondFraction);
                        break;
                    case "=":
                        Fraction.AreFractionsEqual(firstFraction, secondFraction);
                        break;
                    case "^":
                        Fraction.ReduceFraction(firstFraction);
                        break;
                    default:
                        resFraction = new Fraction(0, 0);
                        break;
                }

                textResultNum.Text = resFraction.numerator.ToString();
                textResultDenum.Text = resFraction.denumerator.ToString();
            }
            catch (FormatException)
            {

            }
        }

    }
}
