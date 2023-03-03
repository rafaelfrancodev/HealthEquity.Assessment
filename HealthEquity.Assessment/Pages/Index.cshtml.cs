using Application.Services.Interfaces;
using Application.UseCases.Interfaces;
using Application.UseCases.Results;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthEquity.Assessment.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ICarService _carService;
        private readonly IDisplayCarGuessResultUseCase _displayCarGuessResultUse;
        public Car Car { get; set; }
        public GuessResult Result { get; set; }

        public IndexModel(ICarService carService, IDisplayCarGuessResultUseCase displayCarGuessResultUse)
        {
            _carService = carService;
            _displayCarGuessResultUse = displayCarGuessResultUse;
            Car = _carService.GetAll()[new Random().Next(_carService.GetAll().Count)];
        }

        public void OnGet()
        {}

        public void OnPost()
        {

            var guess = Request.Form["Guess"];
            double.TryParse(guess, out var inputValue);
            Result = _displayCarGuessResultUse.Execute(inputValue, Car.Price);
        }
    }
}