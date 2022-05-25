using Hostels.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hostels1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomListController : ControllerBase
    {
        private readonly IRoomListServices _roomListServices;
        public RoomListController(IRoomListServices roomListServices)
        {
            _roomListServices = roomListServices;
        }

        [HttpGet]
        public IActionResult GetRoomList()
        {
            return Ok(_roomListServices.GetRoomList());
        }
        
        
        [HttpGet("{id}", Name = "GetRoomList")]
        public IActionResult GetRoomList(string id)
        {
            return Ok(_roomListServices.GetRoomList(id));
        }
        
        
        [HttpPost]
        public IActionResult AddRoomList(RoomList roomList)
        {
            _roomListServices.AddRoomList(roomList);
            return CreatedAtRoute("GetRoomList", new { id = roomList.Id }, roomList);
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteRoomList(string id)
        {
            _roomListServices.DeleteRoomList(id);
            return NoContent();
        }
        
        [HttpPut]
        public IActionResult UpdateRoomList(RoomList roomList)
        {
            return Ok(_roomListServices.UpdateRoomList(roomList));
        }
        
    }
}