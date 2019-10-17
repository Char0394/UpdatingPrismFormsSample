using System;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismFormsUpdatedSample.ViewModels
{
    public class MainPageViewModel :BindableBase, INavigatedAware, IAutoInitialize
    {
        private string message;

        [AutoInitialize(true)] // Makes Message parameter required
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public void Initialize(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
           
        }


        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
