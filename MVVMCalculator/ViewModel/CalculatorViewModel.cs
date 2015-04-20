using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMCalculator.Model;
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
    public class CalculatorViewModel : ViewModelBase
    {
        #region プロパティ

        #region double Left

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

        #region double Right

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

        #region double Result

        private double _Result;
        public double Result
        {
            get { return _Result; }
            set
            {
                if (_Result != value)
                {
                    _Result = value;
                    RaisePropertyChanged("Result");
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

        #region コンストラクタ

        public CalculatorViewModel()
        {
            this.CalculateTypes = CalculateTypeViewModel.Create();
            this.SelectedCalculateType = this.CalculateTypes.First();
        }

        #endregion

        #region コマンド

        #region CalculateCommand

        private ICommand _CalculateCommand;
        public ICommand CalculateCommand
        {
            get
            {
                if (_CalculateCommand == null)
                {
                    _CalculateCommand = new RelayCommand(() => 
                        Result = Calculator.Instance.Execute(Left, Right, SelectedCalculateType.CalculateType)
                    );
                }
                return _CalculateCommand;
            }
        }

        #endregion

        #endregion
    }
}