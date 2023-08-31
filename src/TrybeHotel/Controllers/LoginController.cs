// using Microsoft.AspNetCore.Mvc;
// using TrybeHotel.Models;
// using TrybeHotel.Repository;
// using TrybeHotel.Dto;
// using TrybeHotel.Services;

// namespace TrybeHotel.Controllers
// {
//     [ApiController]
//     [Route("login")]

//     public class LoginController : Controller
//     {

//         private readonly IUserRepository _repository;
//         public LoginController(IUserRepository repository)
//         {
//             _repository = repository;
//         }

//         [HttpPost]
//         public IActionResult Login([FromBody] LoginDto login){
//            throw new NotImplementedException();
//         }
//     }
// }

using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;
using TrybeHotel.Dto;
using TrybeHotel.Services;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("login")]

    public class LoginController : Controller
    {

        private readonly IUserRepository _repository;
        private readonly TokenGenerator _tokenGenerator;

        public LoginController(IUserRepository repository)
        {
            _repository = repository;
            _tokenGenerator = new TokenGenerator();
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto login){
           var user = _repository.Login(login);

           if (user == null)
           {
            return Unauthorized(new { message = "Incorrect e-mail or password" });
           }

           var token = _tokenGenerator.Generate(user);

           return Ok(new { token });  
        }
    }
}