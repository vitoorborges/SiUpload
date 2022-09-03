using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiUpload.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        [BindProperty(SupportsGet = true)]
        public int IdEvento { get; set; }

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            var idEventoRecebe = IdEvento;
            var resultado = idEventoRecebe;
        }

        public IActionResult OnPost(string CPF, string Senha)
        {
            var email = CPF;
            var senha = Senha;
           return RedirectToPage("Index");
        }
    }
}