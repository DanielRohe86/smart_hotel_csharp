// using Microsoft.AspNetCore.Mvc;
// using TrybeHotel.Models;
// using TrybeHotel.Repository;
// using System.Security.Claims;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Authentication.JwtBearer;

// namespace TrybeHotel.Controllers
// {
//     [ApiController]
//     [Route("room")]
//     public class RoomController : Controller
//     {
//         private readonly IRoomRepository _repository;
//         public RoomController(IRoomRepository repository)
//         {
//             _repository = repository;
//         }

//         [HttpGet("{HotelId}")]
//         public IActionResult GetRoom(int HotelId){
//             throw new NotImplementedException();
//         }

//         [HttpPost]
//         public IActionResult PostRoom([FromBody] Room room){
//             throw new NotImplementedException();
//         }

//         [HttpDelete("{RoomId}")]
//         public IActionResult Delete(int RoomId)
//         {
//              throw new NotImplementedException();
//         }
//     }
// }

using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("room")]
    public class RoomController : Controller
    {
        private readonly IRoomRepository _repository;
        public RoomController(IRoomRepository repository)
        {
            _repository = repository;
        }

        // 6. Desenvolva o endpoint GET /room/:hotelId
        [HttpGet("{HotelId}")]
        public IActionResult GetRoom(int HotelId){            
            return Ok(_repository.GetRooms(HotelId));
        }

        // 7. Desenvolva o endpoint POST /room
        [HttpPost]
        [Authorize(Policy = "Admin")]
        public IActionResult PostRoom([FromBody] Room room){
            return Created("", _repository.AddRoom(room));
        }

        // 8. Desenvolva o endpoint DELETE /room/:roomId
        [HttpDelete("{RoomId}")]
        [Authorize(Policy = "Admin")]
        public IActionResult Delete(int RoomId)
        {
            _repository.DeleteRoom(RoomId);
            return NoContent();
        }
    }
}