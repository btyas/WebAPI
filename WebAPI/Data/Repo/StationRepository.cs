using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class StationRepository : IStationInterface
    {
        private readonly DataContext dc;

        public StationRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddStation(StationPos station)
        {
            dc.Stations.Add(station);
        }

        public void DeleteStation(int StationPosId)
        {
            var station = dc.Stations.Find(StationPosId);
            dc.Stations.Remove(station);

        }

        public async Task<StationPos> FindStation(int id)
        {
            return await dc.Stations.FindAsync(id);
        }

        public async Task<IEnumerable<StationPos>> GetStationDataAsync()
        {
            return await dc.Stations.ToListAsync();
        }
    }
}
