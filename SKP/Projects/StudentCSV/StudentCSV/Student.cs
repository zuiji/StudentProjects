using System;
using StudentCSV.StaticsAndEnums;
using StudentCSV.StudentValidater;

namespace StudentCSV
{
    public class Student
    {
        #region Feilds
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _email;
        private string _zbcEmail;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;
        private string _gfSchool; 
        #endregion

        #region NameProbs
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (Validator.IsValidFirstName(value))
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidFirstname);
                }
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (Validator.IsValidMiddleName(value))
                {
                    _middleName = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidMiddlename);

                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (Validator.IsValidLastName(value))
                {
                    _lastName = value;

                }
                else
                {
                    throw new ArgumentException(Properties.Resources.InvalidLastname);
                }

            }
        }



        #endregion#region Email Prop

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
        public string ZbcEmail
        {
            get { return _zbcEmail; }
            set
            {
                if (Validator.IsValidZbcEmail(value))
                {
                    _zbcEmail = value;
                }
                else
                {
                    throw new ArgumentException(Properties.Resources.IsValidZbcEmail);
                }

            }
        }

        #endregion

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
            get {return _gfSchool;}
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


