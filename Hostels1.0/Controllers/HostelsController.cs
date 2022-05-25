using Hostels.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hostels1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostelsController : ControllerBase
    {
        private readonly IHostelServices _hostelServices;
        
        public HostelsController(IHostelServices hostelServices)
        {
            _hostelServices = hostelServices;
        }

        [HttpGet]
        public IActionResult GetHostels()
        {
            return Ok(_hostelServices.GetHostels());
        }

        [HttpGet("{id}", Name = "GetHostel")]
        public IActionResult GetHostel(string id)
        {
           return Ok(_hostelServices.GetHostel(id));
        }

        [HttpPost]
        public IActionResult AddHostel(Hostel hostel)
        {
            _hostelServices.AddHostel(hostel);
            return CreatedAtRoute("GetHostel", new { id = hostel.Id }, hostel);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHostel(string id)
        {
            _hostelServices.DeleteHostel(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateHostel(Hostel hostel)
        {
            return Ok(_hostelServices.UpdateHostel(hostel));
        }
    }
}