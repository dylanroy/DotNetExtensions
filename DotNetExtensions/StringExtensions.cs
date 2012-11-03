using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetExtensions
{
    public static class StringExtensions
    {
        public static string SubString(this string str, string startStringMatch, string endStringMatch){
            return str.Substring(str.IndexOf(startStringMatch), str.IndexOf(endStringMatch) - str.IndexOf(startStringMatch));
        }
        public static string SubString(this string str, int startIndex, int endIndex)
        {
            return str.Substring(startIndex, endIndex - startIndex);
        }
    }
}
