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
            _context = context;
        }

        //asyc

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
            int value = 0;
            try
            {
                _context.ShipInfos.Update(shipInfo);
                value = shipInfo.ShipId;


                await _context.SaveChangesAsync();
            }
            catch (Exception){}
            return value;
        }

        public async Task<List<ShipInfo>> GetAllShipInfoAsync()
        {
            List<ShipInfo> list = await _context.ShipInfos.ToListAsync();
            return list;
        }

        public async Task<ShipInfo> GetShipInfoAsync(int id)
        {
            ShipInfo shipInfo = null;
            shipInfo = await _context.ShipInfos.FindAsync(id);
            return shipInfo;
        }

        public async Task<ShipInfo> GetShipInfoByOrderAsync(int orderId)
        {
            ShipInfo shipInfo = null;
            return shipInfo = await _context.ShipInfos
                .Where(x => x.OrderId == orderId).FirstOrDefaultAsync();
        }

        //sync

        public int AddShipInfo(ShipInfo shipInfo)
        {
            int ret = 0;
            try
            {
                _context.Add(shipInfo);
                _context.SaveChanges();
                ret = shipInfo.ShipId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditShipInfo(int id, ShipInfo shipInfo)
        {
            int value = 0;
            try
            {
                _context.ShipInfos.Update(shipInfo);
                value = shipInfo.ShipId;
                _context.SaveChanges();
            }
            catch (Exception) { }
            return value;
        }

        public List<ShipInfo> GetAllShipInfo()
        {
            List<ShipInfo> list = _context.ShipInfos.ToList();
            return list;
        }

        public ShipInfo GetShipInfo(int id)
        {
            ShipInfo shipInfo = null;
            shipInfo = _context.ShipInfos.Find(id);
            return shipInfo;
        }

        public  ShipInfo GetShipInfoByOrder(int orderId)
        {
            var shipInfo = new ShipInfo();
            return shipInfo = _context.ShipInfos
                .Where(x => x.OrderId == orderId)
                .Include(x => x.Order).FirstOrDefault();
        }
    }
}
