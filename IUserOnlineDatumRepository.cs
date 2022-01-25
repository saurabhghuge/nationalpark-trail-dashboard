using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface IUserOnlineDatumRepository
    {
        Task<IEnumerable<UserOnlineDatum>> GetUserOnlineDatums();
        Task<UserOnlineDatum> GetUserOnlineDatum(int id);
        Task<int> AddUserOnlineDatum(UserOnlineDatum userOnlineDatum);
        Task<int> UpdateUserOnlineDatum(UserOnlineDatum userOnlineDatum);
        Task<int> DeleteUserOnlineDatum(int id);
    }
}
