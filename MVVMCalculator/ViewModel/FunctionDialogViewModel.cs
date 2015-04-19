using GalaSoft.MvvmLight;
using System;
using System.Linq;
using System.Collections.Generic;

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

        #region Left

        private double _Left;
        public double Left
        {
            get { return _Left; }
            set
            {
                if (_Left != value)
                {
                    _Left = value;
                    RaisePropertyChanged("Left");
                }
            }
        }

        #endregion

        #region Right

        private double _Right;
        public double Right
        {
            get { return _Right; }
            set
            {
                if (_Right != value)
                {
                    _Right = value;
                    RaisePropertyChanged("Right");
                }
            }
        }

        #endregion

        #region IEnumerable<CalculateTypeViewModel> CalculateTypes

        public IEnumerable<CalculateTypeViewModel> CalculateTypes { get; private set; }

        #endregion

        #region CalculateTypeViewModel SelectedCalculateType

        private CalculateTypeViewModel _SelectedCalculateType;
        public CalculateTypeViewModel SelectedCalculateType
        {
            get { return _SelectedCalculateType; }
            set
            {
                _SelectedCalculateType = value;
                RaisePropertyChanged("SelectedCalculateType");
            }
        }

        #endregion

        #endregion

        private Action closeAction;

        /// <summary>
        /// Initializes a new instance of the FunctionDialogViewModel class.
        /// </summary>
        public FunctionDialogViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
            CalculateTypes = CalculateTypeViewModel.Create();
            SelectedCalculateType = CalculateTypes.First();
        }
    }
}