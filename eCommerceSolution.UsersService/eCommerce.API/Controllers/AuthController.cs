using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")] //api/Auth
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")] //POST api/auth/register
        public async Task<IActionResult> Register(Core.DTO.RegisterRequest registerRequest) 
        {
            //check if the request is valid
            if (registerRequest == null)
                return BadRequest("Invalid request");

            AuthenticationResponse? response = await _userService.Register(registerRequest);

            if (response == null || !response.Success)             
                return BadRequest(response);            

            return Ok(response);
        }
        [HttpPost("login")] //POST api/auth/register
        public async Task<IActionResult> Login(Core.DTO.LoginRequest loginRequest) 
        {
            //check if the request is valid
            if (loginRequest == null)
                return BadRequest("Invalid request");

            AuthenticationResponse? response = await _userService.Login(loginRequest);

            if (response == null || !response.Success)
                return Unauthorized(response);

            return Ok(response);
        }
    }
}
