using Microsoft.Practices.EnterpriseLibrary.Logging;
using Oasp4net.Infrastructure.Logging;
using System;
using System.Data.Entity;
using System.Diagnostics;

namespace Oasp4net.DataAccessLayer.Transaction
{
    /// <summary>
    /// Implements <see cref="ITransactionScope"/>
    /// </summary>
    public class TransactionScope : ITransactionScope
    {

        /// <summary>
        /// Database Context
        /// </summary>
        private RestaurantContext dbContext;

        /// <summary>
        /// Transaction context
        /// </summary>
        private DbContextTransaction transaction;

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="dbContext">Database context</param>
        public TransactionScope(RestaurantContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Implements <see cref="ITransactionScope.BeginTransaction"/>
        /// </summary>
        public void BeginTransaction()
        {
            transaction = dbContext.Database.BeginTransaction();
        }

        /// <summary>
        /// Implements <see cref="ITransactionScope.Commit"/>
        /// </summary>
        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Logger.Write(string.Format("Exception during commit: {0}",ex.ToString()), LogCategory.DefaultCategory, LogPriority.High, 0, TraceEventType.Error);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception exRollback)
                {
                    Logger.Write(string.Format("Exception during rollback after commit exception: {0}", ex.ToString()), LogCategory.DefaultCategory, LogPriority.High, 0, TraceEventType.Error);
                    transaction.Dispose();
                    throw exRollback;
                }
                transaction.Dispose();
                throw ex;
            }
        }

        /// <summary>
        /// Implements <see cref="ITransactionScope.Rollback"/>
        /// </summary>
        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            catch (Exception ex)
            {
                Logger.Write(string.Format("Exception during rollback: {0}", ex.ToString()), LogCategory.DefaultCategory, LogPriority.High, 0, TraceEventType.Error);
                transaction.Dispose();
                throw ex;
            }
        }
    }
}
