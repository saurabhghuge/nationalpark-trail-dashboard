using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IApplicantDetailRepository
    {
        Task<IEnumerable<ApplicantDetail>> GetApplicantDetails();
        Task<ApplicantDetail> GetApplicantDetail(int applicantId);
        Task<int> AddApplicantDetail(ApplicantDetail applicantDetail);
        Task<int> UpdateApplicantDetail(ApplicantDetail applicantDetail);
        Task<int> DeleteApplicantDetail(int applicantId);
    }
}
