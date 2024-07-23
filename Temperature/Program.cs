using System;

class TemperatureConverter
{
    static void Main()
    {
        // Prompt user to enter a temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        string input = Console.ReadLine();
        
        // Try to parse the input to an integer
        if (int.TryParse(input, out int fahrenheit))
        {
            // Convert Fahrenheit to Celsius
            decimal temperature = (fahrenheit - 32m) * 5m / 9m;
            Console.WriteLine("The temperature is " + temperature + " degrees Celsius");
            
            // Round the Celsius temperature
            decimal roundedTemperature = Math.Round(temperature, 2);
            Console.WriteLine("The rounded temperature is " + roundedTemperature + " degrees Celsius");

            // Compare with a predefined temperature value (e.g., boiling point of water)
            decimal boilingPointCelsius = 100m;
            if (roundedTemperature > boilingPointCelsius)
            {
                Console.WriteLine("The temperature is above the boiling point of water.");
            }
            else if (roundedTemperature == boilingPointCelsius)
            {
                Console.WriteLine("The temperature is at the boiling point of water.");
            }
            else
            {
                Console.WriteLine("The temperature is below the boiling point of water.");
            }

            // Provide additional information
            decimal freezingPointCelsius = 0m;
            if (roundedTemperature > freezingPointCelsius)
            {
                Console.WriteLine("The temperature is above the freezing point of water.");
            }
            else if (roundedTemperature == freezingPointCelsius)
            {
                Console.WriteLine("The temperature is at the freezing point of water.");
            }
            else
            {
                Console.WriteLine("The temperature is below the freezing point of water.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the temperature in Fahrenheit.");
        }
    }
}
