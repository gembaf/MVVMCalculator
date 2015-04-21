using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;

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
        #region プロパティ

        #region IEnumerable<CalculateTypeViewModel> CalculateTypes

        public IEnumerable<CalculateTypeViewModel> CalculateTypes { get; private set; }

        #endregion

        #endregion

        private Action closeAction;

        public SortFunctionDialogViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
            CalculateTypes = CalculateTypeViewModel.Create();
        }
    }
}