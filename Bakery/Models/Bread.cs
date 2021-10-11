using System;
using System.Collections.Generic;
using Bakery.Models;

// Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
// Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

// Prompt how many loaves of bread.
// Prompt how many pastries.
// Use BreadAmount { get; set} and PastryAmount{ get; set} to get totals
//
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
      
    }
    // public static BreadTotal(string amount, int price) // Test methods
    // {
    //   Console.WriteLine("How many loaves would you like?");
    //   string breadInput = Console.ReadLine();
    //   int breadNumber = Convert.ToInt32(breadInput);
    //   Bread BreadAmount = new Bread();
    //   Console.WriteLine(BreadAmount);

      // Console.WriteLine (BreadAmount);
    }
}


  // 
//   public class Interface
//   {
//     public static void Main(string[] args)
//     {
//       Console.WriteLine("Welcome to Pierre's Bakery! We offer the following items:");
//       Console.WriteLine("Bread: $5 per loaf. Buy 2 get 1 free!");
//       Console.WriteLine("Pastry: 1 for $2 or 3 for $5! Four for $7, Five for $9 and six for $10!");
//       Console.WriteLine("How many loaves of bread would you like?");
//     }
//   }
// }


    // {
    //   Console.WriteLine("You ordered " + Amount + " " + " loaves of bread. Your total is " + Price);
    // }