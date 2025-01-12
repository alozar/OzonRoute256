using System.Reflection;
using Xunit.Sdk;

namespace OzonRoute256.Tests;

internal class TestFilesAttribute : DataAttribute
{
    private readonly IEnumerable<FileInfo> _files;

    public TestFilesAttribute(string contestName, string problemName)
    {
        string dirPath = Path.Combine(
            Path.GetFullPath(@"..\\..\\.."),
            contestName,
            problemName);
        DirectoryInfo dir = new(dirPath);
        if (!dir.Exists)
        {
            throw new ArgumentException($"Не нашел папку c тестами \"{dirPath}\"");
        }

        _files = dir.GetFiles().Where(f => f.Extension == "");
    }

    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        List<object[]> data = new(_files.Count());
        foreach (FileInfo file in _files)
        {
            string[] input = File.ReadAllLines($"{file.FullName}");
            string[] expected = File.ReadAllLines($"{file.FullName}.a");
            yield return new object[] { input, expected, file.FullName };
        }
    }
}
