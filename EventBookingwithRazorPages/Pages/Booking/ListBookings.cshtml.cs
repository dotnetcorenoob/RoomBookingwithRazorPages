using EventBookingwithRazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventBookingwithRazorPages.Pages.Events
{
    public class ListEventsModel : PageModel
    {
        private readonly EventBookingDBContext dbContext;
        public ListEventsModel(EventBookingDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public void OnGet()
        {
        }
        public IActionResult OnGetFindAllEvents()
        
        {
            var events =  dbContext.Events.Select(x => new {
            title = x.title,
            start = x.startDateTime,
            end= x.endDateTime}).ToList();
            return new JsonResult(events);
        }
    }
}
