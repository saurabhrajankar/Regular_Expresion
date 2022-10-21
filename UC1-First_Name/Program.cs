using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC1_First_Name
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
    }
    class main
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Validation for Form ");
            RegexValidation r1 = new RegexValidation();
            r1.FirstNameValidation();
            Console.ReadLine();
        }
    }
}
