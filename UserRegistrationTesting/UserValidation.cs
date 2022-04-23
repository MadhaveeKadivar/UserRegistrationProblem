using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
using System;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UserValidation
    {
        /// <summary>
        /// Testing for Firstname Validation
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="expected"></param>        
        [TestMethod]
        [DataRow("Madhavee", true)]
        [DataRow("Ab", false)]
        [DataRow("madhavee", false)]
        public void GivenFirstNameValidation(string firstName, bool expected) 
        {
            //Act
            bool actual = Validation.FirstNameValidation(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Lastname Validation
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("Kadivar", true)]
        [DataRow("Ab", false)]
        [DataRow("kadivar", false)]
        public void GivenLastNameValidation(string lastName, bool expected) 
        {
            //Act
            bool actual = Validation.FirstNameValidation(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Email Validation
        /// </summary>
        /// <param name="email"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmailValidation(string email, bool expected) 
        {
            //Act
            bool actual = Validation.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Mobile Number Validation
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("91 9652545874", true)]
        [DataRow("919652545874", false)]
        [DataRow("9144 9652545874", false)]
        [DataRow("91 1652545874", false)]
        public void GivenMobileNumberValidation(string mobileNumber, bool expected) 
        {
            //Act
            bool actual = Validation.MobileNumberValidation(mobileNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Password Rule - 1  Validation
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("dfghnjvbn", true)]
        [DataRow("ADF@#$%JVGB", true)]
        [DataRow("FVGdf", false)]
        [DataRow("8745fgvhA", true)]
        public void GivenPasswordRule1Validation(string password, bool expected) 
        {
            //Act
            bool actual = Validation.PasswordRule1Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Password Rule - 2  Validation
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("dfghnjvbn", false)]
        [DataRow("A5sdf@#34", true)]
        [DataRow("FVGdf", false)]
        [DataRow("wsdfgADFG65@3", true)]
        public void GivenPasswordRule2Validation(string password, bool expected) 
        {
            //Act
            bool actual = Validation.PasswordRule2Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Password Rule - 3  Validation
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("dfgDnjvbn", false)]
        [DataRow("A5sdf@#df", true)]
        [DataRow("F5G@f", false)]
        [DataRow("8465ADFG", true)]
        public void GivenPasswordRule3Validation(string password, bool expected) 
        {
            //Act
            bool actual = Validation.PasswordRule3Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing for Password Rule - 4 along with all rules Validation
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("dfgDnjvbn", false)]
        [DataRow("A5sdf@df", true)]
        [DataRow("F5G@f", false)]
        [DataRow("85ADcv*gj5", true)]
        [DataRow("*&&dfgADDd845", false)]
        [DataRow("885@dfvvvb", false)]
        [DataRow("AAaa#8ghbb", true)]
        public void GivenPasswordRule4Validation(string password, bool expected) 
        {
            //Act
            bool actual = Validation.PasswordRule4Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }        
    }
}
