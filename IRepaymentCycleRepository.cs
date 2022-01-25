using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IRepaymentCycleRepository
    {
        Task<IEnumerable<RepaymentCycle>> GetRepaymentCycles();
        Task<RepaymentCycle> GetRepaymentCycle(int id);
        Task<int> AddRepaymentCycle(RepaymentCycle repaymentCycle);
        Task<int> UpdateRepaymentCycle(RepaymentCycle repaymentCycle);
        Task<int> DeleteRepaymentCycle(int id);
    }
}
