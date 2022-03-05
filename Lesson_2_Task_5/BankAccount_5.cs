//5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет.
//Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.

var privateBankAccount = new BankAccount(150.00);
var publicBankAccount = new BankAccount(100, BankAccountType.Public);
var anotherPrivateBankAccount = new BankAccount(400, BankAccountType.Private);

privateBankAccount.AddBalance(50);

Console.WriteLine($"Account Number: {privateBankAccount.AccountId}" +
    $"\nAccount Type: {privateBankAccount.AccountType}\nAccount Balance: {privateBankAccount.Balance}");

publicBankAccount.Withdraw(95.3);

Console.WriteLine($"Account Number: {publicBankAccount.AccountId}" +
    $"\nAccount Type: {publicBankAccount.AccountType}\nAccount Balance: {publicBankAccount.Balance}");

anotherPrivateBankAccount.Withdraw(50);

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
    private static int _accountNumber = default;
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
        if( amount > _balance)
        {
            Console.WriteLine("Not enough money to deduct " + amount);
        }
        else
        {
            _balance -= amount;
        }
    }
}