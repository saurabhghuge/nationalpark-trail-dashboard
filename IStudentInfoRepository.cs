using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IStudentInfoRepository
    {
        Task<IEnumerable<StudentInfo>> GetStudentInfos();
        Task<StudentInfo> GetStudentInfo(int studentId);
        Task<int> AddStudentInfo(StudentInfo studentInfo);
        Task<int> UpdateStudentInfo(StudentInfo studentInfo);
        Task<int> DeleteStudentInfo(int studentId);


    }
}
