using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IdealWeightCalculator;

namespace IdealWeightCalculatorTest
{
    [TestClass]
    public class WeightCalculatorTest
    {
        [TestMethod]
        public void GetIdealWeight_Height_176_Gender_w_return__63()
        {
            //Arange
            WeightCalculator Sut = new WeightCalculator
            {
                Height = 176,
                Gender = 'w'
            };
            //Act
            double actual = Sut.GetIdealWeight();
            double expected = 63;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetIdealWeight_Height_170_Gender_m_return__65()
        {
            //Arange
            WeightCalculator Sut = new WeightCalculator
            {
                Height = 170,
                Gender = 'm'
            };
            //Act
            double actual = Sut.GetIdealWeight();
            double expected = 65;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
