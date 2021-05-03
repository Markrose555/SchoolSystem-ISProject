using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Data
{
    public class SchoolSystemDbContext : DbContext
    {
        public SchoolSystemDbContext(DbContextOptions<SchoolSystemDbContext> options) : base(options)
        {

        }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<StudentClass> StudentClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(student =>
            {
                student.Property(s => s.Name).IsRequired();
                student.Property(s => s.Surname).IsRequired();
                student.Property(s => s.Year).IsRequired();
                student.HasKey(s => s.Id);
                student.HasMany(s => s.StudentClasses);
            });

            modelBuilder.Entity<Class>(Class =>
            {
                Class.Property(c => c.Id).IsRequired();
                Class.HasKey(c => c.Id);
                Class.Property(c => c.Subject).HasMaxLength(800).IsRequired();
                Class.HasMany(c => c.StudentClasses);
            });

            modelBuilder.Entity<StudentClass>(sc =>
            {
                sc.Property(sc => sc.Id).IsRequired();
                sc.HasKey(sc => sc.Id);
                sc.Property(sc => sc.Grade).IsRequired();
                sc.HasOne(sc => sc.Student).WithMany(s => s.StudentClasses).HasForeignKey(sc => sc.StudentId);
                sc.HasOne(sc => sc.Class).WithMany(c => c.StudentClasses).HasForeignKey(sc => sc.ClassId);
            });
        }
    }
}
