using Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Controllers
{
    class CarController
    {
        public List<CarTable> GetCars()
        {
            using (CarDatabaseEntities ex = new CarDatabaseEntities())
            {
                return ex.CarTables.ToList();
            }
        }
        public void CreateCar(CarTable car)
        {
            using (CarDatabaseEntities ex = new CarDatabaseEntities())
            {
                var lastCar = ex.CarTables.ToList().LastOrDefault();
                if (lastCar == null)
                {
                    lastCar = new CarTable();
                    lastCar.Id = 0;
                }
                car.Id = lastCar.Id + 1;
                ex.CarTables.Add(car);
                ex.SaveChanges();
            }
        }
    }
}
