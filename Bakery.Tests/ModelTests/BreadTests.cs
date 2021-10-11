using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // public void Dispose()
    // {
    //   Bread.ClearAll();
    // }
      [TestMethod] //Name of Method we are testing - Bread = Constructor. Description of behavior.
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void BreadCost_CreatesIntOfTotalBreadCost_ReturnCost()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadCost(3));
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_CreatePastry()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
  }
}