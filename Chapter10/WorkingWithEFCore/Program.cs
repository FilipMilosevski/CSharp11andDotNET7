using Packt.Shared;


Northwind db = new Northwind();
WriteLine($"Provider: {db.Database.ProviderName}");