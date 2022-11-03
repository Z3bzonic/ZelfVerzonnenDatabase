using System.ComponentModel.DataAnnotations;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Classroom : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public char Floor { get; set; }

        [Required]
        public int NumberOfChairs { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public bool HasProjector { get; set; }

        [Required]
        public bool HasBioLab { get; set; }

        [Required]
        public bool HasChemistryLab { get; set; }

        [Required]
        public bool HasInstruments { get; set; }
    }
}