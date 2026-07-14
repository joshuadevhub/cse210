using System;

class Program
{
  static void Main(string[] args)
  {
    Fraction fraction = new Fraction();
    Fraction fraction2 = new Fraction(6);
    Fraction fraction3 = new Fraction(6, 7);

    Console.WriteLine(fraction3.GetDecimalValue());
    // Console.WriteLine(fraction2);
    // Console.WriteLine(fraction3);

  }
}