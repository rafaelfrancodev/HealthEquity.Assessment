using Application.Services;
using Application.Services.Interfaces;
using Application.UseCases;
using Application.UseCases.Interfaces;

namespace HealthEquity.Assessment.DependencyInjection
{
    public static class ApplicationDependencyInjection
    {
        public static void AddApplicationDependencies(this IServiceCollection service)
        {
            service.AddSingleton<ICarService, CarService>();
            service.AddScoped<IDisplayCarGuessResultUseCase, DisplayCarGuessResultUseCase>();
        }
    }
}
