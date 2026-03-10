using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class ImpuestosModel : PageModel
    {
        private readonly ILogger<ImpuestosModel> _logger;

        public ImpuestosModel(ILogger<ImpuestosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
