using System.Collections.Generic;
using System.Threading.Tasks;
using ComedyEvents.Models;

namespace ComedyEvents.Data
{
    public interface ICommonRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<List<User>> GetUsers();
         Task<User> GetUser(int id, bool isCurrentUser);

    }
}