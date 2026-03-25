using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Type.Tests
{
    [TestClass()]
    public class FractionTests
    {

        //[TestMethod()]
        //public void GetGCDTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetLCDTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void ReduceFractionTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void EqualsTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod]
        public void EqualOperatorTest()
        {
            var firstFraction = new Fraction(1, 3);
            var secondFraction = new Fraction(1, 3);

            Assert.AreEqual(firstFraction, secondFraction);
        }

        [TestMethod]
        public void PlusOperatorTest()
        {
            var firstFraction = new Fraction(1, 3);
            var secondFraction = new Fraction(2, 4);

            var result = firstFraction + secondFraction;

            Assert.AreEqual(new Fraction(10, 12), result);
        }

        [TestMethod]
        public void MinusOperatorTest()
        {
            var firstFraction = new Fraction(1, 3);
            var secondFraction = new Fraction(2, 4);

            var result = firstFraction - secondFraction;

            Assert.AreEqual(new Fraction(-2, 12), result);
        }

        [TestMethod]
        public void MultiplyOperatorTest()
        {
            var firstFraction = new Fraction(1, 3);
            var secondFraction = new Fraction(2, 4);

            var result = firstFraction * secondFraction;

            Assert.AreEqual(new Fraction(2, 12), result);
        }

        [TestMethod]
        public void DivideOperatorTest()
        {
            var firstFraction = new Fraction(1, 3);
            var secondFraction = new Fraction(2, 4);

            var result = firstFraction / secondFraction;

            Assert.AreEqual(new Fraction(2, 12), result);
        }
    }
}