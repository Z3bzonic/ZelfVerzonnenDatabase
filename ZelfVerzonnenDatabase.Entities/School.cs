using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class School : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public Address? Address { get; set; }

        public ISet<Student> Students { get; set; } = null!;
        public ISet<Teacher> Teachers { get; set; } = null!;
        public ISet<Classroom> ClassRooms { get; set; } = null!;
    }
}