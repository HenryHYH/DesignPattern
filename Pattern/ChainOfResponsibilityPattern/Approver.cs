namespace Pattern.ChainOfResponsibilityPattern
{
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }

        public string Name { get; private set; }

        public Approver(string name)
        {
            Name = name;
        }

        public abstract string ProcessRequest(PurchaseRequest request);
    }
}
