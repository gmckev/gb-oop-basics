using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public enum BankAccountType
    {
        Private,
        Public
    }

    public class BankAccount
    {
        public static int _accountNumber = default;
        private int _accountId;
        private double _balance;
        private BankAccountType _accountType;

        public BankAccount(double balance)
        {
            _balance = balance;
            IncreaseAccountNumber();
        }

        public BankAccount(BankAccountType type)
        {
            _accountType = type;
            IncreaseAccountNumber();
        }

        public BankAccount(double balance, BankAccountType type)
        {
            _accountType = type;
            _balance = balance;
            IncreaseAccountNumber();
        }

        public double Balance { get => _balance; }
        public BankAccountType AccountType { get => _accountType; }
        public int AccountId { get => _accountId; }

        public void IncreaseAccountNumber()
        {
            _accountNumber++;
            _accountId = _accountNumber;
        }

        public void AddBalance(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine($"Not enough money to deduct {amount} from bank account with id {_accountId}");
            }
            else
            {
                _balance -= amount;
            }
        }

        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            return (account1._accountId == account2._accountId);
        }

        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return !(account1._accountId == account2._accountId);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return (this == (BankAccount)obj);
            }

            return false;
        }

        // Не понял как определять GetHashCode
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(_accountId);
        //}

        public override string ToString()
        {
            return $"Account ID: {_accountId}, Account number: {_accountNumber}, Account type: {_accountType}, Account balance: {_balance}";
        }
    }
}
