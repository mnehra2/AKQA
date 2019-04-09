using AKQA.Feature.ConvertNumberToWords.Repositories;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AKQA.Feature.ConvertNumberToWords.Tests.Repositories
{
    [TestClass]
    public class NumberToWordsRepositoryTest
    {
        [TestMethod]
        public void GetWordsFromAmount_ReturnsStringInWords()
        {
            // Arrange         
            decimal amount = 144.20M;

            //Act
            var model = new NumberToWordsRepository();
            var stringInWords = model.GetWordsFromAmount(amount);

            // Assert
            stringInWords.Should().Be("ONE HUNDRED  FORTY-FOUR DOLLARS AND TWENTY CENTS");

        }

        [TestMethod]
        public void GetWordsFromAmount_ReturnsInCorrectStringInWords()
        {
            // Arrange         
            decimal amount = 144.20M;

            //Act
            var model = new NumberToWordsRepository();
            var stringInWords = model.GetWordsFromAmount(amount);

            // Assert
            stringInWords.Should().NotBe("ONE HUNDRED  FORTY-FOUR DOLLARS AND THIRTY CENTS");

        }
    }
}
