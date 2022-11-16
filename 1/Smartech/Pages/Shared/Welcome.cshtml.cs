using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Smartech.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Name { get; }
        public string Message { get; }

        public WelcomeModel(string name, string message)
        {
            Name = name;
            Message = message;
        }
    }
}