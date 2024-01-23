namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
       bool result = true;
       Assert.False(result, "This is a fail");

    }
}