using System.Collections.Generic;

namespace MVVMCalculator.Model
{
    public class FunctionList
    {
        public List<Function> Collections { get; private set; }

        #region static FunctionList Instance

        private static FunctionList instance = new FunctionList();
        public static FunctionList Instance
        {
            get { return instance; }
        }

        #endregion

        #region コンストラクタ Singleton

        private FunctionList() {
            Load();
        }

        #endregion

        private void Load()
        {
            Collections = new List<Function>
            {
                new Function(8, 2, Calculator.Type.Add),
                new Function(8, 2, Calculator.Type.Sub),
                new Function(8, 2, Calculator.Type.Mul),
                new Function(8, 2, Calculator.Type.Add),
                new Function(8, 2, Calculator.Type.Sub),
                new Function(8, 2, Calculator.Type.Mul),
                new Function(8, 2, Calculator.Type.Div)
            };
        }
    }
}
