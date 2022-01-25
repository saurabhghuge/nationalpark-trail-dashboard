using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IApplicantDocumentRepository
    {
        Task<IEnumerable<ApplicantDocument>> GetApplicantDocuments();
        Task<ApplicantDocument> GetApplicantDocument(int docUploadId);
        Task<int> AddApplicantDocument(ApplicantDocument applicantDocument);
        Task<int> UpdateApplicantDocument(ApplicantDocument applicantDocument);
        Task<int> DeleteApplicantDocument(int docUploadId);
    }
}
