using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCitys();
        Task<City> GetCity(int cityId);
        Task<int> AddCity(City city);
        Task<int> UpdateCity(City city);
        Task<int> DeleteCity(int cityId);
    }
}
