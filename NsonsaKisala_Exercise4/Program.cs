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
    }
}
