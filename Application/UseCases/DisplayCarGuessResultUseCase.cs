using Application.UseCases.Interfaces;
using Application.UseCases.Results;

namespace Application.UseCases
{
    public class DisplayCarGuessResultUseCase : IDisplayCarGuessResultUseCase
    {
        public GuessResult Execute(double guess, double price)
        {
            var calc = (double)guess - price;
            int difference = (int)Math.Abs(calc);
            string color = "red";
            string message = "Sorry, your guess was incorrect.";

            if (difference <= 5000)
            {
                color = "green";
                message = "Great job! Your guess was within $5000 of the actual price.";
            }

            return new GuessResult { Color = color, Message = message };
        }
    }
}
