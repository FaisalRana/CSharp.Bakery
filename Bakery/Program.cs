using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.BackgroundColor = ConsoleColor.Black;
      string bakeryAscii = @"
                          ....
                      .'      `.
                    .' .-'``-._ `.
                    |  / -    - ` |
                    / |'<o>  <o> | \
                    (|    '`    |) 
                      \  -==-  /   
                       `.____.'    
                        |    |     
                  _ _.'`-.__.-'`._/_
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
            ( Welcome to Faisal's Bakery! \  |  |-'
            )                             ) `--'
            (          _        _.---.__.-'
            `-.___.--' `------'

        ";
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine(bakeryAscii);
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.WriteLine("Please [y] to place your order, [m] to view the menu and [n] to exit");
      string  continueAnswer = Console.ReadLine().ToLower();
      if (continueAnswer == "y") {
        Console.WriteLine("How many loaves of bread would you like to purchase today?");
        string stringNumOfBread = Console.ReadLine(); 

        int numOfBread = 0;
        bool checkBreadInput = Int32.TryParse(stringNumOfBread, out numOfBread);
          if (checkBreadInput == true) {
            if (numOfBread >= 0 ) {
              Bread bread = new Bread();
              int breadPrice = bread.CalcBread(numOfBread);
              Console.WriteLine("You have bought " + numOfBread + " loaves of bread for: $" + breadPrice);
              Console.WriteLine("Would you like to buy some Pastry's today? [y] or [n]");
              string pastryAnswer = Console.ReadLine().ToLower();
                if (pastryAnswer == "y") {
                  Console.WriteLine("Please enter the amount of pastry's you would like to buy:");
                  string stringNumOfPastry = Console.ReadLine(); 
                  int numOfPastry = 0;
                  bool checkPastryInput = Int32.TryParse(stringNumOfPastry, out numOfPastry);
                  if (checkPastryInput == true) {
                    if (numOfPastry >= 0) {
                      Pastry pastry = new Pastry();
                      int pastryPrice = pastry.CalcPastry(numOfPastry);
                      Console.WriteLine("You have bought " + numOfPastry + " pastry's");
                      Console.BackgroundColor = ConsoleColor.Black;
                      Console.ForegroundColor = ConsoleColor.Green;
                      int total = breadPrice + pastryPrice;
                      Console.WriteLine("Your total bill is $" + total);
                      Console.ForegroundColor = ConsoleColor.Gray;
                      Console.WriteLine("Goodbye");
                    } else ErrorNegativeNumber(); 
                  } else Error();
                } 
                else if (pastryAnswer == "n") {
                    Console.WriteLine("Thank you for Coming in, your total bill is $" + breadPrice);
                    Console.WriteLine("Goodbye");
                  } else Error();
              } 
              else {   
              ErrorNegativeNumber();      
            } 
          } else Error();
      } else if (continueAnswer == "m") {
        Menu();
    } else if (continueAnswer == "n") {
      Console.WriteLine("Goodbye");
    } else {
      Error();
    }
}

    public static void Menu() {
      Console.WriteLine("--------------------------------");
      Console.ForegroundColor = ConsoleColor.Yellow;
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
        public static void Error() {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Error, Invalid Input");
          Console.WriteLine("Press Enter to Restart");
          Console.ReadLine();
          Main();
    }

        public static void ErrorNegativeNumber() {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Error, Invalid Input. Negative Input detected.  You owe us bread!");
          Console.WriteLine("Press Enter to Restart");
          Console.ReadLine();
          Main();
    }
    }
}




           