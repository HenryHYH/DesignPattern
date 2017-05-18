namespace Pattern.ChainOfResponsibilityPattern
{
    public class President : Approver
    {
        public President(string name)
            : base(name)
        {
        }

        public override string ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000.0)
                return string.Format("Approved by {0}", Name);
            else
                return "需要组织会议讨论";
        }
    }
}
