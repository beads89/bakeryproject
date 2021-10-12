using System;
using System.Collections.Generic;


namespace Bakery
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