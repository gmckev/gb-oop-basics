//3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
//конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса
//и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.

var privateBankAccount = new BankAccount(150.30);
var publicBankAccount = new BankAccount(BankAccountType.Public);
var anotherPrivateBankAccount = new BankAccount(220.5, BankAccountType.Private);

Console.WriteLine($"Account number: {privateBankAccount.GetAccountId()}\nAccount type: {privateBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {privateBankAccount.GetBalance()}");

Console.WriteLine($"Account number: {publicBankAccount.GetAccountId()}\nAccount type: {publicBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {publicBankAccount.GetBalance()}");

Console.WriteLine($"Account number: {anotherPrivateBankAccount.GetAccountId()}\nAccount type: {anotherPrivateBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {anotherPrivateBankAccount.GetBalance()}");

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

    public double GetBalance() { return _balance; }
    public BankAccountType GetBankAccountType() { return _accountType; }
    public int GetAccountId() { return _accountId; }

    public void IncreaseAccountNumber()
    {
        _accountNumber++;
        _accountId = _accountNumber;
    }

}