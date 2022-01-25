using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ILeadStatusRepository
    {
        Task<IEnumerable<LeadStatus>> GetLeadStatuses();
        Task<LeadStatus> GetLeadStatus(int leadStatusId);
        Task<int> AddLeadStatus(LeadStatus leadStatus);
        Task<int> UpdateLeadStatus(LeadStatus leadStatus);
        Task<int> DeleteLeadStatus(int leadStatusId);


    }
}
