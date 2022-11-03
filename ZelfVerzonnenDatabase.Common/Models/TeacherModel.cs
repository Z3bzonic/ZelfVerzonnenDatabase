using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelfVerzonnenDatabase.Entities;

namespace ZelfVerzonnenDatabase.Common.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Voornaam { get; set; }
        public int Age { get; set; }

        // public IList<Student> Students { get; set; } = new List<Student>();
        public string Address { get; set; }
    }
}