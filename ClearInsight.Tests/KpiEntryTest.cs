using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearInsight;
using ClearInsight.Model;

namespace ClearInsight.Tests
{
    public class KpiEntryTest
    {
        private ClearInsightAPI api;
        public KpiEntryTest()
        {
            api = new ClearInsightAPI("http://192.168.1.112:3000", "75d01f648f80b01ca975d4ec8b00acf72cca8be60156e96e5fcc7c534cc1fcb4");
        }

        public void TestImportsingleKpiEntry()
        {
            Console.WriteLine("Test Single KpiEntry");
            //init kpientry
            KpiEntry entry = new KpiEntry();
            entry.KpiID = "1";
            entry.Value = "100";
            entry.Date = "2014-5-5";
            entry.Email = "C-RBA_User@leoni.com";
            //entry.EntryType = "1";
            //property
            KpiProperty property = new KpiProperty();
            property.Name = "SEX";
            property.Value = "MAN";
            //add attribute
            entry.Attributes.Add(property);
            //call api
            CIResponse response = api.ImportKpiEntries(entry);
            //
            Console.WriteLine(response.ToString());
        }

        public void TestImportbulkKpiEntries()
        {
            Console.WriteLine("Test Bulk KpiEntries");
            //init kpientry
            List<KpiEntry> entries = new List<KpiEntry>();
            DateTime time = DateTime.Today;
            Console.WriteLine(DateTime.Now);

            //property
            KpiProperty property = new KpiProperty();
            property.Name = "SEX"; 

            for (int i = 0; i < 5; i++)
            {
                property.Value =i%2==0 ? "MAN" : "WOMAN";
                KpiEntry entry = new KpiEntry();
                entry.KpiID = "1";
                entry.Value = (i+300).ToString();
                entry.Date = time.AddMinutes(i).ToString();
                entry.Email = "C-RBA_User@leoni.com";
                //entry.EntryType = "0";
                entry.Attributes.Add(property);
                entries.Add(entry);
            }
            //cal api
            CIResponse response = api.ImportKpiEntries(entries.ToArray());
            Console.WriteLine(DateTime.Now);
            //
            Console.WriteLine(response.ToString());
        }

        public void TestImportKpiEntryAsync()
        {
            Console.WriteLine("Test Single KpiEntry Async");
            //init kpientry
            KpiEntry entry = new KpiEntry();
            entry.KpiID = "1";
            entry.Value = "200";
            entry.Date = "2014-3-20";
            entry.Email = "C-RBA_User@leoni.com";
            //entry.EntryType = "1";
            //property
            KpiProperty property = new KpiProperty();
            property.Name = "test";
            property.Value = "100";
            //add attribute
            entry.Attributes.Add(property);
            //cal api
            api.ImportKpiEntriesAsync(entry, res => { Console.WriteLine(res.ToString()); });
            //
        }

        public void TestImportKpiEntriesAsync()
        {
            Console.WriteLine("Test Bulk KpiEntries Async");
            //init kpientry
            List<KpiEntry> entries = new List<KpiEntry>();
            DateTime time = DateTime.Today;
            //property
            KpiProperty property = new KpiProperty();
            property.Name = "test";
            property.Value = "100";
            for (int i = 0; i < 100; i++)
            {
                KpiEntry entry = new KpiEntry();
                entry.KpiID = "1";
                entry.Value = "200";
                entry.Date = time.AddDays(i).ToString();
                entry.Email = "C-RBA_User@leoni.com";
                //entry.EntryType = "1";
                entry.Attributes.Add(property);
                entries.Add(entry);
            }
            //cal api
            api.ImportKpiEntriesAsync(entries.ToArray(), res => { Console.WriteLine(res.ToString()); });
            //
        }

        //test kpi entries with batch
        public void TestImportbulkKpiEntriesBatch()
        {
            Console.WriteLine("Test Bulk KpiEntries Batch");
            //init kpientry
            List<KpiEntry> entries = new List<KpiEntry>();
            DateTime time = DateTime.Today;

            for (int i = 0; i < 100; i++)
            {
                //
                KpiEntry entry = new KpiEntry();
                entry.KpiID = "1";
                entry.Value = "200";
                entry.Date = time.AddDays(i).ToString();
                entry.Email = "C-RBA_User@leoni.com";
                //entry.EntryType = "1";
                //property
                KpiProperty property = new KpiProperty();
                property.Name = "test";
                property.Value = "100";
                //add attribute
                entry.Attributes.Add(property);
                entries.Add(entry);
            }
            //cal api
            CIResponse response = api.ImportKpiEntries(entries.ToArray(),true);
            //
            Console.WriteLine(response.ToString());
        }

        public void TestImportKpiEntriesAsyncBatch()
        {
            Console.WriteLine("Test Bulk KpiEntries Async Batch");
            //init kpientry
            List<KpiEntry> entries = new List<KpiEntry>();
            DateTime time = DateTime.Today;
            //property
            KpiProperty property = new KpiProperty();
            property.Name = "test";
            property.Value = "100";
            for (int i = 0; i < 100; i++)
            {
                KpiEntry entry = new KpiEntry();
                entry.KpiID = "1";
                entry.Value = "100";
                entry.Date = time.AddDays(i).ToString();
                entry.Email = "C-RBA_User@leoni.com";
                //entry.EntryType = "1";
                //add attribute
                entry.Attributes.Add(property);
                entries.Add(entry);
            }
            //cal api
            api.ImportKpiEntriesAsync(entries.ToArray(), res => { Console.WriteLine(res.ToString()); },true);
            //
        }

        public void TestErrorMessage()
        {
            Console.WriteLine("Test Error Message!");
            //init kpiEntry
            KpiEntry entry = new KpiEntry();
            entry.KpiID = "1";
            entry.Value = "155";
            entry.Date = DateTime.Today.ToString();
            entry.Email = "C-RBA_User@leoni.com";
            //entry.EntryType = "1";
            //property
            KpiProperty property = new KpiProperty();
            property.Name = "test";
            property.Value = "100";
            //
            entry.Attributes.Add(property);
            CIResponse res = api.ImportKpiEntries(entry);
            Console.WriteLine("Error Message:"+res.ToString());
        }
    }
}
