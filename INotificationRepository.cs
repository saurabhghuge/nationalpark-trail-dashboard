using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface INotificationRepository
    {
        Task<IEnumerable<Notification>> GetNotifications();
        Task<Notification> GetNotification(int id);
        Task<int> AddNotification(Notification notification);
        Task<int> UpdateNotification(Notification notification);
        Task<int> DeleteNotification(int id);
    }
}
