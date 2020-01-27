using System;
using StudentCSV.StaticsAndEnums;
using StudentCSV.StudentValidater;

namespace StudentCSV
{
    public class Student
    {

        // Creating defination Object of student.
        #region Feilds


        private string _fullName;
        private string _email;
        private string _unilogin;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;
        private string _gfSchool;


        #endregion

        #region NameProbs

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (Validator.IsValidFullName(value))
                {
                    _fullName = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidFullName);
                }
            }
        }

        #endregion

        #region EmailProp

        public string Email
        {
            get { return _email; }
            set
            {
                if (Validator.IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidEmail);
                }

            }
        }
        #endregion#region Email Prop

        public string Unilogin
        {
            get { return _unilogin; }
            set
            {
                if (Validator.Unilogin(value))
                {
                    _unilogin = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.IsValidUnilogin);
                }

            }
        }

       

        #region CprProp
        public string CprNr
        {
            get { return _cprNr; }
            set
            {
                if (Validator.IsValidCprNr(value))
                {
                    if (!value.Contains("-"))
                    {
                        value = value.Insert(6, "-");
                    }
                    _cprNr = value;

                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidCPRNr);
                }
            }
        }



        #endregion

        #region PhoneNumberProp

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (Validator.IsValidPhoneNumber(value))
                {
                    _phoneNumber = value;

                }

                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidPhonenumber);

                }
            }
        }

        #endregion

        #region SpecialInfoProp
        public string SpecialInfo
        {
            get { return _specialInfo; }
            set
            {
                if (Validator.IsValidSpecialInfo(value))
                {
                    _specialInfo = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidSpecialInfo);

                }
            }
        }

        #endregion
        public bool EUX { get; set; }
        public WantedSkpLocationEnum WantedSkpLocation { get; set; }

        public string GfSchool
        {
            get { return _gfSchool; }
            set
            {
                if (Validator.IsValidSpecialInfo(value))
                {
                    _gfSchool = value;

                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidGF2School);
                }
            }
        }

        public EducationDirectionEnum EducationDirection { get; set; }
    }
}


