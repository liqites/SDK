using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Exception
{
    /// <summary>
    /// Class<c>CIArgumentErrorException</c>
    /// Argument Error Exception
    /// </summary>
    class CIArgumentErrorException : ClearInsightException
    {
        /// <summary>
        /// CIArgumentErrorException
        /// </summary>
        /// <param name="message">Error message</param>
        public CIArgumentErrorException(string message)
        { }

        /// <summary>
        /// CIArgumentErrorException
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <param name="innerException">System Exception</param>
        public CIArgumentErrorException(string message, System.Exception innerException)
        {
            
        }
    }
}
