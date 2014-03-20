using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Exception
{
    /// <summary>
    /// Class <c>CIRequestTooLong</c>
    /// throw then http request too long
    /// </summary>
    class CIRequestTooLong : ClearInsightException
    {
        /// <summary>
        /// constructor<c>CIRequestTooLong</c>
        /// </summary>
        /// <param name="message">Error Message</param>
        public CIRequestTooLong(string message)
        { }

        /// <summary>
        /// constructor<c>CIRequestTooLong</c>
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <param name="innerException">System.Exception</param>
        public CIRequestTooLong(string message,System.Exception innerException)
        { }
    }
}
