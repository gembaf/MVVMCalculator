using GalaSoft.MvvmLight;
using MVVMCalculator.Model;
using System;
using System.Collections.Generic;

namespace MVVMCalculator.ViewModel
{
    public class CalculateTypeViewModel : ViewModelBase
    {
        #region private static variable

        private static Dictionary<Calculator.Type, string> calculateTypeName = new Dictionary<Calculator.Type, string>
        {
            {Calculator.Type.None, "未選択"},
            {Calculator.Type.Add, "足し算"},
            {Calculator.Type.Sub, "引き算"},
            {Calculator.Type.Mul, "掛け算"},
            {Calculator.Type.Div, "割り算"}
        };

        #endregion

        #region public static method

        public static CalculateTypeViewModel Create(Calculator.Type type)
        {
            return new CalculateTypeViewModel(type, calculateTypeName[type]);
        }

        public static IEnumerable<CalculateTypeViewModel> Create()
        {
            foreach (Calculator.Type e in Enum.GetValues(typeof(Calculator.Type)))
            {
                yield return Create(e);
            }
        }

        #endregion

        #region プロパティ

        #region Calculator.Type CalculateType

        public Calculator.Type CalculateType { get; private set; }

        #endregion

        #region string Label

        public string Label { get; private set; }

        #endregion

        #endregion

        #region コンストラクタ

        public CalculateTypeViewModel(Calculator.Type type, string label)
        {
            this.CalculateType = type;
            this.Label = label;
        }

        #endregion
    }
}