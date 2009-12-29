using QuickPharma.Core.Contracts;

namespace QuickPharma.Core.Model
{
    public class Laboratory : Entity
    {
        public virtual string Name { get; private set; }

        public Laboratory(string name)
        {
            this.Name = name;
        }

        protected Laboratory()
        {           
        }

        private void SetName(string name)
        {
            Check.Require(!string.IsNullOrEmpty(name), "The name of the Laboratory cannot be null.");
            this.Name = name;
        }
    }
}
