using Microsoft.VisualStudio.TestTools.UnitTesting;


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
  }
  [TestClass]
  public class PastryTests
    {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_CreatePastry()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void PastryCost_CreatesIntOfTotalPastryCost_ReturnCost()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.PastryCost(3));
    }
    [TestMethod]
    public void PastryCost_CreatesSecondIntOfTotalPastryCost_ReturnCost()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(10, testPastry.PastryCost(6));
    }
  }
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void Main_CalculatesTotalCostOfOrder_ReturnTotalCost()
    {
      Bread testBread = new Bread();
      int testBreadInput = testBread.BreadCost(6);
      Pastry testPastry = new Pastry();
      int testPastryInput = testPastry.PastryCost(6);
      int totalCost = testBreadInput + testPastryInput;
      Assert.AreEqual(totalCost, 30);
    }
  }
}
