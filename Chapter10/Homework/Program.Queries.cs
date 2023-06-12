

using Microsoft.EntityFrameworkCore;
using Packt.Shared;

partial class Program
    {
    static void QueryingCategories()
    {
        using (Northwind db = new Northwind())
        {
            SectionTitle("Categories and how many products they have");
            // a querry to get all categories and their related products
            IQueryable<Category> categories = db.Categories?.Include(c => c.Products);

            if ((categories is null) || (!categories.Any()))
            {
                Fail("No categories found");
                return;
            }
            foreach (Category category in categories)
            {
                WriteLine($"{category.CategoryName} has {category.Products.Count} products ");
                WriteLine("They are: ");
                foreach (Product product in category.Products)
                {
                    WriteLine($" *                {product.ProductName}");
                }
            }
            
        }
    }

    static void QueriyngProducts()
    {
        using (Northwind db = new Northwind())
        {
            SectionTitle("Product names and their category names");

            IQueryable<Product> products = db.Products?.Include(p => p.Category);

            if ((products is null) || (!products.Any()))
            {
                Fail("No products found");
                return;
            }

            foreach (Product product in products)
            {
                WriteLine($"{product.ProductName} has {product.Category.CategoryName} category");
            }
        }
    }
}

