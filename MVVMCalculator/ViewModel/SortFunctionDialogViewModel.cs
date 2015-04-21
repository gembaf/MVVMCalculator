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
    public class SortFunctionDialogViewModel : ViewModelBase
    {
        private Action closeAction;

        public SortFunctionDialogViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
        }
    }
}