using System;

class Program
{
    static void Main()
    {
        // User input for array of pallets
        string[] pallets = GetPalletsFromUser();

        Console.WriteLine("\nOriginal Array:");
        PrintArray(pallets);

        // Sort the array
        Array.Sort(pallets);
        Console.WriteLine("\nSorted Array:");
        PrintArray(pallets);

        // Reverse the array
        Array.Reverse(pallets);
        Console.WriteLine("\nReversed Array:");
        PrintArray(pallets);
    }

    static string[] GetPalletsFromUser()
    {
        Console.WriteLine("Enter the number of pallets:");
        int count;
        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        string[] pallets = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter pallet #{i + 1}:");
            pallets[i] = Console.ReadLine();
        }

        return pallets;
    }

    static void PrintArray(string[] array)
    {
        foreach (string item in array)
        {
            Console.WriteLine($"-- {item ?? "null"}");  // Handle null values gracefully
        }
    }
}

