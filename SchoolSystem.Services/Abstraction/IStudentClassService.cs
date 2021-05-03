using SchoolSystem.Models.Models.StudentClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstraction
{
    public interface IStudentClassService
    {
        Task<StudentClassModel> GetByClassId(int id);

        Task<StudentClassModel> GetByStudentId(int id);

        Task<StudentClassModel> Insert(StudentClassCreateModel model);

        Task<StudentClassModel> Update(StudentClassUpdateModel model);

        Task<bool> Delete(int id);
    }
}
