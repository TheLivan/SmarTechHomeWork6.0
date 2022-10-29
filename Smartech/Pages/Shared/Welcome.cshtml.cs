using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Smartech.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Name { get; }

        public WelcomeModel(string name)
        {
            Name = name;
        }
    }
}