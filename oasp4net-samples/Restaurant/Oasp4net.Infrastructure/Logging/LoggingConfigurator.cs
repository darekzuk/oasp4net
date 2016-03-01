using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System.Configuration;
using System.Diagnostics;

namespace Oasp4net.Infrastructure.Logging
{
    /// <summary>
    /// Configures the enterprise library logging application block
    /// </summary>
    public static class LoggingConfigurator
    {
        /// <summary>
        /// Initialized the configuartion 
        /// </summary>
        /// <returns></returns>
        public static LoggingConfiguration ConfigureLogging()
        {
            // Read the log file path
            var appSettings = ConfigurationManager.AppSettings;
            var logfilePath = appSettings[ApplicationConstants.LogFilePath];
            if (string.IsNullOrEmpty(logfilePath))
            {
                logfilePath = @".\default.log";
            }

            

            // Formatter
            var textFormatter = new TextFormatter("Timestamp: {timestamp(local)}{newline}Message: {message}{newline} Priority: {priority}");

            // flat file trace
            var flatFileTraceListener = new FlatFileTraceListener(
                logfilePath,
                "----------------------------------------",
                "----------------------------------------",
                textFormatter);

            // Build Configuration, with one default priority
            var config = new LoggingConfiguration();
            config.AddLogSource(
               LogCategory.DefaultCategory,
               SourceLevels.All,
               true).AddTraceListener(flatFileTraceListener); 
            
            config.IsTracingEnabled = true;            
            return config;
        }
    }
}
