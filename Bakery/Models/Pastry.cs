using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Pastry
  {

    public string PastryDescription { get; set; }
    public int PastryPrice { get;set; }

    private static List<Pastry> _pastryList = new List<Pastry> { }; 

    public Pastry(string description, int price)
    {
      PastryDescription = description;
      PastryPrice = price;
      // _pastryList.Add(this);
    }
    public static List<Pastry> GetAll()
    {
      return _pastryList;
    }
    public static void ClearAll()
    {
      _pastryList.Clear();
    }
  }
}