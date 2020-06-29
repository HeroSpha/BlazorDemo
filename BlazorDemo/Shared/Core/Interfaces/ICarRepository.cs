using BlazorDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Core.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> AddAsync(Car car);
        Task<List<Car>> GetCarsAsync();
    }
}
