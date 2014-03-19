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
            //kpitest.TestImportbulkKpiEntries();
            kpitest.TestImportKpiEntriesAsync();
            Console.WriteLine("End Test...");
            Console.ReadLine();
        }
    }
}
