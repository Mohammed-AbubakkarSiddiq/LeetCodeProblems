using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(-121);
        }

        public static bool IsPalindrome(int x)
        {

            int actualValue = x;
            int reversedInt = ReverseInt(x);

            if (actualValue == reversedInt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Source - https://stackoverflow.com/a/2040714
        // Posted by cfern, modified by community. See post 'Timeline' for change history
        // Retrieved 2026-07-17, License - CC BY-SA 2.5

        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }

    }
}
