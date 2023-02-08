namespace EventBookingwithRazorPages.Models.Domain
{
    public class Event
    {
        public Guid Id { get; set; }
        public string title { get; set; } = string.Empty;

        public DateTime startDateTime { get; set; }

        public DateTime endDateTime { get; set; }

    }
}
