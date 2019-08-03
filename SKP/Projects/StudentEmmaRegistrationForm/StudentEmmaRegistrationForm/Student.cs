using System;
using DocumentFormat.OpenXml.CustomProperties;

namespace StudentEmmaRegistrationForm
{
    public class Student
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _email;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;


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
        public GfSchoolEnum GfSchool { get; set; }
        public EducationDirectionEnum EducationDirection { get; set; }
    }
}


