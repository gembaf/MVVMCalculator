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
        public double CalculateTest(double a, double b, Calculator.Type type)
        {
            Function func = new Function {
                Right = a,
                Left = b,
                CalculateType = type
            };
            return func.Calculate();
        }
    }
}
