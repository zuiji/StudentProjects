using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
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
       
        protected override void OnStartup(StartupEventArgs e)
        {

            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.AddExtension = true;
            Dialog.OverwritePrompt = false;
            Dialog.Filter = "Encrypted File (*.zbc)|*.ZBC";
            var result = Dialog.ShowDialog();

            if (result == true)
            {
                if (Path.GetExtension(Dialog.FileName).ToLower() != ".zbc" )
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
    }
}
