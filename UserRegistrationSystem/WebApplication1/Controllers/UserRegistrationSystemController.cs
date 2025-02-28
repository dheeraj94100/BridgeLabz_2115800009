using BusinessLayer.service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Route("api/user")]
    public class UserRegistrationSystemController : ControllerBase
        {
            UserServiceBL _userServiceBL;

            public UserRegistrationSystemController(UserServiceBL userServiceBL)
            {
                _userServiceBL = userServiceBL;
            }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User Registration System");
        }

        [HttpPost]
            public IActionResult Register(User user)
            {
                var result = _userServiceBL.RegisterUser(user);
                if (result == "User already exists")
                {
                    return Conflict(new { message = result });
                }
                return Ok(new { message = result });
            }
        }
}
