using System;
using Xunit;
using System.Collections.Generic;
using PalindromesApp.Objects;

namespace PalindromesAppTest
{
    public class PalindromesTest
    {
        [Fact]
        public void Palindromes_Constructor_Result()
        {
            // Arrange
            string userInput = "Hello";

            // Act
            Palindromes newPalindromes = new Palindromes(userInput);

            // Assert
            Assert.Equal(userInput, newPalindromes.GetUserString());
        }

        [Fact]
        public void SetReverseString_Reversal_InputBackwards()
        {
            // Arrange
            string userInput = "Hello";
            string reverseInput = "olleH";
            Palindromes newPalindromes = new Palindromes(userInput);

            // Act
            newPalindromes.SetReverseString();

            // Assert
            Assert.Equal(reverseInput, newPalindromes.GetReverseString());
        }

        [Fact]
        public void CompareStrings_Compare_True()
        {
            // Arrange
            string userInput = "HelloolleH";
            string reverseInput = "olleH";
            Palindromes newPalindromes = new Palindromes(userInput);
            newPalindromes.SetReverseString();

            // Act
            newPalindromes.CompareStrings();

            // Assert
            Assert.Equal(true, newPalindromes.CompareStrings());
        }
    }
}
