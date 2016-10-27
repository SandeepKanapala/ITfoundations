using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Excersice___Identify_the_Name
{
    class ClassExcersice
    {
        static void Main()
        {
            Console.WriteLine("Enter a persons fullname:");
            string str = Console.ReadLine();

            str = str.ToUpper;

            if (str.EndsWith(" SMITH"));
            {
                Console.WriteLine("you have found smith!");
            }
            else
            {
                Console.WriteLine("You did not find smith");
            }
            Console.ReadLine();
        }
    }
}

