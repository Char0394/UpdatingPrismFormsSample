using System;
using System.Diagnostics;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;

namespace PrismFormsUpdatedSample.ViewModels
{
    public class LoginPageViewModel
    {
        public DelegateCommand GoToHomeCommand { get; set; }
        public DelegateCommand ShowDialogCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            GoToHomeCommand = new DelegateCommand(async() =>
            {

                await navigationService.NavigateAsync("MainPage",("Message", "John"));
            });

            ShowDialogCommand = new DelegateCommand(async () =>
            {
                dialogService.ShowDialog("DialogView", CloseDialogCallback);
            });

        }

        void CloseDialogCallback(IDialogResult dialogResult)
        {

        }
    }
}
