using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution2Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("eye"));
            Console.WriteLine(Palindrome("test"));
            Console.WriteLine(Palindrome("Madam"));
            Console.WriteLine(Palindrome("Race car"));
        }

        static bool Palindrome(string str)
        {
            int front = 0;
            int back = str.Length - 1;
            while (back > front)
            {
                while(Regex.Match(str[front].ToString(), @"[\W_]").Success)
                {
                    front++;
                    continue;
                }
                while(Regex.Match(str[back].ToString(), @"[\W_]").Success)
                {
                    back--;
                    continue;
                }
                if (str[back].ToString().ToLower() != str[front].ToString().ToLower())
                {
                    return false;
                }
                front++;
                back--;
            }
            return true;
        }
    }
}
