using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Switch
    {
        static void Main()
        {
            string strname;
            Console.Write("Please enter a month number (1 to 12): ");
            strname = Console.ReadLine();

            string month;
            int nDays = 0;

            switch (strname)
            {
                case "1":
                    month = "January";
                    nDays = 31;
                    break;

                case "2":
                    month = "Febuary";
                    nDays = 29;
                    break;

                case "3":
                    month = "March";
                    nDays = 31;
                    break;

                default:
                    month = "unknown";
                    nDays = -1;
                    break;

            }
            Console.WriteLine("The month {0} has {1} days", month, nDays);
            Console.ReadLine();
        }
    }
}
