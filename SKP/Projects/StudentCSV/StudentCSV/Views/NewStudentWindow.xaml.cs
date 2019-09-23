using System;
using System.ComponentModel;
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
            ((NewStudentWindowViewModel)CprBox.DataContext).PropertyChanged += OnPropertyChanged;


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

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var correctSender = (NewStudentWindowViewModel)sender;
            if (e.PropertyName == nameof(correctSender.CprNr))
            {
                if (CprBox.Password == correctSender.CprNr)
                {
                    return;
                }

                CprBox.Password = correctSender.CprNr;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CorrectSender = (ComboBox)sender;
            if (CorrectSender.SelectedIndex == 0)
            {
                Grid.SetColumnSpan(SpecialInfolabel, 1);
                Grid.SetColumnSpan(SpecialInfoTextBox, 1);
      

                OtherLabel.Visibility = Visibility.Visible;
                OtherTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                Grid.SetColumnSpan(SpecialInfolabel, 3);
                Grid.SetColumnSpan(SpecialInfoTextBox, 3);


                OtherLabel.Visibility = Visibility.Collapsed;
                OtherTextBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
