namespace QuickPharma.Core.Contracts
{
    public class PostConditionFailException : ContractException
    {
        public PostConditionFailException(string message)
            : base(message)
        {}
    }
}
