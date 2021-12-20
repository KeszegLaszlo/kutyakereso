using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface iCItyRepository
    {
         Task<IEnumerable<City>> GetCitiesAsync();

         void AddCity(City city);
        void DeleteCity(int cityId);
        Task<City> FindCity(int id);
    }
}