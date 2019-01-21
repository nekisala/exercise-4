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
            redDict.Add(0, "Seeing the color red can make your heart beat faster.");
            redDict.Add(1, "As few as 2% of people in the US have red hair.");
            redDict.Add(2, "Chinese brides traditionally wear red dresses to symbolize; happiness, prosperity, and good luck.");

            // Orange Dictionary
            Dictionary<int, string> orangeDict = new Dictionary<int, string>();
            orangeDict.Add(0, "Orange is the only color whose name was taken from an object... the orange.");
            orangeDict.Add(1, "Orange is associated with vitamin C and good health.");
            orangeDict.Add(2, "Orange is the color of the Dutch royal family.");

            // Yellow Dictionary
            Dictionary<int, string> yellowDict = new Dictionary<int, string>();
            yellowDict.Add(0, "In Japan, yellow is the color of courage.");
            yellowDict.Add(1, "In the US, turning yellow is slang for being cowardly ");
            yellowDict.Add(2, "Yellow is known to have a positive effect on the mind when studying.");

            // Green Dictionary
            Dictionary<int, string> greenDict = new Dictionary<int, string>();
            greenDict.Add(0, "Night vision goggles use green because the human eye is most sensitive and can distinguish various shades in that color. ");
            greenDict.Add(1, "Green is the color of love, associated with Venus.");
            greenDict.Add(2, "Green is the 2nd most popular favorite color, after blue.");

            // Blue Dictionary
            Dictionary<int, string> blueDict = new Dictionary<int, string>();
            blueDict.Add(0, "In ancient Rome, people who had blue eyes were considered to have bad character or a physical deformity.");
            blueDict.Add(1, "Blue was the symbolic color of the French Revolution, but France had trouble maintaining a large enough supply of indigo dye to keep its military dressed in blue.");
            blueDict.Add(2, "Blue can help you stay physically calmer, regulating heart beat and breathing in studies of video gamers.");

            // Indigo Dictionary
            Dictionary<int, string> indigoDict = new Dictionary<int, string>();
            indigoDict.Add(0, "Ripining bananas glow a bright indigo under a black light.");
            indigoDict.Add(1, "Indigo resides at 270 degrees between purple and blue on the color wheel.");
            indigoDict.Add(2, "The color indigo is named after the indigo dye derived from the plant \"Indigofera tinctoria\".");

            // Violet Dictionary
            Dictionary<int, string> violetDict = new Dictionary<int, string>();
            violetDict.Add(0, "Violet is the color at the end of the visible spectrum of light between blue and the invisible ultraviolet.");
            violetDict.Add(1, "Not Exactly violet, but the color purple is specifically associated with royalty and nobility as it was an expensive dye and very hard to come by.");
            violetDict.Add(2, "The color's name is derived from the violet flower.");

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
                        FactRandomizer(orangeDict);
                        break;
                    case 3:
                        Console.WriteLine("Yellow");
                        FactRandomizer(yellowDict);
                        break;
                    case 4:
                        Console.WriteLine("Green");
                        FactRandomizer(greenDict);
                        break;
                    case 5:
                        Console.WriteLine("Blue");
                        FactRandomizer(blueDict);
                        break;
                    case 6:
                        Console.WriteLine("Indigo");
                        FactRandomizer(indigoDict);
                        break;
                    case 7:
                        Console.WriteLine("Violet");
                        FactRandomizer(violetDict);
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
                        userInput = Console.ReadLine();
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

        //Method to color text
        public static void Colorizer(Dictionary<int, string> dict)
        {
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine();
            }
        }
    }
}
