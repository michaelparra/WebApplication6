using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class FoodTruckModel : PageModel
    {
        private readonly ILogger<FoodTruckModel> _logger;

        public FoodTruckModel(ILogger<FoodTruckModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
