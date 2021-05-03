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
            var entity = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<StudentClassModel> GetByClassId(int id)
        {
            var studentClasses = await _context.StudentClasses.Include(sc => sc.Student).Include(sc => sc.Class).Where(sc => sc.ClassId == id).ToListAsync();
            return _mapper.Map<StudentClassModel>(studentClasses);
        }

        public async Task<StudentClassModel> GetByStudentId(int id)
        {
            var studentClasses = await _context.StudentClasses.Include(sc => sc.Student).Include(sc => sc.Class).Where(sc => sc.StudentId == id).ToListAsync();
            return _mapper.Map<StudentClassModel>(studentClasses);
        }

        public async Task<StudentClassModel> Insert(StudentClassCreateModel model)
        {
            var entity = _mapper.Map<StudentClass>(model);
            _context.StudentClasses.Add(entity);
            await SaveAsync();
            return _mapper.Map<StudentClassModel>(entity);
        }

        public async Task<StudentClassModel> Update(StudentClassUpdateModel model)
        {
            var entity = _mapper.Map<StudentClass>(model);
            _context.StudentClasses.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return _mapper.Map<StudentClassModel>(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
