using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.Student;
using SchoolSystem.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolSystemDbContext _context;
        private readonly IMapper _mapper;

        public StudentService(Data.SchoolSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<StudentModelBase>> Get()
        {
            var students = await _context.Students.ToListAsync();
            return _mapper.Map<IEnumerable<StudentModelBase>>(students);
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Students.FindAsync(id);
            _context.Students.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<StudentModelExtended> Get(int id)
        {
            var player = await _context.Students.Include(p => p.StudentSubjects).ThenInclude(sc => sc.Subject).FirstOrDefaultAsync(s => s.Id == id);
            return _mapper.Map<StudentModelExtended>(player);
        }

        public async Task<StudentModelBase> Insert(StudentCreateModel model)
        {
            var entity = _mapper.Map<Student>(model);
            await _context.Students.AddAsync(entity);
            await SaveAsync();
            return _mapper.Map<StudentModelBase>(entity);
        }

        public async Task<StudentModelBase> Update(StudentUpdateModel model)
        {
            var entity = _mapper.Map<Student>(model);
            _context.Students.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return _mapper.Map<StudentModelBase>(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
