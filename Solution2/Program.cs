using System;

namespace Solution2
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
            int front = 0;
            int back = str.Length - 1;
            while(back > front)
            {
                if(str[back].ToString().ToLower() != str[front].ToString().ToLower())
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
