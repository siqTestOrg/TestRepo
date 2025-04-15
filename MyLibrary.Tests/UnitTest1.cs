using Xunit;
using MyLibrary;

public class UnitTest1
{
    [Fact]
    public void Test_Subtract()
    {
        var Calculator = new Calculator(); 
        int result = Calculator.Subtract(2, 3);
        Assert.Equal(-1, result);  
    }
}
