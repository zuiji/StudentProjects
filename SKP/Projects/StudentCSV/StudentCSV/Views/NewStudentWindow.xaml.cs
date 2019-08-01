using System.Globalization;
using System.Windows;
using System.Windows.Data;

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
    }
}
