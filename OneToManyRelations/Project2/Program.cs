

using Filip;
using Microsoft.EntityFrameworkCore;


static void read()
{
    using (BankContext mi = new BankContext())
    {
        DbSet<AccountType> accounts = mi.AccountTypes;

        foreach (AccountType a in accounts)
        {
            Console.WriteLine($"   {a.Name}");
        }
    }

}

read();