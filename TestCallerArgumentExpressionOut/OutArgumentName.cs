namespace TestCallerArgumentExpressionOut;

public class OutArgumentName
{
    [Fact]
    public void StringNameOut()
    {
        ArgNameTester.GetArgValueByNameOut(out string valueStringName);
        Assert.Equal("valueStringName", valueStringName);
    }

    [Fact]
    public void VarNameOut()
    {
        ArgNameTester.GetArgValueByNameOut(out var valueVarName);
        Assert.Equal("valueVarName", valueVarName);
    }

    [Fact]
    public void StringNameReturn()
    {
        string valueStringName = "";
        ArgNameTester.GetArgValueByNameReturn(valueStringName);
        Assert.Equal("valueStringName", valueStringName);
    }

    [Fact]
    public void VarNameReturn()
    {
        var valueVarName = "";
        ArgNameTester.GetArgValueByNameReturn(valueVarName);
        Assert.Equal("valueVarName", valueVarName);
    }
}