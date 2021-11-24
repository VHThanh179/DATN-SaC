using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IStatisticalSvc
    {
        List<Statistical> GetAllStatistical();
    }
}
