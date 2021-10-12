using System;
using Bakery;

namespace Bakery
{
    public class Program
  {
    public static void Main(string[] args)
    {
      Bread totalBreadOrder = new Bread();
      Pastry totalPastryOrder = new Pastry();
      Console.WriteLine("Welcome to Pierre's Bakery! We offer the following items:");
      Console.WriteLine("Bread: $5 per loaf. Buy 2 get 1 free!");
      Console.WriteLine("Pastry: 1 for $2 or 3 for $5! Four for $7, Five for $9 and six for $10! Buy 2 get 1 half off!");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadInput = Console.ReadLine();
      int breadInputInt = Convert.ToInt32(breadInput);
      Console.WriteLine("How many delicious pastries would you like?");
      string pastryInput = Console.ReadLine();
      int pastryInputInt = Convert.ToInt32(pastryInput);
      int totalCost = totalBreadOrder.BreadTotal(breadInputInt) + totalPastryOrder.PastryTotal(pastryInputInt);
      Console.WriteLine("Your order comes out to " + totalCost + ". Thank you for your generosity and enjoy your delights!");

    }
  }
}