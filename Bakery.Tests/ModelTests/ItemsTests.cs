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
    //   // Bread.ClearAll();
    // }
      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread testBread = new Bread("5");
      Assert.AreEqual(typeof(Bread), testBread.GetType());
  }
  }
}