using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication40.Models;

namespace WebApplication40.Controllers
{
    
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtAuthManager jwtAuthManager;

        public AuthController(IJwtAuthManager jwtAuthManager)
        {
            this.jwtAuthManager = jwtAuthManager;
        }

        [HttpPost]
        [Route("api/login")]
        public IActionResult Login(UserCred userCred)
        {
            var token = jwtAuthManager.Authenticate(userCred.Username, userCred.Password);
            if(token == null) 
                return Unauthorized();
            return Ok(token);
        }
    }
}
