using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CoreWeb7.Data
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";

        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public List<Student> Students { get; set; } = new List<Student>();
    }

    public class EduDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public EduDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(col => col.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Web Programlama" },
                new Course { Id = 2, Name = "Python ML" },
                new Course { Id = 3, Name = ".Net Core" },
                new Course { Id = 4, Name = "Social Medya" });

            modelBuilder.Entity<Student>()
                .HasIndex(x => new { x.Name, x.Surname });

        }

    }
}
