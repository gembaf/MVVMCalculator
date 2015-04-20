using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FunctionDialogViewModel : ViewModelBase
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

        private Action closeAction;

        #endregion

        #region コンストラクタ

        public FunctionDialogViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
            FunctionViewModel = new FunctionViewModel();
        }

        #endregion

        #region コマンド

        #region CreateFunctionCommand

        private ICommand _CreateFunctionCommand;
        public ICommand CreateFunctionCommand
        {
            get
            {
                if (_CreateFunctionCommand == null)
                {
                    _CreateFunctionCommand = new RelayCommand(() => closeAction());
                }
                return _CreateFunctionCommand;
            }
        }

        #endregion

        #endregion
    }
}