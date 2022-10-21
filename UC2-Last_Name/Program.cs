using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2_Last_Name
{
    public class RegexV
    {
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
    }
    internal class main
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.LastNameValidation();
            Console.ReadLine();
        }
    }
}
