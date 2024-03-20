using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            // Console.WriteLine("Challenge 1: String and Number Processor");
            // StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"

            // Challenge 2: Object Swapper
            // Console.WriteLine("\nChallenge 2: Object Swapper");
            // int num1 = 25, num2 = 30;
            // int num3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";
                          
            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            // Uncomment to test the GuessingGame method
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            // Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            // string sentence = "This is the original sentence!";
            // string reversed = ReverseWords(sentence);
            // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
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
    }
}
