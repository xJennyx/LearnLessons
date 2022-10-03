using Lesson1.Core.ResourceModels;
using Lesson1.Core.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.API.Controllers
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
