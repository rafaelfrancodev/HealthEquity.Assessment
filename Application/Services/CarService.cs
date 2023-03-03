using Application.Services.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class CarService : ICarService
    {
        private List<Car> _cars = new List<Car>{
            new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
            new Car { Id = 2, Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 },
            new Car { Id = 3, Make = "Porsche", Model = "911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
            new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
            new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 },
        };

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(car => car.Id == id).ToList();
        }

        public Car Insert(Car car)
        {
            _cars.Add(car);
            return car;
        }

        public Car Update(Car updatedCar)
        {
            Car car = _cars.Find(car => car.Id == updatedCar.Id);

            if (car == null)
            {
                return null!;
            }

            car.Make = updatedCar.Make;
            car.Model = updatedCar.Model;
            car.Year = updatedCar.Year;
            car.Doors = updatedCar.Doors;
            car.Color = updatedCar.Color;
            car.Price = updatedCar.Price;

            return updatedCar;
        }

        public bool Delete(int id)
        {
            Car car = _cars.Find(car => car.Id == id);
            if (car == null)
            {
                return false;
            }

            return _cars.Remove(car);
        }
    }
}
