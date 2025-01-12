using FluentAssertions;
using OzonRoute256.Techpoint_2025_01_10;

namespace OzonRoute256.Tests.Techpoint_2025_01_10;

public class Problems_Tests
{
    [Theory]
    [TestFiles("Techpoint_2025_01_10", "remove-digit")]
    public void DigitRemove_Success(string[] input, string[] expected, string fileName)
    {
        int t = int.Parse(input[0]);
        string[] sums = new string[t];
        for (int i = 0; i < t; i++)
        {
            sums[i] = input[i + 1];
        }

        Problems.DigitRemove(t, sums);

        sums.Should().Equal(expected, fileName);
    }

    [Theory]
    [TestFiles("Techpoint_2025_01_10", "validate-output")]
    public void ValidateOutput_Success(string[] input, string[] expected, string fileName)
    {
        int t = int.Parse(input[0]);

        int[] n = new int[t];
        string[] data = new string[t];
        string[] verifiableData = new string[t];

        for (int i = 0, k = 1; i < t; i++, k += 3)
        {
            n[i] = int.Parse(input[k]);
            data[i] = input[k + 1];
            verifiableData[i] = input[k + 2];
        }

        string[] results = Problems.ValidateOutput(n, data, verifiableData);

        results.Should().Equal(expected, fileName);
    }
}
