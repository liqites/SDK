using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Exception
{
    /// <summary>
    /// Exception <c>CIPropertyMissingException</c>
    /// </summary>
    class CIPropertyMissingException : ClearInsightException
    {
        /// <summary>
        /// CIPropertyMissingException
        /// </summary>
        /// <param name="message">Error Message</param>
        public CIPropertyMissingException(string message)
        { }

        /// <summary>
        /// CIPropertyMissingException
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <param name="innerException">System Exception</param>
        public CIPropertyMissingException(string message,System.Exception innerException)
        { }
    }
}
