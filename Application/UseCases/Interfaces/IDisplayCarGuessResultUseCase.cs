using Application.UseCases.Results;

namespace Application.UseCases.Interfaces
{
    public interface IDisplayCarGuessResultUseCase
    {
        GuessResult Execute(double guess, double price);
    }
}
