using System;

class Testmain
{
    static void Main() //for compiler to start
    {
        //1. ask the user to input a number on the console

        Console.Write("Please type in a number for x: ");

        //2. read number form console

        string str;
        str = Console.ReadLine();

        //3. convert the number that is in string format into a numeric format

        int x = int.Parse(str);

        //4. Do the calculations for the formula 5*x*x + 6

        int iResult;
        iResult = (int)((5 * x * x) + 6);

        //5. Convert the result to a string or can be automatically if using console.write to show on the screen.

        Console.WriteLine("The calculated value for 5x^2+6 is {0}", iResult);

        Console.ReadLine();
    }
}