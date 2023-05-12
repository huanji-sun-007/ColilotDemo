using Xunit;

public class StringExtensionsTests
{
    [Fact]
    public void ToSnakeCase_ReturnsCorrectResult()
    {
        // Arrange
        string input = "ThisIsATestString";
        string expectedOutput = "this_is_a_test_string";

        // Act
        string actualOutput = input.ToSnakeCase();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void ToSnakeCase_ReturnsEmptyString_WhenInputIsNull()
    {
        // Arrange
        string input = null;
        string expectedOutput = "";

        // Act
        string actualOutput = input.ToSnakeCase();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void ToSnakeCase_ReturnsEmptyString_WhenInputIsEmpty()
    {
        // Arrange
        string input = "";
        string expectedOutput = "";

        // Act
        string actualOutput = input.ToSnakeCase();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    
}