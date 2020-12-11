using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  {
    // public void Dispose()
    // {
    //   Pastry.ClearAll();
    // }
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("Pastry", 5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsPastryDescription_String()
    {
      string description = "pretty sure this is a Pastry";
      int price = 2;
      Pastry newPastry = new Pastry(description, price);
      string result = newPastry.PastryDescription;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPastryPrice_Int()
    {
      string description = "this is a Pastry";
      int price = 2;
      Pastry newPastry = new Pastry(description, price);
      int result = newPastry.PastryPrice;
      Assert.AreEqual(price, result);
    }
    // [TestMethod]
    // public void SetPrice_SetPastryPrice_Int()
    // {
    //   string description = "this is a Pastry";
    //   int price = 2;
    //   Pastry newPastry = new Pastry(description, price);
    //   int updatedPrice = 10;
    //   newPastry.PastryPrice = updatedPrice;
    //   int result = newPastry.PastryPrice;
    //   Assert.AreEqual(updatedPrice, result);
    // }
    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_PastryList()
    // {
    //   List<Pastry> newList = new List<Pastry> { };
    //   List<Pastry> result = Pastry.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void GetAll_ReturnsItems_PastryList()
    // {
    //   string description = "this is surely a Pastry";
    //   int price = 2;
    //   Pastry newPastry = new Pastry(description, price);
    //   List<Pastry> newList = new List<Pastry> { newPastry };
    //   List<Pastry> result = Pastry.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}
