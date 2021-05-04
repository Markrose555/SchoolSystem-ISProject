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

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<StudentSubject> StudentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(student =>
            {
                student.Property(s => s.StudentName).IsRequired();
                student.Property(s => s.StudentSurname).IsRequired();
                student.Property(s => s.StudentYear).IsRequired();
                student.HasKey(s => s.Id);
                student.HasMany(s => s.StudentSubjects);
            });

            modelBuilder.Entity<Subject>(Subject =>
            {
                Subject.Property(su => su.Id).IsRequired();
                Subject.HasKey(su => su.Id);
                Subject.Property(su => su.SubjectName).HasMaxLength(800).IsRequired();
                Subject.HasMany(su => su.StudentSubjects);
            });

            modelBuilder.Entity<StudentSubject>(ss =>
            {
                ss.Property(ss => ss.Id).IsRequired();
                ss.HasKey(ss => ss.Id);
                ss.Property(ss => ss.Grade).IsRequired();
                ss.HasOne(ss => ss.Student).WithMany(s => s.StudentSubjects).HasForeignKey(ss => ss.StudentId);
                ss.HasOne(ss => ss.Subject).WithMany(su => su.StudentSubjects).HasForeignKey(ss => ss.SubjectId);
            });
        }
    }
}
