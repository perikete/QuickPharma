using System.Collections.Generic;
namespace QuickPharma.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        /// <summary>
        /// Adds a entity to the repository.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        void Add(TEntity entity);
        
        /// <summary>
        /// Deletes a entity from the repository.
        /// </summary>
        /// <param name="entity">Entity to delete.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Gets an entity by Id.
        /// </summary>
        /// <param name="id">Id to search.</param>
        TEntity GetById(int id);

        /// <summary>
        /// Gets all the entities from the repository.
        /// </summary>
        IEnumerable<TEntity> GetAll();
    }
}
