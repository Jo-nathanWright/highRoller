using System;

namespace highRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hi High Roller! Want to Roll the dice?");
            Console.WriteLine(@"
First we need to know the dice your playing with.
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

      int totalRoll = 0;
      var Rand = new Random();
      for (int i = 0; i < total-1; i++)
      {
        int roll = Rand.Next(sides) + 1;
        Console.WriteLine("You rolled a " + roll);
        totalRoll += roll;
      }
      Console.WriteLine("\n");
      Console.WriteLine("This is the Total Roll: " + (totalRoll + mod));
    }
    }
}
