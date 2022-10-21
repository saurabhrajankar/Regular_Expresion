using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC7_Password_Rule3
{
    public class RegexV
    {
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
    }
   
    internal class main
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.PasswordRule3();
            Console.ReadLine();
        }
    }
}
