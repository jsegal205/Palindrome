using System;
using System.Globalization;

namespace Palindrome
{
    static class Program
    {
        static void Main()
        {
            RunMe();
        }

        static void RunMe()
        {
            Console.WriteLine("This program will test if the word is a Palindrome:");

            var chkWord = Console.ReadLine().ToLower();

            if (chkWord == "quit" || chkWord == "exit")
            {
                QuitEasterEgg(chkWord);
            }
            
            bool isPal = Palindrome.IsPalindrome(chkWord);
            Console.WriteLine("{0} is a palindrome: {1}", chkWord, isPal);
            ReRun();
        }

        private static void QuitEasterEgg(string chkWord)
        {
            Console.WriteLine("{0} is not a palindrome. Closing in...", chkWord);
            for (var i = 3; i >= 0; i--)
            {
                if (i == 0)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture));
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void ReRun()
        {
            Console.WriteLine();
            Console.Write("Run again (Y / N): ");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.N:
                case ConsoleKey.Escape:
                    {
                        Console.Write("N");
                        System.Threading.Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    }
                case ConsoleKey.Y:
                    {
                        Console.Write("Y");
                        Console.WriteLine();
                        RunMe();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice. ");
                        ReRun();
                        break;
                    }
            }
        }
    }
}
