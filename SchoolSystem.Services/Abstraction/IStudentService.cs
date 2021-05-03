using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstraction
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentModelBase>> Get();

        Task<StudentModelExtended> Get(int id);

        Task<StudentModelBase> Insert(StudentCreateModel model);

        Task<StudentModelBase> Update(StudentUpdateModel model);

        Task<bool> Delete(int id);
    }
}
