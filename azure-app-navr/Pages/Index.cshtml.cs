using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_navr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;
        public IndexModel(ILogger<IndexModel> logger, IConfiguration _configuration )
        {
            _logger = logger; this._configuration = _configuration;
        }

        public void OnGet()
        {
            ViewData["Greeting"] = _configuration["Greeting"];
        }
    }
}