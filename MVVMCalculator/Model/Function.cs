
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
            this.Left = left;
            this.Right = right;
            this.CalculateType = type;
        }

        public Function() { }
        
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
