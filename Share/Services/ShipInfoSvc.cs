﻿using Microsoft.EntityFrameworkCore;
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
                //ShipInfo _shipInfo = null;
                //_shipInfo = _context.ShipInfos.Find(id);
                //_shipInfo.CusName = shipInfo.CusName;
                //_shipInfo.Address = shipInfo.Address;
                //_shipInfo.PhoneNumber = shipInfo.PhoneNumber;
                //_shipInfo.Notes = shipInfo.Notes;
                //_shipInfo.Price = shipInfo.Price;
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
            var shipInfo = new ShipInfo();
            return shipInfo = await _context.ShipInfos
                .Where(x => x.OrderId == orderId)
                .Include(x => x.Order).FirstOrDefaultAsync();
        }

        //sync

        public int AddShipInfo(ShipInfo shipInfo)
        {
            int ret = 0;
            try
            {
                _context.Add(shipInfo);
                _context.SaveChangesAsync();
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
                //ShipInfo _shipInfo = null;
                //_shipInfo = _context.ShipInfos.Find(id);
                //_shipInfo.CusName = shipInfo.CusName;
                //_shipInfo.Address = shipInfo.Address;
                //_shipInfo.PhoneNumber = shipInfo.PhoneNumber;
                //_shipInfo.Notes = shipInfo.Notes;
                //_shipInfo.Price = shipInfo.Price;
                _context.ShipInfos.Update(shipInfo);
                value = shipInfo.ShipId;


                _context.SaveChangesAsync();
            }
            catch (Exception) { }
            return value;
        }

        public List<ShipInfo> GetAllShipInfo()
        {
            List<ShipInfo> list = new List<ShipInfo>();
            list    = _context.ShipInfos.ToList();
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
