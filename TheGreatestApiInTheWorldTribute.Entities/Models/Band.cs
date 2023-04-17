using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheGreatestApiInTheWorldTribute.Entities.Models
{
    public class Band
    {
        [Column("BandId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Band name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")] 
        public string? Name { get; set; }

        [Required(ErrorMessage = "Hometown is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Hometown is 60 characters.")] 
        public string? Hometown { get; set; }

        public ICollection<Member>? Members { get; set; }
    }
}
