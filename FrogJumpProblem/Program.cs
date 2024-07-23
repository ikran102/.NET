using System;

class Program
{
    static void Main()
    {
        // Test cases
        Console.WriteLine("Example 1: " + CalculateJumps(10, 85, 30)); // Expected: 3
        Console.WriteLine("Example 2: " + CalculateJumps(1, 100, 10)); // Expected: 10
        Console.WriteLine("Example 3: " + CalculateJumps(100, 100, 10)); // Expected: 0
    }

    static int CalculateJumps(int X, int Y, int D)
    {
        // Input validation
        if (X < 0 || Y < 0 || D <= 0)
        {
            throw new ArgumentException("X and Y should be non-negative, and D should be positive.");
        }

        if (X >= Y)
        {
            Console.WriteLine("Starting point is already beyond or at the target point.");
            return 0;
        }

        int jumpProgress = X;
        int count = 0;

        // Calculate the number of jumps needed
        while (jumpProgress < Y)
        {
            jumpProgress += D;
            count++;
            Console.WriteLine($"Jump {count}: Position {jumpProgress}"); // Debug information
        }

        return count;
    }
}
