namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.

            Console.WriteLine("Please enter person's name: ");
            string personName = Console.ReadLine();

            // TODO 2: Validate if the person already exists in the personList.

            if(personList.Contains(personName))
            {
                Console.WriteLine("The name you entered is already exists");
            }
            // TODO 3: Add the person to the personList if they don't already exist.

            else
            {
                personList.Add(personName);

                // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.

                Console.WriteLine(personName + " is added successfully");
            }
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.


            if (!personAgeDictionary.ContainsKey(personName))
            {
                Console.WriteLine("Please enter the age for " + personName);

                int personAge = Convert.ToInt32(Console.ReadLine());
                personAgeDictionary.Add(personName, personAge);
                Console.WriteLine("Age is added successfully");
            }
            else
            {
                Console.WriteLine("Age already exists in the dictionary");
            }
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.

            Console.WriteLine("Please enter a name to remove: ");
            string nameToRemove = Console.ReadLine();

            // TODO 9: Remove the person from personList if they exist.

            if (personList.Contains(nameToRemove))
            {
                personList.Remove(nameToRemove);
                Console.WriteLine(nameToRemove + " is removed successfully");
            }
            else
            {
                Console.WriteLine(nameToRemove + " doesn't exist");
            }
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            if (personAgeDictionary.ContainsKey(nameToRemove))
            {
                personAgeDictionary.Remove(nameToRemove);
                Console.WriteLine(nameToRemove + "age is also removed");
            }
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.\

            else
            {
                Console.WriteLine(nameToRemove + " doesn't exist");
            }
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            Console.WriteLine("Please enter a name to find: ");
            string nameToFind = Console.ReadLine();

            if (personList.Contains(nameToFind))
            {
                Console.WriteLine(nameToFind + " is in the list");
            }
            else
            {
                Console.WriteLine(nameToFind + " doesn't exist in the list");
            }

            if (personAgeDictionary.ContainsKey(nameToFind))
            {
                Console.WriteLine(nameToFind + "'s age is " + personAgeDictionary[nameToFind]);
            }
            else
            {
                Console.WriteLine(nameToFind + "'s age is not available");
            }

        }

        public static void DisplayAllPersons()
        
        {
            // TODO 16: Iterate over personList and display each person's name.
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.

            if (personList.Count > 0)
            {
                foreach (string person in personList)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }

            if (personAgeDictionary.Count > 0)
            {
                foreach (var entry in personAgeDictionary)
                {
                    Console.WriteLine($"{entry.Key} - Age: {entry.Value}");
                }
            }
            else
            {
                Console.WriteLine("Age dictionary is empty");
            }

        }
    }
}
