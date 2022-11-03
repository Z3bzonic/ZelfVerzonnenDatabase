using Microsoft.EntityFrameworkCore;
using ZelfVerzonnenDatabase.Entities;

namespace ZelfVerzonnenDatabase.DAL
{
    public class ZelfVerzonennenDatabaseContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var cs = "Server = ZENTOP; Database = ZelfVerzonnenDatabase; Trusted_Connection = True;"; // ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            options.UseSqlServer(cs);
        }
    }
}