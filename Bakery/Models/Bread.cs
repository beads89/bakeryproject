using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {

    public int BreadPrice { get; set; }
    public int BreadTotal(int price)
    {
      BreadPrice = price;
      return price;
    }

    public int BreadCost(int amount)
    {
      int breadSingle = 0;
      for(int i = 0; i <= amount; i++)
      {
        if(i % 3 == 0)
        {
          breadSingle+= 0;
        }
        else
        {
          breadSingle += 5;
        }
      } return breadSingle;
    }
  }
}