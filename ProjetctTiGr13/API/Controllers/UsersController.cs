using Microsoft.AspNetCore.Mvc;
using ProjetctTiGr13.Helpers;
using ProjetctTiGr13.Models;
using ProjetctTiGr13.Services;

namespace ProjetctTiGr13.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new {message = "Pseudo ou mot de passe incorrect"});

            return Ok(response);
        }
        
        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}