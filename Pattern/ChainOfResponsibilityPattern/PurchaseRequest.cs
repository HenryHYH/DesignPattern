namespace Pattern.ChainOfResponsibilityPattern
{
    public class PurchaseRequest
    {
        public double Amount { get; private set; }

        public string ProductName { get; private set; }

        public PurchaseRequest(string productName, double amount)
        {
            ProductName = productName;
            Amount = amount;
        }
    }
}
