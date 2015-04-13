using GalaSoft.MvvmLight;
using MVVMCalculator.Model;
using System;
using System.Collections.Generic;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class CalculateTypeViewModel : ViewModelBase
    {
        private static Dictionary<Calculator.Type, string> calculateTypeName = new Dictionary<Calculator.Type, string>
        {
            {Calculator.Type.None, "未選択"},
            {Calculator.Type.Add, "足し算"},
            {Calculator.Type.Sub, "引き算"},
            {Calculator.Type.Mul, "掛け算"},
            {Calculator.Type.Div, "割り算"}
        };

        public Calculator.Type CalculateType { get; private set; }

        public string Label { get; private set; }

        /// <summary>
        /// Initializes a new instance of the CalculateTypeViewModel class.
        /// </summary>
        public CalculateTypeViewModel(Calculator.Type type, string label)
        {
            this.CalculateType = type;
            this.Label = label;
        }

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
    }
}