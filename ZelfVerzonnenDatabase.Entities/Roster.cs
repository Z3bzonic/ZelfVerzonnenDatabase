using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Roster : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        public Teacher Teacher { get; set; }
        public Classroom ClassRoom { get; set; }
        public School School { get; set; }
        public Class Class { get; set; }
        public ISet<Student> Students { get; set; }
    }
}