using System;
using System.Threading;

namespace highRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string intro = "Hi High Roller! Want to Roll the dice? Press Anykey to Continue, q to quit.";
            foreach (char c  in intro)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
      char response = Console.ReadKey().KeyChar;
      Console.Clear();
      bool rolling = true;
          if(response == 'q'){
          string quit = "Leaving So Soon?";
          foreach (char c  in quit)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
          rolling = false;
        } else {
            string info = @"First we need to know the dice your playing with.
    - How many Are You playing with?
    - How many sides do they have?
    - Whats your Dice Modifier?";
            foreach (char c  in info)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine("\n");
        while(rolling){
      string TotalDice = "Total Dice: ";
            foreach (char c  in TotalDice)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
      string totalString = Console.ReadLine();
      int total = Int32.Parse(totalString);

          string DiceSides = "Dice Sides: ";
          foreach (char c  in DiceSides)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
          string sidesString = Console.ReadLine();
      int sides = Int32.Parse(sidesString);

      string TotalMod =  "Total Modifier: ";
      foreach (char c  in TotalMod)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
      string modString = Console.ReadLine();
      int mod = Int32.Parse(modString);
      Console.WriteLine("\n");

          string rollingDice = "Rolling Dice";
          foreach (char c  in rollingDice)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
          string dots = ".....";
          foreach (char c  in dots)
          {
            Console.Write(c);
            Thread.Sleep(1000);
          }
          Console.WriteLine("\n");

          int totalRoll = 0;
      var Rand = new Random();
      for (int i = 0; i < total; i++)
      {
        int roll = Rand.Next(sides) + 1;
            totalRoll += roll;
          }
          Console.WriteLine("\n");
          int finalTotal = totalRoll + mod;
          string finalResult = "This is the Total Roll: " + (finalTotal);
      foreach (char c  in finalResult)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
          Console.WriteLine("\n");

        bool leaving = true;
        while (leaving){
            string question = "Want To Roll Again? y/n";
            foreach (char c  in question)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine("");
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            if(answer == 'n'){
                string n = "Thanks For Rolling With Us.";
                foreach (char c  in n)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
                rolling = false;
                leaving = false;
            } else if(answer == 'y') {
                string y = "Lets Roll Again Partner!";
                foreach (char c  in y)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
                Console.Clear();
                leaving = false;
            } else {
                string tryAgain = "Please Select A correct Key.";
                foreach (char c  in tryAgain)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
              Console.WriteLine("\n");
              Console.Beep();
          }
        }
        }
      }
    }
    }
}
