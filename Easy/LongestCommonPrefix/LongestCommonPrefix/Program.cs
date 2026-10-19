using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = new string[] { "c", "acc", "ccc" };
            var output = LongestCommonPrefix(arrayOfStrings);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string longestCommonPrefix = string.Empty;

            if (strs.Length > 1)
            {
                var firstString = strs[0];
                string trimmedFirstStr = firstString;
                List<string> strListWithoutFirstStr = strs.ToList();
                strListWithoutFirstStr.RemoveAt(0);
                List<int> indexOfCharInString = new List<int>();


                foreach (char c in firstString)
                {
                    //int matchStrCount = strListWithoutFirstStr.Where(str => str.Contains(c.ToString())).ToList().Count();
                    //matchStrCount == strListWithoutFirstStr.Count() &&

                    if (strListWithoutFirstStr.All(str => str.Contains(c.ToString())))
                    {
                        int indexOfCharInFirstStr = trimmedFirstStr.IndexOf(c);
                        

                        foreach (string str in strListWithoutFirstStr)
                        {
                            int index = str.IndexOf(c);
                            indexOfCharInString.Add(index);
                        }

                        if (indexOfCharInString.All(index => index == indexOfCharInFirstStr))
                        {
                            longestCommonPrefix = longestCommonPrefix + c.ToString();
                            trimmedFirstStr = trimmedFirstStr.Remove(0, 1);
                            strListWithoutFirstStr = strListWithoutFirstStr.Select(str => str.Remove(0, 1)).ToList();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                longestCommonPrefix = strs[0];
            }

            return longestCommonPrefix;
        }

    }
}
