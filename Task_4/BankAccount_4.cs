// 4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.

var privateBankAccount = new BankAccount(150.00d);
var publicBankAccount = new BankAccount(BankAccountType.Public);
var anotherPrivateBankAccount = new BankAccount(130.00, BankAccountType.Private);

Console.WriteLine($"Account Number: {privateBankAccount.AccountId}" +
    $"\nAccount Type: {privateBankAccount.AccountType}\nAccount Balance: {privateBankAccount.Balance}");

Console.WriteLine($"Account Number: {publicBankAccount.AccountId}" +
    $"\nAccount Type: {publicBankAccount.AccountType}\nAccount Balance: {publicBankAccount.Balance}");

Console.WriteLine($"Account Number: {anotherPrivateBankAccount.AccountId}" +
    $"\nAccount Type: {anotherPrivateBankAccount.AccountType}\nAccount Balance: {anotherPrivateBankAccount.Balance}");

public enum BankAccountType
{
    Private,
    Public
}

public class BankAccount
{
    private int _accountId;
    public static int _accountNumber = default;
    private double _balance;
    private BankAccountType _accountType;

    public BankAccount(double balance)
    {
        _balance = balance;
        IncreaseAccountNumber();
    }

    public BankAccount(BankAccountType bankAccountType) 
    {
        _accountType = bankAccountType;
        IncreaseAccountNumber();
    }

    public BankAccount(double balance, BankAccountType bankAccountType)
    {
        _balance = balance;
        _accountType = bankAccountType;
        IncreaseAccountNumber();
    }

    public int AccountId { get => _accountId; }
    public double Balance { get => _balance; set => _balance = value; }
    public BankAccountType AccountType { get => _accountType; set => _accountType = value; }

    public void IncreaseAccountNumber() { 
        _accountNumber++;
        _accountId = _accountNumber;
    }

}