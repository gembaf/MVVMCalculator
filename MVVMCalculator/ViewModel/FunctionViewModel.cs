using GalaSoft.MvvmLight;
using MVVMCalculator.Model;
using System.Collections.Generic;
using System.Linq;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FunctionViewModel : ViewModelBase
    {
        #region プロパティ

        #region double Left

        public double Left
        {
            get { return function.Left; }
            set
            {
                if (function.Left != value)
                {
                    function.Left = value;
                    RaisePropertyChanged("Left");
                }
            }
        }

        #endregion

        #region double Right

        public double Right
        {
            get { return function.Right; }
            set
            {
                if (function.Right != value)
                {
                    function.Right = value;
                    RaisePropertyChanged("Right");
                }
            }
        }

        #endregion

        #region double Result

        public double Result
        {
            get { return function.Calculate(); }
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
                function.CalculateType = _SelectedCalculateType.CalculateType;
                RaisePropertyChanged("SelectedCalculateType");
            }
        }

        #endregion

        #region Function Instance

        public Function Instance
        {
            get { return function; }
        }

        #endregion

        #endregion

        #region private variable

        private Function function;

        #endregion

        #region コンストラクタ

        public FunctionViewModel()
        {
            function = new Function();
            SetProperty();
        }

        public FunctionViewModel(Function function)
        {
            this.function = function;
            SetProperty();
        }

        #endregion

        #region private method

        private void SetProperty()
        {
            CalculateTypes = CalculateTypeViewModel.Create();
            SelectedCalculateType = CalculateTypes.First();
        }

        #endregion
    }
}