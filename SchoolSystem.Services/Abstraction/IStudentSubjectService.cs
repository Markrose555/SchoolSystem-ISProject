using SchoolSystem.Models.Models.StudentSubject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Abstraction
{
    public interface IStudentSubjectService
    {
        Task<StudentSubjectModel> GetBySubjectId(int id);

        Task<StudentSubjectModel> GetByStudentId(int id);

        Task<StudentSubjectModel> Insert(StudentSubjectCreateModel model);

        Task<StudentSubjectModel> Update(StudentSubjectUpdateModel model);

        Task<bool> Delete(int id);
    }
}
