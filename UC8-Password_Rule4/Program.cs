using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC8_Password_Rule4
{
    public class RegexV
    {
        public void EmailSample()
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
    }
    internal class main
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.EmailSample();
            Console.ReadLine();
        }
    }
}
