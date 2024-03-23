using System;
using Microsoft.VisualBasic;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"

            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";
                          
            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(ref str3, ref str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types
            Console.WriteLine($"\nSwap:");
            
            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            // // Uncomment to test the GuessingGame method
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"

        }

        public static void StringNumberProcessor(params dynamic[] listItems) {
            try
            {
                if (listItems.Length < 2)
                {
                    throw new ArgumentException();
                }
                int total = 0;
                string concatenateText = " ";
                foreach (var item in listItems)
                {
                    switch (item)
                    {
                    case int:
                        total += item;
                        break;
                    case string:
                        concatenateText = concatenateText + " " + item;
                        break;
                    default:
                        throw new InvalidDataException();
                    }
                }
                if (total == 0 || concatenateText.Length == 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine($"{concatenateText}; {total}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error: The total is 0 or no text or the length of array is less than 2");
            }
            catch (InvalidDataException)
            {
                Console.WriteLine($"Error: Unknown data type");
            }
        }

        public static void SwapObjects(ref int num, ref int num2){
            try
            {
                int temp;
            if (num > 18 && num2 > 18)
            {
                temp = num;
                num = num2;
                num2 = temp;
            } else {
                throw new ArgumentException();
            }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error: Value must be more than 18");
            }
        }

        public static void SwapObjects(ref string str, ref string str2){
            try
            {
                string temp;
            if (str.Length > 5 && str2.Length > 5)
            {
                temp = str;
                str = str2;
                str2 = temp;
            } else
            {
                throw new ArgumentException(); 
            }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error: Length must be more than 5");
            }
        }

        public static void GuessingGame() {
            Console.WriteLine($"Guess a number between 1 and 10, or type Quit to exit from the game.");
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            try
            {
            while (true)
            {
                string input = Console.ReadLine() ?? "";
                string[] parts = input.Split(" ");
                
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine($"Game Over");
                    break;
                }

                if (parts.Length != 1)
                {
                    Console.WriteLine($"Invalid input please try again...");
                    continue;
                } 
                
                if (!int.TryParse(parts[0], out int guessedNumber))
                {
                    Console.WriteLine($"Invalid input type, Please enter a numeric value");
                    continue;
                }

                if (randomNumber == guessedNumber)
                {
                    Console.WriteLine($"Your guess is {guessedNumber} and it is correct.");
                    break;
                } else
                {
                    Console.WriteLine($"Wrong guess try again");
                    
                }
            }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        public static string ReverseWords(string sentence) {
            try
            {
                if (string.IsNullOrWhiteSpace(sentence) || sentence.Length == 1)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    string[] parts = sentence.Split(" ");
                    string reversedStr = string.Join(" ", parts
                    .Select(word => new string(word.Reverse().ToArray())));

                    return reversedStr;   
                }
            }
            catch (ArgumentNullException)
            {
                return $"Argument is null or empty or it have 1 character";
            } 
        }
    }
}
