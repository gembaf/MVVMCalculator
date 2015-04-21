using GalaSoft.MvvmLight;
using MVVMCalculator.Model;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FunctionDetailViewModel : ViewModelBase
    {
        #region プロパティ

        #region FunctionViewModel FunctionViewModel

        private FunctionViewModel _FunctionViewModel;
        public FunctionViewModel FunctionViewModel
        {
            get { return _FunctionViewModel; }
            set
            {
                if (_FunctionViewModel != value)
                {
                    _FunctionViewModel = value;
                    RaisePropertyChanged("FunctionViewModel");
                }
            }
        }

        #endregion

        #endregion

        public FunctionDetailViewModel(Function function)
        {
            FunctionViewModel = new FunctionViewModel(function);
        }
    }
}