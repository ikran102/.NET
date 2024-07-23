using System;

class DiceGame
{
    static void Main()
    {
        Random dice = new Random();
        
        // User input for number of dice rolls
        Console.Write("Enter the number of dice rolls: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numRolls) && numRolls > 0)
        {
            int[] rolls = new int[numRolls];
            int total = 0;

            // Roll the dice and calculate the total
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = dice.Next(1, 7);
                total += rolls[i];
            }

            Console.WriteLine($"Dice rolls: {string.Join(" + ", rolls)}");

            // Check for triples
            bool isTriple = true;
            for (int i = 1; i < numRolls; i++)
            {
                if (rolls[i] != rolls[0])
                {
                    isTriple = false;
                    break;
                }
            }

            // Check for doubles
            bool isDouble = false;
            for (int i = 0; i < numRolls; i++)
            {
                for (int j = i + 1; j < numRolls; j++)
                {
                    if (rolls[i] == rolls[j])
                    {
                        isDouble = true;
                        break;
                    }
                }
                if (isDouble)
                    break;
            }

            if (isTriple)
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else if (isDouble)
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            Console.WriteLine($"Total score: {total}");

            // Determine win/loss based on different thresholds
            if (total >= numRolls * 4)
            {
                Console.WriteLine("You win with a high score!");
            }
            else if (total >= numRolls * 3)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer for the number of dice rolls.");
        }
    }
}
