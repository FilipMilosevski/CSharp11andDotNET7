using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    public class SavingAccount : IBankAccount
    {
        private decimal _balance;
        private decimal _perDayLimit;
        public decimal Balance => throw new NotImplementedException();

        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insuficent Balance!");
                return false;
            }
         
           else if (_perDayLimit + amount > 5000)
            {
                Console.WriteLine("Withdraw atempt failed!");
                return false;
            }
            else
            {
                _balance = amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw:{0,6:C}", amount));
                return true;    
            }
       
        
        
        
        }

        
    }
}
