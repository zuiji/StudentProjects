using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace StudentCSV
{
    public static class Statics
    {
        public static readonly List<string> CorrectEducationDirectionEnumNames = new List<string>()
        {
            "IT-Supporter", "Datatekniker med speciale i programmering", "Datatekniker med speciale i infrastruktur"
        };

        public static readonly List<string> CorrectGfSchoolEnumNames = new List<string>()
        {
            "Køge", "Nykøbing F.", "Ringsted", "Roskilde", "Slagelse", "Vordingborg"

        };

    }

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