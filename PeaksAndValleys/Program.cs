using CsvHelper;
using System.Globalization;

namespace PeaksAndValleys;
class Program
{

    static void Main(string[] args)
    {
        //input file path as parameter
        var recordList = CsvLine.GetCsvData("/Users/caulinsnarr/Desktop/Code Test Eight Round.csv");

        //re-order the records by x ascending since the data is coming in descending
        //assuming x is time, if not necessary, getpeaks and valleys by recordList on Line 11 - NOT sortedRecordList
        var sortedRecordList = recordList.OrderBy(cl => cl.X).ToList();

        List<CsvLine> peaks = Peaks.GetPeaks(sortedRecordList);
        List<CsvLine> valleys = Valleys.GetValleys(sortedRecordList);

        //for debugging 
        Console.WriteLine("Peaks");

        foreach (var val in peaks)
        {
            Console.WriteLine($"{val.X}, {val.Y}");
        }

        Console.WriteLine("-----------------");
        Console.WriteLine("Valleys");

        foreach (var val in valleys)
        {
            Console.WriteLine($"{val.X}, {val.Y}");
        }
    }
}

