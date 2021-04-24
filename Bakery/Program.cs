using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
  
      Console.WriteLine("How much bread would you like to buy?");
      int breadInput = Convert.ToInt32(Console.ReadLine()); 
      Bread testBread = new Bread();
      Console.WriteLine(testBread.CalcBread(breadInput));
     }
  }
}