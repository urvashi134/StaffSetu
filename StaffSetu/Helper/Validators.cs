using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Staff_Management
{
    public static class Validators
    {
        public static bool IsNumeric(string strNumber)
        {
            return int.TryParse(strNumber, out int result);
        }
        public static bool IsDouble(string strNumber)
        {
            return double.TryParse(strNumber, out double result);
        }

        public static bool RequiredValidation(string data)
        {
            return !string.IsNullOrEmpty(data);
        }
        public static bool IsValidText(string data)
        {
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(data);
        }
        public static bool IsValidPassword(string data)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(data);
        }
        

        public static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsValidMobile(string strNumber)
        {
            if (IsDouble(strNumber) && (strNumber.Length == 10 || strNumber.Length == 11 ))
                return true;
            else
                return false;
        }
        public static bool IsValidDate(DateTime dt)
        {
            if (dt > DateTime.Today)
            {
                return false;
            }
            else
                return true;
        }
    }
}
