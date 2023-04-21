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
            Console.WriteLine(Palindrome.GetPalindrome());
        }
    }

    public static class Palindrome
    {

        public static int GetPalindrome()
        {
            var result = 0;

            for (int i = 999; i > 99; i--)
            {
                for (int j = i; j > 99; j--)
                {
                    var currentResult = Multiply(i, j);

                    if (IsPalindrome(currentResult) && currentResult > result)
                    {
                        result = currentResult;
                    };
                }

            }

            return result;
        }

        private static bool IsPalindrome(int number)
        {
            return new string(number.ToString().Reverse().ToArray()) == number.ToString();
        }

        private static int Multiply(int i, int j)
        {
            return i * j;
        }
    }

}
