using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.Unity;
using Oasp4net.DataAccessLayer.Transaction;
using Oasp4net.Infrastructure.Logging;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Oasp4net.ServiceLayer.Api
{
    public class RestaurantController: ApiController
    {      
        /// <summary>
        /// Default Konstruktor
        /// </summary>
        public RestaurantController() : base()
        {
        }


        /// <summary>
        /// Gibt und setzt den TransactionScope
        /// </summary>
        [Dependency]
        public ITransactionScope TransactionScope { private get; set; }

        /// <summary>
        /// Asynchrone Ausführung eines http Requests
        /// </summary>
        /// <param name="controllerContext">Controller Context</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Neu gestartete Task</returns>
        public override async Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        {
            Logger.Write(string.Format("Start Action method: {0}", controllerContext.Request.RequestUri), LogCategory.DefaultCategory, LogPriority.Normal, 0, TraceEventType.Information);
            TransactionScope.BeginTransaction();
            HttpResponseMessage result;
            try
            {                
                result = await base.ExecuteAsync(controllerContext, cancellationToken);
            }
            catch (Exception ex)
            {
                Logger.Write(string.Format("Error executing action method: {0}  Exception: {1}", controllerContext.ToString(), ex.ToString()),
                    LogCategory.DefaultCategory, LogPriority.Normal, 0, TraceEventType.Information);
                TransactionScope.Rollback();                
                throw;
            }

            try
            {
                TransactionScope.Commit();
                Logger.Write(string.Format("End Action method: {0}", controllerContext.Request.RequestUri), 
                    LogCategory.DefaultCategory, LogPriority.Normal, 0, TraceEventType.Information);
                return result;
            }
            catch (Exception ex)
            {
                Logger.Write(string.Format("Error executint action method: {0}    {1}", controllerContext.Request.RequestUri, ex.ToString()), 
                    LogCategory.DefaultCategory, LogPriority.High, 0, TraceEventType.Error);
                Console.WriteLine(ex);
                throw;
            }            
        }
    }
}
