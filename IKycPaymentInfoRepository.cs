using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IKycPaymentInfoRepository
    {
        Task<IEnumerable<KycPaymentInfo>> GetKycPaymentInfos();
        Task<KycPaymentInfo> GetKycPaymentInfo(int id);
        Task<int> AddKycPaymentInfo(KycPaymentInfo kycPaymentInfo);
        Task<int> UpdateKycPaymentInfo(KycPaymentInfo kycPaymentInfo);
        Task<int> DeleteKycPaymentInfo(int id);
    }
}
