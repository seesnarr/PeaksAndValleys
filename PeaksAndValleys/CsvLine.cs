using System;
using System.Globalization;
using CsvHelper;

namespace PeaksAndValleys
{
    public class CsvLine
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        //is there a better place for this
        public static List<CsvLine> GetCsvData(string filePath)
        {
            List<CsvLine> recordList;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //added 2 csv.Read() for the first 2 rows in csv
                csv.Read();
                csv.Read();

                IEnumerable<CsvLine> records = csv.GetRecords<CsvLine>();

                recordList = records.ToList();
            }

            return recordList;
        }
    }
}

