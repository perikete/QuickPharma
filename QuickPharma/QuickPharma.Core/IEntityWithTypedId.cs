namespace QuickPharma.Core
{
    /// <summary>
    /// Interface of an entity with a custom type
    /// Id.
    /// </summary>
    /// <typeparam name="TId">The type of the Id.</typeparam>
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
