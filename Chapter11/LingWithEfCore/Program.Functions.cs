
using LingWithEfCore;
using LingWithEfCore.Models;
using Microsoft.EntityFrameworkCore;

partial class Program
    {
        static void FilterAndSort()
    {
        SectionTitle("Filter and sort");


        using(Northwind db = new Northwind())
        {
            // List<Product> filSortProducts = db.Products.Where(p => p.UnitPrice < 10M).OrderByDescending(p=>p.UnitPrice).ToList();
            //DbSet<Klasata za producti> allProducts = site producti od baza
            //So samoto pristapuvanje do propertit pravi povik do baza za site produkti 
            DbSet<Product> allProducts = db.Products;

            //od site producti da pobarame samo producti koi UnitePrice e pomalo od 10M
            //IQueryable<Klasata za producti> filteredProducts = 
            //Where(lamda)
            IQueryable<Product> filteredProducts = allProducts.Where(product => product.UnitPrice < 10M);
            // Da gi sortirame po UnitePrice
            // IOrderedQueryable<Klasata za producti> sortedAndFilteredProducts = 
            // OrderByDescending(lamda)
            IQueryable<Product> sortedAndFilteredProducts = filteredProducts.OrderByDescending(product => product.UnitPrice);
            //foreach na sortedAndFilteredProducts
            //WriteLine("{0}: {1} costs {2:$#,##0.00}",p.ProductId, p.ProductName, p.UnitPrice);
            foreach (Product pro in sortedAndFilteredProducts)
            {
                WriteLine("{0} : {1} cost {2}", pro.ProductId, pro.ProductName, pro.UnitPrice);
            }
            WriteLine(filteredProducts.ToQueryString());
        }
    }


    static void FilterAndSortQuerry()
    {
        using(Northwind db = new Northwind())
        {
            IQueryable<Product> products = from product in db.Products where product.UnitPrice < 10M orderby product.UnitPrice descending select product;

            foreach (Product pro in products)
            {
                WriteLine("{0} : {1} cost {2}", pro.ProductId, pro.ProductName, pro.UnitPrice);

            }
            WriteLine(products.ToQueryString());
        }
    }

}

