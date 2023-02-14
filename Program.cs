using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public static class Pattern
    {
        public static string checkFirstName = "^[A-Z][a-z]{3,}$";
        public static string checkLastName = "^[A-Z][a-z]{3,}$";
        public static string checkEmailId = "^[a-z{3,}]+[@+-.0-9a-z{3,}]+$";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex rg1 = new Regex(Pattern.checkFirstName);
            Console.WriteLine("Enter User First Name-");
            Console.WriteLine(rg1.IsMatch(Console.ReadLine()));

            Regex rg2 = new Regex(Pattern.checkLastName);
            Console.WriteLine("Enter User Last Name-");
            Console.WriteLine(rg2.IsMatch(Console.ReadLine()));

            Regex rg3 = new Regex(Pattern.checkEmailId);
            Console.WriteLine("Enter User E-mail Id-");
            Console.WriteLine(rg3.IsMatch(Console.ReadLine()));

        }
    }
}
