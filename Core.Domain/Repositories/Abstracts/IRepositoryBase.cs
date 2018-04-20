using System.Collections.Generic;

namespace Core.Domain.Repositories.Abstracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        #region GetAll
        /// <summary>
        /// Obtém todos os objeto do tipo da Entity da base
        /// </summary>
        /// <param name="pagina">identificação da paginação da pagina</param>
        /// <param name="nrItensPorPagina">Numero de item por pagina</param>
        /// <returns>Lista da Entity</returns>
        List<TEntity> GetAll(int pagina = 0, int nrItensPorPagina = 0);
        #endregion

        #region Insert
        /// <summary>
        /// Insert a new object in the context
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(TEntity entity);
        #endregion

        #region InsertMany
        /// <summary>
        /// Insert many objects in context
        /// </summary>
        /// <param name="entities">List of entities</param>
        void InsertMany(List<TEntity> entities);
        #endregion

        #region GetById
        /// <summary>
        /// Obtém uma Entity apartir de sua chave
        /// </summary>
        /// <param name="chave">Chave de identificação da Entity</param>
        /// <returns>Entidade requisitada</returns>
        TEntity GetById(long key);
        #endregion

        #region Update
        /// <summary>
        /// Altera uma Entity no contexto
        /// </summary>
        /// <param name="entity">Entidade</param>
        void Update(TEntity entity);
        #endregion

        #region Delete
        /// <summary>
        /// Exclui uma Entity do contexto
        /// </summary>
        /// <param name="chave">Chave de identificação da Entity</param>
        void Delete(int key);
        #endregion

        #region Save
        /// <summary>
        /// Salva as alterações do contexto na base de dados
        /// </summary>
        /// <returns>Numero de linhas afetadas. Se não conseguir executar nada retorna negativo.</returns>
        int Save();
        #endregion
    }
}
