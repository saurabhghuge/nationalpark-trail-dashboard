using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IDisbursementTranchRepository
    {
        Task<IEnumerable<DisbursementTranch>> GetDisbursementTranchs();
        Task<DisbursementTranch> GetDisbursementTranch(int id);
        Task<int> AddDisbursementTranch(DisbursementTranch disbursementTranch);
        Task<int> UpdateDisbursementTranch(DisbursementTranch disbursementTranch);
        Task<int> DeleteDisbursementTranch(int id);
    }
}
