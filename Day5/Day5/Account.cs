using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Account
    {
        public string FirstName, LastName, Type, BankName, IFSC;
        private int AccountNo;
        private bool isNetBankingEnabled, isATMEnabled;
        public bool isDepositEnabled;

        private double Balance;

        public void SetName(string FN, string LN) 
        {
            this.FirstName = FN;
            this.LastName = LN;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void SetBankName(string bankName)
        {
            this.BankName = bankName;
        }

        public double WithDraw(double amt)
        {
            return Balance - amt;
        }

        public void Deposit(double amt)
        {
            if(isDepositEnabled)
            {
                this.Balance += amt;
            } else
            {
                Console.WriteLine("Balance not enabled");
            }
        }

        public void SetIFSC(string IFSC)
        {
            this.IFSC = IFSC;
        }

        public void setAccountNo(int accountNo) 
        {
            this.AccountNo = accountNo;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}\nAccountNo: {AccountNo}\nBank Name: {BankName}\nIFSC: {IFSC}");
        }

    }


    public class SavingsAccount : Account
    {
        public SavingsAccount()
        {
            base.Type = "Savings";
            base.isDepositEnabled = true;
        }




    }

    public class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            base.Type = "Current";
            base.isDepositEnabled = false;
        }


    }

    public class FDAccount : Account
    {
        public FDAccount()
        {
            base.Type = "Fixed Deposit";
            base.isDepositEnabled = true;
        }


    }
}
