using System;
using System.Collections.Generic;
using Bakery.Models;

  public class Program
  {
    static void Main()
    {
      string userInputStr = Console.ReadLine();
      int userInputInt = int.Parse(Console.ReadLine());
      Console.WriteLine("Welcome to Boulangerie de Pierre!");
      Console.WriteLine("1. View Order       2.Start Order");
      if (userInputStr == "1")
      {
        List<Bread> BreadResult = Bread.GetAll();
        List<Pastry> pastryResult = Pastry.GetAll();
      }
      else if (userInputStr == "2")
      {
        Console.WriteLine("What would you like to add to your order?");
        Console.WriteLine("      1. Bread             2. Pastry");
        if (userInputStr == "1")
        {
          Console.WriteLine("How many Bread loafs would you like to add to your order?");
          
        }
        else if (userInputStr == "2")
        {
          Console.WriteLine("How many Pastries would you like to add to your order?");
        }
      }
      
    }
  }
