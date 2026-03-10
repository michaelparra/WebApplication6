using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class CafeEspecialidadModel : PageModel
    {
        private readonly ILogger<CafeEspecialidadModel> _logger;

        public CafeEspecialidadModel(ILogger<CafeEspecialidadModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
