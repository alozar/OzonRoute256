namespace OzonRoute256.Techpoint_2025_01_10;

public class Problems
{
    /// <summary>
    /// 1. Удалить цифру из числа
    /// </summary>
    public static void DigitRemove(int t, string[] sums)
    {
        for (int i = 0; i < sums.Length; i++)
        {
            if (sums[i].Length == 1)
            {
                sums[i] = "0";
                continue;
            }

            char[] chars = new char[sums[i].Length - 1];
            bool changed = false;
            for (int j = 0, k = 0; j < sums[i].Length; j++, k++)
            {
                if (!changed && j + 1 < sums[i].Length && sums[i][j] < sums[i][j + 1])
                {
                    chars[k] = sums[i][j + 1];
                    j++;
                    changed = true;
                    continue;
                }

                if (k < sums[i].Length - 1)
                {
                    chars[k] = sums[i][j];
                }
            }

            sums[i] = new(chars);
        }
    }

    /// <summary>
    /// 2. Валидация ответа
    /// </summary>
    public static string[] ValidateOutput(int[] n, string[] data, string[] verifiableData)
    {
        string[] results = new string[n.Length];
        string[] splitedData;
        string[] spletedVerifiableData;
        int[] intData;
        int[] intVerifiableData;
        int count = -1;

        while (true)
        {
            CountLoopStart: count++;
            if (count == n.Length)
            {
                break;
            }

            if (data[count].Length != verifiableData[count].Length)
            {
                results[count] = "no";
                continue;
            }

            splitedData = data[count].Split();
            spletedVerifiableData = verifiableData[count].Split();

            if (spletedVerifiableData.Length != n[count])
            {
                results[count] = "no";
                continue;
            }

            intData = new int[n[count]];
            intVerifiableData = new int[n[count]];
            for (int i = 0; i < n[count]; i++)
            {
                intData[i] = int.Parse(splitedData[i]);
                if (int.TryParse(spletedVerifiableData[i], out int number))
                {
                    intVerifiableData[i] = number;
                    continue;
                }
                results[count] = "no";
                goto CountLoopStart;
            }

            Array.Sort(intData);

            for (int i = 0; i < n[count]; i++)
            {
                if (intData[i] != intVerifiableData[i])
                {
                    results[count] = "no";
                    goto CountLoopStart;
                }
            }

            results[count] = "yes";
        }

        return results;
    }

    /// <summary>
    /// 3. Ваня и вирусный файл (C#)
    /// </summary>
    public static void VirusFilesCs()
    {
    }

    /// <summary>
    /// 4. Планировщик заказов
    /// </summary>
    public static void OrderPlanner()
    {
    }

    /// <summary>
    /// 5. ASCII-роботы
    /// </summary>
    public static void ASCIIRobots()
    {
    }
}
