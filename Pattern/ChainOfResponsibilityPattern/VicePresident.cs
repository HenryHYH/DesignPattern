namespace Pattern.ChainOfResponsibilityPattern
{
    public class VicePresident : Approver
    {
        public VicePresident(string name)
            : base(name)
        {
        }

        public override string ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 25000.0)
                return string.Format("Approved by {0}", Name);
            else if (null != NextApprover)
                return NextApprover.ProcessRequest(request);
            else
                return string.Format("Reject by {0}", Name);
        }
    }
}
