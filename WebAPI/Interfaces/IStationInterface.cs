using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
  public  interface IStationInterface
    {

        Task<IEnumerable<StationPos>> GetStationDataAsync();

        void AddStation(StationPos station);

        void DeleteStation(int StationPosId);

        Task<StationPos> FindStation(int id);
    }
}
