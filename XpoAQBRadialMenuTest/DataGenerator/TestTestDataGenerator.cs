using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator;

namespace MyRibbonBarTest
{
    class TestTestDataGenerator
    {
        //static void Main(string[] args)
        //{
        //    // TextListDataGeneration();
        //    // TestFileDataGenerator();
        //    //o();
        //    // TestProjectRuleDataGenerator();
        //    // TestDbStatementDataGenerator();
        //    // TestTableDataGenerator();
        //    // TestPatternDataGenerator();
        //    // TestMaskValueDataGenerator();
        //    // TestIncrementalDataGenerator();
        //    // TestLibraryDataGenerator();
        //    //TestLowLevelDataGenerator2();
        //    TestLowLevelDataGenerator();
        //}
        static void TestLowLevelDataGenerator()
        {
            Console.WriteLine("Short\tInteger\tSymbol\tUpper\tLower\tDigit\tDouble\tDate\tTime\tString");
            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",
                 DataGeneratorWrapper.ShortRandom(100, 200),
                 DataGeneratorWrapper.IntRandom(1000000, 5000000),
                 DataGeneratorWrapper.CharRandom(),
                 DataGeneratorWrapper.CharRandomUpper(),
                 DataGeneratorWrapper.CharRandomLower(),
                 DataGeneratorWrapper.CharRandomDigit(),
                 DataGeneratorWrapper.DoubleRandom(100, 100000, 2),
                 DataGeneratorWrapper.DateRandom("DD.MM.YYYY", "01.01.2000", "31.12.2009"),
                 DataGeneratorWrapper.TimeRandom("HH:MM:SS", "00:00:00", "23:59:59"),
                 DataGeneratorWrapper.StringRandom(10));
            }
        }

    }
}
