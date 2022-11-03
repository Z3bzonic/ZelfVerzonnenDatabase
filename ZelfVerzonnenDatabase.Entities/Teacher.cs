using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Teacher : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string SurName { get; set; }

        public int Age { get; set; }

        public IList<Student> Students { get; set; } = new List<Student>();
        public Address Address { get; set; }
    }
}