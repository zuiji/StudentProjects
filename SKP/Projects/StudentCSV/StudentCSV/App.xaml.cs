using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using Microsoft.Win32;
using StudentCSV.Helpers;
using StudentCSV.StaticsAndEnums;
using StudentCSV.Views;

namespace StudentCSV
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";

        private const string RegistryValueName = "AppsUseLightTheme";

        protected override void OnStartup(StartupEventArgs e)
        {
            WatchTheme();
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.AddExtension = true;
            Dialog.OverwritePrompt = false;
            Dialog.Filter = "Encrypted File (*.zbc)|*.ZBC";
            var result = Dialog.ShowDialog();

            if (result == true)
            {
                if (Path.GetExtension(Dialog.FileName).ToLower() != ".zbc")
                {

                }
                Statics.Path = Dialog.FileName;

            }
            else
            {
                Environment.Exit(-1);
            }

            base.OnStartup(e);

        }


        public void WatchTheme()
        {
            var currentUser = WindowsIdentity.GetCurrent();
            string query = string.Format(
                CultureInfo.InvariantCulture,
                @"SELECT * FROM RegistryValueChangeEvent WHERE Hive = 'HKEY_USERS' AND KeyPath = '{0}\\{1}' AND ValueName = '{2}'",
                currentUser.User.Value,
                RegistryKeyPath.Replace(@"\", @"\\"),
                RegistryValueName);
            Statics.WindowsThemeChanged += SetAppTheme;
            try
            {
                var watcher = new ManagementEventWatcher(query);
                watcher.EventArrived += (sender, args) =>
                {

                    // React to new theme
                    SetAppThemeFromWindowsTheme();
                };

                SystemParameters.StaticPropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == nameof(SystemParameters.HighContrast))
                    {
                       SetAppThemeFromWindowsTheme();
                    }
                };

                // Start listening for events
                watcher.Start();
                SetAppThemeFromWindowsTheme();
            }
            catch (Exception)
            {
                // This can fail on Windows 7
            }

        }

        private void SetAppThemeFromWindowsTheme()
        {
            if (SystemParameters.HighContrast)
            {
                Statics.theme = WindowsTheme.HighContrast;
            }

            Statics.theme = GetWindowsTheme();

        }

        private void SetAppTheme()
        {
            switch (Statics.theme)
            {

                case WindowsTheme.Dark:
                    this.Resources.MergedDictionaries[0].Source = new Uri($"/Themes/Dark.xaml", UriKind.Relative);
                    break;
                case WindowsTheme.HighContrast:
                    this.Resources.MergedDictionaries[0].Source = new Uri($"/Themes/HighContrast.xaml", UriKind.Relative);
                    break;
                default:
                    this.Resources.MergedDictionaries[0].Source = new Uri($"/Themes/Light.xaml", UriKind.Relative);
                    break;
            }
        }

        private static WindowsTheme GetWindowsTheme()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
            {
                object registryValueObject = key?.GetValue(RegistryValueName);
                if (registryValueObject == null)
                {
                    return WindowsTheme.Light;
                }

                int registryValue = (int)registryValueObject;

                return registryValue > 0 ? WindowsTheme.Light : WindowsTheme.Dark;
            }

        }
               
    }
}
