using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine("Welcome to Brother Lasif's Bakery!");
      string bakeryAscii = @"
                          ....
                      .'      `.
                    .' .-'``-._ `.
                    |  / -    - ` |
                    / |'<o>  <o> | \
                  | (|    '`    |) |
                  |   \  -==-  /   |
                  |    `.____.'    |
                  \     |    |     |
                  _\_.'`-.__.-'`._/_
                .'| |`-.  /\  .-'| |`.
              _.'   \ \  `'  `'  / /   `._
            { `.    | `-.____.-' |    .' }
            /`. `./ /   __  __   \ \.' .'\
            /   `.| |   /  \/  \   | |.'   \
          (    (  \ \  \      /  / /  )    )
            `.   \  Y|   `.  .'   |Y  /   .'
              \   \ ||_ _ _\/_ _ _|| /   /
              `.  \|'            `|/  .'
        _______/  _ >--------------< _  \______.##._
              ((((_(                )_))))   .##. |
            / ```` `--------------' ''''\   |  | |
            (                             \  |  |-'
            )                             ) `--'
            (          _        _.---.__.-'
            `-.___.--' `------'

        ";
      Console.WriteLine(bakeryAscii);
      Console.WriteLine("Please [y] to place your order, and [m] to view the menu");
      string  continueAnswer = Console.ReadLine().ToLower();
      if (continueAnswer == "y") {
          Console.WriteLine("How many loaves of bread would you like to purchase today?");
          int breadInput = Convert.ToInt32(Console.ReadLine()); 
            if (breadInput > 0 ) {
              Bread testBread = new Bread();
              int breadPrice = testBread.CalcBread(breadInput);
              Console.WriteLine("You have bought " + breadInput + " loaves of bread for: $" + breadPrice);
              Console.WriteLine("Would you like to buy some Pastry's today? [y] or [n]");
              string pastryAnswer = Console.ReadLine().ToLower();
              if (pastryAnswer == "y") {
                Console.WriteLine("Please enter the amount of pastry's you would like to buy:");
                int pastryInput = Convert.ToInt32(Console.ReadLine()); 
                  if (pastryInput >= 0) {
                    Pastry testPastry = new Pastry();
                    int pastryPrice = testPastry.CalcPastry(pastryInput);
                    Console.WriteLine("You have bought " + pastryInput + " pastry's");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your total bill is $" + breadPrice + pastryPrice);
                } 
                  else {            
                  negativeNumberError();    
                } 

                  } 
                  else if (pastryAnswer == "n") {
                    Console.WriteLine("Thank you for Coming in, your total bill is $" + breadPrice);
                    Console.WriteLine("Goodbye");
                  }
  
            } else {   
              negativeNumberError();      
            }
      } else if (continueAnswer == "m") {
        Menu();
    };
}

    public static void Menu() {
      Console.WriteLine("--------------------------------");
        string menu = @"Fresh Bread: $5 each (loaf)
        Delicious Pastry: $2 each

        ** Special of the week **
        Bread: Buy 2, get 1 free!
        Pastry: 3 for $5!";
        Console.WriteLine(menu);
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Press enter to continue");
        string menuAnswer = Console.ReadLine();
        Main();
    }
        public static void negativeNumberError() {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Error, please try again and enter a number greater than 0");
          Console.ReadLine();
          Main();
    }
    }
}




           