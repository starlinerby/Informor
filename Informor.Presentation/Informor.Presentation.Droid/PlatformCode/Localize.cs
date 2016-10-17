using System.Globalization;
using System.Threading;
using Informor.Presentation.Droid.PlatformCode;
using Informor.Presentation.Interfaces;
using Java.Util;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]

namespace Informor.Presentation.Droid.PlatformCode
{
    public class Localize : ILocalize
    {
        public void SetLocale(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
        public CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-");
            return CultureInfo.CurrentCulture;
        }
    }
}