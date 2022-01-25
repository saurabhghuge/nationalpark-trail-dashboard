using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ILeadDetailRepository
    {
        Task<IEnumerable<LeadDetail>> GetLeadDetails();
        Task<LeadDetail> GetLeadDetail(int leadId);
        Task<int> AddLeadDetail(LeadDetail leadDetail);
        Task<int> UpdateLeadDetail(LeadDetail leadDetail);
        Task<int> DeleteLeadDetail(int leadId);

    }
}
