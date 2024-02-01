using System.Runtime.CompilerServices;

ArgNameTester.GetArgValueByName(out string myName);
Console.WriteLine(myName);

string testValue = "test";
var result = ArgNameTester.GetArgValueByNameReturn(testValue);
Console.WriteLine(result);

public class ArgNameTester
{
    public static void GetArgValueByName(out string value, [CallerArgumentExpression(nameof(value))] string key = "")
    {
        value = key;
    }

    public static string GetArgValueByNameReturn(string value, [CallerArgumentExpression(nameof(value))] string key = "")
    {
        return key;
    }
}

//return $"{key} ({value})";
