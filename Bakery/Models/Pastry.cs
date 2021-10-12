using System;
using System.Collections.Generic;
using Bakery.Models;

// Buy 2 get 1 half off.

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryTotal(int price)
    {
      PastryPrice = price;
      return price;
    }
        public int PastryCost(int amount)
    {
      int pastrySingle = amount*2;
      for(int i = 0; i < amount; i++)
      {
        if(i % 3 == 0)
        {
          --pastrySingle;
        }
      } return pastrySingle;
    }
  }
}
    // public string PastryTotal(string amount)
    // {
    //   Console.WriteLine("How many pastry's do you want?");
    //   string pastryInput = Console.ReadLine();
    //   int pastryNumber = Convert.ToInt32(pastryInput);
    //   Pastry PastryAmount = new Pastry();
    //   Console.WriteLine(amount);
    //   return PastryAmount.PastryTotal(amount);
    // }