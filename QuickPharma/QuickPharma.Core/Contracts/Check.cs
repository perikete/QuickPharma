namespace QuickPharma.Core.Contracts
{
    public static class Check
    {
        public static void Require(bool preCondition, string message)
        {
            if (!preCondition)
            {
                throw new PreConditionFailException(message);
            }
        }

        public static void Ensure(bool postCondition, string message)
        {
            if (!postCondition)
            {
                throw new PostConditionFailException(message);
            }
        }        
    }
}
