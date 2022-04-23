using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validation
    {
        /// <summary>
        /// First Name Validation
        /// </summary>
        /// <param name="fName"></param>
        /// <returns>bool</returns>
        public static bool FirstNameValidation(string fName) 
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is not valid");
                return false;
            }
        }
        /// <summary>
        /// Last Name Validation
        /// </summary>
        /// <param name="lName"></param>
        /// <returns>bool</returns>
        public static bool LastNameValidation(string lName) // Creating a method for Last name validation
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(lName, pattern))
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of last name");
                return false;
            }
        }
        /// <summary>
        /// Email Validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns>bool</returns>
        public static bool EmailValidation(string email) 
        {
            string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Regex for Email validation
            //If email address entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"\nYour Email address \"{email}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Email address \"{email}\" is not valid");
                return false;
            }
        }
        /// <summary>
        /// Mobile Number Validation
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns>bool</returns>
        public static bool MobileNumberValidation(string mobileNo) 
        {
            string pattern = "^[9][1][ ][6-9][0-9]{9}$"; // Regex for Mobile number validation
            //If Mobile Number entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(mobileNo, pattern))
            {
                Console.WriteLine($"\nYour Mobile Number \"{mobileNo}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Mobile Number \"{mobileNo}\" is not valid");
                return false;
            }
        }
        /// <summary>
        /// Password Rule 1 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool PasswordRule1Validation(string password) 
        {
            //Rule -1 Minimum 8 characters
            string patternForRule1 = "^[0-9a-zA-Z@#$%^&*!+=]{8,}"; // Regex for password validation rule 1
            //If password entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(password, patternForRule1))
            {
                Console.WriteLine($"\nYour password \"{password}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour password \"{password}\" is not follow password rules");
                return false;
            }
        }
        /// <summary>
        /// Password Rule 2 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool PasswordRule2Validation(string password) 
        {
            //Rule - 2 Atleast 1 Capital Letter
            string patternForRule2 = "^(?=.*[A-Z])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password validation rule 2
            //If password entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(password, patternForRule2))
            {
                Console.WriteLine($"\nYour password \"{password}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour password \"{password}\" is not follow password rules");
                return false;
            }
        }
        /// <summary>
        /// Password Rule 3 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool PasswordRule3Validation(string password)
        {
            //Rule - 2 Atleast 1 Capital Letter
            string patternForRule3 = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password validation rule 3
            //If password entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(password, patternForRule3))
            {
                Console.WriteLine($"\nYour password \"{password}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour password \"{password}\" is not follow password rules");
                return false;
            }
        }
        /// <summary>
        /// Password Rule 4 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool PasswordRule4Validation(string password) // Creating a method for password validation
        {
            //Rule - 4  Has Exactly one special character
            string finalPatternPassword = @"^(?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,}?[@~!#$%^&*+=\/-]{1}[a-zA-Z0-9]{0,}$"; // Regex for password validation rule 4
            //If password entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(password, finalPatternPassword))
            {
                Console.WriteLine($"\nYour password \"{password}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour password \"{password}\" is not follow password rules");
                return false;
            }
        }

    }
}
