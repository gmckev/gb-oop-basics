//1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
//Предусмотреть методы для доступа к данным – заполнения и чтения.
//Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

var privateBankAccount = new BankAccount();
privateBankAccount.SetAccountNumber(1);
privateBankAccount.SetBalance(150.30);
privateBankAccount.SetType(BankAccountType.Private);

Console.WriteLine($"Account number: {privateBankAccount.GetAccountNumber()}\nAccount type: {privateBankAccount.GetBankAccountType()}" +
    $"\nAccount balance: {privateBankAccount.GetBalance()}");

public enum BankAccountType
{
    Private,
    Public
}

public class BankAccount
{
    private int _accountNumber;
    private double _balance;
    private BankAccountType _accountType;

    public int GetAccountNumber() { return _accountNumber; }
    public double GetBalance() { return _balance; }
    public BankAccountType GetBankAccountType() { return _accountType; }

    public void SetAccountNumber(int accountNumber) { _accountNumber = accountNumber; }
    public void SetBalance(double balance) { _balance = balance; }
    public void SetType(BankAccountType type) { _accountType = type; }

}