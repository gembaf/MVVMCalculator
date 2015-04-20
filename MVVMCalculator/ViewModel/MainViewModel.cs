using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

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
            get { return _CurrentPage; }
            set
            {
                if (_CurrentPage != value)
                {
                    _CurrentPage = value;
                    RaisePropertyChanged("CurrentPage");
                }
            }
        }

        #endregion

        #region CalculatorViewModel CalculatorPage

        private CalculatorViewModel _CalculatorPage;
        public CalculatorViewModel CalculatorPage
        {
            get { return _CalculatorPage; }
            set
            {
                if (_CalculatorPage != value)
                {
                    _CalculatorPage = value;
                    RaisePropertyChanged("CalculatorPage");
                }
            }
        }

        #endregion

        #region IndexViewModel IndexPage

        private IndexViewModel _IndexPage;
        public IndexViewModel IndexPage
        {
            get { return _IndexPage; }
            set
            {
                if (_IndexPage != value)
                {
                    _IndexPage = value;
                    RaisePropertyChanged("IndexPage");
                }
            }
        }

        #endregion

        #endregion

        #region コンストラクタ

        public MainViewModel()
        {
            CalculatorPage = new CalculatorViewModel();
            IndexPage = new IndexViewModel();
            CurrentPage = CalculatorPage;
        }
        
        #endregion
    }
}