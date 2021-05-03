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
    public class ClassService : IClassService
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
            var entity = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<IEnumerable<ClassModelBase>> Get()
        {
            var classes = await _context.Classes.ToListAsync();
            return _mapper.Map<IEnumerable<ClassModelBase>>(classes);
        }

        public async Task<ClassModelExtended> Get(int id)
        {
            var Class = await _context.Classes.Include(c => c.StudentClasses).ThenInclude(sc => sc.Class).FirstOrDefaultAsync(s => s.Id == id);
            return _mapper.Map<ClassModelExtended>(Class);
        }

        public async Task<ClassModelBase> Insert(ClassCreateModel model)
        {
            var entity = _mapper.Map<Class>(model);
            await _context.Classes.AddAsync(entity);
            await SaveAsync();
            return _mapper.Map<ClassModelBase>(entity);
        }

        public async Task<ClassModelBase> Update(ClassUpdateModel model)
        {
            var entity = _mapper.Map<Class>(model);
            _context.Classes.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return _mapper.Map<ClassModelBase>(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
