using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Bread
  {

    public string BreadDescription { get; set; }
    public int BreadPrice { get;set; }

    private static List<Bread> _breadList = new List<Bread> { }; 

    public Bread(string description, int price)
    {
      BreadDescription = description;
      BreadPrice = price;
      _breadList.Add(this);
    }
    public static List<Bread> GetAll()
    {
      return _breadList;
    }
    public static void ClearAll()
    {
      _breadList.Clear();
    }
  }
}