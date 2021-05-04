using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.StudentClass;
using SchoolSystem.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Services
{
    public class StudentClassService : IStudentClassService
    {
        private readonly SchoolSystemDbContext _context;
        private readonly IMapper _mapper;
        public StudentClassService(Data.SchoolSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Subjects.FindAsync(id);
            _context.Subjects.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<StudentSubjectModel> GetBySubjectId(int id)
        {
            var studentClasses = await _context.StudentSubjects.Include(sc => sc.Student).Include(sc => sc.Class).Where(sc => sc.ClassId == id).ToListAsync();
            return _mapper.Map<StudentSubjectModel>(studentClasses);
        }

        public async Task<StudentSubjectModel> GetByStudentId(int id)
        {
            var studentClasses = await _context.StudentSubjects.Include(sc => sc.Student).Include(sc => sc.Class).Where(sc => sc.StudentId == id).ToListAsync();
            return _mapper.Map<StudentSubjectModel>(studentClasses);
        }

        public async Task<StudentSubjectModel> Insert(StudentSubjectCreateModel model)
        {
            var entity = _mapper.Map<StudentSubject>(model);
            _context.StudentSubjects.Add(entity);
            await SaveAsync();
            return _mapper.Map<StudentSubjectModel>(entity);
        }

        public async Task<StudentSubjectModel> Update(StudentSubjectUpdateModel model)
        {
            var entity = _mapper.Map<StudentSubject>(model);
            _context.StudentSubjects.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return _mapper.Map<StudentSubjectModel>(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
