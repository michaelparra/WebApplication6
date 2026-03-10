using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class BuenasPracticasModel : PageModel
    {
        private readonly ILogger<BuenasPracticasModel> _logger;

        public BuenasPracticasModel(ILogger<BuenasPracticasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
