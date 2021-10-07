using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IShipInfoSvc
    {
        Task<List<ShipInfo>> GetAllShipInfo();
        Task<ShipInfo> GetShipInfo(int id);
        Task<int> AddShipInfoAsync(ShipInfo shipInfo);
        Task<int> EditShipInfoAsync(int id, ShipInfo shipInfo);
    }
}
