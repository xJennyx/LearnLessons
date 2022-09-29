using Lesson1.Architecture.Models;
using Lesson1.Architecture.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        [HttpPost]
        public ActionResult <bool> Login(LoginRequest request)
        {
            var authService = new AuthService();

            return Ok(authService.Login(request.LastName));
        }
    }
}
