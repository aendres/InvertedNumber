using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertedNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string result = "";
            // created a string for the number entered and for the resulting inverted number
            Console.WriteLine("Enter your number here: ");
            input = Console.ReadLine();
            // the string input is now  eqaul to the number entered 

            foreach (char num in input.ToArray())
            // created a foreach loop that will take each number one by one starting with the first number entered
            {
                result = num + result;
                // the result in now equal to the inverted number created by the foreach loop
            }

            Console.WriteLine("Reverse of your number: " + result);
            Console.ReadLine();
        }

    }
}
