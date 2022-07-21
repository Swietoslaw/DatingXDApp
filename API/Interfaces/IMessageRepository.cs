using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<IEnumerable<MessageDto>> GetMessagesForUser();
        Task<IEnumerable<MessageDto>> GetMessagesThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync();
    }
}