using System.ComponentModel.DataAnnotations;

namespace Smartech.Data
{
    public class Languages
    {
        [Key]
        public string Lang { get; set; }
        public string Message { get; set; }
    }
}
