using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBankAccount
    {
        bool Deposit(decimal ammount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }
}
