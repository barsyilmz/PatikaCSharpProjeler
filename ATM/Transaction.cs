public class Transaction
{
    public string TransactionType { get; set; }
    public double Amount { get; set; }
    public DateTime TransactionDate { get; set; }

    public Transaction(string transactionType, double amount)
    {
        TransactionType = transactionType;
        Amount = amount;
        TransactionDate = DateTime.Now;
    }
}
