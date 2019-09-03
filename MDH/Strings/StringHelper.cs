using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MDH.Strings
{
    public static class StringHelper
    {
        private static bool IsSingleWord(string str)
        {
            char[] sep = new char[] { ' ', '\t', ',', '.', ':', '_', '=', '+', '-' }; // complete this list as you see fit
            //string myString = "the string I want to test";
            bool isSingleWord = str.Trim(sep).IndexOfAny(sep) < 0;

            //str.Contains(sep.ToString());

            //Alternatively, you may use a regular expression.
            bool isSingleWord2 = !System.Text.RegularExpressions.Regex.IsMatch(str, @"\w+\W+\w");

            //Alternatively, you may use a regular expression.
            string word = "doesn't";
            bool isWord = Regex.IsMatch(word, @"^[A-Za-z]+$");

            return isSingleWord;
        }

        private static bool IsAWord(this string text)
        {
            var regex = new Regex(@"\b[\w']+\b");
            //var regex = new Regex(@"\b\w+\b");
            var match = regex.Match(text);
            return match.Value.Equals(text);
        }
    }
}
