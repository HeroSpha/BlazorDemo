using BlazorDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User> GetUser(int Id);
        Task<List<User>> GetUsersAsync();
    }
}
