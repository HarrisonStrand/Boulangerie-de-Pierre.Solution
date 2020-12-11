using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("bread", 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsBreadDescription_String()
    {
      string description = "this is bread";
      int price = 5;
      Bread newBread = new Bread(description, price);
      string result = newBread.BreadDescription;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsBreadPrice_Int()
    {
      string description = "this is bread";
      int price = 5;
      Bread newBread = new Bread(description, price);
      int result = newBread.BreadPrice;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDealPrice_SetDealPrice_Int()
    {
      string description = "Bread";
      int price = 5;
      Bread newBread = new Bread(description, price);
      int DealPrice = 0;
      newBread.BreadPrice = DealPrice;
      int result = newBread.BreadPrice;
      Assert.AreEqual(DealPrice, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_BreadList()
    {
      List<Bread> newList = new List<Bread> { };
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_BreadList()
    {
      string description = "this is surely bread";
      int price = 5;
      Bread newBread = new Bread(description, price);
      List<Bread> newList = new List<Bread> { newBread };
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
