using EventBookingwithRazorPages.Data;
using EventBookingwithRazorPages.Models.Domain;
using EventBookingwithRazorPages.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventBookingwithRazorPages.Pages.Events
{
    public class AddEventModel : PageModel
    {
        private readonly EventBookingDBContext dbContext;
        public AddEventModel(EventBookingDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        [BindProperty]
        public AddEventViewModel AddEventRequest { get; set; }
        public void OnGet()
        {
        }
        public void OnPost() {
            var eventDomainModel = new Event
            {
                title = AddEventRequest.title,
                startDateTime = AddEventRequest.startDateTime,
                endDateTime = AddEventRequest.endDateTime

            };
            dbContext.Events.Add(eventDomainModel);
            dbContext.SaveChanges();
            ViewData["Message"] = "Even Added Successfully";
            ModelState.Clear();
        }
    }
}
