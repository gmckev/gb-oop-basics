// 1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
// Предусмотреть методы для доступа к данным – заполнения и чтения.
// Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

var privateBankAccount = new BankAccount();
privateBankAccount.SetAccountNumber(1);
privateBankAccount.SetBalance(100.00);
privateBankAccount.SetBankAccountType(BankAccountType.Private);

Console.WriteLine($"Account Number: {privateBankAccount.GetAccountNumber()}" +
    $"\nAccount Type: {privateBankAccount.GetAccountType()}\nAccount Balance: {privateBankAccount.GetBalance()}");

public enum BankAccountType
{
    Private,
    Public
}

public class BankAccount
{
    private int _accountNumber;
    private double _balance;
    private BankAccountType _accountName;

    public int GetAccountNumber() { return _accountNumber; }
    public double GetBalance() { return _balance; }
    public BankAccountType GetAccountType() { return _accountName;}

    public void SetAccountNumber(int accountNumber) { _accountNumber = accountNumber; }
    public void SetBalance(double balance) { _balance = balance; }
    public void SetBankAccountType(BankAccountType bankAccountType) { _accountName = bankAccountType; }
}