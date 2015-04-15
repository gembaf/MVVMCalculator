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
        #region プロパティ

        #region FunctionList FunctionList

        private FunctionList _FunctionList;
        public FunctionList FunctionList
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

        #endregion

        #endregion

        /// <summary>
        /// Initializes a new instance of the IndexViewModel class.
        /// </summary>
        public IndexViewModel()
        {
            FunctionList = FunctionList.Instance;
        }
    }
}