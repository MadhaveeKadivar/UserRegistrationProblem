using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nWelcome to C# Regular Expression");
            //User First name validation
            Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your first name : ");
            string fName = Console.ReadLine(); //storing first name entered by user in variable
            bool checkFirstName = Validation.FirstNameValidation(fName); //Calling method to check first name is valid or not with argument
            if (!checkFirstName)//If not valid then ask user to enter first name again
                goto Firstname;

            Console.ReadLine();
        }
    }
}
