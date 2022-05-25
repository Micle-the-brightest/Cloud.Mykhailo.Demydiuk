using Hostels.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hostels1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomInfoController: ControllerBase
    {
        private readonly IRoomInfoServices _roomInfoServices;
        public RoomInfoController(IRoomInfoServices roomInfoServices)
        {
            _roomInfoServices = roomInfoServices;
        }

        [HttpGet]
        public IActionResult GetRoomInfo()
        {
            return Ok(_roomInfoServices.GetRoomInfo());
        }
        
        [HttpGet("{id}", Name = "GetRoomInfo")]
        public IActionResult GetRoomInfo(string id)
        {
            return Ok(_roomInfoServices.GetRoomInfo(id));
        }
        
        
        [HttpPost]
        public IActionResult AddRoomInfo(RoomInfo roomInfo)
        {
            _roomInfoServices.AddRoomInfo(roomInfo);
            return CreatedAtRoute("GetRoomInfo", new { id = roomInfo.Id }, roomInfo);
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteRoomInfo(string id)
        {
            _roomInfoServices.DeleteRoomInfo(id);
            return NoContent();
        }
        
        [HttpPut]
        public IActionResult UpdateRoomInfo(RoomInfo roomInfo)
        {
            return Ok(_roomInfoServices.UpdateRoomInfo(roomInfo));
        }
    }
}