using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    internal class BankAccount
    {
        private Person _accoutnHolder;
        private double _balance;

        public double Balance 
        { get => _balance; 
          set => _balance = value; 
        }







        // a static property top store the total number of BankAccounts objects
        // it is initialized to 0 and will be incremented every time a new BankAccount object is created
        public static int TotalAccounts { get; private set; } = 0;


        // a static property to store the interest rate for all BankAccounts objects
        // this value is shared by all instances of the Bank Account class and cannot bne changed after it is initialized 
        public static double InterestRate { get;  } = 1.5;
      

        public BankAccount(Person accountHolder, double initialBalance)
        {
            _accoutnHolder = accountHolder;
            _balance = initialBalance;
            TotalAccounts++;

        }



    }
}
