using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Class : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}