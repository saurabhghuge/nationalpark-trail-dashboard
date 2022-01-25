using Eduvanz.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eduvanz.Core.DTOs;
using System;
using System.Text;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IApiRequestRepository
    {
        Task<IEnumerable<api_request>> GetApiRequests();
        Task<api_request> GetApiRequest(int apirequestid);
        Task<int> AddApiRequest(api_request apiRequest);
        Task<int> UpdateApiRequest(api_request apiRequest);
        Task<int> DeleteApiRequest(int apirequestid);
    }
}
