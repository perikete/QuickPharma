using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickPharma.Core.Contracts;

namespace QuickPharma.Core.Tests
{
    [TestClass]
    public class CheckTests
    {
        [TestMethod]
        [ExpectedException(typeof(PreConditionFailException))]
        public void Violating_a_PreCondition_Should_Throw_Exception()
        {
            Check.Require(1 == 2, "The numbers must be equals");
        }

        [TestMethod]
        [ExpectedException(typeof(PostConditionFailException))]
        public void Violating_a_PostCondition_Should_Throw_Exception()
        {
            Check.Ensure(1 == 2, "The numbers must be equals");
        }       
    }
}
