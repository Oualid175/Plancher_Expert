using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Plancher_Expert.Pages
{
    public class DateModel : PageModel
    {
        public string? Paragraph { get; set; }
        public string? CurrentTime { get; set; }

        public void OnGet()
        {
            Paragraph = " This is a 4IIR - G3 of EMSI Tanger ";
            CurrentTime = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}