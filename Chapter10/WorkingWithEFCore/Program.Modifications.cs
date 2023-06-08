using Microsoft.EntityFrameworkCore;

using Packt.Shared;

partial class Program
  {
    static void ListProducts(int[]? ProductIdsToHighlight = null)
    {
        using(Northwind db = new Northwind())
        {
            if((db.Products is null) || (!db.Products.Any()))
            {
                Fail("There are no products");
                return;

            }
            WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4} |", "Id", "Product Name", "Cost", "Stock", "Disc.");
            foreach (Product p in db.Products)
            {
                ConsoleColor previousColor = ForegroundColor;
                if((ProductIdsToHighlight is not null) && ProductIdsToHighlight.Contains(p.ProductId))
                {

                }
            }

        }
    }
  }

