using GalaSoft.MvvmLight;
using System;

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
        private Action closeAction;

        /// <summary>
        /// Initializes a new instance of the FunctionDialogViewModel class.
        /// </summary>
        public FunctionDialogViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
        }
    }
}