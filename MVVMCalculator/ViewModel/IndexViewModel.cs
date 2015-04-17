using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMCalculator.Model;
using System;
using System.Collections.Generic;
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
                    RaisePropertyChanged("FunctioinList");
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

        /// <summary>
        /// Initializes a new instance of the IndexViewModel class.
        /// </summary>
        public IndexViewModel()
        {
            FunctionList = FunctionList.Instance;
        }

        #region コマンド

        private ICommand _OpenDialogCommand;
        public ICommand OpenDialogCommand
        {
            get
            {
                if (_OpenDialogCommand == null)
                {
                    _OpenDialogCommand = new RelayCommand(
                        () => Dialog = new FunctionDialogViewModel(() => Dialog = null)
                    );
                }
                return _OpenDialogCommand;
            }
        }

        #endregion
    }
}