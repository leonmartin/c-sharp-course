public struct Transaction
{
    public decimal Amount;
    public int OtherAccountNumber;
    public DateTime Timestamp;

    public Transaction(decimal amount, int otherAccountNumber)
    {
        Amount = amount;
        OtherAccountNumber = otherAccountNumber;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {   
        if (Amount >= 0)
        {
            return $"On {Timestamp}: {Amount} received from {OtherAccountNumber}";
        } else {
            return $"On {Timestamp}: {Amount} sent to {OtherAccountNumber}";
        }
    }
}
