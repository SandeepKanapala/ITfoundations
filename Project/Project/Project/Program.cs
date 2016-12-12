// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{

    public enum Userinput
    {
        Add = 1,
        Change,
        Delete,
        List,
        Quit
    }
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory	
        var numberofitems = 0;

        // create an array of your ItemData struct

        var itemdata = new ItemData[10];

        // use a never ending loop that shows the user what options they can select 

        while (true)
        {
            Console.WriteLine("1) Add an item 2) Change an item 3) Delete an item 4) List all the items 5) Quit:");

            // as long as no one Quits, continue the inventory update

            // in that loop, show what user can select from the list

            // read the user's input and then create what case it falls
            string strx = Console.ReadLine();   // read user's input	

            int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below
            Userinput userInput = (Userinput) optx;
            Console.WriteLine(); // provide an extra blank line on screen        
            string strresp = "";
            switch (userInput)
            {
                case Userinput.Add: // add an item to the list if this option is selected
                    {

                        Console.WriteLine("ItemIDNo: ");
                        string itemidno = Console.ReadLine();
                        int ITEMIDNO = int.Parse(itemidno);
                        bool fFound = false;
                        for (int x = 0; x < numberofitems; x++)
                        {
                            if (itemdata[x].itemIDNo == ITEMIDNO)
                            {
                                fFound = true;
                                // code to show what has to happen if the item in the list is found
                                break;
                                // reset the count to show a new count for your list 
                                // (Note: your list is now increased by one item)
                            }
                        }

                        if (fFound) // if found
                        {
                            Console.WriteLine("Item with same id {0} already exists", ITEMIDNO);
                            break;
                        }

                        Console.WriteLine("sDescription: ");
                        string Description = Console.ReadLine();

                        Console.WriteLine("dblPricePerItem: ");
                        string dblpriceperitem = Console.ReadLine();
                        double PricePerItem = double.Parse(dblpriceperitem);


                        Console.WriteLine("iQuantityOnHand: ");
                        string iquantityonhand = Console.ReadLine();
                        int QuantityOnHand = int.Parse(iquantityonhand);


                        Console.WriteLine("dblOurCostPerItem: ");
                        string dblourcostperitem = Console.ReadLine();
                        double CostPerItem = double.Parse(dblourcostperitem);

                        Console.WriteLine("dblValueOfItem: ");
                        string dblvalueOfitem = Console.ReadLine();
                        double ValueOfItem = double.Parse(dblvalueOfitem);
                        

                        itemdata[numberofitems].itemIDNo = ITEMIDNO;
                        itemdata[numberofitems].sDescription = Description;
                        itemdata[numberofitems].dblPricePerItem = PricePerItem;
                        itemdata[numberofitems].iQuantityOnHand = QuantityOnHand;
                        itemdata[numberofitems].dblOurCostPerItem = CostPerItem;
                        itemdata[numberofitems].dblValueOfItem = ValueOfItem;


                        numberofitems++;
                        break;
                    }

                case Userinput.Change: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;
                        int x;
                        for (x = 0; x < numberofitems; x++)
                        {
                            if (itemdata[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                // code to show what has to happen if the item in the list is found
                                break;
                               
                            }
                        }

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        else
                        {
                            Console.WriteLine("ItemIDNo: " + itemdata[x].itemIDNo);
                            Console.WriteLine("Enter New Value");
                            string itemidno = Console.ReadLine();
                            int ITEMIDNO = int.Parse(itemidno);
                            bool idFound = false;
                            for (int y = 0; y < numberofitems; y++)
                            {
                                if (x == y)
                                {
                                    continue;
                                }
                                if (itemdata[y].itemIDNo == ITEMIDNO)
                                {
                                    idFound = true;
                                    // code to show what has to happen if the item in the list is found
                                    break;
                                    
                                }
                            }

                            if (idFound) // if found
                            {
                                Console.WriteLine("Item with same id {0} already exists", ITEMIDNO);
                                break;
                            }

                            Console.WriteLine("sDescription: " + itemdata[x].sDescription);
                            Console.WriteLine("Enter New Value");
                            string Description = Console.ReadLine();

                            Console.WriteLine("dblPricePerItem: " + itemdata[x].dblPricePerItem);
                            Console.WriteLine("Enter New Value");
                            string dblpriceperitem = Console.ReadLine();
                            double PricePerItem = double.Parse(dblpriceperitem);


                            Console.WriteLine("iQuantityOnHand: " + itemdata[x].iQuantityOnHand);
                            Console.WriteLine("Enter New Value");
                            string iquantityonhand = Console.ReadLine();
                            int QuantityOnHand = int.Parse(iquantityonhand);


                            Console.WriteLine("dblOurCostPerItem: " + itemdata[x].dblOurCostPerItem);
                            Console.WriteLine("Enter New Value");
                            string dblourcostperitem = Console.ReadLine();
                            double CostPerItem = double.Parse(dblourcostperitem);

                            Console.WriteLine("dblValueOfItem: " + itemdata[x].dblValueOfItem);
                            Console.WriteLine("Enter New Value");
                            string dblvalueOfitem = Console.ReadLine();
                            double ValueOfItem = double.Parse(dblvalueOfitem);


                            itemdata[x].itemIDNo = ITEMIDNO;
                            itemdata[x].sDescription = Description;
                            itemdata[x].dblPricePerItem = PricePerItem;
                            itemdata[x].iQuantityOnHand = QuantityOnHand;
                            itemdata[x].dblOurCostPerItem = CostPerItem;
                            itemdata[x].dblValueOfItem = ValueOfItem;
                        }

                        break;
                    }

                case Userinput.Delete: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        
                        for (int x = 0; x < numberofitems; x++)
                        {
                            if (itemdata[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                // delete the item if you found it
                                for (var y = x; y < numberofitems; y++)
                                {
                                    
                                    itemdata[y] = itemdata[y + 1];

                                }
                                // reset the count to show a new count for your list 
                                numberofitems--;
                                break;

                                //(Note: your list is now reduced by one item)								
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        break;
                    }

                case Userinput.List:  //list all items in current database if this option is selected
                    {
                        Console.WriteLine("ItemID \t"+  "Description \t"+  "Price \t"+ "QOH \t"+  "Cost \t"+  "Value");
                        Console.WriteLine("-----   ------------ ------ ---- -----  ----- ");

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        int index = 0;
                        foreach (var item in itemdata)
                        {
                            if (index == numberofitems)
                            {
                                break;
                            }
                            Console.WriteLine(item.itemIDNo + "\t" +
                                item.sDescription + "\t" +
                                item.dblPricePerItem + "\t" +
                                item.iQuantityOnHand + "\t" +
                                item.dblOurCostPerItem + "\t" +
                                item.dblValueOfItem);
                            index++;
                            
                        }

                            break;
                    }


                case Userinput.Quit: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        strresp = Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
            if(userInput == Userinput.Quit &&  strresp.ToLower() == "y")
            {
                break;
            }
        }
    }
}