using Microsoft.AspNetCore.Mvc;
using ProjetctTiGr13.Entities;
using ProjetctTiGr13.Helpers;
using ProjetctTiGr13.Models;
using ProjetctTiGr13.Services;

namespace API.Controllers
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
            return Ok(_userService.GetAll());
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            return Ok(_userService.GetRepository().Create(user));
        }
        
        

        [HttpPut]
        public ActionResult<User> Put(User user)
        {
            if (_userService.GetRepository().Update(user))
            {
                return Ok();
            }

            return NotFound();
        }
        
    }
}