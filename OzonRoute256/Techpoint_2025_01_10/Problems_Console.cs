namespace OzonRoute256.Techpoint_2025_01_10;

public static class Problems_Console
{
    public static void DigitRemove()
    {
        using var input = new StreamReader(Console.OpenStandardInput());
        using var output = new StreamWriter(Console.OpenStandardOutput());

        int t = int.Parse(input.ReadLine()!);
        string[] sums = new string[t];
        for (int i = 0; i < t; i++)
        {
            sums[i] = input.ReadLine()!;
        }

        Problems.DigitRemove(t, sums);

        output.Write(string.Join("\n", sums));
    }

    public static void ValidateOutput()
    {
        using var input = new StreamReader(Console.OpenStandardInput());
        using var output = new StreamWriter(Console.OpenStandardOutput());

        int t = int.Parse(input.ReadLine()!);

        int[] n = new int[t];
        string[] data = new string[t];
        string[] verifiableData = new string[t];

        for (int i = 0; i < t; i++)
        {
            n[i] = int.Parse(input.ReadLine()!);
            data[i] = input.ReadLine()!;
            verifiableData[i] = input.ReadLine()!;
        }

        string[] results = Problems.ValidateOutput(n, data, verifiableData);

        output.Write(string.Join("\n", results));
    }
}
