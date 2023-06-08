using Packt.Shared;


Northwind db = new Northwind();
WriteLine($"Provider: {db.Database.ProviderName}");

SectionTitle("filip");
SectionTitle("proba");
Fail("fi");
Info("di");

QueryingCategories();

QueryingProducts();