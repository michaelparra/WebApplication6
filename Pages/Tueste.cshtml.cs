using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class TuesteModel : PageModel
    {
        private readonly ILogger<TuesteModel> _logger;

        public TuesteModel(ILogger<TuesteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
