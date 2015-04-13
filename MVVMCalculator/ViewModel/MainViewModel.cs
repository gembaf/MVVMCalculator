using GalaSoft.MvvmLight;
using MVVMCalculator.Model;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region プロパティ

        #region ViewModelBase CurrentPage

        private ViewModelBase _CurrentPage;
        public ViewModelBase CurrentPage
        {
            get { return this._CurrentPage; }
            set
            {
                if (this._CurrentPage != value)
                {
                    this._CurrentPage = value;
                    RaisePropertyChanged("CurrentPage");
                }
            }
        }

        #endregion

        #region CalculatorViewModel CalculatorPage

        private CalculatorViewModel _CalculatorPage;
        public CalculatorViewModel CalculatorPage
        {
            get { return this._CalculatorPage; }
            set
            {
                if (this._CalculatorPage != value)
                {
                    this._CalculatorPage = value;
                    RaisePropertyChanged("CalculatorPage");
                }
            }
        }

        #endregion

        #endregion

        public MainViewModel()
        {
            CalculatorPage = new CalculatorViewModel();
            CurrentPage = CalculatorPage;
        }
    }
}