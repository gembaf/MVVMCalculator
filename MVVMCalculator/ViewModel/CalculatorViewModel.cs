using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class CalculatorViewModel : ViewModelBase
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

        #region double Result

        private double _Result;
        public double Result
        {
            get { return _Result; }
            set
            {
                if (_Result != value)
                {
                    _Result = value;
                    RaisePropertyChanged("Result");
                }
            }
        }

        #endregion

        #endregion

        #region コンストラクタ

        public CalculatorViewModel() {
            FunctionViewModel = new FunctionViewModel();
        }

        #endregion

        #region コマンド

        #region CalculateCommand

        private ICommand _CalculateCommand;
        public ICommand CalculateCommand
        {
            get
            {
                if (_CalculateCommand == null)
                {
                    _CalculateCommand = new RelayCommand(() => 
                        Result = FunctionViewModel.Result
                    );
                }
                return _CalculateCommand;
            }
        }

        #endregion

        #endregion
    }
}