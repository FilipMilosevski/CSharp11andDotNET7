

using Bank;


IBankAccount savingAccount = new SavingAccount();
IBankAccount currentAccount = new CurrentAccount();
    
savingAccount.Deposit(200);
savingAccount.Withdraw(100);
savingAccount.ToString();
    
currentAccount.Deposit(500);
currentAccount.Withdraw(600);
currentAccount.Withdraw(200);
currentAccount.ToString();
Console.ReadLine();

IBankAccount s1 = new SavingAccount();
IBankAccount c1 = new SavingAccount();

s1.Deposit(500);
s1.Withdraw(300);
s1.ToString();

c1.Deposit(700);
c1.Withdraw(800);
c1.Withdraw(200);
c1.ToString();
Console.ReadLine();

IBankAccount s2 = new SavingAccount();
IBankAccount c2 = new SavingAccount();

s2.Deposit(2000);
s2.Withdraw(1900);
s2.ToString();

c2.Deposit(3000);
c2.Withdraw(3200);
c2.Withdraw(2800);
c2.ToString();