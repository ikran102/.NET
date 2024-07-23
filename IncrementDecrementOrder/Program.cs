using System;

class IncrementDecrementOrderDemo
{
    static void Main()
    {
        int value = 1;

        // Postfix Increment
        value++;
        Console.WriteLine("First Postfix Increment: " + value);

        // Display current value then Postfix Increment
        Console.WriteLine("Second Postfix Increment (before increment): " + value++);
        Console.WriteLine("Second Postfix Increment (after increment): " + value);

        // Prefix Increment
        Console.WriteLine("Third Prefix Increment: " + (++value));

        // Decrement examples for added originality
        Console.WriteLine("Decrement Operations:");

        // Postfix Decrement
        value--;
        Console.WriteLine("First Postfix Decrement: " + value);

        // Display current value then Postfix Decrement
        Console.WriteLine("Second Postfix Decrement (before decrement): " + value--);
        Console.WriteLine("Second Postfix Decrement (after decrement): " + value);

        // Prefix Decrement
        Console.WriteLine("Third Prefix Decrement: " + (--value));

        // Reset value to 1
        value = 1;
        Console.WriteLine("Reset Value: " + value);

        // Demonstrate multiple increments in sequence
        Console.WriteLine("Multiple Increments:");

        // Increment by 1 using prefix and postfix operators
        ++value;
        value++;
        Console.WriteLine("After multiple increments: " + value);

        // Increment by 3 using combined assignment operator
        value += 3;
        Console.WriteLine("Increment by 3 using combined assignment: " + value);

        // Reset value to 1 for decrement demonstration
        value = 1;
        Console.WriteLine("Reset Value: " + value);

        // Demonstrate multiple decrements in sequence
        Console.WriteLine("Multiple Decrements:");

        // Decrement by 1 using prefix and postfix operators
        --value;
        value--;
        Console.WriteLine("After multiple decrements: " + value);

        // Decrement by 2 using combined assignment operator
        value -= 2;
        Console.WriteLine("Decrement by 2 using combined assignment: " + value);
    }
}
