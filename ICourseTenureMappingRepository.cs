using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ICourseTenureMappingRepository
    {
        Task<IEnumerable<CourseTenureMapping>> GetCourseTenureMappings();
        Task<CourseTenureMapping> GetCourseTenureMapping(int id);
        Task<int> AddCourseTenureMapping(CourseTenureMapping courseTenureMapping);
        Task<int> UpdateCourseTenureMapping(CourseTenureMapping courseTenureMapping);
        Task<int> DeleteCourseTenureMapping(int id);
    }
}
