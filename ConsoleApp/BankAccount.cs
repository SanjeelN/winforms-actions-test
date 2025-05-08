namespace BankAccountNS;

/// <summary>
/// Bank account demo class.
/// </summary>
public class BankAccount
{
    public BankAccount(string customerName, double balance)
    {
        CustomerName = customerName;
        Balance = balance;
    }

    public string CustomerName { get; }

    public double Balance { get; }

    public static void Main()
    {
        var ba = new BankAccount("Sanjeel", 11.99);
        Console.WriteLine("Current balance is ${0} for {1}", ba.Balance, ba.CustomerName);
    }
}