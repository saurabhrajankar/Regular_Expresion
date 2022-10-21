using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6_Password_UC
{
    public class RegexV
    {
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
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.PasswordRule2();
            Console.ReadLine();
        }
    }
}
