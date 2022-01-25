using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ILocationMasterRepository
    {
        Task<IEnumerable<LocationMaster>> GetLocationMasters();
        Task<LocationMaster> GetLocationMaster(int id);
        Task<int> AddLocationMaster(LocationMaster locationMaster);
        Task<int> UpdateLocationMaster(LocationMaster locationMaster);
        Task<int> DeleteLocationMaster(int id);
    }
}
