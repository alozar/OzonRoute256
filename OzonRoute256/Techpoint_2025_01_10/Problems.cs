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
    public static void ValidateOutput()
    {
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
