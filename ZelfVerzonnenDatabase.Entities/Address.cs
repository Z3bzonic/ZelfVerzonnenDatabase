using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Address : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required, MinLength(5), MaxLength(40)]
        public string City { get; set; }

        [Required, MinLength(4), MaxLength(8)]
        public string ZipCode { get; set; }
    }
}