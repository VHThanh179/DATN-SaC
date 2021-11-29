using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Share.Interfaces;
using Share.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipInfoController : ControllerBase
    {
        private readonly IShipInfoSvc _shipInfoSvc;
        public ShipInfoController(IShipInfoSvc shipInfoSvc)
        {
            _shipInfoSvc = shipInfoSvc;
        }

        [HttpGet]
        public async Task<ActionResult<ShipInfo>> GetShipInfoByOrder([FromQuery] int orderId)
        {
            var shipinfo = await _shipInfoSvc.GetShipInfoByOrderAsync(orderId);
            return shipinfo;
        }
    }
}
