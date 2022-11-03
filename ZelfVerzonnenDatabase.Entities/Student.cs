using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Student : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string SurName { get; set; }

        public ISet<Teacher> Teachers { get; set; } = null!;
        public Address Address { get; set; }
    }
}