using System.Collections.Generic;

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

    public static void GetPriceBread(int userAmount1)
    {
      for(int i = 1; i <= userAmount1; i ++)
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
    }
    public static void ClearAll()
    {
      _breadList.Clear();
    }
  }
}