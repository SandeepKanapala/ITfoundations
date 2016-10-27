using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project___If_Statement
{
    class TestIfClass
    {
        static void Main()
        {
            int x = 5;
            int y = 2;

            if (x == y)//equal
            {
                Console.WriteLine("x is equal to y");
            }

            if (x != y)//not equal to
            {
                Console.WriteLine("x is not equal to y");
            }

            if (x > 5)//greater
            {
                Console.WriteLine("x is greater than 5");
            }

            if (x >= 5)//greater than and equal to
            {
                Console.WriteLine("x is greater than or equal to 5");
            }

            if (y < 2)//less than
            {
                Console.WriteLine("y is less than 2");
            }

            if (y <= 2)//less than or equal to
            {
                Console.WriteLine("y is less than or equal to 2");
            }
            Console.ReadLine();
        }
    }
}
