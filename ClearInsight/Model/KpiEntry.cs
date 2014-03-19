using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Model
{
    /// <summary>
    /// Class <c>KpiEntry</c>
    /// Model for Kpi Entry
    /// </summary>
    public class KpiEntry
    {
        /// <summary>
        /// Property <c>KpiID</c>
        /// id of kpi
        /// <remarks>should not be empty</remarks>
        /// </summary>
        public string KpiID { get; set; }

        /// <summary>
        /// Property <c>Value</c>
        /// value of kpi entry
        /// <remarks>should not be empty</remarks>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Property <c>Email</c>
        /// email for entity user
        /// <remarks>should not be empty.Email of who should enter the kpi entry</remarks>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Property <c>Date</c>
        /// date of kpi entry,
        /// <remarks>should not be empty,should be UTC Time.Time if KpiEntry</remarks>
        /// </summary>
        public string Date { get; set; }
    }
}
