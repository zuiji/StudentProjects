using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using StudentCSV.Helpers;
using StudentCSV.Properties;
using StudentCSV.StaticsAndEnums;
using StudentCSV.StudentValidater;

namespace StudentCSV.ViewModel
{
    public class ButtonPressed
    {
        private NewStudentWindowViewModel _newStudentWindowViewModel;

        public ButtonPressed(NewStudentWindowViewModel newStudentWindowViewModel)
        {
            _newStudentWindowViewModel = newStudentWindowViewModel;
        }
        #region OnPropertyChangedRegion
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
      
        #region OnCancelPressedRegion
        public void OnCancelPressed()
        {
            var confirmation = MessageBox.Show(Properties.Resources.MessageBoxConfirmCanceled, Properties.Resources.MessageBoxConfirmCancel, MessageBoxButton.YesNo);
            if (confirmation == MessageBoxResult.Yes)
            {
                _newStudentWindowViewModel.FreshGui();
            }
        }
        #endregion

        #region OnSavePressedRegion
        public void OnSavePressed()
        {
            var confirmation = MessageBox.Show(Properties.Resources.MessageBoxConfirm,
                Properties.Resources.Confirm,
                MessageBoxButton.YesNo);
            if (confirmation != MessageBoxResult.Yes)
            {
                return;
            }

            if (_newStudentWindowViewModel.PreferredSKPlocationIndexChecker())
            {
                return;
            }

            if (_newStudentWindowViewModel.GfSchoolIndexChecker())
            {
                return;
            }

            if (_newStudentWindowViewModel.EducationDirectionIndexChecker())
            {
                return;
            }

            if (!Validator.IsValidFullName(_newStudentWindowViewModel.FullName))
            {
                if (!_newStudentWindowViewModel.Errors.Contains(nameof(_newStudentWindowViewModel.FullName)))
                {
                    _newStudentWindowViewModel.Errors.Add(nameof(_newStudentWindowViewModel.FullName), Properties.Resources.InvalidFullName);
                    OnPropertyChanged(nameof(_newStudentWindowViewModel.LastError));
                    _newStudentWindowViewModel.FullNameValid = false;
                }
            }


            if (!Validator.IsValidEmail(_newStudentWindowViewModel.Email))
            {
                if (!_newStudentWindowViewModel.Errors.Contains(nameof(_newStudentWindowViewModel.Email)))
                {
                    _newStudentWindowViewModel.Errors.Add(nameof(_newStudentWindowViewModel.Email), Properties.Resources.InvalidEmail);
                    OnPropertyChanged(nameof(_newStudentWindowViewModel.LastError));
                    _newStudentWindowViewModel.EmailValid = false;
                }
            }

            if (!Validator.IsValidPhoneNumber(_newStudentWindowViewModel.PhoneNumber))
            {
                if (!_newStudentWindowViewModel.Errors.Contains(nameof(_newStudentWindowViewModel.PhoneNumber)))
                {
                    _newStudentWindowViewModel.Errors.Add(nameof(_newStudentWindowViewModel.PhoneNumber), Properties.Resources.InvalidPhonenumber);
                    OnPropertyChanged(nameof(_newStudentWindowViewModel.LastError));
                    _newStudentWindowViewModel.PhoneNumberValid = false;
                }

            }

            if (!Validator.IsValidCprNr(_newStudentWindowViewModel.CprNr))
            {
                if (!_newStudentWindowViewModel.Errors.Contains(nameof(_newStudentWindowViewModel.CprNr)))
                {
                    _newStudentWindowViewModel.Errors.Add(nameof(_newStudentWindowViewModel.CprNr), Properties.Resources.InvalidCPRNr);
                    OnPropertyChanged(nameof(_newStudentWindowViewModel.LastError));
                    _newStudentWindowViewModel.CprNrValid = false;
                }
            }
            if (_newStudentWindowViewModel.GfSchoolIndex == 0)
            {
                if (!Validator.IsValidSpecialInfo(_newStudentWindowViewModel.Gf2SchoolOtherText))
                {
                    if (!_newStudentWindowViewModel.Errors.Contains(nameof(_newStudentWindowViewModel.Gf2SchoolOtherText)))
                    {
                        _newStudentWindowViewModel.Errors.Add(nameof(_newStudentWindowViewModel.Gf2SchoolOtherText), Properties.Resources.InvalidGF2School);
                        OnPropertyChanged(nameof(_newStudentWindowViewModel.Gf2SchoolOtherText));
                        _newStudentWindowViewModel.OtherGF2SchoolValid = false;
                    }
                }
            }

            if (_newStudentWindowViewModel.Errors.Keys.Count > 0)
            {
                return;
            }

            if (_newStudentWindowViewModel.EUXIndex == 0)
            {
                _newStudentWindowViewModel.student.EUX = true;
            }
            else
            {
                _newStudentWindowViewModel.student.EUX = false;
            }

            _newStudentWindowViewModel.student.EducationDirection = (EducationDirectionEnum)_newStudentWindowViewModel.EducationDirectionIndex;
            _newStudentWindowViewModel.student.WantedSkpLocation = (WantedSkpLocationEnum)_newStudentWindowViewModel.PreferredSkpLocationIndex;

            if (_newStudentWindowViewModel.GfSchoolIndex != 0)
            {
                _newStudentWindowViewModel.student.GfSchool = _newStudentWindowViewModel.GF2School[_newStudentWindowViewModel.GfSchoolIndex];
            }


            try
            {
                DataSaveLocationAndFileType.SaveStudentFile(_newStudentWindowViewModel.student, Statics.Path);
                _newStudentWindowViewModel.FreshGui();
                MessageBox.Show(Properties.Resources.MessageBoxInfomationSavedString);
            }
            catch (FileFormatException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (IOException)
            {

                MessageBox.Show(Properties.Resources.MessageBoxUnableToAccessFileError);
            }
        }
        #endregion

        #region ExportPressedREgion
        public void ExportPressed()
        {
            try
            {
                if (DataSaveLocationAndFileType.DecryptFile())
                {
                    MessageBox.Show(Properties.Resources.MessageBoxExportFileSaved);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MessageBoxFileNotSaved);
                }
            }
            catch (FileFormatException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show(Properties.Resources.MessageBoxUnableToAccessFileError);
            }
        }
        #endregion

        #region QuestionMarkPressedRegion
        public void QuestionMarkPressed()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            var companyName = versionInfo.CompanyName;
            MessageBox.Show($"{Properties.Resources.CreatedByText}: Peter Bøgh Stubberup\n{Properties.Resources.Version_text} {versionInfo.ProductVersion}\n{versionInfo.LegalCopyright}\n{versionInfo.Comments}");
        }
        #endregion


    }
}