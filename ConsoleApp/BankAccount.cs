namespace BankAccountNS;

/// <summary>
/// Bank account demo class.
/// </summary>
public class BankAccount
{
    private readonly string m_customerName;
    private double m_balance;

    public BankAccount(string customerName, double balance)
    {
        m_customerName = customerName;
        m_balance = balance;
    }

    public string CustomerName
    {
        get { return m_customerName; }
    }

    public double Balance
    {
        get { return m_balance; }
    }

    public static void Main()
    {
        BankAccount ba = new BankAccount("Sanjeel", 11.99);
        Console.WriteLine("Current balance is ${0} for {1}", ba.Balance, ba.CustomerName);
    }
}