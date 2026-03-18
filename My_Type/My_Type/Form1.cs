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
            try
            {
                var firstNum = int.Parse(textFirstNum.Text);
                var firstDenum = int.Parse(textFirstDenum.Text);
                var secondNum = int.Parse(textSecondNum.Text);
                var secondDenum = int.Parse(textSecondDenum.Text);

                var firstFraction = new Fraction(firstNum, firstDenum);
                var secondFraction = new Fraction(secondNum, secondDenum);
            }
            catch (FormatException)
            {

            }
        }

        private void textFirstDenum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var firstNum = int.Parse(textFirstNum.Text);
                var firstDenum = int.Parse(textFirstDenum.Text);
                var secondNum = int.Parse(textSecondNum.Text);
                var secondDenum = int.Parse(textSecondDenum.Text);

                var firstFraction = new Fraction(firstNum, firstDenum);
                var secondFraction = new Fraction(secondNum, secondDenum);
            }
            catch (FormatException)
            {

            }
        }

        private void textSecondNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var firstNum = int.Parse(textFirstNum.Text);
                var firstDenum = int.Parse(textFirstDenum.Text);
                var secondNum = int.Parse(textSecondNum.Text);
                var secondDenum = int.Parse(textSecondDenum.Text);

                var firstFraction = new Fraction(firstNum, firstDenum);
                var secondFraction = new Fraction(secondNum, secondDenum);
            }
            catch (FormatException)
            {

            }
        }

        private void textSecondDenum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var firstNum = int.Parse(textFirstNum.Text);
                var firstDenum = int.Parse(textFirstDenum.Text);
                var secondNum = int.Parse(textSecondNum.Text);
                var secondDenum = int.Parse(textSecondDenum.Text);

                var firstFraction = new Fraction(firstNum, firstDenum);
                var secondFraction = new Fraction(secondNum, secondDenum);
            }
            catch (FormatException)
            {

            }
        }
    }
}
