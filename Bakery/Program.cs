using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Welcome to Brother Lasif's Bakery!");
      Console.WriteLine("Please press enter [m] for the menu, or [y] to continue your order.");
      Console.WriteLine("Please enter the amount of bread in loaves that you would like to buy:");
      int breadInput = Convert.ToInt32(Console.ReadLine()); 
      Bread testBread = new Bread();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You have bought " + breadInput + " loaves of bread");
      Console.WriteLine("You Owe $" + testBread.CalcBread(breadInput));
     }
  }
}