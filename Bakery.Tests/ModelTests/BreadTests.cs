using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using Bakery.Models;
// using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
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
    public void SetPrice_SetBreadPrice_Int()
    {
      //Arange
      string description = "this is bread";
      int price = 5;
      Bread newBread = new Bread(description, price);

      //Act
      int updatedPrice = 10;
      newBread.BreadPrice = updatedPrice;
      int result = newBread.BreadPrice;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }
  }
}
