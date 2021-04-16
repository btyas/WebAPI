using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
   public interface ICuisinerRepository
    {


        Task<IEnumerable<Cuisinier>> GetCuisiniersAsync();

        void AddCuisinier(Cuisinier _cuisinier);

        void DeleteCuisinier(int cuisinierId);

        Task<Cuisinier> FindCuisinier(int id);
    }
}
