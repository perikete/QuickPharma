using System;

namespace QuickPharma.Core.Contracts
{
    public abstract class ContractException : Exception
    {
        public ContractException(string message)
            : base(message)
        {}
    }
}
