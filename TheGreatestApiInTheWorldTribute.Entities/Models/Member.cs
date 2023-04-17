using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheGreatestApiInTheWorldTribute.Entities.Models
{
    public class Member
    {
        [Column("MemberId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Member name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")] 
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is a required field.")] 
        public int Age { get; set; }

        [Required(ErrorMessage = "Role is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Role is 20 characters.")] 
        public string? Role { get; set; }

        [ForeignKey(nameof(Band))] 
        public Guid BandId { get; set; }

        public Band? Band { get; set; }
    }
}
