using System;
using System.Text.RegularExpressions;

namespace StudentCSV.StudentValidater
{
    public class Validator
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

            if (Regex.IsMatch(value, @"^$|[æøåa-zÆØÅA-Z.][^0-9_!¡?÷?¿/\\,£¤+=@#$%ˆ&*(){}|~<>;:[\]]{1,50}$"))
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

        public static bool IsValidEmail(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && 
                Regex.IsMatch(value, @"^[æøåÆØÅa-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[æøåÆØÅa-zA-Z0-9](?:[æøåÆØÅa-zA-Z0-9-]{0,61}[æøåÆØÅa-zA-Z0-9])?(?:\.[æøåÆØÅa-zA-Z0-9](?:[æøåÆØÅa-zA-Z0-9-]{0,61}[æøåÆØÅa-zA-Z0-9])?)*$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Unilogin(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && 
                Regex.IsMatch(value, @"^[æøåa-zÆØÅA-Z0-9]*$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidCprNr(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) &&
                Regex.IsMatch(value, @"^(?:(?:31(?:0[13578]|1[02])|(?:30|29)(?:0[13-9]|1[0-2])|(?:0[1-9]|1[0-9]|2[0-8])(?:0[1-9]|1[0-2]))[0-9]{2}?-??[0-9]|290200?-?[4-9]|2902(?:(?!00)[02468][048]|[13579][26])?-??[0-3])[0-9]{3}$"))
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
            if (!String.IsNullOrWhiteSpace(value) &&
                Regex.IsMatch(value, @"^(((([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?([0-9]\s{0,1}){3})([-\s\.]?([0-9]\s{0,1}){3,4}))|(\d{8}))$"))
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