namespace TestProject1;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {

  }
}

public class MathTests
{
  [Fact]
  public void Add_TwoNumbers_ReturnsCorrectSum()
  {
    int result = 2 + 3;
    Assert.Equal(5, result);
  }
}

public class StringTests
{
  [Fact]
  public void ToUpper_ConvertsToUpperCase()
  {
    string input = "hello";
    string result = input.ToUpper();
    Assert.Equal("HELLO", result);
  }
}

public class Calculator
{
  public int Multiply(int a, int b) => a * b;
}

public class CalculatorTests
{
  [Fact]
  public void Multiply_TwoNumbers_ReturnsProduct()
  {
    var calculator = new Calculator();
    int result = calculator.Multiply(4, 5);
    Assert.Equal(20, result);
  }
}