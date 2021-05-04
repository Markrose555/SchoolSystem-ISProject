using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.Class;
using SchoolSystem.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Services
{
    public class ClassService : ISubjectService
    {

        private readonly SchoolSystemDbContext _context;
        private readonly IMapper _mapper;

        public ClassService(Data.SchoolSystemDbContext context, IMapper mapper)
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

        public async Task<IEnumerable<SubjectModelBase>> Get()
        {
            var classes = await _context.Subjects.ToListAsync();
            return _mapper.Map<IEnumerable<SubjectModelBase>>(classes);
        }

        public async Task<SubjectModelExtended> Get(int id)
        {
            var Class = await _context.Subjects.Include(c => c.StudentSubjects).ThenInclude(sc => sc.Class).FirstOrDefaultAsync(s => s.Id == id);
            return _mapper.Map<SubjectModelExtended>(Class);
        }

        public async Task<SubjectModelBase> Insert(SubjectCreateModel model)
        {
            var entity = _mapper.Map<Subject>(model);
            await _context.Subjects.AddAsync(entity);
            await SaveAsync();
            return _mapper.Map<SubjectModelBase>(entity);
        }

        public async Task<SubjectModelBase> Update(SubjectUpdateModel model)
        {
            var entity = _mapper.Map<Subject>(model);
            _context.Subjects.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return _mapper.Map<SubjectModelBase>(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
