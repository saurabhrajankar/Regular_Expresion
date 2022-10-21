using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_Mobile_Number
{
    public class RegexV
    {
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
    }
    internal class main
    {
        static void Main(string[] args)
        {
            RegexV obj = new RegexV();
            obj.MobileNumber();
            Console.ReadLine();
        }
    }
}
