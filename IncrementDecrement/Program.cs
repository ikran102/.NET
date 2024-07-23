using System;

class IncrementDecrementDemo
{
    static void Main()
    {
        int value = 1;
        int initialValue = value;

        // Incrementing the value
        value = value + 1;
        Console.WriteLine("First Increment: " + value);

        value += 1;
        Console.WriteLine("Second Increment: " + value);

        value++;
        Console.WriteLine("Third Increment: " + value);

        // Decrementing the value
        value = value - 1;
        Console.WriteLine("First Decrement: " + value);

        value -= 1;
        Console.WriteLine("Second Decrement: " + value);

        value--;
        Console.WriteLine("Third Decrement: " + value);

        // Resetting the value to its initial state
        value = initialValue;
        Console.WriteLine("Value reset to initial state: " + value);

        // Adding an additional increment and decrement step for originality
        value = value + 5;
        Console.WriteLine("Additional Increment by 5: " + value);

        value = value - 3;
        Console.WriteLine("Additional Decrement by 3: " + value);
    }
}
