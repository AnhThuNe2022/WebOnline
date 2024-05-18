using System.ComponentModel.DataAnnotations;

namespace WebAppOnline.Models
{
    public class TableViewModel
    {
        [Required]
        public string? name { get; set; }
        public string? old { get; set; }
        public string? address { get; set; }
        public TableViewModel( string name, string old, string address)
        {
            this.name = name;
            this.address = address;
            this.old = old; 
        }

        public TableViewModel()
        {
        }
    }
}