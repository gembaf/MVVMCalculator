
namespace MVVMCalculator.Model
{
    public class Function
    {
        #region プロパティ

        #region double Left

        public double Left { get; set; }

        #endregion

        #region double Right

        public double Right { get; set; }

        #endregion

        #region Calculator.Type CalculateType

        public Calculator.Type CalculateType { get; set; }

        #endregion

        #endregion

        #region コンストラクタ

        public Function(double left, double right, Calculator.Type type)
        {
            Left = left;
            Right = right;
            CalculateType = type;
        }

        public Function() {
            Left = 0;
            Right = 0;
            CalculateType = Calculator.Type.None;
        }
        
        #endregion

        #region public method

        public double Calculate()
        {
            Calculator calc = Calculator.Instance;
            return calc.Execute(Left, Right, CalculateType);
        }

        #endregion
    }
}
