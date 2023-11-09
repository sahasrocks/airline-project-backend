using Class18projectrialDbfirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class18projectrialDbfirst.BokRepo
{
    public interface IBokRepo
    {
        Task<ActionResult<IEnumerable<Booking>>> GetBookings();
        Task<ActionResult<Booking>> PostBookings(Booking booking);
        Task<ActionResult<Booking>> PutBookings(Booking booking);
        Task<ActionResult<Booking>> DeleteBookings(int id);
    }
}
