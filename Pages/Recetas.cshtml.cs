using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class RecetasModel : PageModel
    {
        private readonly ILogger<RecetasModel> _logger;

        public RecetasModel(ILogger<RecetasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
