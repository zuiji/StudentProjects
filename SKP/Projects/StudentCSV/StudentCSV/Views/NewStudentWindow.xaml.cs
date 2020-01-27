using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using StudentCSV.StaticsAndEnums;
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
            //((NewStudentWindowViewModel)CprBox.DataContext).PropertyChanged += OnPropertyChanged;
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

        //private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        //{
        //    if (((PasswordBox)sender).DataContext != null)
        //    {
        //        ((NewStudentWindowViewModel)((PasswordBox)sender).DataContext).CprNr = ((PasswordBox)sender).Password;
        //    }
        //}

        //private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    var correctSender = (NewStudentWindowViewModel)sender;
        //    if (e.PropertyName == nameof(correctSender.CprNr))
        //    {
        //        if (CprBox.Password == correctSender.CprNr)
        //        {
        //            return;
        //        }

        //        CprBox.Password = correctSender.CprNr;
        //    }
        //}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CorrectSender = (ComboBox)sender;
            if (CorrectSender.SelectedIndex == 0)
            {
                Grid.SetRow(SpecialInfolabel, 2);
                Grid.SetRow(SpecialInfoTextBox, 2);
                Grid.SetRowSpan(SpecialInfoTextBox, 1);
                Grid.SetColumnSpan(SpecialInfolabel, 3);
                Grid.SetColumnSpan(SpecialInfoTextBox, 3);
      

                OtherLabel.Visibility = Visibility.Visible;
                OtherTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                Grid.SetRow(SpecialInfolabel, 0);
                Grid.SetRow(SpecialInfoTextBox, 0);
                Grid.SetColumnSpan(SpecialInfolabel, 3);
                Grid.SetColumnSpan(SpecialInfoTextBox, 3);


                OtherLabel.Visibility = Visibility.Collapsed;
                OtherTextBox.Visibility = Visibility.Collapsed;
            }
        }
        private void ShowPassword_PreviewMouseDown(object sender, MouseButtonEventArgs e) => ShowPasswordFunction();
        private void ShowPassword_PreviewMouseUp(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
        private void ShowPassword_MouseLeave(object sender, MouseEventArgs e) => HidePasswordFunction();

        private void ShowPasswordFunction()
        {
            ShowPassword.Text = "🔒";
            PasswordUnmask.Visibility = Visibility.Visible;
            PasswordHidden.Visibility = Visibility.Hidden;
            PasswordUnmask.Text = PasswordHidden.Password;
        }

        private void HidePasswordFunction()
        {
            ShowPassword.Text = "👁️";
            PasswordUnmask.Visibility = Visibility.Hidden;
            PasswordHidden.Visibility = Visibility.Visible;
        }
    }
}
