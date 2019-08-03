using System.Diagnostics;
using System.Globalization;

namespace StudentEmmaRegistrationForm
{
    public class Language
    {
        public static Properties.Resources GetResourceInstance()
        {
            //  ChangeCulture(new CultureInfo("da"));
            return new Properties.Resources();
        }
        public static void ChangeCulture(CultureInfo culture)
        {
            //remain on the current culture if the desired culture cannot be found
            // - otherwise it would revert to the default resources set,
            //   which may or may not be desired.
            // if (pSupportedCultures.Contains(culture))
            // {
            Properties.Resources.Culture = culture;
            //                ResourceProvider.Refresh();
            //}
            // else
            Debug.WriteLine("Culture [{0}] not available", culture);
        }
    }
}