using SchoolSystem.Models.Models.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstraction
{
    public interface IClassService
    {
        Task<IEnumerable<ClassModelBase>> Get();

        Task<ClassModelExtended> Get(int id);

        Task<ClassModelBase> Insert(ClassCreateModel model);

        Task<ClassModelBase> Update(ClassUpdateModel model);

        Task<bool> Delete(int id);
    }
}
