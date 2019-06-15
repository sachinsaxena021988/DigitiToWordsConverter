using System;
using Shared.Logging;

namespace Shared
{
    /// <summary>
    /// Logging class
    /// </summary>
    public class ConsoleLogger :ILogger
    {
        #region Public Method
        
        /// <summary>
        /// Log Error
        /// </summary>
        /// <param name="error"></param>
        public void LogError(string error)
        {
            Console.WriteLine(error);
        }

        #endregion
    }
}
