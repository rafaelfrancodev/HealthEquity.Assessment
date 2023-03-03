using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        Car Insert(Car car);
        Car Update(Car updatedCar);
        bool Delete(int id);
    }
}
