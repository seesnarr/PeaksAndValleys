using PeaksAndValleys;

namespace UnitTests;

public class UnitTest1
{
    //need to figure out data creation in order to consolidate test cases using Theory attribute

    [Fact]
    public void Peaks_InputHas1Peak_ReturnsExpectedValue()
    {
        CsvLine expectedPeak = new CsvLine() { X = 3, Y = 4 };

        List<CsvLine> input = new List<CsvLine>
        {
            new CsvLine() { X = 0, Y = 1 },
            new CsvLine() { X = 1, Y = 2 },
            new CsvLine() { X = 2, Y = 3 },
            expectedPeak,
            new CsvLine() { X = 4, Y = 3 },
            new CsvLine() { X = 5, Y = 2 }
        };

        var actualPeak = Peaks.GetPeaks(input).SingleOrDefault();

        Assert.Equal(expectedPeak, actualPeak);
    }

    [Fact]
    public void Valleys_InputHas1Valley_ReturnsExpectedValue()
    {
        CsvLine expectedValley = new CsvLine() { X = 3, Y = 2 };

        List<CsvLine> input = new List<CsvLine>
        {
            new CsvLine() { X = 0, Y = 5 },
            new CsvLine() { X = 1, Y = 4 },
            new CsvLine() { X = 2, Y = 3 },
            expectedValley,
            new CsvLine() { X = 4, Y = 3 },
            new CsvLine() { X = 5, Y = 4 }
        };

        var actualValley = Valleys.GetValleys(input).SingleOrDefault();

        Assert.Equal(expectedValley, actualValley);
    }

    [Fact]
    public void Peaks_InputHas2Peaks_ReturnsExpectedValue()
    {
        CsvLine expectedPeak1 = new CsvLine() { X = 3, Y = 4 };
        CsvLine expectedPeak2 = new CsvLine() { X = 8, Y = 5 };
        CsvLine unexpectedValley = new CsvLine() { X = 5, Y = 2 };

        List<CsvLine> expectedPeaks = new List<CsvLine> { expectedPeak1, expectedPeak2 };

        List<CsvLine> input = new List<CsvLine>
        {
            new CsvLine() { X = 0, Y = 1 },
            new CsvLine() { X = 1, Y = 2 },
            new CsvLine() { X = 2, Y = 3 },
            expectedPeak1,
            new CsvLine() { X = 4, Y = 3 },
            unexpectedValley,
            new CsvLine() { X = 6, Y = 3 },
            new CsvLine() { X = 7, Y = 4 },
            expectedPeak2,
            new CsvLine() { X = 9, Y = 4 }
        };

        var actualPeaks = Peaks.GetPeaks(input);

        Assert.Equal(expectedPeaks, actualPeaks);
        Assert.DoesNotContain(unexpectedValley, expectedPeaks);
    }

    [Fact]
    public void Valleys_InputHas2Valleys_ReturnsExpectedValue()
    {
        CsvLine expectedValley1 = new CsvLine() { X = 3, Y = 2 };
        CsvLine expectedValley2 = new CsvLine() { X = 8, Y = 1 };
        CsvLine unexpectedPeak = new CsvLine() { X = 5, Y = 4 };

        List<CsvLine> expectedValleys = new List<CsvLine> { expectedValley1, expectedValley2 };

        List<CsvLine> input = new List<CsvLine>
        {
            new CsvLine() { X = 0, Y = 5 },
            new CsvLine() { X = 1, Y = 4 },
            new CsvLine() { X = 2, Y = 3 },
            expectedValley1,
            new CsvLine() { X = 4, Y = 3 },
            unexpectedPeak,
            new CsvLine() { X = 6, Y = 3 },
            new CsvLine() { X = 7, Y = 2 },
            expectedValley2,
            new CsvLine() { X = 9, Y = 2 },
        };

        var actualValleys = Valleys.GetValleys(input);

        Assert.Equal(expectedValleys, actualValleys);
        Assert.DoesNotContain(unexpectedPeak, expectedValleys);
    }
}