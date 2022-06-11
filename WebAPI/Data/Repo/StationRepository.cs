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
        private readonly DataContext _dc;

        public StationRepository(DataContext dc)
        {
            this._dc = dc;
        }
        public void AddStation(StationPos station)
        {
            _dc.Stations.Add(station);
        }

        public void Delete(int StationPosId)
        {
            var station = _dc.Stations.Find(StationPosId);
            _dc.Stations.Remove(station);

        }

        public async Task<StationPos> FindStation(int id)
        {
            return await _dc.Stations.FindAsync(id);
        }

        public async Task<IEnumerable<StationPos>> GetStationDataAsync()
        {
            return await _dc.Stations.ToListAsync();
        }
    }
}
