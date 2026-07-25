using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxProduct(124);
        }

        public static int MaxProduct(int n)
        {
            List<int> splittedNums = new List<int>();

            while(n>0)
            {
                splittedNums.Add(n % 10);

                n /= 10;
            }

            splittedNums.Reverse();

            if(splittedNums.Count == 2)
            {
                return splittedNums[0] * splittedNums[1];
            }

            int highestNum = splittedNums.Max();
            splittedNums.Remove(highestNum);

            int secondHighestNum = splittedNums.Max();

            return highestNum * secondHighestNum;
        }
    }
}
