using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IUnitOfWork
    {
         iCItyRepository CityRepository{get;}
         IUserRepository UserRepository{get;}
         Task<bool> SaveAsync();
    }
}