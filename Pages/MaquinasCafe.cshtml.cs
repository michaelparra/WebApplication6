using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class MaquinasCafeModel : PageModel
    {
        private readonly ILogger<MaquinasCafeModel> _logger;

        public MaquinasCafeModel(ILogger<MaquinasCafeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
