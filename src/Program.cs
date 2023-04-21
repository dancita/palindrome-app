using System;
using System.Linq;

/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WorkItOut.GetPalindrome());
        }
    }

    public static class WorkItOut
    {
        public static int GetPalindrome()
        {
            var result = 0;

            // outer will be first loop
            for (int i = 10; i < 1000; i++)
            {
                // go through the numbers from 100 to 1000
                for (int x = 10; x < 1000; x++)
                {
                    // work out the product
                    var y = i * x;
                    //var yb = y.ToString();

                    var yb = new string(y.ToString().Reverse().ToArray());

                    // figure out if this is a palindrome
                    if (y.ToString() == yb)
                    {
                        if (y > result) result = y;
                    }
                }

            }

            return result;
        }
    }

}
