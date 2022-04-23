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
            //User Last name validation
            Lastname:
            Console.WriteLine("\nNote : Your Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your last name : ");
            string lName = Console.ReadLine(); //storing last name entered by user in variable
            bool checkLastName = Validation.LastNameValidation(lName); //Calling method to check last name is valid or not with argument
            if (!checkLastName)//If not valid then ask user to enter last name again
                goto Lastname;
            //User Email Validation
            Email:
            Console.WriteLine("\n\nEnter your email name : ");
            string email = Console.ReadLine(); //storing email address entered by user in variable
            bool checkEmail = Validation.EmailValidation(email); //Calling method to check email is valid or not with argument
            if (!checkEmail)//If not valid then ask user to enter email again
                goto Email;
            //user Mobile Number validation
            MobileNumber:
            Console.WriteLine("\n\nEnter your Mobile Number : ");
            string mNo = Console.ReadLine(); //storing mobile number entered by user in variable
            bool checkMobileNo = Validation.MobileNumberValidation(mNo); //Calling method to check mobile number is valid or not with argument
            if (!checkMobileNo)//If not valid then ask user to enter mobile number again
                goto MobileNumber;
            Console.ReadLine();
        }
    }
}
