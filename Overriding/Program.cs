using System;

class DiceRoller
{
    static void Main()
    {
        Random dice = new Random();
        
        // User input for number of rolls
        Console.Write("Enter the number of rolls: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numRolls) && numRolls > 0)
        {
            int[] rolls = new int[numRolls];
            int sum = 0;

            for (int i = 0; i < numRolls; i++)
            {
                // Roll the dice with different ranges
                if (i % 3 == 0)
                {
                    rolls[i] = dice.Next();
                }
                else if (i % 3 == 1)
                {
                    rolls[i] = dice.Next(101);
                }
                else
                {
                    rolls[i] = dice.Next(50, 101);
                }
                
                sum += rolls[i];
                Console.WriteLine($"Roll {i + 1}: {rolls[i]}");
            }

            // Calculate the average of the rolls
            double average = (double)sum / numRolls;
            Console.WriteLine($"Sum of rolls: {sum}");
            Console.WriteLine($"Average of rolls: {average:F2}");

            // Find the minimum and maximum roll values
            int minRoll = int.MaxValue;
            int maxRoll = int.MinValue;

            foreach (int roll in rolls)
            {
                if (roll < minRoll)
                {
                    minRoll = roll;
                }
                if (roll > maxRoll)
                {
                    maxRoll = roll;
                }
            }

            Console.WriteLine($"Minimum roll: {minRoll}");
            Console.WriteLine($"Maximum roll: {maxRoll}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer for the number of rolls.");
        }
    }
}

