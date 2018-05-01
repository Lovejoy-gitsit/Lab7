using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //names
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(Names(name));
            if (Names(name) == true)
            {
                Console.WriteLine($"{name} is a valid name");
            }
            else
            {
                Console.WriteLine("That is not a valid name.");
            }
            //emails
            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine(Email(email));
            //phone numbers
            Console.WriteLine("Enter your phone number: ");
            string number = Console.ReadLine();
            Console.WriteLine(PhoneNumbers(number));
            //date
            Console.WriteLine("Enter the date: dd/mm/yyyy ");
            string date = Console.ReadLine();
            Console.WriteLine(Date(date));
            //HTML
            Console.WriteLine("Enter html tag: ");
            string html = Console.ReadLine();
            Console.WriteLine(HTML(html));
        }

        public static bool Names(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z\s][A-Za-z]{1,29}$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Email(string email)
        {
           
            if (Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PhoneNumbers(string input)
        {

            if (Regex.IsMatch(input, @"^\d{3}-\d{3}-\d{4}$|^\d{10}$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Date(string date)
        {
            if (Regex.IsMatch(date, @"^\d{2,2}/\d{2,2}/\d{4,4}$"))
                return true;
            else
            {
                return false;
            }
            
        }

       public static bool HTML(string html)
       {
            if (Regex.IsMatch(html, @"</?\w+((\s+\w+(\s*=\s*(?:""[^""]*""|'[^']*'|[^'"">\s]+))?)+\s*|\s*)/?>"))
                return true;
            else
            {
                return false;
            }
       }

        
    }
    
}
