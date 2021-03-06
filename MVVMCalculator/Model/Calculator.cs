﻿
namespace MVVMCalculator.Model
{
    public class Calculator
    {
        #region enum Type

        public enum Type
        {
            None,
            Add,
            Sub,
            Mul,
            Div
        }

        #endregion

        #region public static method

        private static Calculator instance = new Calculator();
        public static Calculator Instance
        {
            get { return instance; }
        }

        #endregion

        #region コンストラクタ Singleton

        private Calculator() { }

        #endregion

        #region public method

        public double Execute(double left, double right, Type type)
        {
            double result = 0;

            switch (type)
            {
                case Type.Add:
                    result = left + right;
                    break;
                case Type.Sub:
                    result = left - right;
                    break;
                case Type.Mul:
                    result = left * right;
                    break;
                case Type.Div:
                    result = (right == 0) ? 0 : left / right;
                    break;
            }

            return result;
        }

        #endregion
    }
}
