using System;

namespace ConsoleApplication1
{
    // defining a structure with variables.
    public struct Pet
    {
        public string Name;
        public string TypeOfPet;
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0; // defined a varriable numberOfPets and initialzed with 0.
            var pets = new Pet[10]; //new array of 10 pets.

            while (true) // a while condition repeatedly exectues until the specified expression evaluates to false.
            {
                Console.Write("A)dd D)elete L)ist pets:"); // writes to the console for input from user.
                var choice = Console.ReadLine(); // reads the input from the user given in the console and stores it into choice.

                switch (choice) // Switch statement to check the input (choice) from the user and executes the appropriate case to reply back to the user.
                {
                    case "A": // a case to add the name and type of pet.
                    case "a":
                        {
                            Console.Write("Name :"); // If the user choice is A, this case is executed and Name given to the user onto the console to input data.
                            var name = Console.ReadLine(); //reads the input from the user given in the console and stores it into name.

                            Console.Write("Type of pet :"); // then Type of pet is given to the user onto the console to input data.
                            var typeOfPet = Console.ReadLine(); //reads the input from the user given in the console and stores it into typeofPet.

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name; // the data (Name and Typeofpet) is pushed into the array.
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            numberOfPets++; // number of pets is increamented by 1 and user is propmpted to input the choice again.
                            break;
                        }

                    case "D": // a case to delete the name and type of pet.
                    case "d":
                        {
                            if (numberOfPets == 0) // count of number of pets is compared to 0 and if it is true the block of code (in the loop statement) is executed.
                            {
                                Console.WriteLine("No pets"); // Asks the user to give the number of the pet to be deleted.
                                break;
                            }

                            for (var index = 0; index < numberOfPets; index++) // for loop executes repeatedly checking for numberOfPets (total number of pets entered with name and type) less than index
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); // displays the list of the pets with serial number 1. 2. etc amking it easier for the user to delete a pet.
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); // asks the user which pet to be deleted from the list displayed above.

                            var petNumberToDelete = Console.ReadLine(); //reads the input from the console given by the user and stores it into petNumberToDelete.
                            var indexToDelete = int.Parse(petNumberToDelete); // implicit conversion of var to int

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;

                            break;
                        }

                    case "L": // a case to list the name and type of pet.
                    case "l":
                        {
                            if (numberOfPets == 0) // count of number of pets is compared to 0 and if it is true the block of code (in the loop statement) is executed.
                            {
                                Console.WriteLine("No pets"); //if true (no pet names or type added by the user) this block of code is executed and user is promped with No pets
                            }

                            for (int index = 0; index < numberOfPets; index++) // for loop executes repeatedly checking for numberOfPets (total number of pets entered with name and type) less than index
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); // displays the list of the pets with serial number 1. 2. etc amking it easier for the user to delete a pet.
                            }

                            break;
                        }
                    default: // default case that will prompt the user when incorrect given is made by the use in the console.
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); // writes back to the user as Invalid option 
                            break;
                        }
                }
            }
        }
    }
}