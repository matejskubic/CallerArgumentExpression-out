namespace TestCallerArgumentExpressionOut;

public class OutArgumentName
{
    [Fact]
    public void StringName()
    {
        ArgNameTester.GetArgValueByName(out string valueStringName);
        Assert.Equal("valueStringName", valueStringName);
    }

    [Fact]
    public void VarName()
    {
        ArgNameTester.GetArgValueByName(out var valueVarName);
        Assert.Equal("valueVarName", valueVarName);
    }
}