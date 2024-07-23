using System;

class ArrayChallenge
{
    static void Main()
    {
        // Initial array challenge
        string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        Console.WriteLine("Order IDs starting with 'B':");
        foreach (string item in orderIds)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }

        // Another array challenge with user input
        Console.Write("Enter the number of random OrderIDs to generate: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfOrderIDs) && numberOfOrderIDs > 0)
        {
            Random random = new Random();
            string[] orderIDs = new string[numberOfOrderIDs];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70); // ASCII values for A to E
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");

                orderIDs[i] = prefix + suffix;
            }

            Console.WriteLine("Generated Order IDs:");
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            // Categorize Order IDs
            Console.WriteLine("\nCategorized Order IDs:");
            foreach (char prefix in new char[] { 'A', 'B', 'C', 'D', 'E' })
            {
                Console.WriteLine($"Order IDs starting with '{prefix}':");
                foreach (var orderID in orderIDs)
                {
                    if (orderID.StartsWith(prefix))
                    {
                        Console.WriteLine(orderID);
                    }
                }
            }

            // Filter specific Order IDs based on user input
            Console.Write("\nEnter a prefix to filter Order IDs: ");
            string userPrefix = Console.ReadLine().ToUpper();
            if (!string.IsNullOrEmpty(userPrefix) && userPrefix.Length == 1 && userPrefix[0] >= 'A' && userPrefix[0] <= 'E')
            {
                Console.WriteLine($"Order IDs starting with '{userPrefix}':");
                foreach (var orderID in orderIDs)
                {
                    if (orderID.StartsWith(userPrefix))
                    {
                        Console.WriteLine(orderID);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid prefix entered.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}

