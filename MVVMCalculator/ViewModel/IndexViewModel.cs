using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMCalculator.Model;
using System.Windows.Input;

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
                    RaisePropertyChanged("FunctionList");
                }
            }
        }

        #endregion

        #region Function SelectedFunction

        private Function _SelectedFunction;
        public Function SelectedFunction
        {
            get { return _SelectedFunction; }
            set
            {
                if (_SelectedFunction != value)
                {
                    _SelectedFunction = value;
                    FunctionDetail = new FunctionDetailViewModel(_SelectedFunction, () => RemoveFunctionAction(_SelectedFunction));
                    RaisePropertyChanged("SelectedFunction");
                }
            }
        }

        private void RemoveFunctionAction(Function function)
        {
            FunctionList.Remove(function);
            FunctionDetail = null;
        }

        #endregion

        #region FunctionDialogViewModel FunctionDialog

        private FunctionDialogViewModel _FunctionDialog;
        public FunctionDialogViewModel FunctionDialog
        {
            get { return _FunctionDialog; }
            set
            {
                if (_FunctionDialog != value)
                {
                    _FunctionDialog = value;
                    RaisePropertyChanged("FunctionDialog");
                }
            }
        }

        #endregion

        #region SortFunctionDialogViewModel SortFunctionDialog

        private SortFunctionDialogViewModel _SortFunctionDialog;
        public SortFunctionDialogViewModel SortFunctionDialog
        {
            get { return _SortFunctionDialog; }
            set
            {
                if (_SortFunctionDialog != value)
                {
                    _SortFunctionDialog = value;
                    RaisePropertyChanged("SortFunctionDialog");
                }
            }
        }

        #endregion

        #region FunctionDetailViewModel FunctionDetail

        private FunctionDetailViewModel _FunctionDetail;
        public FunctionDetailViewModel FunctionDetail
        {
            get { return _FunctionDetail; }
            set
            {
                if (_FunctionDetail != value)
                {
                    _FunctionDetail = value;
                    RaisePropertyChanged("FunctionDetail");
                }
            }
        }

        #endregion

        #endregion

        #region コンストラクタ

        public IndexViewModel()
        {
            FunctionList = FunctionList.Instance;
        }

        #endregion
        
        #region コマンド

        #region OpenFunctionDialogCommand

        private ICommand _OpenFunctionDialogCommand;
        public ICommand OpenFunctionDialogCommand
        {
            get
            {
                if (_OpenFunctionDialogCommand == null)
                {
                    _OpenFunctionDialogCommand = new RelayCommand(
                        () => FunctionDialog = new FunctionDialogViewModel(CloseFunctionDialogAction)
                    );
                }
                return _OpenFunctionDialogCommand;
            }
        }

        private void CloseFunctionDialogAction()
        {
            FunctionList.Add(FunctionDialog.FunctionViewModel.Instance);
            FunctionDialog = null;
        }

        #endregion

        #region OpenSortFunctionDialogCommand

        private ICommand _OpenSortFunctionDialogCommand;
        public ICommand OpenSortFunctionDialogCommand
        {
            get
            {
                if (_OpenSortFunctionDialogCommand == null)
                {
                    _OpenSortFunctionDialogCommand = new RelayCommand(
                        () => SortFunctionDialog = new SortFunctionDialogViewModel(() => SortFunctionDialog = null)
                    );
                }
                return _OpenSortFunctionDialogCommand;
            }
        }

        #endregion

        #endregion
    }
}