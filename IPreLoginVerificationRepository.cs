using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IPreLoginVerificationRepository
    {
        Task<IEnumerable<PreLoginVerification>> GetPreLoginVerifications();
        Task<PreLoginVerification> GetPreLoginVerification(int id);
        Task<int> AddPreLoginVerification(PreLoginVerification preLoginVerification);
        Task<int> UpdatePreLoginVerification(PreLoginVerification preLoginVerification);
        Task<int> DeletePreLoginVerification(int id);
    }
}
