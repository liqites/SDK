using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClearInsight.Model
{
    /// <summary>
    /// Class <c>KpiEntry</c>
    /// Model for Kpi Entry
    /// </summary>
    public class KpiEntry
    {
        /// <summary>
        /// constructor<c>KpiEntry()</c>
        /// </summary>
        public KpiEntry()
        {
            this.EntryType = "1";
            this.Attributes = new List<KpiProperty>();
        }
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

        /// <summary>
        /// Property <c>EntryType<c>
        /// entry_type for kpi entry,if not set,it will be 0
        /// <remarks>0 should be the Kpi Entry detail,1 should be the Kpi Entry,
        /// you can't change the KpiEntry value with EntryType 1 if it has  Kpi Entry details
        /// </remarks>
        /// <summary>
        public string EntryType {get; set;}

        /// <summary>
        /// Property<c>Attribute</c>
        /// properties of kpi entry
        /// </summary>
        public IList<KpiProperty> Attributes { get; set; }

        /// <summary>
        /// Function<c>toJson</c>
        /// </summary>
        /// <returns><c>string</c></returns>
        public string toJson()
        {
            return toJsonObject().ToString();
        }

        /// <summary>
        /// Function<c>toJsonObject</c>
        /// return JObject
        /// </summary>
        /// <returns>JObject</returns>
        public JObject toJsonObject()
        {
            JObject o = new JObject();
            JObject o2 = new JObject();

            o["kpi_id"] = this.KpiID;
            o["date"] = this.Date;
            o["value"] = this.Value;
            o["email"] = this.Email;
            o["entry_type"] = this.EntryType;

            foreach (var property in this.Attributes)
            {
                o2[property.Name] = property.Value;
            }
            o["kpi_properties"] = o2;

            return o;
        }
    }
}
