using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IRepaymentAccountDetailRepository
    {
        Task<IEnumerable<RepaymentAccountDetail>> GetRepaymentAccountDetails();
        Task<RepaymentAccountDetail> GetRepaymentAccountDetail(int id);
        Task<int> AddRepaymentAccountDetail(RepaymentAccountDetail repaymentAccountDetail);
        Task<int> UpdateRepaymentAccountDetail(RepaymentAccountDetail repaymentAccountDetail);
        Task<int> DeleteRepaymentAccountDetail(int id);
    }
}
