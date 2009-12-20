using System;

namespace QuickPharma.Core.Contracts
{
    public class PreConditionFailException : ContractException
    {
        public PreConditionFailException(string message)
            : base(message)
        {}
    }
}
