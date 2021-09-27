using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgoritmPrograms
{
    /// <summary>
    /// RegexInput class to check the input validation
    /// </summary>
    public class RegexInput
    {
        /// <summary>
        /// Check() method to check the Names and other inputs by using Regex...
        /// </summary>
        public void Check()
        {
            Console.Write("Enter Your FirstName : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Your LastName : ");
            string lname = Console.ReadLine();
            string namepattrn = @"^[A-Z]{1}[a-z]{3,}";
            Regex regex = new Regex(namepattrn);
            bool firstname = regex.IsMatch(fname);
            bool lasttname = regex.IsMatch(lname);
            Console.Write("Enter the Phone No. with Country Code : ");
            string PhoneNo = Console.ReadLine();
            string numpattern = @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}$";
            Regex reg = new Regex(numpattern);
            bool phoneno = reg.IsMatch(PhoneNo);
            Console.WriteLine("FirstName : " + firstname + "\nLastName : " + lasttname + "\nPhone No. : " + phoneno);
            Console.Write("Date is : ");
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine();

            Console.WriteLine("Hello {0}, We have your fullname as {1} {2} in our system.", fname, fname, lname);
            Console.WriteLine("Your contact number is {0}.", PhoneNo);
            Console.WriteLine("Please,let us know in case of any clarification Thank you BridgeLabz {0}", today.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
