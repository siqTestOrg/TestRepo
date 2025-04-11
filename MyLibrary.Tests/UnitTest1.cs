using Xunit;
using MyLibrary;

public class UnitTest1
{
    [Fact]
    public void Test_Add()
    {
        var Calculator = new Calculator();
        int result = Calculator.Add(2, 3);
        Assert.Equal(6, result);
    }
}
