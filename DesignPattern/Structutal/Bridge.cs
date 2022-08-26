using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structutal
{
    public interface IAccount
    {
        void OpenAccount();
    }

    public class CheckingAccount: IAccount
    {
        public void OpenAccount()
        {
            Console.WriteLine("Checking Account");
        }
    }

    public class SavingAccount : IAccount
    {
        public void OpenAccount()
        {
            Console.WriteLine("Saving Account");
        }
    }

    public abstract class Bank
    {
        protected IAccount account;
        public Bank(IAccount account)
        {
            this.account = account;
        }
        public abstract void OpenAccount();
    }

    public class VietcomBank : Bank
    {
        public VietcomBank(IAccount account) : base(account)
        {

        }

        public override void OpenAccount()
        {
            Console.WriteLine("Open your account at VietcomBank is a ");
            account.OpenAccount();
        }
    }

    public class TPBank : Bank
    {
        public TPBank(IAccount account) : base(account)
        {

        }

        public override void OpenAccount()
        {
            Console.WriteLine("Open your account at TPBank is a ");
            account.OpenAccount();
        }
    }
}
