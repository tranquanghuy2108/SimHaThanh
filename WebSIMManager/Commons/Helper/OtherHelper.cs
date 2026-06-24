using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commons.Helper
{
    public static class OtherHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomString(int length)
        {
            Random random = new Random();
            StringBuilder strResult = new StringBuilder(length);
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < length; i++)
                strResult.Append(chars[random.Next(chars.Length)]);

            return strResult.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalPayable"></param>
        /// <param name="days"></param>
        /// <param name="interestRate"></param>
        /// <returns></returns>
        public static double CalculateMonthlyInstallments(double totalPayable, int days, int interestRate)
        {
            double monthlyInstallments = (totalPayable / 1000000d) * days * interestRate;
            return monthlyInstallments;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
