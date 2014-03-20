using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearInsight.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Test...");
            KpiEntryTest kpitest = new KpiEntryTest();
            //kpitest.TestImportsingleKpiEntry();
            kpitest.TestImportbulkKpiEntries();
            //kpitest.TestImportKpiEntryAsync();
            //kpitest.TestImportKpiEntriesAsync();
            //kpitest.TestImportbulkKpiEntriesBatch();
            //kpitest.TestImportKpiEntriesAsyncBatch();
            Console.WriteLine("End Test...");
            Console.ReadLine();
        }
    }
}
