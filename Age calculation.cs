using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1              //DO NOT CHANGE the namespace name
{
    public class Program       //DO NOT CHANGE the class name
    {
         
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            string dob=Console.ReadLine();
            int age= calculateAge(dob);
            Console.WriteLine(age);
            //Implement code here
        }
        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            DateTime Birthdate = DateTime.ParseExact(dateOfBirth,"dd-MM-yyyy",null);
            TimeSpan tsDob=DateTime.Now.Subtract(Birthdate);
            int age =(int)tsDob.TotalDays/365;
            return age;
         
        }
       


    }
}
