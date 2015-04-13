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
            return new CalculateTypeViewModel(type, type.ToString());
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