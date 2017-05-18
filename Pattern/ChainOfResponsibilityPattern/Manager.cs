namespace Pattern.ChainOfResponsibilityPattern
{
    public class Manager : Approver
    {
        public Manager(string name)
            : base(name)
        {
        }

        public override string ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
                return string.Format("Approved by {0}", Name);
            else if (null != NextApprover)
                return NextApprover.ProcessRequest(request);
            else
                return string.Format("Reject by {0}", Name);
        }
    }
}
