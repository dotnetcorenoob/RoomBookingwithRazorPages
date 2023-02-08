namespace EventBookingwithRazorPages.Models.ViewModels
{
    public class AddEventViewModel
    {
        public string title { get; set; } = string.Empty;

        public DateTime startDateTime { get; set; }

        public DateTime endDateTime { get; set; }
    }
}
