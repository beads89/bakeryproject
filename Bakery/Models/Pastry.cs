using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice {get; set;}
    public string PastryAmount {get; set;}
    public string PastryTotal(string amount)
    {
      Console.WriteLine("How many pastry's do you want?");
      string pastryInput = Console.ReadLine();
      int pastryNumber = Convert.ToInt32(pastryInput);
      Pastry PastryAmount = new Pastry();
      Console.WriteLine(amount);
      return PastryAmount.PastryTotal(amount);
    }
  }
}