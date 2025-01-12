using OzonRoute256.Techpoint_2025_01_10;

namespace OzonRoute256.Tests.Techpoint_2025_01_10;

public class Problems_Tests
{
    public static IEnumerable<object[]> GetDataDigitRemove()
    {
        List<object[]> data = new();

        int t = 1;
        string[] sums = new[] { "200000" };
        string[] expected = new[] { "20000" };
        data.Add(new object[] { t, sums, expected });

        t = 3;
        sums = new[] { "9", "0", "9123" };
        expected = new[] { "0", "0", "923" };
        data.Add(new object[] { t, sums, expected });

        t = 2;
        sums = new[] { "987654321", "9611511" };
        expected = new[] { "98765432", "961511" };
        data.Add(new object[] { t, sums, expected });

        t = 3;
        sums = new[] { "984724", "32313", "34322" };
        expected = new[] { "98724", "3313", "4322" };
        data.Add(new object[] { t, sums, expected });
        return data;
    }

    [Theory]
    [MemberData(nameof(GetDataDigitRemove))]
    public void DigitRemove_Success(int t, string[] sums, string[] expected)
    {
        Problems.DigitRemove(t, sums);

        Assert.Equal(expected, sums);
    }
}
