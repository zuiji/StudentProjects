using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using StudentCSV.Helpers;
using StudentCSV.Properties;
using StudentCSV.StaticsAndEnums;
using StudentCSV.StudentValidater;
using StudentCSV.Views;

namespace StudentCSV.ViewModel
{
    public class NewStudentWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // Binding to View 
        #region Props and fields

        public Student student { get; set; }

        private string _firstname;
        private string _middlename;
        private string _lastname;
        private string _email;
        private string _unilogin;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;
        private string _gf2SchoolOtherText;
        

        private int _euxIndex;
        private int _preferredSkpLocationIndex;
        private int _gfSchoolIndex;
        private int _educationDirectionIndex;

        private bool _firstNameValid;
        private bool _middleNameValid;
        private bool _lastNameValid;
        private bool _emailValid;
        private bool _uniloginValid;
        private bool _cprNrValid;
        private bool _phoneNumberValid;
        private bool _specialInfoValid;
        private bool _otherGf2SchoolValid;
        private readonly ButtonPressed _buttonPressed;

        public Visibility ShowDebug { get; set; } = Visibility.Collapsed;

        public List<string> EUX { get; set; }
        public List<string> PreferredSKPlocation { get; set; }
        public List<string> GF2School { get; set; }
        public List<string> EducationDirection { get; set; }

        public RelayCommand OnOtherGf2SchoolOtherTextLostFocusCommand { get; set; }
        public RelayCommand OnSpecialInfoFieldLostFocusCommand { get; set; }
        public RelayCommand OnPhoneNumberFieldLostFocusCommand { get; set; }
        public RelayCommand OnCprNrFieldLostFocusCommand { get; set; }
        public RelayCommand OnEmailFieldLostFocusCommand { get; set; }
        public RelayCommand OnUniloginFieldLostFocusCommand { get; set; }
        public RelayCommand OnLastNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnMiddleNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnFirstNameFieldLostFocusCommand { get; set; }
        public RelayCommand OnCancelPressedCommand { get; set; }
        public RelayCommand OnSavePressedCommand { get; set; }
        public RelayCommand OnLanguageChangedCommand { get; set; }
        public RelayCommand QuestionMarkPressedCommand { get; set; }
        public RelayCommand ExportPressedCommand { get; set; }
#if DEBUG
        public RelayCommand FillDebugInfoIntoFieldsPressedCommand { get; set; }

#endif
        public OrderedDictionary Errors { get; set; }
        
        public string Gf2SchoolOtherText
        {
            get { return _gf2SchoolOtherText; }
            set
            {
                _gf2SchoolOtherText = value;
                OnPropertyChanged();

            }
        }
        
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
            get { return _middlename; }
            set
            {
                _middlename = value;
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
        
        public string Fullname
        {
            get { return $"{_firstname} {_middlename} {_lastname}"; }
          
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

        public string Unilogin
        {
            get { return _unilogin; }
            set
            {
                _unilogin = value;
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

        public int PreferredSkpLocationIndex
        {
            get { return _preferredSkpLocationIndex; }
            set
            {
                _preferredSkpLocationIndex = value;
                PreferredSKPlocationIndexChecker();
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

        public bool UniloginValid
        {
            get { return _uniloginValid; }
            set
            {
                _uniloginValid = value;
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
        public bool OtherGF2SchoolValid
        {
            get { return _otherGf2SchoolValid; }
            set
            {
                _otherGf2SchoolValid = value;
                OnPropertyChanged();

            }
        }
        #endregion

        #region Constructor
        public NewStudentWindowViewModel()
        {
            bool correctPassword = false;

            do
            {
                string Password = PasswordWindow.Prompt("Please Enter Password", "Password");
                if (string.IsNullOrWhiteSpace(Password))
                {
                    var result2 = MessageBox.Show("Wrong Password\nPassword cannot be empty\nTry Again", "Wrong Password", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Cancel, MessageBoxOptions.DefaultDesktopOnly);
                    if (result2 != MessageBoxResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {


                    Statics.Password = PasswordHelper.HashPassword(Password);
                    try
                    {
                        if (File.Exists(Statics.Path) && new FileInfo(Statics.Path).Length != 0)
                        {
                            StringCipher.Decrypt(File.ReadAllText(Statics.Path), Statics.Password);
                            correctPassword = true;
                        }
                        else
                        {
                            correctPassword = true;
                        }

                    }
                    catch (Exception)
                    {
                        var result2 = MessageBox.Show("Wrong Password\nTry Again",
                                                      "Wrong Password",
                                                      MessageBoxButton.YesNo,
                                                      MessageBoxImage.Warning,
                                                      MessageBoxResult.Cancel,
                                                      MessageBoxOptions.DefaultDesktopOnly);
                        if (result2 != MessageBoxResult.Yes)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            } while (!correctPassword);


            FreshGui();
            _buttonPressed = new ButtonPressed(this);
        }
        #endregion
        
        #region FreshGui

        public void FreshGui()
        {
            Errors = new OrderedDictionary();
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Unilogin = string.Empty;
            CprNr = string.Empty;
            PhoneNumber = string.Empty;
            SpecialInfo = string.Empty;
            FirstNameValid = true;
            MiddleNameValid = true;
            LastNameValid = true;
            EmailValid = true;
            UniloginValid = true;
            CprNrValid = true;
            PhoneNumberValid = true;
            SpecialInfoValid = true;
            OtherGF2SchoolValid = true;
            EUX = new List<string>() { Properties.Resources.Yes, Properties.Resources.No };
            PreferredSKPlocation = new List<string>();
            GF2School = new List<string>();
            EducationDirection = new List<string>();
            PreferredSKPlocation.AddRange(Enum.GetNames(typeof(WantedSkpLocationEnum)));
            EducationDirection.AddRange(Statics.CorrectEducationDirectionEnumNames);
            GF2School.AddRange(Statics.CorrectGfSchoolEnumNames);
            EUXIndex = 1;
            PreferredSkpLocationIndex = -1;
            GfSchoolIndex = -1;
            EducationDirectionIndex = -1;
            OnFirstNameFieldLostFocusCommand = new RelayCommand(a => OnFirstNameFieldLostFocus());
            OnMiddleNameFieldLostFocusCommand = new RelayCommand(a => OnMiddleNameFieldLostFocus());
            OnLastNameFieldLostFocusCommand = new RelayCommand(a => OnLastNameFieldLostFocus());
            OnEmailFieldLostFocusCommand = new RelayCommand(a => OnEmailFieldLostFocus());
            OnUniloginFieldLostFocusCommand = new RelayCommand(a => OnUnilogFieldLostFocus());
            OnCprNrFieldLostFocusCommand = new RelayCommand(a => OnCprNrFieldLostFocus());
            OnPhoneNumberFieldLostFocusCommand = new RelayCommand(a => OnPhoneNumberFieldLostFocus());
            OnSpecialInfoFieldLostFocusCommand = new RelayCommand(a => OnSpecialInfoFieldLostFocus());
            OnOtherGf2SchoolOtherTextLostFocusCommand = new RelayCommand(a => OnOtherGf2SchoolOtherTextFieldLostFocus());
            OnCancelPressedCommand = new RelayCommand(a => _buttonPressed.OnCancelPressed());
            OnSavePressedCommand = new RelayCommand(a => _buttonPressed.OnSavePressed());
            OnLanguageChangedCommand = new RelayCommand(a => OnLanguageChanged());
            QuestionMarkPressedCommand = new RelayCommand(a => _buttonPressed.QuestionMarkPressed());
            ExportPressedCommand = new RelayCommand(a => _buttonPressed.ExportPressed());
#if DEBUG
            FillDebugInfoIntoFieldsPressedCommand = new RelayCommand(a => FillDebugInfoIntoFieldsPressed());
            ShowDebug = Visibility.Visible;
#endif

            student = new Student();
            Errors.Clear();
            OnPropertyChanged(nameof(LastError));
        }

#if DEBUG
        private void FillDebugInfoIntoFieldsPressed()
        {
            student.FirstName = FirstName = "Hans";
            student.MiddleName = MiddleName = "Jes Man";
            student.LastName = LastName = "Hansen";
            student.Email = Email = "HansHansen@hans.dk";
            student.Unilogin = Unilogin = "Haha656a";
            student.PhoneNumber = PhoneNumber = "99999999";
            student.CprNr = CprNr = "121212-1212";
            EUXIndex = 1;
            EducationDirectionIndex = 1;
            GfSchoolIndex = 0;
            PreferredSkpLocationIndex = 1;
            student.SpecialInfo = SpecialInfo = "Some very special info cake";
            student.GfSchool = Gf2SchoolOtherText = "Borup";

        }
#endif

        #endregion

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

            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(FirstName)))
                {
                    Errors.Add(nameof(FirstName), e.Message);
                }

                FirstNameValid = false;

            }
            OnPropertyChanged(nameof(LastError));
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


            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(MiddleName)))
                {
                    Errors.Add(nameof(MiddleName), e.Message);
                }

                MiddleNameValid = false;


            }
            OnPropertyChanged(nameof(LastError));
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

            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(LastName)))
                {
                    Errors.Add(nameof(LastName), e.Message);
                }

                LastNameValid = false;

            }
            OnPropertyChanged(nameof(LastError));

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
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(Email)))
                {
                    Errors.Add(nameof(Email), e.Message);
                }

                EmailValid = false;

            }
            OnPropertyChanged(nameof(LastError));

        }
        public void OnUnilogFieldLostFocus()
        {
            try
            {
                student.Unilogin = Unilogin;
                if (Errors.Contains(nameof(Unilogin)))
                {
                    Errors.Remove(nameof(Unilogin));
                    UniloginValid = true;
                }
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(Unilogin)))
                {
                    Errors.Add(nameof(Unilogin), e.Message);
                }
                UniloginValid = false;
            }
            OnPropertyChanged(nameof(LastError));
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
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(PhoneNumber)))
                {
                    Errors.Add(nameof(PhoneNumber), e.Message);
                }
                PhoneNumberValid = false;
            }
            OnPropertyChanged(nameof(LastError));

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
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(CprNr)))
                {
                    Errors.Add(nameof(CprNr), e.Message);
                }
                CprNrValid = false;
            }
            OnPropertyChanged(nameof(LastError));
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
            }
            catch (ArgumentException e)
            {
                // MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(SpecialInfo)))
                {
                    Errors.Add(nameof(SpecialInfo), e.Message);
                }
                SpecialInfoValid = false;
            }
            OnPropertyChanged(nameof(LastError));
        }

        public void OnOtherGf2SchoolOtherTextFieldLostFocus()
        {
            try
            {
                student.GfSchool = Gf2SchoolOtherText;
                if (Errors.Contains(nameof(Gf2SchoolOtherText)))
                {
                    Errors.Remove(nameof(Gf2SchoolOtherText));
                    OtherGF2SchoolValid = true;
                }
            }
            catch (ArgumentException e)
            {// MessageBox.Show(e.InnerException.Message);
                if (!Errors.Contains(nameof(Gf2SchoolOtherText)))
                {
                    Errors.Add(nameof(Gf2SchoolOtherText), e.Message);
                }
                OtherGF2SchoolValid = false;
            }
            OnPropertyChanged(nameof(LastError));
        }

        #endregion
        
        #region EnumIndexCheckersRegion

        public bool EducationDirectionIndexChecker()
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

        public bool GfSchoolIndexChecker()
        {
            if (GfSchoolIndex == -1)
            {
                if (!Errors.Contains(nameof(GF2School)))
                {
                    Errors.Add(nameof(GF2School), Properties.Resources.GfSchoolIndexChecker);
                    OnPropertyChanged(nameof(LastError));
                }
                return true;
            }

            if (Errors.Contains(nameof(GF2School)))
            {
                Errors.Remove(nameof(GF2School));
                OnPropertyChanged(nameof(LastError));
            }
            return false;
        }

        public bool PreferredSKPlocationIndexChecker()
        {
            if (PreferredSkpLocationIndex == -1)
            {
                if (!Errors.Contains(nameof(PreferredSKPlocation)))
                {
                    Errors.Add(nameof(PreferredSKPlocation), Properties.Resources.PreferredSKPlocationIndexChecker);
                    OnPropertyChanged(nameof(LastError));
                }
                return true;
            }

            if (Errors.Contains(nameof(PreferredSKPlocation)))
            {
                Errors.Remove(nameof(PreferredSKPlocation));
                OnPropertyChanged(nameof(LastError));
            }
            return false;
        }

        #endregion

        #region OnPropertyChangedRegion
        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region OnLanguageChangeRegion
        public void OnLanguageChanged()
        {
            var OldEUXIndex = EUXIndex;
            EUX = new List<string>() { Properties.Resources.Yes, Properties.Resources.No };
            OnPropertyChanged(nameof(EUX));
            EUXIndex = OldEUXIndex;
            var keys = new List<string>();
            keys.AddRange(Errors.Keys.Cast<string>());
            var Gf2SchoolTemp = new List<string>();
            bool isIndex0 = GfSchoolIndex == 0;
            Gf2SchoolTemp.AddRange(GF2School);
            Gf2SchoolTemp[0] = Resources.Other;
            GF2School = new List<string>();
            GF2School.AddRange(Gf2SchoolTemp);
            OnPropertyChanged(nameof(GF2School));
            if (isIndex0)
            {
                GfSchoolIndex = 0;
            }
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
                    case nameof(GF2School):
                        Errors[errorsKey] = Properties.Resources.GfSchoolIndexChecker;
                        break;
                    case nameof(PreferredSKPlocation):
                        Errors[errorsKey] = Properties.Resources.PreferredSKPlocationIndexChecker;
                        break;
                    case nameof(SpecialInfo):
                        Errors[errorsKey] = Properties.Resources.InvalidSpecialInfo;
                        break;
                }
            }
            OnPropertyChanged(nameof(LastError));
        }
        #endregion

     
    }
}
