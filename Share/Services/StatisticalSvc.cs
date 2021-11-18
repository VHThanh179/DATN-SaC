using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class StatisticalSvc : IStatisticalSvc
    {
        protected DataContext _context;
        public StatisticalSvc(DataContext context)
        {
            _context = context;
        }
        public List<Statistical> GetAllStatistical()
        {
            return _context.Statisticals.ToList();
        }
    }
}
