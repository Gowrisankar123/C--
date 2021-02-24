using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
        Console.WriteLine("Enter your name :");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter your age :");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your country :");
        string country = Console.ReadLine();
        Console.WriteLine("Welcome" + userName+"."+"Your age is"+age+"and you are from"+country);
        }
    }
}
