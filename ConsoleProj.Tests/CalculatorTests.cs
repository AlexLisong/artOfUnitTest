using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProj.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Sum_NoAddCalls_DefaultToZero()
        {
           
            int lastSum = calc.Sum();

            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_CalledOnce_SaveNumbersForSum()
        {
            calc.Add(1);
            int lastSum = calc.Sum();
            Assert.AreEqual(1, lastSum);
        }
    }
}
