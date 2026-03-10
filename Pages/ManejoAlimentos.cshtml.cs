using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class ManejoAlimentosModel : PageModel
    {
        private readonly ILogger<ManejoAlimentosModel> _logger;

        public ManejoAlimentosModel(ILogger<ManejoAlimentosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
