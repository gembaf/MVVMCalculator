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

        #region FunctionDialogViewModel Dialog

        private FunctionDialogViewModel _Dialog;
        public FunctionDialogViewModel Dialog
        {
            get { return _Dialog; }
            set
            {
                if (_Dialog != value)
                {
                    _Dialog = value;
                    RaisePropertyChanged("Dialog");
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

        #region OpenDialogCommand

        private ICommand _OpenDialogCommand;
        public ICommand OpenDialogCommand
        {
            get
            {
                if (_OpenDialogCommand == null)
                {
                    _OpenDialogCommand = new RelayCommand(
                        () => Dialog = new FunctionDialogViewModel(CloseDialogAction)
                    );
                }
                return _OpenDialogCommand;
            }
        }

        private void CloseDialogAction()
        {
            FunctionList.Add(new Function(Dialog.Left, Dialog.Right, Dialog.SelectedCalculateType.CalculateType));
            Dialog = null;
        }

        #endregion

        #endregion
    }
}