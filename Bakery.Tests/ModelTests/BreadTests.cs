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
    public void GetDescription_ReturnsBreadDescription_StringAndInt()
    {
      string description = "this is bread";
      int price = 5;
      Bread newBread = new Bread(description, price);
      string result = newBread.BreadDescription;
      Assert.AreEqual(description, result);
    }
  }
}
