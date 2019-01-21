using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsonsaKisala_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clear console
            Console.Clear();

            // Opening Statement
            Console.WriteLine("What is your favorite color? \n" +
                "Type a number corresponded to its associated color to learn more about it.");

            
            string colorList = "---------- \n" +
                "1 - Red \n" +
                "2 - Orange \n" +
                "3 - Yellow \n" +
                "4 - Green \n" +
                "5 - Blue \n" +
                "6 - Indigo \n" +
                "7 - Violet \n" +
                "8 - Exit \n" +
                "----------";
            // Red Dictionary
            Dictionary<int, string> redDict = new Dictionary<int, string>();
            redDict.Add(0, "Fact 1");
            redDict.Add(1, "Fact 2");
            redDict.Add(2, "Fact 3");

            // Orange Dictionary
            Dictionary<int, string> orangeDict = new Dictionary<int, string>();
            orangeDict.Add(0, "Fact 1");
            orangeDict.Add(1, "Fact 2");
            orangeDict.Add(2, "Fact 3");

            // Yellow Dictionary
            Dictionary<int, string> yellowDict = new Dictionary<int, string>();
            yellowDict.Add(0, "Fact 1");
            yellowDict.Add(1, "Fact 2");
            yellowDict.Add(2, "Fact 3");

            // Green Dictionary
            Dictionary<int, string> greenDict = new Dictionary<int, string>();
            greenDict.Add(0, "Fact 1");
            greenDict.Add(1, "Fact 2");
            greenDict.Add(2, "Fact 3");

            // Blue Dictionary
            Dictionary<int, string> blueDict = new Dictionary<int, string>();
            blueDict.Add(0, "Fact 1");
            blueDict.Add(1, "Fact 2");
            blueDict.Add(2, "Fact 3");

            // Indigo Dictionary
            Dictionary<int, string> indigoDict = new Dictionary<int, string>();
            indigoDict.Add(0, "Fact 1");
            indigoDict.Add(1, "Fact 2");
            indigoDict.Add(2, "Fact 3");

            // Violet Dictionary
            Dictionary<int, string> violetDict = new Dictionary<int, string>();
            violetDict.Add(0, "Fact 1");
            violetDict.Add(1, "Fact 2");
            violetDict.Add(2, "Fact 3");

            // Form while loop
            bool isRunning = true;
            while (isRunning)
            {
                // Prompt colorList
                Console.WriteLine(colorList);
                
                // Get userInput
                string userInput = Console.ReadLine();
                Console.WriteLine();

                // convert userInput into an int
                // valdate there input to make sure it's an int
                int userNum;

                while (!int.TryParse(userInput, out userNum))
                {
                    Console.WriteLine("Please input a valid integer");
                }

                //Switch statement based on userInput
                switch (userNum)
                {
                    case 1:
                        Console.WriteLine("Red");
                        FactRandomizer(redDict);
                        break;
                    case 2:
                        Console.WriteLine("Orange");
                        break;
                    case 3:
                        Console.WriteLine("Yellow");
                        break;
                    case 4:
                        Console.WriteLine("Green");
                        break;
                    case 5:
                        Console.WriteLine("Blue");
                        break;
                    case 6:
                        Console.WriteLine("Indigo");
                        break;
                    case 7:
                        Console.WriteLine("Violet");
                        break;
                    case 8:
                        Console.Write("Are you sure you want to exit? Y or N: ");
                        string userExitChoice = Console.ReadLine().ToLower();

                        switch (userExitChoice)
                        {
                            case "y":
                                isRunning = false;
                                Console.Clear();
                                break;

                            case "n":
                                isRunning = true;
                                break;
                            default:
                                Console.WriteLine("Please type either \'Y\' or \'N\'");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Please input a valid integer");
                        break;
                }
                
            }
        }

        //Method to randomize the color facts
        public static void FactRandomizer(Dictionary<int, string> dict)
        {
            // Get the keys of the dictionary and put it into a list
            List<int> keyList = new List<int>(dict.Keys);

            Random rand = new Random();

            // Get length of new key list
            int length = keyList.Count;

            //create a random number based off the length of the key list
            int randomKey = keyList[rand.Next(length)];

            // print back to console
            Console.WriteLine(dict[randomKey]); 
        }
    }
}
