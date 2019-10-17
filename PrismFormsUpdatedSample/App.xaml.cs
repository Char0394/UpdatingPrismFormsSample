using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismFormsUpdatedSample.ViewModels;
using PrismFormsUpdatedSample.Views;

namespace PrismFormsUpdatedSample
{
   [AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<DialogView, DialogViewModel>();
            // containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }
    }
}
