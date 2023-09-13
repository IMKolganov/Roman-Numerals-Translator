using System;
using Xunit;
using Roman_Numerals_Translator;

namespace Roman_Numerals_Translator.Tests;

public class IntToRomanExtenstionTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void IntToRoman_ValidNumbers_ReturnsExpectedRomanNumerals(int number, string expected)
    {
        // Arrange & Act
        string result = number.IntToRoman();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IntToRoman_NumberAbove3999_ThrowsException()
    {
        // Arrange
        int number = 4000;

        // Act & Assert
        Assert.Throws<Exception>(() => number.IntToRoman());
    }

    [Fact]
    public void IntToRoman_NegativeNumber_ThrowsException()
    {
        // Arrange
        int number = -5;

        // Act & Assert
        Assert.Throws<Exception>(() => number.IntToRoman());
    }
}