using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class ShipInfoSvc : IShipInfoSvc
    {
        protected DataContext _context;
        public ShipInfoSvc (DataContext context)
        {
            context = _context;
        }
        public async Task<int> AddShipInfoAsync(ShipInfo shipInfo)
        {
            int ret = 0;
            try
            {
                _context.Add(shipInfo);
                await _context.SaveChangesAsync();
                ret = shipInfo.ShipId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditShipInfoAsync(int id, ShipInfo shipInfo)
        {
            await _context.SaveChangesAsync();
            return 0;
        }

        public async Task<List<ShipInfo>> GetAllShipInfo()
        {
            List<ShipInfo> list = await _context.ShipInfos.ToListAsync();
            return list;
        }

        public async Task<ShipInfo> GetShipInfo(int id)
        {
            ShipInfo shipInfo = null;
            shipInfo = await _context.ShipInfos.FindAsync(id);
            return shipInfo;
        }
    }
}
