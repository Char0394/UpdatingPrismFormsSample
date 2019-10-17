using System;
using Prism.Commands;
using Prism.Services.Dialogs;

namespace PrismFormsUpdatedSample.ViewModels
{
    public class DialogViewModel : IDialogAware
    {
        public DelegateCommand CloseCommand { get; }

        public DialogViewModel()
        {
            CloseCommand = new DelegateCommand(() => RequestClose(null));
        }

        public event Action<IDialogParameters> RequestClose;

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }
    }
}
