using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using Microsoft.Win32;
using StudentCSV.Annotations;

namespace StudentCSV
{
    public class NewStudentWindowViewModel : INotifyPropertyChanged
    {
        #region Props and fields
        private Student student { get; set; }
        private readonly string _path;

        private string _firstname;
        private string _middleName;
        private string _lastname;
        private string _email;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;

        private int _euxIndex;
        private int _wantedSkpLocationIndex;
        private int _gfSchoolIndex;
        private int _educationDirectionIndex;

        private bool _firstNameValid;
        private bool _middleNameValid;
        private bool _lastNameValid;
        private bool _emailValid;
        private bool _cprNrValid;
        private bool _phoneNumberValid;
        private bool _specialInfoValid;

        public List<string> EUX { get; set; }
        public List<string> WantedSkpLocation { get; set; }
        public List<string> GFSchool { get; set; }
        public List<string> EducationDirection { get; set; }

        public RelayCommand OnSpecialInfoFieldLostFocusCommand { get; set; }
        public RelayCommand OnPhoneNumberFieldLostFocusCommand { get; set; }
        public RelayCommand OnCprNrFieldLostFocusCommand { get; set; }
        public RelayCommand OnEmailFieldLostFocusCommand { get; set; }
        public RelayCommand OnLastNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnMiddleNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnFirstNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnCancelPressedCommand { get; set; }
        public RelayCommand OnSavePressedCommand { get; set; }
        public RelayCommand OnLanguageChangedCommand {get; set;}

        public OrderedDictionary Errors { get; set; }

        public string LastError
        {

            get
            {
                if (Errors.Keys.Count > 0)
                {
                    return (string)Errors[Errors.Keys.Count - 1];
                }

                return null;
            }

        }
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged();
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string CprNr
        {
            get { return _cprNr; }
            set
            {
                _cprNr = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string SpecialInfo
        {
            get { return _specialInfo; }
            set
            {
                _specialInfo = value;
                OnPropertyChanged();
            }
        }

        public int EUXIndex
        {
            get { return _euxIndex; }
            set
            {
                _euxIndex = value;
                OnPropertyChanged();
            }
        }

        public int WantedSkpLocationIndex
        {
            get { return _wantedSkpLocationIndex; }
            set
            {
                _wantedSkpLocationIndex = value;
                WantedSkpLocationIndexChecker();
                OnPropertyChanged();
            }
        }

        public int GfSchoolIndex
        {
            get { return _gfSchoolIndex; }
            set
            {
                _gfSchoolIndex = value;
                GfSchoolIndexChecker();
                OnPropertyChanged();
            }
        }

        public int EducationDirectionIndex
        {
            get { return _educationDirectionIndex; }
            set
            {
                _educationDirectionIndex = value;
                EducationDirectionIndexChecker();
                OnPropertyChanged();
            }
        }

        public bool FirstNameValid
        {
            get { return _firstNameValid; }
            set
            {
                _firstNameValid = value;
                OnPropertyChanged();
            }
        }

        public bool MiddleNameValid
        {
            get { return _middleNameValid; }
            set
            {
                _middleNameValid = value;
                OnPropertyChanged();

            }
        }

        public bool LastNameValid
        {
            get { return _lastNameValid; }
            set
            {
                _lastNameValid = value;
                OnPropertyChanged();

            }
        }

        public bool EmailValid
        {
            get { return _emailValid; }
            set
            {
                _emailValid = value;
                OnPropertyChanged();

            }
        }

        public bool CprNrValid
        {
            get { return _cprNrValid; }
            set
            {
                _cprNrValid = value;
                OnPropertyChanged();

            }
        }

        public bool PhoneNumberValid
        {
            get { return _phoneNumberValid; }
            set
            {
                _phoneNumberValid = value;
                OnPropertyChanged();

            }
        }

        public bool SpecialInfoValid
        {
            get { return _specialInfoValid; }
            set
            {
                _specialInfoValid = value;
                OnPropertyChanged();

            }
        }
        #endregion

        #region Constructor
        public NewStudentWindowViewModel()
        {
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.AddExtension = true;
            Dialog.OverwritePrompt = false;
            Dialog.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx";
            Dialog.FilterIndex = 2;
            var result = Dialog.ShowDialog();

            if (result == true)
            {
                if (Path.GetExtension(Dialog.FileName).ToLower() != ".csv" && Path.GetExtension(Dialog.FileName).ToLower() != ".xlsx")
                {
                    switch (Dialog.FilterIndex)
                    {
                        case 1:
                            Dialog.FileName += ".csv";
                            break;
                        case 2:
                            Dialog.FileName += ".xlsx";
                            break;
                    }
                }
                _path = Dialog.FileName;
            }
            else
            {
                Environment.Exit(-1);
            }
            FreshGui();
        }
        #endregion

        #region FreshGui

        private void FreshGui()
        {
            Errors = new OrderedDictionary();
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            CprNr = string.Empty;
            PhoneNumber = string.Empty;
            SpecialInfo = string.Empty;
            FirstNameValid = true;
            MiddleNameValid = true;
            LastNameValid = true;
            EmailValid = true;
            CprNrValid = true;
            PhoneNumberValid = true;
            SpecialInfoValid = true;
            EUX = new List<string>() { Properties.Resources.Yes, Properties.Resources.No };
            WantedSkpLocation = new List<string>();
            GFSchool = new List<string>();
            EducationDirection = new List<string>();
            WantedSkpLocation.AddRange(Enum.GetNames(typeof(WantedSkpLocationEnum)));
            EducationDirection.AddRange(Statics.CorrectEducationDirectionEnumNames);
            GFSchool.AddRange(Statics.CorrectGfSchoolEnumNames);
            EUXIndex = 1;
            WantedSkpLocationIndex = -1;
            GfSchoolIndex = -1;
            EducationDirectionIndex = -1;
            OnFirstNameFieldLostFocusCommand = new RelayCommand(a => OnFirstNameFieldLostFocus());
            OnMiddleNameFieldLostFocusCommand = new RelayCommand(a => OnMiddleNameFieldLostFocus());
            OnLastNameFieldLostFocusCommand = new RelayCommand(a => OnLastNameFieldLostFocus());
            OnEmailFieldLostFocusCommand = new RelayCommand(a => OnEmailFieldLostFocus());
            OnCprNrFieldLostFocusCommand = new RelayCommand(a => OnCprNrFieldLostFocus());
            OnPhoneNumberFieldLostFocusCommand = new RelayCommand(a => OnPhoneNumberFieldLostFocus());
            OnSpecialInfoFieldLostFocusCommand = new RelayCommand(a => OnSpecialInfoFieldLostFocus());
            OnCancelPressedCommand = new RelayCommand(a => OnCancelPressed());
            OnSavePressedCommand = new RelayCommand(a => OnSavePressed());
            OnLanguageChangedCommand = new RelayCommand(a => OnLanguageChanged());
            student = new Student();
            Errors.Clear();
            OnPropertyChanged(nameof(LastError));
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        #region FieldLostFocusCommands
        public void OnFirstNameFieldLostFocus()
        {
            try
            {
                student.FirstName = FirstName;
                if (Errors.Contains(nameof(FirstName)))
                {
                    Errors.Remove(nameof(FirstName));
                    FirstNameValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(FirstName)))
                {
                    Errors.Add(nameof(FirstName), e.Message);
                }

                FirstNameValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnMiddleNameFieldLostFocus()
        {
            try
            {
                student.MiddleName = MiddleName;
                if (Errors.Contains(nameof(MiddleName)))
                {
                    Errors.Remove(nameof(MiddleName));
                    MiddleNameValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(MiddleName)))
                {
                    Errors.Add(nameof(MiddleName), e.Message);
                }

                MiddleNameValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnLastNameFieldLostFocus()
        {
            try
            {
                student.LastName = LastName;
                if (Errors.Contains(nameof(LastName)))
                {
                    Errors.Remove(nameof(LastName));
                    LastNameValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(LastName)))
                {
                    Errors.Add(nameof(LastName), e.Message);
                }

                LastNameValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnEmailFieldLostFocus()
        {
            try
            {
                student.Email = Email;
                if (Errors.Contains(nameof(Email)))
                {
                    Errors.Remove(nameof(Email));
                    EmailValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(Email)))
                {
                    Errors.Add(nameof(Email), e.Message);
                }

                EmailValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnPhoneNumberFieldLostFocus()
        {
            try
            {
                student.PhoneNumber = PhoneNumber;
                if (Errors.Contains(nameof(PhoneNumber)))
                {
                    Errors.Remove(nameof(PhoneNumber));
                    PhoneNumberValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(PhoneNumber)))
                {
                    Errors.Add(nameof(PhoneNumber), e.Message);
                }

                PhoneNumberValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnCprNrFieldLostFocus()
        {
            try
            {
                student.CprNr = CprNr;
                if (Errors.Contains(nameof(CprNr)))
                {
                    Errors.Remove(nameof(CprNr));
                    CprNrValid = true;
                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(CprNr)))
                {
                    Errors.Add(nameof(CprNr), e.Message);
                }

                CprNrValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }
        public void OnSpecialInfoFieldLostFocus()
        {
            try
            {
                student.SpecialInfo = SpecialInfo;
                if (Errors.Contains(nameof(SpecialInfo)))
                {
                    Errors.Remove(nameof(SpecialInfo));
                    SpecialInfoValid = true;

                }

                OnPropertyChanged(nameof(LastError));
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(SpecialInfo)))
                {
                    Errors.Add(nameof(SpecialInfo), e.Message);
                }

                SpecialInfoValid = false;
                OnPropertyChanged(nameof(LastError));

            }
        }

        #endregion 

        public void OnCancelPressed()
        {
            Language.ChangeCulture(new CultureInfo("en"));
            OnPropertyChanged("");
            var Confirmation = MessageBox.Show(Properties.Resources.MessageBoxConfirmCanceled, Properties.Resources.MessageBoxConfirmCancel, MessageBoxButton.YesNo);
            if (Confirmation == MessageBoxResult.Yes)
            {
                FreshGui();
            }
        }

        #region OnSavePressedRegion
        private void OnSavePressed()
        {
            var Confirmation = MessageBox.Show(Properties.Resources.MessageBoxConfirm, Properties.Resources.Confirm, MessageBoxButton.YesNo);
            if (Confirmation != MessageBoxResult.Yes)
            {
                return;
            }

            if (WantedSkpLocationIndexChecker())
            {
                return;
            }

            if (GfSchoolIndexChecker())
            {
                return;
            }

            if (EducationDirectionIndexChecker())
            {
                return;
            }

            if (Validator.IsValidFirstName(FirstName))
            {
                if (!Errors.Contains(nameof(FirstName)))
                {
                    Errors.Add(nameof(FirstName), Properties.Resources.InvalidFirstname);
                    OnPropertyChanged(nameof(LastError));
                    FirstNameValid = false;
                }
            }

            if (Validator.IsValidLastName(LastName))
            {

                if (!Errors.Contains(nameof(LastName)))
                {
                    Errors.Add(nameof(LastName), Properties.Resources.InvalidLastname);
                    OnPropertyChanged(nameof(LastError));
                    LastNameValid = false;

                }
            }
            if (Validator.IsValidEmail(Email))
            {
                if (!Errors.Contains(nameof(Email)))
                {
                    Errors.Add(nameof(Email), Properties.Resources.InvalidEmail);
                    OnPropertyChanged(nameof(LastError));
                    EmailValid = false;
                }
            }
            if (Validator.IsValidPhoneNumber(PhoneNumber))
            {
                if (!Errors.Contains(nameof(PhoneNumber)))
                {
                    Errors.Add(nameof(PhoneNumber), Properties.Resources.InvalidPhonenumber);
                    OnPropertyChanged(nameof(LastError));
                    PhoneNumberValid = false;
                }

            }
            if (Validator.IsValidCprNr(CprNr))
            {
                if (!Errors.Contains(nameof(CprNr)))
                {
                    Errors.Add(nameof(CprNr), Properties.Resources.InvalidCPRNr);
                    OnPropertyChanged(nameof(LastError));
                    CprNrValid = false;
                }

            }

            if (Errors.Keys.Count > 0)
            {
                return;
            }

            if (EUXIndex == 0)
            {
                student.EUX = true;
            }
            else
            {
                student.EUX = false;
            }

            student.EducationDirection = (EducationDirectionEnum)EducationDirectionIndex;
            student.WantedSkpLocation = (WantedSkpLocationEnum)WantedSkpLocationIndex;
            student.GfSchool = (GfSchoolEnum)GfSchoolIndex;
            try
            {

                DataSaveLocationAndFileType.SaveStudentFile(student, _path);
                FreshGui();
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

        #region EnumIndexCheckersRegion

        private bool EducationDirectionIndexChecker()
        {
            if (EducationDirectionIndex == -1)
            {
                if (!Errors.Contains(nameof(EducationDirection)))
                {
                    Errors.Add(nameof(EducationDirection), Properties.Resources.EducationDirectionIndexChecker);
                    OnPropertyChanged(nameof(LastError));
                }

                return true;
            }

            if (Errors.Contains(nameof(EducationDirection)))
            {
                Errors.Remove(nameof(EducationDirection));
                OnPropertyChanged(nameof(LastError));
            }

            return false;
        }

        private bool GfSchoolIndexChecker()
        {
            if (GfSchoolIndex == -1)
            {
                if (!Errors.Contains(nameof(GFSchool)))
                {
                    Errors.Add(nameof(GFSchool), Properties.Resources.GfSchoolIndexChecker);
                    OnPropertyChanged(nameof(LastError));
                }

                return true;
            }

            if (Errors.Contains(nameof(GFSchool)))
            {
                Errors.Remove(nameof(GFSchool));
                OnPropertyChanged(nameof(LastError));
            }

            return false;
        }

        private bool WantedSkpLocationIndexChecker()
        {
            if (WantedSkpLocationIndex == -1)
            {
                if (!Errors.Contains(nameof(WantedSkpLocation)))
                {
                    Errors.Add(nameof(WantedSkpLocation), Properties.Resources.WantedSkpLocationIndexChecker);
                    OnPropertyChanged(nameof(LastError));
                }

                return true;
            }

            if (Errors.Contains(nameof(WantedSkpLocation)))
            {
                Errors.Remove(nameof(WantedSkpLocation));
                OnPropertyChanged(nameof(LastError));
            }

            return false;
        }

        #endregion

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnLanguageChanged()
        {
            var OldEUXIndex = EUXIndex;
            EUX = new List<string>() { Properties.Resources.Yes, Properties.Resources.No };
            OnPropertyChanged(nameof(EUX));
            EUXIndex = OldEUXIndex;
            var keys = new List<string>();
            keys.AddRange( Errors.Keys.Cast<string>());
            foreach (string errorsKey in keys)
            {
                string obj = errorsKey.ToString();
                switch (obj)
                {
                    case nameof(FirstName):
                        Errors[errorsKey] = Properties.Resources.InvalidFirstname;
                        break;
                    case nameof(MiddleName):
                        Errors[errorsKey] = Properties.Resources.InvalidMiddlename;
                        break;
                    case nameof(LastName):
                        Errors[errorsKey] = Properties.Resources.InvalidLastname;
                        break;
                    case nameof(Email):
                        Errors[errorsKey] = Properties.Resources.InvalidEmail;
                        break;
                    case nameof(PhoneNumber):
                        Errors[errorsKey] = Properties.Resources.InvalidPhonenumber;
                        break;
                    case nameof(CprNr):
                        Errors[errorsKey] = Properties.Resources.InvalidCPRNr;
                        break;
                    case nameof(EducationDirection):
                        Errors[errorsKey] = Properties.Resources.EducationDirectionIndexChecker;
                        break;
                    case nameof(GFSchool):
                        Errors[errorsKey] = Properties.Resources.GfSchoolIndexChecker;
                        break;
                    case nameof(WantedSkpLocation):
                        Errors[errorsKey] = Properties.Resources.WantedSkpLocationIndexChecker;
                        break;
                    case nameof(SpecialInfo):
                        Errors[errorsKey] = Properties.Resources.InvalidSpecialInfo;
                        break;
                    
                }
            }
            OnPropertyChanged(nameof(LastError));


        }

    }
}
