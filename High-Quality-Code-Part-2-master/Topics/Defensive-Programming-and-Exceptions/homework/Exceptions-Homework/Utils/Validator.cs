using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionsHomework.Utils
{
    public static class Validator
    {
        public static void ValidateIfNumberInRange(int number, int min, int max, string name)
        {
            if(number < min || max < number)
            {
                throw new ArgumentOutOfRangeException(String.Format("{2} must be in range {0} - {1}", min, max, name));
            }
        }
        public static void ValidatefNumberNonNegative(int number, string name)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} cannot be negative!", name));
            }
        }
        public static void ValidateString(string value, string name)
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(String.Format("{0} cannot be null or empty!", name));
            }
        }
        public static void ValidateName(string value, string name)
        {
            Regex namergx = new Regex(@"^[A-Za-z]$");
            if(!namergx.IsMatch(value))
            {
                throw new ArgumentException(String.Format("{0} contains invalid symbols", name));
            }
        }
    }
}
