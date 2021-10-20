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
        //async
        Task<List<ShipInfo>> GetAllShipInfoAsync();
        Task<ShipInfo> GetShipInfoAsync(int id);
        Task<int> AddShipInfoAsync(ShipInfo shipInfo);
        Task<int> EditShipInfoAsync(int id, ShipInfo shipInfo);
        Task<ShipInfo> GetShipInfoByOrderAsync(int orderId);

        //sync
        List<ShipInfo> GetAllShipInfo();
        ShipInfo GetShipInfo(int id);
        int AddShipInfo(ShipInfo shipInfo);
        int EditShipInfo(int id, ShipInfo shipInfo);
        ShipInfo GetShipInfoByOrder(int orderId);
    }
}
