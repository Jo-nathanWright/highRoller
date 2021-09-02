﻿using System;
using System.Threading;

namespace highRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hi High Roller! Want to Roll the dice? Press Anykey to Continue, q to quit.");
      Console.Write("-");
      char response = Console.ReadKey().KeyChar;
      Console.Clear();
      bool rolling = true;
      while(rolling){
          if(response == 'q'){
          Console.WriteLine("Leaving So Soon?");
          rolling = false;
        } else {
            Console.WriteLine(@"First we need to know the dice your playing with.
    - How many Are You playing with?
    - How many sides do they have?
    - Whats your Dice Modifier?
    ");
      Console.Write("Total Dice: ");
      string totalString = Console.ReadLine();
      int total = Int32.Parse(totalString);

      Console.Write("Dice Sides: ");
      string sidesString = Console.ReadLine();
      int sides = Int32.Parse(sidesString);

      Console.Write("Total Modifier: ");
      string modString = Console.ReadLine();
      int mod = Int32.Parse(modString);
      Console.WriteLine("\n");

          Console.WriteLine("Rolling Dice.........");
          Thread.Sleep(5000);

          int totalRoll = 0;
      var Rand = new Random();
      for (int i = 0; i < total; i++)
      {
        int roll = Rand.Next(sides) + 1;
        Console.WriteLine("You rolled a " + roll);
        totalRoll += roll;
      }
      Console.WriteLine("\n");
      Console.WriteLine("This is the Total Roll: " + (totalRoll + mod));

        bool leaving = true;
        while (leaving){
            Console.WriteLine("Want To Roll Again? y/n");
            Console.Write("-");
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            if(answer == 'n'){
                Console.WriteLine("Thanks For Rolling With Us.");
                rolling = false;
                leaving = false;
            } else if(answer == 'y') {
                Console.WriteLine("Lets Roll Again Partner!");
                Console.Clear();
                leaving = false;
            } else {
                Console.WriteLine("Please Select A correct Key.");
                Console.Beep();
          }
        }
        }
      }
    }
    }
}
