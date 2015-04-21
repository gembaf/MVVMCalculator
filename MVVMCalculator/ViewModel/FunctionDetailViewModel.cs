using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMCalculator.Model;
using System;
using System.Windows.Input;

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

        #region private variable

        private Action removeFunctionAction;

    	#endregion

        #region コンストラクタ

        public FunctionDetailViewModel(Function function, Action removeFunctionAction)
        {
            FunctionViewModel = new FunctionViewModel(function);
            this.removeFunctionAction = removeFunctionAction;
        }

        #endregion

        #region コマンド

        #region RemoveFunctionCommand

        private ICommand _RemoveFunctionCommand;
        public ICommand RemoveFunctionCommand
        {
            get
            {
                if (_RemoveFunctionCommand == null)
                {
                    _RemoveFunctionCommand = new RelayCommand(removeFunctionAction);
                }
                return _RemoveFunctionCommand;
            }
        }

        #endregion

        #endregion
    }
}