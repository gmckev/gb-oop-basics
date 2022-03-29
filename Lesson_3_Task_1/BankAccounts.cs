using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_1
{
    internal class BankAccounts
    {
        static void Main(string[] args)
        {

            var privateBankAccount = new BankAccount(100);
            var publicBankAccount = new BankAccount(BankAccountType.Public);
            var anotherPrivateBankAccount = new BankAccount(50, BankAccountType.Private);

            privateBankAccount.AddBalance(100);
            publicBankAccount.Withdraw(10);
            anotherPrivateBankAccount.AddBalance(100);
            anotherPrivateBankAccount.TransferMoney(privateBankAccount, 100);

            Console.WriteLine($"Account number: {privateBankAccount.AccountId}\nAccount type: {privateBankAccount.AccountType}" +
                $"\nAccount balance: {privateBankAccount.Balance}");

            Console.WriteLine($"Account number: {publicBankAccount.AccountId}\nAccount type: {publicBankAccount.AccountType}" +
                $"\nAccount balance: {publicBankAccount.Balance}");

            Console.WriteLine($"Account number: {anotherPrivateBankAccount.AccountId}\nAccount type: {anotherPrivateBankAccount.AccountType}" +
                $"\nAccount balance: {anotherPrivateBankAccount.Balance}");
            Console.ReadLine();
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

        private void IncreaseAccountNumber()
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

        public void TransferMoney(BankAccount account, double amount)
        {
            account.AddBalance(amount);
            this.Withdraw(amount);
        }
    }
}