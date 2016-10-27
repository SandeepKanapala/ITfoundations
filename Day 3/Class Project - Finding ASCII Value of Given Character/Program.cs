using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project___Finding_ASCII_Value_of_Given_Character
{
    class FindingASCII
    {
        static void Main()
        {
            // ASk the user to enter a character
            Console.Write("Enter a character:");

            //Read and store the input from the user from the console.
            string str = Console.ReadLine(); // this will grab and store information as a string.
            
            //Make sure you grab the first character that they have entered (regardless of word or letter given)

            char mychar = str[0];

            //convert the the character into the a ascii number
            //going from 2 bytes to interger 4 bytes
            int myascii = (int)mychar;

            // Show the ASCII value 

            Console.WriteLine("ACSII value of {0} = {1}", mychar, myascii);

            Console.ReadLine(); // to hold the console to read the result from console.

        }
    }
}
