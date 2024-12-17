using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Tests
{
    public class StringOperatioinsTests
    {
        [Fact(Skip = "Hasta que se me ronquen los buebos")]
        public void ConcatenateStrings() {
            var strOperations = new StringOperations();

            var result = strOperations.ConcatenateStrings("Hello", "World");

            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("racecar");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("Pendejooo");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.RemoveWhitespace("Probando Remove White Spaces");
            //Assert
            Assert.DoesNotContain(" ", result);
            Assert.Equal("ProbandoRemoveWhiteSpaces", result);
        }

        [Fact]
        public void QuantityInWords() {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.QuantintyInWords("cat", 10);
            //Assert
            Assert.StartsWith("ten", result);
            Assert.Contains("cat", result);
        }

        [Fact]
        public void GetStringLength_Exception(){
            var strOpreations = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>( () => strOpreations.GetStringLength(null)  );
        }

        [Fact]
        public void GetStringLength()
        {
            var strOpreations = new StringOperations();

            var result = strOpreations.GetStringLength("Hello World");

            Assert.Equal(11, result);
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        public void FromRomanToNumber( string romanNumber, int Expected ) {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(Expected, result);
        }

        [Fact]
        public void CountOccurrences() {

            var moqLogger = new Mock<ILogger<StringOperations>>();
            var strOperations = new StringOperations(moqLogger.Object);
            
            var resutl = strOperations.CountOccurrences("Hello World", 'o');

            Assert.Equal(2, resutl);
        }

        [Fact]
        public void ReadFile()
        {
            var strOpreations = new StringOperations();
            var mockFileReader = new Mock<IFileReaderConector>();

            mockFileReader.Setup(x => x.ReadString("test.txt")).Returns("Hello World");

            var result = strOpreations.ReadFile(mockFileReader.Object, "test.txt");

            Assert.Equal("Hello World", result);
        }
    }
}
