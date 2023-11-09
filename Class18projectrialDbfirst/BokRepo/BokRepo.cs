using Class18projectrialDbfirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Class18projectrialDbfirst.BokRepo
{
    public class BokRepo : IBokRepo
    {
        private readonly AirRDbContext _context;
        public BokRepo(AirRDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<ActionResult<Booking>> PostBookings(Booking booking)
        {

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }
        public async Task<ActionResult<Booking>> PutBookings(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return booking;
        }
        public async Task<ActionResult<Booking>> DeleteBookings(int id)
        {
            var regBooking = await _context.Bookings.FindAsync(id);
            if (regBooking == null)
            {
                throw new NullReferenceException("Sorry no Booking found with this id");
            }
            else
            {
                _context.Bookings.Remove(regBooking);
                await _context.SaveChangesAsync();
                return regBooking;
            }
        }

    }
}
