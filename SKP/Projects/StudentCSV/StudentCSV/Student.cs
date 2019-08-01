using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace StudentCSV
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

    public static class Validator
    {
        public static bool IsValidFirstName(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) &&
                Regex.IsMatch(value, @"^[\w'\-][^0-9,._!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{1,30}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidMiddleName(string value)
        {
            if (value == null)
            {
                value = "";
            }

            if (Regex.IsMatch(value, @"^[\w'\-][^0-9,_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]$"))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static bool IsValidLastName(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) &&
                Regex.IsMatch(value, @"^[\w'\-][^0-9,._!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{1,30}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidCprNr(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(?:(?:31(?:0[13578]|1[02])|(?:30|29)(?:0[13-9]|1[0-2])|(?:0[1-9]|1[0-9]|2[0-8])(?:0[1-9]|1[0-2]))[0-9]{2}?-??[0-9]|290200?-?[4-9]|2902(?:(?!00)[02468][048]|[13579][26])?-??[0-3])[0-9]{3}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidPhoneNumber(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(((([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?([0-9]\s{0,1}){3})([-\s\.]?([0-9]\s{0,1}){3,4}))|(\d{8}))$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidSpecialInfo(string value)
        {
            if (value == null)
            {
                value = "";
            }

            if (!value.Contains(";"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


