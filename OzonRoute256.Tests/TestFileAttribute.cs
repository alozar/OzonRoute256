using System.Reflection;
using Xunit.Sdk;

namespace OzonRoute256.Tests;

internal class TestFileAttribute : DataAttribute
{
    private readonly string _testFilePath;

    public TestFileAttribute(string contestName, string problemName, string testFileName)
    {
        _testFilePath = Path.Combine(
                Path.GetFullPath(@"..\\..\\.."),
                contestName,
                problemName,
                testFileName);

        if (!File.Exists(_testFilePath))
        {
            throw new ArgumentException($"Не нашел файл теста \"{_testFilePath}\"");
        }
    }

    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        var input = File.ReadAllLines($"{_testFilePath}");
        var expected = File.ReadAllLines($"{_testFilePath}.a");
        yield return new object[] { input, expected };
    }
}
