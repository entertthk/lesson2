using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string firstName;
            string lastName;
            string color;
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Hello, " + firstName);
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstname + " " + lastname + "!");
            Console.WriteLine("Nice to meet you {0} {1}", firstName, lastName);
            Console.WriteLine("What is your favourite color: ");
            color = Console.ReadLine();
            Console.WriteLine("Cool story {0} {1} your favourite color is {2} ", firstName, lastName, color);


            Console.ReadLine();
            

        }
    }
}
