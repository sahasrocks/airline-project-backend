using Class18projectrialDbfirst.BokRepo;
using Class18projectrialDbfirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class18projectrialDbfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBokRepo _repository;
        public BookingsController(IBokRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _repository.GetBookings();

        }
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBookings(Booking booking)
        {
            return await _repository.PostBookings(booking);
        }
        [HttpPut]
        public async Task<ActionResult<Booking>> PutBookings(Booking booking)
        {
            return await _repository.PutBookings(booking);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Booking>> DeleteBookings(int id)
        {
            try
            {
                return await _repository.DeleteBookings(id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
