using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadDescription { get; set; }
    public int BreadPrice { get;set; }

    private static List<Bread> _breadList = new List<Bread> { }; 

    public Bread(string description)
    {
      BreadDescription = description;
      // _breadList.Add(this);
    }
    public Bread(string description, int price)
      : this(description)
    {
      BreadPrice = price;
      // _breadList.Add(this);
    }
    public static List<Bread> GetAll()
    {
      return _breadList;
    }
  }
}