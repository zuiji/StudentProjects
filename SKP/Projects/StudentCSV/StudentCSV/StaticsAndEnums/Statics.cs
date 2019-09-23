using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace StudentCSV.StaticsAndEnums
{
    public static class Statics
    {
        public static readonly List<string> CorrectEducationDirectionEnumNames = new List<string>()
        {
            "IT-Supporter", "Datatekniker med speciale i programmering", "Datatekniker med speciale i infrastruktur"
        };

        public static readonly List<string> CorrectGfSchoolEnumNames = new List<string>()
        {
            "Anden","Køge", "Nykøbing F.", "Ringsted", "Roskilde", "Slagelse", "Vordingborg"

        };
        public static string Path { get; set; }
        public static string Password {get; set;}

    }
    public class BooleanToVisibilityConverter : MarkupExtension, IValueConverter
    {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            if (targetType == typeof(Visibility))
            {
                var visible = System.Convert.ToBoolean(value, culture);
                if (InvertVisibility)
                    visible = !visible;
                return visible ? Visibility.Visible : Visibility.Collapsed;
            }
            throw new InvalidOperationException("Converter can only convert to value of type Visibility.");
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("Converter cannot convert back.");
        }

        public Boolean InvertVisibility { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }

}