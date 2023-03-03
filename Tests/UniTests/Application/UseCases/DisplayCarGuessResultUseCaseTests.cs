using Application.UseCases;
using Application.UseCases.Results;
using Xunit;

namespace UniTests.Application.UseCases
{
    public class DisplayCarGuessResultUseCaseTests
    {
        private readonly DisplayCarGuessResultUseCase _useCase = new DisplayCarGuessResultUseCase();

        [Fact]
        public void Execute_GuessWithinRange_ReturnsGreatJobResult()
        {
            // Arrange
            int guess = 85000;
            double price = 90000;

            // Act
            GuessResult result = _useCase.Execute(guess, price);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("green", result.Color);
            Assert.Equal("Great job! Your guess was within $5000 of the actual price.", result.Message);
        }

        [Fact]
        public void Execute_GuessOutOfRange_ReturnsSorryResult()
        {
            // Arrange
            int guess = 50000;
            double price = 90000;

            // Act
            GuessResult result = _useCase.Execute(guess, price);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("red", result.Color);
            Assert.Equal("Sorry, your guess was incorrect.", result.Message);
        }
    }

}
