using System.Collections.Generic;

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
      _pastryList.Add(this);
    }
    public static List<Pastry> GetAll()
    {
      return _pastryList;
    }
    public static void GetPricePastry(int userAmount2)
    {
      for(int i = 1; i <= userAmount2; i++)
      {
        if(i % 3 ==0)
        {
          Pastry newPastryAmount = new Pastry("Pastry (deal)", 1);
        }
        else
        {
          Pastry newPastryAmount = new Pastry("Pastry", 2);
        }
      }
    }
    public static void ClearAll()
    {
      _pastryList.Clear();
    }
  }
}