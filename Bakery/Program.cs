using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Boulangerie de Pierre!");
      Console.WriteLine("1. View Order       2.Add to Order       3.See Total");
      string userInput1 = Console.ReadLine();
      if (userInput1 == "1")
      {
        List<Bread> BreadResult = Bread.GetAll();
        Bread.GetAll().ForEach(i => Console.WriteLine(i.BreadDescription + " $" + i.BreadPrice));
        List<Pastry> pastryResult = Pastry.GetAll();
        Pastry.GetAll().ForEach(i => Console.WriteLine(i.PastryDescription + " $" + i.PastryPrice));
        Program.Main();
      }
      else if (userInput1 == "2")
      {
        Console.WriteLine("What would you like to add to your order?");
        Console.WriteLine("      1. Bread             2. Pastry");
        string userInput2 = Console.ReadLine();
        if (userInput2 == "1")
        {
          Console.WriteLine("How many Bread loafs would you like to add to your order?");
          int userAmount = int.Parse(Console.ReadLine());
          for(int i = 1; i <= userAmount; i++)
          {
            if(i % 3 == 0)
            {
            Bread newBreadAmount = new Bread("Bread (deal)", 0);
            }
            else 
            {
            Bread newBreadAmount = new Bread("Bread", 5);
            }
          }
          Console.WriteLine("bread amount added to order");
          Program.Main();
        }
        else if (userInput2 == "2")
        {
          Console.WriteLine("How many Pastries would you like to add to your order?");
          int userAmount = int.Parse(Console.ReadLine());
          for(int i = 1; i <= userAmount; i++)
          {
            Pastry newPastryAmount = new Pastry("Pastry", 2);
          }
          Console.WriteLine("pastry amount added to order");
          Program.Main();
        }
      }

    }
  }
}
