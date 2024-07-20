using LoginRegistration.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace LoginRegistration.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;




        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
			

        }

        public void OnGet()
        {

        }
    }
}
