using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadDescription { get; set; }
    public int BreadPrice{get;set;}

    public Bread(string description, int price )
    {
      BreadDescription = description;
      BreadPrice = pric;
    }
  }
}