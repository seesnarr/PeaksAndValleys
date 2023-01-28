using System;
namespace PeaksAndValleys
{
	public class Valleys
	{
        public static List<CsvLine> GetValleys(List<CsvLine> csvLines)
        {
            List<CsvLine> valleys = new List<CsvLine>();

            for (int i = 0; i < csvLines.Count() - 2; i++)
            {
                if (csvLines[i].Y > csvLines[i + 1].Y && csvLines[i + 1].Y < csvLines[i + 2].Y)
                {
                    //add to valleys
                    valleys.Add(csvLines[i + 1]);
                }
            }

            return valleys;
        }
    }
}

