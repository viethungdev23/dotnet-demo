namespace Test;

public class DemoUnitTest
{
    [Fact]
    public void TestAdd()
    {
        // Arrange
        Calculator calculator = new Calculator();
        int x = 3;
        int y = 5;
        int expectedSum = 8;

        // Act
        int actualSum = calculator.Add(x, y);

        // Assert
        Assert.Equal(expectedSum, actualSum);
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b -1 ;
    }
}