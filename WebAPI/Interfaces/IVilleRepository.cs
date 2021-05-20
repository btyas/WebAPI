using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
   public interface IVilleRepository
    {

        Task<IEnumerable<Ville>> GetVillesAsync();

        void AddVille(Ville ville);

        void DeleteVille(int villeId);

        Task<Ville> FindVille(int id);
    }
}
