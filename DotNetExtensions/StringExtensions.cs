using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetExtensions
{
    /// <summary>
    /// This class provides useful extensions for the String Object.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// More similar to Java version of substring, except removes the step of calling index of.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startStringMatch"></param>
        /// <param name="endStringMatch"></param>
        /// <returns></returns>
        public static string SubString(this string str, string startStringMatch, string endStringMatch){
            return str.Substring(str.IndexOf(startStringMatch), str.IndexOf(endStringMatch) - str.IndexOf(startStringMatch));
        }
        /// <summary>
        /// More similar to Java version of substring.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public static string SubString(this string str, int startIndex, int endIndex)
        {
            return str.Substring(startIndex, endIndex - startIndex);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        //Find
        public static string Search(this String str){
            //Boyer-Moore Algorithm
            return null;
        }
        //Contains with fast search
    }
}
