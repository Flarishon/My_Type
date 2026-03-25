using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Type
{
    public class Fraction
    {
        public int numerator;
        public int denumerator;

        public Fraction(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public static int GetGCD(int firstNum, int secondNum)
        {
            while (secondNum != 0)
            {
                int tempNum = secondNum;
                secondNum = firstNum % secondNum;
                firstNum = tempNum;
            }
            return Math.Abs(firstNum);
        }
        public static int GetLCD(int firstNum, int secondNum)
        {
            return Math.Abs(firstNum * secondNum) / GetGCD(firstNum, secondNum);
        }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            int firstNum = firstFraction.numerator;
            int firstDenum = firstFraction.denumerator;
            int secondNum = secondFraction.numerator;
            int secondDenum = secondFraction.denumerator;

            if (firstDenum == secondDenum)
            {
                return new Fraction(firstNum + secondNum, firstDenum);
            }

            int commonDen = GetLCD(firstDenum, secondDenum);

            int newFirstNum = firstNum * (commonDen / firstDenum);
            int newSecondNum = secondNum * (commonDen / secondDenum);

            return new Fraction(newFirstNum + newSecondNum, commonDen);
        }

        public static Fraction operator -(Fraction firstFraction, Fraction secondFraction)
        {
            int firstNum = firstFraction.numerator;
            int firstDenum = firstFraction.denumerator;
            int secondNum = secondFraction.numerator;
            int secondDenum = secondFraction.denumerator;

            if (firstDenum == secondDenum)
            {
                return new Fraction(firstNum - secondNum, firstDenum);
            }

            int commonDen = GetLCD(firstDenum, secondDenum);

            int newFirstNum = firstNum * (commonDen / firstDenum);
            int newSecondNum = secondNum * (commonDen / secondDenum);

            return new Fraction(newFirstNum - newSecondNum, commonDen);
        }

        public static Fraction operator *(Fraction firstFraction, Fraction secondFraction)
        {
            int resNum = firstFraction.numerator * secondFraction.numerator;
            int resDenum = firstFraction.denumerator * secondFraction.denumerator;
            var resFraction = new Fraction(resNum, resDenum);
            return resFraction;
        }

        public static Fraction operator /(Fraction firstFraction, Fraction secondFraction)
        {
            int temp = secondFraction.numerator;
            secondFraction.numerator = secondFraction.denumerator;
            secondFraction.denumerator = temp;
            int resNum = firstFraction.numerator * secondFraction.numerator;
            int resDenum = firstFraction.denumerator * secondFraction.denumerator;
            var resFraction = new Fraction(resNum, resDenum);
            return resFraction;
        }

        public static bool operator >(Fraction firstFraction, Fraction secondFraction)
        {
            int lcd = GetLCD(firstFraction.denumerator, secondFraction.denumerator);

            int firstNum = firstFraction.numerator * (lcd / firstFraction.denumerator);
            int secondNum = secondFraction.numerator * (lcd / secondFraction.denumerator);

            if (firstNum > secondNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Fraction firstFraction, Fraction secondFraction)
        {
            int lcd = GetLCD(firstFraction.denumerator, secondFraction.denumerator);

            int firstNum = firstFraction.numerator * (lcd / firstFraction.denumerator);
            int secondNum = secondFraction.numerator * (lcd / secondFraction.denumerator);

            if (firstNum < secondNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Fraction firstFraction, Fraction secondFraction)
        {
            int lcd = GetLCD(firstFraction.denumerator, secondFraction.denumerator);

            int firstNum = firstFraction.numerator * (lcd / firstFraction.denumerator);
            int secondNum = secondFraction.numerator * (lcd / secondFraction.denumerator);

            if (firstNum == secondNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction firstFraction, Fraction secondFraction)
        {
            return !(firstFraction == secondFraction);
        }

        public static Fraction ReduceFraction(Fraction fraction)
        {
            int gcd = GetGCD(fraction.numerator, fraction.denumerator);
            return new Fraction(fraction.numerator / gcd, fraction.denumerator / gcd);
        }

        public override bool Equals(object? obj)
        {
            return (Fraction)obj == this;
        }

        public override string ToString()
        {
            return $"numerator - {numerator}, denumerator - {denumerator}";
        }
    }
}
