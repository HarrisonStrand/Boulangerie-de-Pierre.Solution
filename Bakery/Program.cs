using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥");
      Console.WriteLine("           Welcome to Boulangerie de Pierre!           ");
      Console.WriteLine("≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥≤≥");
      Console.WriteLine("         We have two deals going on right now:");
      Console.WriteLine("              Bread is 'Buy 2 get 1 FREE!");
      Console.WriteLine("        Pastries are 'Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("_______________________________________________________");
      Console.WriteLine("                Normal Price of Bread: $5");
      Console.WriteLine("              Normal Price of Pastries: $2");
      Console.WriteLine("_______________________________________________________");
      Console.WriteLine("                 START YOUR ORDER BELOW!");
      Console.WriteLine("_______________________________________________________");
      Console.WriteLine(" 1. View Order       2.Add to Order       3.See Total");
      string userInput1 = Console.ReadLine();
      if (userInput1 == "1")
      {
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("        Here is your Itemized order so far:");
        Console.WriteLine("_______________________________________________________");
        List<Bread> BreadResult = Bread.GetAll();
        Bread.GetAll().ForEach(i => Console.WriteLine(i.BreadDescription + " $" + i.BreadPrice));
        List<Pastry> pastryResult = Pastry.GetAll();
        Pastry.GetAll().ForEach(i => Console.WriteLine(i.PastryDescription + " $" + i.PastryPrice));
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("                 Would you like to do?");
        Console.WriteLine("  1. Clear Order                         2. Main Menu");
        Console.WriteLine("_______________________________________________________");
        string userInput2 = Console.ReadLine();
        if(userInput2 == "1")
        {
        Console.WriteLine("                 Your Order is Cleared");
        Bread.ClearAll();
        Pastry.ClearAll();
        Program.Main();
        }
        else if (userInput2 == "2")
        {
        Program.Main();
        }
        else
        {
          Console.WriteLine("Program Terminated. Please use the command 'dotnet run' to begin... again.");
        }
      }
      else if (userInput1 == "2")
      {
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("       What would you like to add to your order?");     
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("       1. Bread                        2. Pastry");
        Console.WriteLine("_______________________________________________________");
        string userInput3 = Console.ReadLine();
        if (userInput3 == "1")
        {
          Console.WriteLine("_______________________________________________________");
          Console.WriteLine("      How many Bread loafs would you like to add?");
          Console.WriteLine("_______________________________________________________");
          int userAmount1 = int.Parse(Console.ReadLine());
          Bread.GetPriceBread(userAmount1);
          Console.WriteLine("_______________________________________________________");
          Console.WriteLine("               Bread added to order"); 
          Console.WriteLine("_______________________________________________________");
          Program.Main();
        }
        else if (userInput3 == "2")
        {
          Console.WriteLine("_______________________________________________________");
          Console.WriteLine("      How many Pastries would you like to add?");
          Console.WriteLine("_______________________________________________________");
          int userAmount2 = int.Parse(Console.ReadLine());
          Pastry.GetPricePastry(userAmount2);
          Console.WriteLine("_______________________________________________________");
          Console.WriteLine("               Pastries added to order"); 
          Console.WriteLine("_______________________________________________________");
          Program.Main();
        }
        else
        {
          Console.WriteLine("Program Terminated. Please use the command 'dotnet run' to begin... again.");
        }
      }
      else if (userInput1 == "3")
      {
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("                 Here Is your Order:");
        Console.WriteLine("_______________________________________________________");
        int BreadTotal = 0;
        Bread.GetAll().ForEach(i => BreadTotal += i.BreadPrice);
        Console.WriteLine("Bread: $" + BreadTotal);
        int PastryTotal = 0;
        Pastry.GetAll().ForEach(i => PastryTotal += i.PastryPrice);
        Console.WriteLine("Pastry: $" + PastryTotal);
        int GrandTotal = BreadTotal + PastryTotal;
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("       Your Order Total is: " + "$" + GrandTotal);
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("        Press any key to go back to main Menu");
        Console.WriteLine("_______________________________________________________");
        Console.ReadLine();
        Program.Main();
      }
      else
      {
        Console.WriteLine("Please choose an option from the numerical list");
        Console.WriteLine("Program is terminated, please use the command 'dotnet run' to start");
      }
    }
  }
}
