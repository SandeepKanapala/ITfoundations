using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Factorial
{
    static void Main()
    {

        Console.WriteLine("Please type in an integer: "); //1. ask the user to input a number on the console

        string str; // 2. Store the integer given from the console to a string.

        str = Console.ReadLine(); //3. Read the line from console.

        int n = int.Parse(str); //4. Convert the string to a interger.

       int factorial = 1; //5. Do the calculations for n! (n factorial). 
      
      for (int x = 1; x <= n; x++)
       {
            factorial = x * factorial;
            
            Console.WriteLine("{0}! = {1}", x, factorial); //6. Convert the result to a string or can be automatically if using console.write to show on the screen.

        }

        Console.ReadLine(); 
    }

}
