using System.ComponentModel.DataAnnotations;

namespace TFCyberDemoBlazorWasm.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        [Range(1977, int.MaxValue)]
        public int AnneeDeSortie { get; set; }
    }
}
