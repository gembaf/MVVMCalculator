using System;
using NUnit.Framework;
using MVVMCalculator.Model;

namespace MVVMCalculatorTest.Model
{
    [TestFixture]
    public class FunctionTest
    {
        [TestCase(3, 5, Calculator.Type.Add, Result = 8)]
        [TestCase(2, 4, Calculator.Type.Mul, Result = 8)]
        public double CalculateTest(double left, double right, Calculator.Type type)
        {
            Function func = new Function(left, right, type);
            return func.Calculate();
        }
    }
}
