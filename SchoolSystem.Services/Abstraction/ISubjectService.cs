using SchoolSystem.Models.Models.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstraction
{
    public interface ISubjectService
    {
        Task<IEnumerable<SubjectModelBase>> Get();

        Task<SubjectModelExtended> Get(int id);

        Task<SubjectModelBase> Insert(SubjectCreateModel model);

        Task<SubjectModelBase> Update(SubjectUpdateModel model);

        Task<bool> Delete(int id);
    }
}
