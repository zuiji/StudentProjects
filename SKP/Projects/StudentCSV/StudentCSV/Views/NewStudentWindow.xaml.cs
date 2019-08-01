using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentCSV
{
    /// <summary>
    /// Interaction logic for NewStudentWindow.xaml
    /// </summary>
    public partial class NewStudentWindow : Window
    {
        public NewStudentWindow()
        {
            InitializeComponent();
        }

        private void GB_Button_Click(object sender, RoutedEventArgs e)
        {
            StudentCSV.Language.ChangeCulture(new CultureInfo("en"));

            (FindResource("Resources") as ObjectDataProvider).Refresh();

        }

        private void DK_Button_Click(object sender, RoutedEventArgs e)
        {
            StudentCSV.Language.ChangeCulture(new CultureInfo("da"));

            (FindResource("Resources") as ObjectDataProvider).Refresh();

        }
    }
}
