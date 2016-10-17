using Informor.Presentation.ViewModels;
using Informor.Presentation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;

namespace Informor.Presentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var container = new SimpleContainer();

            var mainView = new MainView();
            MainPage = new NavigationPage(mainView);
            var mainViewModel = new MainViewModel(MainPage.Navigation);
            container.Register<MainViewModel>(mainViewModel);

            mainView.BindingContext = mainViewModel;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
