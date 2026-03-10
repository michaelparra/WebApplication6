using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class GranosModel : PageModel
    {
        private readonly ILogger<GranosModel> _logger;

        public GranosModel(ILogger<GranosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
