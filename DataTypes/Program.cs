using System;

class DataTypesDemo
{
    static void Main()
    {
        // Signed integral types
        Console.WriteLine("Signed integral types:");
        Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

        // Unsigned integral types
        Console.WriteLine("\nUnsigned integral types:");
        Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

        // Floating-point types
        Console.WriteLine("\nFloating-point types:");
        Console.WriteLine($"float : {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");

        // Decimal type
        Console.WriteLine("\nDecimal type:");
        Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

        // Boolean type
        Console.WriteLine("\nBoolean type:");
        Console.WriteLine($"bool : {bool.FalseString} to {bool.TrueString}");

        // Character type
        Console.WriteLine("\nCharacter type:");
        Console.WriteLine($"char : {(int)char.MinValue} to {(int)char.MaxValue}");

        // String type
        Console.WriteLine("\nString type:");
        string exampleString = "Hello, World!";
        Console.WriteLine($"string : An example string is \"{exampleString}\"");

        // DateTime type
        Console.WriteLine("\nDateTime type:");
        Console.WriteLine($"DateTime : {DateTime.MinValue} to {DateTime.MaxValue}");
    }
}

