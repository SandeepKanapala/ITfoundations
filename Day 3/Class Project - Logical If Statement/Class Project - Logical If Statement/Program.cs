using System;

class TestIfClass
{
    static void Main()
    {
        int x = 5;
        int y = 2;

        if (x > 1 && y > 1) // && is AND statement
        {
            Console.WriteLine("x is greater than 1 AND y is greater than 1");
        }

        if (x > 5 || y < 4) // || is OR statement
        {
            Console.WriteLine("x is greater than 5 OR y is less than 4");
        }

        if ((x > 2 && y < 3) || x == 2) // combine AND / OR together
        {
            Console.WriteLine("(x is greater than 2 AND y is less than 3)");
            Console.WriteLine(" OR (x is equal to 2)");
        }
            Console.ReadLine();
    }
}