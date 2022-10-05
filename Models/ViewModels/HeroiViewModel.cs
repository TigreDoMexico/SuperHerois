using System.ComponentModel.DataAnnotations;

namespace SuperHerois.Models.ViewModels
{
    public class HeroiViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Poder { get; set; }
    }
}
