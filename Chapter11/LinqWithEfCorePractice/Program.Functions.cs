
using LinqWithEfCorePractice.ModelsPractice;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

partial class Program
    {
        static void Filterandsort1()
    {
        SectionTitle("INSTANCA OD NORTHWIND CONTEXT PREKU DB SET PRV NACIN");
        using(NorthwindPractice db = new NorthwindPractice())
        {
            DbSet<Product> allproducts = db.Products;
            IQueryable<Product> filterProducts = allproducts.Where(p => p.UnitPrice < 10M);
            IQueryable<Product> sortAndFilterProducts = filterProducts.OrderByDescending(p => p.UnitPrice);    
            foreach (Product p in sortAndFilterProducts)
            {
                WriteLine("This is ID : {0}    |   This is name : {1}   |   This is the price : {2:C}", p.ProductId, p.ProductName, p.UnitPrice);

            }
            SectionTitle("INSTANCA OD NORTHWIND CONTEXT PREKU DB SET VTOR NACIN");

            WriteLine(sortAndFilterProducts.ToQueryString()+":     OVA E DODATNO");

        }
    }
        static void Filterandsort2()
    {
        SectionTitle("INSTANCA PREKU LISTA");
        using(NorthwindPractice context = new NorthwindPractice())
        {
            List<Product> allProducts = context.Products.ToList();
            List<Product> filteredProducts = allProducts.Where(product => product.UnitPrice < 10M).ToList();
            List<Product> sorteredAndFilteredProducts = filteredProducts.OrderByDescending(product => product.UnitPrice).ToList();
            foreach (Product p in sorteredAndFilteredProducts)
            {
                WriteLine("This is ID : {0}    |   This is name : {1}   |   This is the price : {2:C}", p.ProductId, p.ProductName, p.UnitPrice);

            }
        }
    }
    static void Filterandsort3()
    {
        SectionTitle("VO EDNA LINIJA");
        using(NorthwindPractice context = new NorthwindPractice())
        {
            List<Product> filterSortProducts = context.Products.Where(p => p.UnitPrice <10M).OrderByDescending(p => p.UnitPrice).ToList();
            foreach (Product p in filterSortProducts)
            {
                WriteLine("This is ID : {0}    |   This is name : {1}   |   This is the price : {2:C}", p.ProductId, p.ProductName, p.UnitPrice);

            }

        }
    }
    static void Filterandsortquery()
    {
        using(NorthwindPractice context = new NorthwindPractice())
        {
            SectionTitle("QUERY PRV NACIN");

            IQueryable<Product> products = 
                from product in context.Products
                where product.UnitPrice < 10M
                orderby product.UnitPrice descending 
                select product;

            foreach (Product p in products)
            {
                WriteLine("This is ID : {0}    |   This is name : {1}   |   This is the price : {2:C}", p.ProductId, p.ProductName, p.UnitPrice);

            }
            SectionTitle("QUERY VTOR NACIN");

            WriteLine(products.ToQueryString());
        }
    }
    }

