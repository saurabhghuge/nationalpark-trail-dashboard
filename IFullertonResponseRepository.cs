using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IFullertonResponseRepository
    {
        Task<IEnumerable<FullertonResponse>> GetFullertonResponses();
        Task<FullertonResponse> GetFullertonResponse(int id);
        Task<int> AddFullertonResponse(FullertonResponse fullertonResponse);
        Task<int> UpdateFullertonResponse(FullertonResponse fullertonResponse);
        Task<int> DeleteFullertonResponse(int id);
    }
}
