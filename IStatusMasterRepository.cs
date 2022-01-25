using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IStatusMasterRepository
    {
        Task<IEnumerable<StatusMaster>> GetStatusMasters();
        Task<StatusMaster> GetStatusMaster(int id);
        Task<int> AddStatusMaster(StatusMaster statusMaster);
        Task<int> UpdateStatusMaster(StatusMaster statusMaster);
        Task<int> DeleteStatusMaster(int id);
    }
}
