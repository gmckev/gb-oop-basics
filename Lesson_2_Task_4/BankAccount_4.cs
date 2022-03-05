//4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.

var privateBankAccount = new BankAccount(150.30);
var publicBankAccount = new BankAccount(BankAccountType.Public);
var anotherPrivateBankAccount = new BankAccount(220.5, BankAccountType.Private);

Console.WriteLine($"Account number: {privateBankAccount.AccountId}\nAccount type: {privateBankAccount.AccountType}" +
    $"\nAccount balance: {privateBankAccount.Balance}");

Console.WriteLine($"Account number: {publicBankAccount.AccountId}\nAccount type: {publicBankAccount.AccountType}" +
    $"\nAccount balance: {publicBankAccount.Balance}");

Console.WriteLine($"Account number: {anotherPrivateBankAccount.AccountId}\nAccount type: {anotherPrivateBankAccount.AccountType}" +
    $"\nAccount balance: {anotherPrivateBankAccount.Balance}");

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

}