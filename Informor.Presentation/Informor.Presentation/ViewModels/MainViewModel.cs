using Xamarin.Forms;

namespace Informor.Presentation.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _mainText;

        public MainViewModel(INavigation navigation) : base(navigation)
        {
            MainText = "Test!@#";
        }

        public string MainText
        {
            get { return _mainText; }
            set { SetProperty(ref _mainText, value); }
        }
    }
}
