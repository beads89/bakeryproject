using System;
using System.Collections.Generic;

// Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
// Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

// Prompt how many loaves of bread.
// Prompt how many pastries.
// Use BreadAmount { get; set} and PastryAmount{ get; set} to get totals
// 
namespace Bakery.Models
{
  public class Bread
  {
    public int price = 5;
    public void Price(int amount)
    {
      this.amount = amount;
    }
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We offer the following items:");
      Console.WriteLine("Bread: $5 per loaf. Buy 2 get 1 free!");
      Console.WriteLine("Pastry: 1 for $2 or 3 for $5! Four for $7, Five for $9 and six for $10!");
      Console.WriteLine("How many loaves of bread would you like?");

    }
  }

  public class Pastry
  {
    public int price = 2;
  }
}