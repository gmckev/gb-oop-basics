// 2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
// Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.


var privateBankAccount = new BankAccount();
privateBankAccount.IncreaseAccountNumber();
privateBankAccount.SetBalance(100.00);
privateBankAccount.SetBankAccountType(BankAccountType.Private);
var publicBankAccount = new BankAccount();
publicBankAccount.IncreaseAccountNumber();

Console.WriteLine($"Account Number: {privateBankAccount.GetAccountId()}" +
    $"\nAccount Type: {privateBankAccount.GetAccountType()}\nAccount Balance: {privateBankAccount.GetBalance()}");

Console.WriteLine($"Account Number: {publicBankAccount.GetAccountId()}" +
    $"\nAccount Type: {publicBankAccount.GetAccountType()}\nAccount Balance: {publicBankAccount.GetBalance()}");

public enum BankAccountType
{
    Private,
    Public
}

public class BankAccount
{
    private int _accountId;
    public static int _accountNumber = 0;
    private double _balance;
    private BankAccountType _accountName;

    public int GetAccountId() { return _accountId; }
    public double GetBalance() { return _balance; }
    public BankAccountType GetAccountType() { return _accountName; }

    public void IncreaseAccountNumber() { 
        _accountNumber++;
        _accountId+=_accountNumber;
    }
    public void SetBalance(double balance) { _balance = balance; }
    public void SetBankAccountType(BankAccountType bankAccountType) { _accountName = bankAccountType; }
}