using System;
namespace PeaksAndValleys
{
	public class Peaks
	{
        public static List<CsvLine> GetPeaks(List<CsvLine> csvLines)
        {
            List<CsvLine> peaks = new List<CsvLine>();

            for (int i = 0; i < csvLines.Count() - 2; i++)
            {
                if (csvLines[i].Y < csvLines[i + 1].Y && csvLines[i + 1].Y > csvLines[i + 2].Y)
                {
                    //add to peaks
                    peaks.Add(csvLines[i + 1]);
                }
            }

            return peaks;
        }
    }
}

