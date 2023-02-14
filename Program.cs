using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public static class Pattern
    {
        public static string CheckFirstName = "^[A-Z][a-z]{3,}$";
        public static string CheckLastName = "^[A-Z][a-z]{3,}$";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex rg = new Regex(Pattern.CheckFirstName);

            Console.WriteLine("Enter User First Name-");
            Console.WriteLine(rg.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter User Last Name-");
            Console.WriteLine(rg.IsMatch(Console.ReadLine()));
            
        }
    }
}
