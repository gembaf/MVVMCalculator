/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MVVMCalculator.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MVVMCalculator.Model;

namespace MVVMCalculator.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CalculatorViewModel>();
            SimpleIoc.Default.Register<IndexViewModel>();
            SimpleIoc.Default.Register<FunctionDialogViewModel>();
        }

        #region MainViewModel Main

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        #endregion

        #region CalculatorViewModel CalculatorViewModel

        public CalculatorViewModel CalculatorViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CalculatorViewModel>();
            }
        }

        #endregion

        #region IndexViewModel IndexViewModel

        public IndexViewModel IndexViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IndexViewModel>();
            }
        }

        #endregion

        #region FunctionDialogViewModel FunctionDialogViewModel

        public FunctionDialogViewModel FunctionDialogViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FunctionDialogViewModel>();
            }
        }

        #endregion

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}