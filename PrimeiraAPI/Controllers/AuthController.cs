using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Application.Services;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == DotNetEnv.Env.GetString("TEST_USER_USERNAME") && password == DotNetEnv.Env.GetString("TEST_USER_PASSWORD"))
            {
                var token = TokenService.GenerateToken(new Domain.Model.Employee());
                return Ok(token);
            }

            return BadRequest("Username or Password invalid!");
        }
    }
}
