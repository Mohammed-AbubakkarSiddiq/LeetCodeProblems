using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("MCMXCIV");
        }

        public static int RomanToInt(string s)
        {
            char[] romanChar = s.ToCharArray();
            int result = 0, previousNum = 0;

            for(int i = 0; i < romanChar.Length ; i++)
            {
                int currentNum = IntEquvalentOfRoman(romanChar[i]);
                if (i > 0)
                {
                    previousNum = IntEquvalentOfRoman(romanChar[i - 1]);
                }

                if (currentNum > previousNum && i != 0)
                {
                    result += (currentNum - previousNum - previousNum);
                }
                else
                {
                    result += currentNum;
                }

            }

            return result;

        }

        public static int IntEquvalentOfRoman(char c)
        {
            switch (c)
            {
                case 'I':
                    {
                        return 1;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'M':
                    {
                        return 1000;
                    }
            }

            return 0;
        }
    }
}
