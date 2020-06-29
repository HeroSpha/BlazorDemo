using BlazorDemo.Shared.Core.Interfaces;
using BlazorDemo.Shared.DAL;
using BlazorDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Core.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DemoDbContext _demoDbContext) : base(_demoDbContext)
        {
        }

        public async Task<User> AddUserAsync(User user)
        {
            try
            {
                var _user = await demoDbContext.Users.AddAsync(user);
                await demoDbContext.SaveChangesAsync();
                return _user.Entity;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<User> GetUser(int userId)
        {
            try
            {
                var _user = await demoDbContext.Users.FirstOrDefaultAsync(f => f.UserId == userId);
                return _user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<User>> GetUsersAsync()
        {
            try
            {
                var users = await demoDbContext.Users
                    .Include(f => f.Cars)
                    .ToListAsync<User>();
                return users.Select(user => new User
                {
                    Name = user.Name,
                    Cars = user.Cars.Select(car => new Car
                    {
                        Make = car.Make,
                        Model = car.Model,
                        Color = car.Color
                    }).ToList()
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
