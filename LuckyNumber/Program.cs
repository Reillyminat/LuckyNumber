using System;
using System.Text.RegularExpressions;
namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int h1 = 0, h2 = 0;
            Console.WriteLine("Test task \"Lucky ticket\".\n");
            while (true)
            {
                Console.WriteLine("Input number with 3-8 digits to check it luck.\n");
                str = Console.ReadLine();
                if (str.Length % 2 != 0)
                    str = 0 + str;
                if (Regex.IsMatch(str, @"^\d{4,8}$"))
                {
                    for (int i = 0; i < str.Length / 2; i++)
                    {
                        h1 += str[i];
                        h2 += str[str.Length - i - 1];
                    }
                    if (h1 == h2)
                        Console.WriteLine("Number is lucky!\n");
                    else
                        Console.WriteLine("Number is not lucky.\n");
                }
                else
                    Console.WriteLine("Wrong input format!\n");
                h1 = 0;
                h2 = 0;
            }
        }
    }
}
