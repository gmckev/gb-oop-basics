//2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
//Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

var privateBankAccount = new BankAccount();
privateBankAccount.SetBalance(150.30);
privateBankAccount.SetType(BankAccountType.Private);

privateBankAccount.IncreaseAccountNumber();

var publicBankAccount = new BankAccount();
publicBankAccount.SetType(BankAccountType.Public);
publicBankAccount.SetBalance(200.5);

publicBankAccount.IncreaseAccountNumber();

Console.WriteLine($"Account number: {privateBankAccount.GetAccountId()}\nAccount type: {privateBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {privateBankAccount.GetBalance()}");

Console.WriteLine($"Account number: {publicBankAccount.GetAccountId()}\nAccount type: {publicBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {publicBankAccount.GetBalance()}");

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

    public double GetBalance() { return _balance; }
    public BankAccountType GetBankAccountType() { return _accountType; }
    public int GetAccountId() { return _accountId; }

    public void SetAccountNumber(int accountNumber) { _accountNumber = accountNumber; }
    public void SetBalance(double balance) { _balance = balance; }
    public void SetType(BankAccountType type) { _accountType = type; }
    public void IncreaseAccountNumber()
    {
        _accountNumber++;
        _accountId = _accountNumber;
    }

}