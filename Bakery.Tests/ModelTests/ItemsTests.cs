using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

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
      public void Bread_ReturnsNumber_True()
      // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
  {
  // any necessary logic to prep for test; instantiating new classes, etc.
  Bread testBread = new Bread();
  Assert.AreEqual(true, testBread.Price(2));
  }
  }
}