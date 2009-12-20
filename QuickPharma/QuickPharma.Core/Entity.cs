namespace QuickPharma.Core
{
    /// <summary>
    /// Base class for all the Entities.
    /// </summary>
    public abstract class Entity : IEntity
    {
        public int Id { get; private set; }        
    }
}
