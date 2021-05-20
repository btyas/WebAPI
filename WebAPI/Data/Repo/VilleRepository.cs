using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class VilleRepository : IVilleRepository
    {
        private readonly DataContext dc;

        public VilleRepository( DataContext dc)
        {
            this.dc = dc;
        }
        public void AddVille(Ville ville)
        {
            dc.Villes.Add(ville);
        }

        public void DeleteVille(int villeId)
        {
            var ville = dc.Villes.Find(villeId);
            dc.Villes.Remove(ville);
        }

        public async Task<Ville> FindVille(int id)
        {
            return await dc.Villes.FindAsync(id);
        }

        public async Task<IEnumerable<Ville>> GetVillesAsync()
        {
            return await dc.Villes.ToListAsync();
        }
    }
}
