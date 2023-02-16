using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IIGStudents.Models;
using Microsoft.EntityFrameworkCore;

namespace IIGStudents
{
    public class GroupContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HP; Database=Group; Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(k => k.Id);
                s.Property(k => k.Id).ValueGeneratedOnAdd().HasColumnType("int");
                s.Property(k => k.FirstName).HasColumnType("NVARCHAR(10)").HasColumnName("First Name");
                s.Property(k => k.LastName).HasColumnName("Last Name").HasColumnType("NVARCHAR(15)");
                s.Property(k => k.Age).HasColumnType("int").HasColumnName("Age");
                s.Property(k => k.CourseName).HasColumnName("Course").HasColumnType("NVARCHAR(50)");
            });
        }
        
    }
}
