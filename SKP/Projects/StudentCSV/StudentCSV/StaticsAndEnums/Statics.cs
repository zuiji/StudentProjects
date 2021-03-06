﻿using System;
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
            Properties.Resources.Other,"Køge", "Nykøbing F.", "Ringsted", "Roskilde", "Slagelse", "Vordingborg"

        };

        private static WindowsTheme _theme;
        public static string Path { get; set; }
        public static string Password { get; set; }

        public static WindowsTheme theme
        {
            get => _theme;
            set
            {
                _theme = value;
                WindowsThemeChanged?.Invoke();
            }
        }

        public static event Action WindowsThemeChanged;


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