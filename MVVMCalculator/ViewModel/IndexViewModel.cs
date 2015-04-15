using GalaSoft.MvvmLight;
using MVVMCalculator.Model;
using System.Collections.Generic;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class IndexViewModel : ViewModelBase
    {
        private List<Function> _FunctionList;
        public List<Function> FunctionList
        {
            get { return _FunctionList; }
            set
            {
                if (_FunctionList != value)
                {
                    _FunctionList = value;
                    RaisePropertyChanged("FunctioinList");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the IndexViewModel class.
        /// </summary>
        public IndexViewModel()
        {
            FunctionList = new List<Function>
            {
                new Function(1, 2, Calculator.Type.Add),
                new Function(10, 2, Calculator.Type.Sub),
                new Function(3, 2, Calculator.Type.Mul),
                new Function(6, 2, Calculator.Type.Div)
            };
        }
    }
}