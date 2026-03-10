using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class PermisosModel : PageModel
    {
        private readonly ILogger<PermisosModel> _logger;

        public PermisosModel(ILogger<PermisosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
