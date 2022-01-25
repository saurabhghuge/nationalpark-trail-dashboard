using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IInstituteRepository
    {
        Task<IEnumerable<Institute>> GetInstitutes();
        Task<Institute> GetInstitute(int instituteId);
        Task<int> AddInstitute(Institute institute);
        Task<int> UpdateInstitute(Institute institute);
        Task<int> DeleteInstitute(int instituteId);
    }
}
