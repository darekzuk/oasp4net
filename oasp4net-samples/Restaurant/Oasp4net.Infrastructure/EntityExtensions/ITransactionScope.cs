
namespace Oasp4net.DataAccessLayer.Transaction
{
    /// <summary>
    /// Interface for transactions
    /// </summary>
    public interface ITransactionScope
    {
        /// <summary>
        /// Starts a new transaction
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Starts a commit and close the transaction
        /// </summary>
        void Commit();

        // Starts a rollback
        void Rollback();
    }
}
