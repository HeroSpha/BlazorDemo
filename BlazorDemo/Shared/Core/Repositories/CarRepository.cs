using BlazorDemo.Shared.Core.Interfaces;
using BlazorDemo.Shared.DAL;
using BlazorDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Core.Repositories
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(DemoDbContext _demoDbContext) : base(_demoDbContext)
        {
        }

        public async Task<Car> AddAsync(Car car)
        {
            try
            {
                var _car = await demoDbContext.Cars.AddAsync(car);
                await demoDbContext.SaveChangesAsync();
                return _car.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            try
            {
                var _cars = await demoDbContext.Cars
                    .Include(f => f.User)
                    .ToListAsync<Car>();
                return _cars.Select(car => new Car
                {
                    CarId = car.CarId,
                    Make = car.Make,
                    User = new User
                    {
                        Name = car.User.Name,
                        UserId = car.User.UserId
                    }
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
