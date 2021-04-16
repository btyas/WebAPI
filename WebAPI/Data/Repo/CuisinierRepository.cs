using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class CuisinierRepository : ICuisinerRepository
    {
        private readonly DataContext dc;

        public CuisinierRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddCuisinier(Cuisinier _cuisinier)
        {
            dc.Cuisiniers.Add(_cuisinier);
        }

        public void DeleteCuisinier(int cuisinierId)
        {
            var Dcuisinier =  dc.Cuisiniers.Find(cuisinierId);

            dc.Cuisiniers.Remove(Dcuisinier);
        }

        public  async Task<Cuisinier> FindCuisinier(int id)
        {
            return await dc.Cuisiniers.FindAsync(id);
        }

        public  async Task<IEnumerable<Cuisinier>> GetCuisiniersAsync()

        {   

            return await dc.Cuisiniers.ToListAsync();
        }

       
       
    }
}
