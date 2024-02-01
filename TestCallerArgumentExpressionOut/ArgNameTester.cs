using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCallerArgumentExpressionOut;

public class ArgNameTester
{
    public static void GetArgValueByNameOut(out string value, [CallerArgumentExpression(nameof(value))] string key = "")
    {
        value = key;
    }

    public static string GetArgValueByNameReturn(string value, [CallerArgumentExpression(nameof(value))] string key = "")
    {
        return $"{key} ({value})";
        //return key;
    }
}
