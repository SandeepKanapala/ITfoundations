using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFactorial
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please type in an integer: "); //1. ask the user to input a number on the console

            string str; // 2. Store the integer given from the console to a string.

            str = Console.ReadLine(); //3. Read the line from console.
                        
            int n = int.Parse(str); //4. Convert the string to a interger.

            int factorial; //5. Do the calculations for n! (n factorial). 
            factorial = n - 1;
            while (factorial > 0)
            {
                n = n * factorial;
                factorial = factorial - 1;

            }
                         
            Console.WriteLine("The calculated value for n! is {0}", n); //6. Convert the result to a string or can be automatically if using console.write to show on the screen.

            Console.ReadLine();
            
        }

      }
}
