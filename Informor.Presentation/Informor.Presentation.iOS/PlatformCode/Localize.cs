using System.Globalization;
using System.Threading;
using Foundation;
using Informor.Presentation.iOS.PlatformCode;
using Informor.Presentation.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]
namespace Informor.Presentation.iOS.PlatformCode
{
    class Localize : ILocalize
    {
        public void SetLocale(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
        private const string DefaultCulture = "en";

        public CultureInfo GetCurrentCultureInfo()
        {
            CultureInfo result = new CultureInfo(DefaultCulture);
            try
            {
                string netLanguage = DefaultCulture;
                if (NSLocale.PreferredLanguages.Length > 0)
                {
                    var pref = NSLocale.PreferredLanguages[0];
                    netLanguage = pref.Replace("_", "-");

                    result = new CultureInfo(netLanguage);
                }
            }
            catch (CultureNotFoundException ex)
            {
                result = new CultureInfo(DefaultCulture);
            }

            return result;
        }
    }
}
