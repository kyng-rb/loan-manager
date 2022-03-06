using Xunit;
using System;

namespace Loans.Application.Test;

public class UnitTest1
{
    private const string _test = "Test on Application";

    [Fact]
    public void Test1()
    {
        Console.WriteLine(_test);
    }
}
