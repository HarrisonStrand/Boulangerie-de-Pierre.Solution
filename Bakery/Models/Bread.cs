using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice{get;set;}

    public Bread(int price)
    {
      BreadPrice = price;
    }
  }
}