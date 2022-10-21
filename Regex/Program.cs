using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexV
{
    public class RegexValidation
    {
        public void FirstNameValidation()
        {
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{2,}"; //writing the expression as we are needed
            Regex regex = new Regex(firstname);      //creating a regex named obj with regular firstname
            if (regex.IsMatch(Firstname))            //if the word matches the regex
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }

        public void LastNameValidation()
        {
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string lastname = "^[A-Z]{1}[a-z]{2,}$";//writing the expression as we are needed
            Regex regex1 = new Regex(lastname);//creating a regex named obj with regular lastname
            if (regex1.IsMatch(Lastname))//creating a regex named obj with regular firstname
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }
        public void Email()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "^[a-z]{3}([.][a-z]{3})?@[a-z]{2}[.][a-z]{2}([.][a-z]{2})?";//writing the expression as we are needed
            Regex regex1 = new Regex(emailFormat);                                     //creating a regex named obj with regular emailFormat     
            if (regex1.IsMatch(email))                                                    //if the word matches the regex                                            
            {
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
        }

        public void MobileNumber()
        {
            Console.WriteLine("Enter Mobile Number :");
            var Number = Console.ReadLine();
            var NumberFormat = "^[0-9]{2}\\s[0-9]{10}$";//writing the expression as we are needed
            Regex regex1 = new Regex(NumberFormat);     //creating a regex named obj with regular NumberFormat
            if (regex1.IsMatch(Number))                 //if the word matches the regex
            {
                Console.Write("Given Phone Number is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Number in Proper Format \n");
            }
        }
        public void Password()
        {
            Console.WriteLine("Enter Password :");
            var Password = Console.ReadLine();
            var PasswordFormat = "[a-z]{8,}";          //writing the expression as we are needed
            Regex regex1 = new Regex(PasswordFormat);  //creating a regex named obj with regular PasswordFormat
            if (regex1.IsMatch(Password))             //if the word matches the regex
            {
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Password in Proper Format \n");
            }
        }
        public void PasswordRule2()
        {
            Console.WriteLine("Enter Password :");
            var Password = Console.ReadLine();
            var PasswordFormat = "[A-Z]{1}[a-z]{8,}";    //writing the expression as we are needed
            Regex regex1 = new Regex(PasswordFormat);   //creating a regex named obj with regular PasswordFormat
            if (regex1.IsMatch(Password))               //if the word matches the regex
            {
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Password in Proper Format \n");
            }
        }
        public void PasswordRule3()
        {
            Console.WriteLine("Enter Password :");
            var Password = Console.ReadLine();
            var PasswordFormat = "(?=.*[A-Z0-9])[a-zA-Z0-9]{8,}";//writing the expression as we are needed
            Regex regex1 = new Regex(PasswordFormat);         //creating a regex named obj with regular PasswordFormat
            if (regex1.IsMatch(Password))                     //if the word matches the regex
            {
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Password in Proper Format \n");
            }
        }
        public void PasswordRule4()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{8}";//writing the expression as we are needed
            Regex regex1 = new Regex(emailFormat);                        //creating a regex named obj with regular firstname   
            if (regex1.IsMatch(email))                                   //if the word matches the regex          
            {
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
        }
        public void EmailSample()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";//writing the expression as we are needed
            Regex regex1 = new Regex(emailFormat);                        //creating a regex named obj with regular firstname   
            if (regex1.IsMatch(email))                                   //if the word matches the regex          
            {
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Validation for Form ");
            RegexValidation r1 = new RegexValidation();
            r1.FirstNameValidation();
            r1.LastNameValidation();
            r1.Email();
            r1.MobileNumber();
            r1.Password();
            r1.PasswordRule2();
            r1.PasswordRule3();
            r1.PasswordRule4();
            r1.EmailSample();
            Console.ReadLine();
        }
    }
}
