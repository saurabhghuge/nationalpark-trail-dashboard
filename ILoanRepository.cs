using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ILoanRepository
    {
        Task<IEnumerable<Loan>> GetLoans();
        Task<Loan> GetLoan(int loanId);
        Task<int> AddLoan(Loan loan);
        Task<int> UpdateLoan(Loan loan);
        Task<int> DeleteLoan(int loanId);
    }
}
