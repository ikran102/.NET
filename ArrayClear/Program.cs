using System;

class Program
{
    static void Main()
    {
        // Initial array of pallets
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Original Array:");
        PrintArray(pallets);

        // Clear part of the array
        Console.WriteLine("\nClearing first 2 elements of the array...");
        Array.Clear(pallets, 0, 2);

        // Display results after clearing
        Console.WriteLine("\nArray After Clearing First 2 Elements:");
        PrintArray(pallets);
    }

    // Method to print the contents of the array
    static void PrintArray(string[] array)
    {
        foreach (string item in array)
        {
            Console.WriteLine($"-- {item ?? "null"}");  // Display "null" for cleared elements
        }
    }
}
