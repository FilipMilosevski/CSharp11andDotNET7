using Packt.Shared;


Northwind db = new Northwind();
WriteLine($"Provider: {db.Database.ProviderName}");



//QueryingCategories();

//QueryingProducts();



var resultAdd = AddProduct(6, "Bob's burgrers", 500M);

if (resultAdd.affected == 1)
{
    WriteLine($"Added product successfully with ID: {resultAdd.productId}");
}

ListProducts(new int[] { resultAdd.productId });




var resultAdd1 = IncreaseProductPrice("Bob", 20M);

if (resultAdd1.affected == 1)
{
    WriteLine($"Added CHANGE product successfully with ID: {resultAdd1.productId}");
}

ListProducts(new int[] { resultAdd1.productId });



//var delres = DeleteProduct("Bob");

//if(delres == 1)
//{
//    WriteLine($"Deleted product successfully with that starts with Bob");
//}

//ListProducts();


WriteLine("filip");
WriteLine("milosevski");