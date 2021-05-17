using FIAP.ChatApp.StartupOne.Managers.Extensions;
using FIAP.ChatApp.StartupOne.Managers.Interfaces;
using FIAP.ChatApp.StartupOne.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FIAP.ChatApp.StartupOne.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersManager usersManager;

        public UsersController(IUsersManager usersManager)
        {
            this.usersManager = usersManager;
        }

        [AllowAnonymous]
        [HttpPost("insert")]
        public IActionResult InserUser([FromBody] UserModel userModel)
        {
            try
            {
                var response = usersManager.InsertUser(userModel);
                if (userModel.ID > 0)
                {
                    var user = usersManager.GetUserById(userModel.ID);
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            try
            {
                var userModel = usersManager.Login(loginModel, HttpContext);

                if (userModel == null || !string.IsNullOrEmpty(userModel.ValidationToken))
                {
                    return BadRequest(new { message = "Login or password is incorrect" });
                }
                return Ok(userModel.WithoutPassword());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpPost("refresh")]
        public IActionResult RefreshToken([FromBody] string refreshToken)
        {
            try
            {
                var userModel = usersManager.RefreshToken(refreshToken, HttpContext);
                if (userModel == null)
                {
                    // TODO Log Error Refresh Token not found.
                    return Unauthorized();
                }
                return Ok(userModel);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("getMyFriends/{userId}")]
        public IActionResult GetMyFriends(long userId)
        {
            try
            {
                return Ok(usersManager.GetMyFriends(userId));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}