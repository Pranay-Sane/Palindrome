using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("eye"));
            Console.WriteLine(Palindrome("test"));
            Console.WriteLine(Palindrome("Madam"));
        }

        static bool Palindrome(string str)
        {
            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            return rev.ToLower() == str.ToLower();
        }
    }
}
