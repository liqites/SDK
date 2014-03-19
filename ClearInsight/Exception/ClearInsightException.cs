using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Exception
{
    /// <summary>
    /// Exception <c>ClearInsightException</c>
    /// Base ClearInsight Exception
    /// </summary>
    [Serializable]
    class ClearInsightException : ApplicationException
    {
        /// <summary>
        /// ClearInsightException
        /// </summary>
        public ClearInsightException()
        { }

        /// <summary>
        /// ClearInsightException
        /// </summary>
        /// <param name="message">Error Message</param>
        public ClearInsightException(string message) : base(message)
        {
            
        }

        /// <summary>
        /// ClearInsightException
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <param name="innerException">System Exception</param>
        public ClearInsightException(string message, System.Exception innerException)
            :base(message,innerException)
        {
            
        }
    }
}
