using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Smartech.Pages
{
    public class IndexModel : PageModel
    {   
        public string Name { get; set; }

        public IndexModel() { }
    }
}