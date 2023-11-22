using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Plancher_Expert.Pages
{
    public class FormModel : PageModel
    {
        private string a = "";
        public bool hasContact = false;
        public string name = "";
        public string email = "";
        public string msg = "";

        public string A
        {
            get { return a; }
            set { a = value; }
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasContact = true;
            name = Request.Form["name"];
            email = Request.Form["email"];
            msg = Request.Form["msg"];
            Console.WriteLine(name);
            Console.WriteLine(email);
            Console.WriteLine(msg);
        }
    }
}