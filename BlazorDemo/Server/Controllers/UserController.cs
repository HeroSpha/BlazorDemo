using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Shared.Core.Interfaces;
using BlazorDemo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        [HttpPost("adduser")]
        public async Task<IActionResult> AddUser([FromBody]User user)
        {
            try
            {
                return Ok(await userRepository.AddUserAsync(user));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                return Ok(await userRepository.GetUsersAsync());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
