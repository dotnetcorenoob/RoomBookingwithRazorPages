using EventBookingwithRazorPages.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventBookingwithRazorPages.Data
{
    public class EventBookingDBContext : DbContext
    {
        public EventBookingDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
