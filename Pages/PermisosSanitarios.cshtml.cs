using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class PermisosSanitariosModel : PageModel
    {
        private readonly ILogger<PermisosSanitariosModel> _logger;

        public PermisosSanitariosModel(ILogger<PermisosSanitariosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
