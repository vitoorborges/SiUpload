using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiUpload.Pages
{
    public class IndexModel : PageModel
    {

        public readonly string _uploadAcceptFile;

        [BindProperty(SupportsGet = true)]
        public int? IdAlinea { get; set; }
        public void OnGet()
        {
        }
    }
}
