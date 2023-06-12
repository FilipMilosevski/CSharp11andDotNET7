using Packt.Shared;

Northwind db = new Northwind();


WriteLine($"{db.Database.ProviderName}     proba");



SectionTitle("F I L I P");
Fail("F I L I P");
Info("F I L I P");

QueryingCategories();

QueriyngProducts();


ListOfProducts();
//DODAVANJE PRODUKT
//var resultAdd = AddProduct(categoryId:6, productName: "Bob's Burgers", price: 500M);
//ZGOLEMUVANJE PRODUKT
//var resultAdd = IncreaseProductPrice("Bob",50M);

var resultAdd = IncreaseProductPrice("Bob",50M);

if (resultAdd.affected == 1)
{
    WriteLine($"Add product succesfully with ID: {resultAdd.productId}.");
}

//ListOfProducts(new int[] { resultAdd.productId });





//BRISENJE PRODUKT

var delResult = DeleteProduct("Bob");
if(delResult == 1)
{
    WriteLine("Deleted product succesfully with that starts with Bob");
}
