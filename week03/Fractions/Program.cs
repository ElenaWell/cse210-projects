using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create fractions using all three constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // 2. Display the fractional and decimal representations
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // 3. Test getters
        Console.WriteLine("\nTesting Getters:");

        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());

        // 4. Test setters
        Console.WriteLine("\nTesting Setters:");

        fraction3.SetTop(6);
        fraction3.SetBottom(8);

        // 5. Retrieve updated values
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());

        // 6. Display updated representations
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}
