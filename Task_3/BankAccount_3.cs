// 3. В классе банковский счет удалить методы заполнения полей.
// Вместо этих методов создать конструкторы.
// Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
// конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса
// и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.


var privateBankAccount = new BankAccount(150.00);
var publicBankAccount = new BankAccount(BankAccountType.Public);
var anotherPrivateBankAccount = new BankAccount(130.00, BankAccountType.Private);

Console.WriteLine($"Account Number: {privateBankAccount.GetAccountId()}" +
    $"\nAccount Type: {privateBankAccount.GetAccountType()}\nAccount Balance: {privateBankAccount.GetBalance()}");

Console.WriteLine($"Account Number: {publicBankAccount.GetAccountId()}" +
    $"\nAccount Type: {publicBankAccount.GetAccountType()}\nAccount Balance: {publicBankAccount.GetBalance()}");

Console.WriteLine($"Account Number: {anotherPrivateBankAccount.GetAccountId()}" +
    $"\nAccount Type: {anotherPrivateBankAccount.GetAccountType()}\nAccount Balance: {anotherPrivateBankAccount.GetBalance()}");

public enum BankAccountType
{
    Private,
    Public
}

public class BankAccount
{
    public int _accountId;
    public static int _accountNumber = 0;
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


    public int GetAccountId() { return _accountId; }    
    public double GetBalance() { return _balance; }
    public BankAccountType GetAccountType() { return _accountType; }

    public void IncreaseAccountNumber() { 
        _accountNumber++;
        _accountId = _accountNumber;
    }

}