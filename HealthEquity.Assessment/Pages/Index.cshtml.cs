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
        public int Guess { get; set; }
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
            Result = _displayCarGuessResultUse.Execute(Guess, Car.Price);
        }
    }
}