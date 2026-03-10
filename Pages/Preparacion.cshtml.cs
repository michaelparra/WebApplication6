using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class PreparacionModel : PageModel
    {
        private readonly ILogger<PreparacionModel> _logger;

        public PreparacionModel(ILogger<PreparacionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
