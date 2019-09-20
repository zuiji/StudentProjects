using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using StudentCSV.ViewModel;

namespace StudentCSV.Views
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
            StaticsAndEnums.Language.ChangeCulture(new CultureInfo("en"));

            (FindResource("Resources") as ObjectDataProvider).Refresh();

        }

        private void DK_Button_Click(object sender, RoutedEventArgs e)
        {
            StaticsAndEnums.Language.ChangeCulture(new CultureInfo("da"));

            (FindResource("Resources") as ObjectDataProvider).Refresh();

        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).DataContext != null)
            {
                ((NewStudentWindowViewModel)((PasswordBox)sender).DataContext).CprNr = ((PasswordBox)sender).Password;
            }
        }
    }
}
