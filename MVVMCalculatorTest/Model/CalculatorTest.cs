using System;
using NUnit.Framework;
using MVVMCalculator.Model;

namespace MVVMCalculatorTest.Model
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(4, 2, Result = 2)]
        [TestCase(3, 2, Result = 1.5)]
        [TestCase(4, 0, Result = 0)]
        public double ExecuteTest割り算(double left, double right)
        {
            Calculator calc = Calculator.Instance;
            return calc.Execute(left, right, Calculator.Type.Div);
        }
    }
}
