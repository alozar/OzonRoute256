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
}
