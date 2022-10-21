using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC9_Clear_All_Email
{
    public class RegexV
    {
        public void Email()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "^[a-z A-Z 0-9_]+[@][a-z]+.[a-z]{2,3}";//writing the expression as we are needed
            Regex regex1 = new Regex(emailFormat);                     //creating a regex named obj with regular emailFormat
            if (regex1.IsMatch(email))                                  //if the word matches the regex
            {
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.Email();
            Console.ReadLine();
        }
    }
}
