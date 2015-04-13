﻿using GalaSoft.MvvmLight;
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

        #region Left

        private double _Left;
        public double Left
        {
            get { return this._Left; }
            set
            {
                if (this._Left != value)
                {
                    this._Left = value;
                    RaisePropertyChanged("Left");
                }
            }
        }

        #endregion

        #region Right

        private double _Right;
        public double Right
        {
            get { return this._Right; }
            set
            {
                if (this._Right != value)
                {
                    this._Right = value;
                    RaisePropertyChanged("Right");
                }
            }
        }

        #endregion

        #region Result

        private double _Result;
        public double Result
        {
            get { return this._Result; }
            set
            {
                if (this._Result != value)
                {
                    this._Result = value;
                    RaisePropertyChanged("Result");
                }
            }
        }

        #endregion

        #region CalculateTypes

        public IEnumerable<CalculateTypeViewModel> CalculateTypes { get; private set; }

        #endregion

        #region SelectedCalculateType

        private CalculateTypeViewModel _SelectedCalculateType;
        public CalculateTypeViewModel SelectedCalculateType
        {
            get { return this._SelectedCalculateType; }
            set
            {
                this._SelectedCalculateType = value;
                RaisePropertyChanged("SelectedCalculateType");
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// Initializes a new instance of the CalculatorViewModel class.
        /// </summary>
        public CalculatorViewModel()
        {
            this.CalculateTypes = CalculateTypeViewModel.Create();
            this.SelectedCalculateType = this.CalculateTypes.First();
        }

        #region コマンド

        #region CalculateCommand

        private ICommand _CalculateCommand;
        public ICommand CalculateCommand
        {
            get
            {
                if (_CalculateCommand == null)
                {
                    _CalculateCommand = new RelayCommand(Calculate);
                }
                return this._CalculateCommand;
            }
        }

        #endregion

        #endregion

        private void Calculate()
        {
            Result = Calculator.Instance.Execute(this.Left, this.Right, this.SelectedCalculateType.CalculateType);
        }
    }
}