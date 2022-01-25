using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ILoanDisbursementRepository
    {
        Task<IEnumerable<LoanDisbursement>> GetLoanDisbursements();
        Task<LoanDisbursement> GetLoanDisbursement(int id);
        Task<int> AddLoanDisbursement(LoanDisbursement loanDisbursement);
        Task<int> UpdateLoanDisbursement(LoanDisbursement loanDisbursement);
        Task<int> DeleteLoanDisbursement(int id);
    }
}
