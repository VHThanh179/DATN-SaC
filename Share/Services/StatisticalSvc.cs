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
        public List<TotalStatistical> GetTotalStatistical()
        {
            return _context.TotalAllStatistical.ToList();
        }

        public List<Statistical> SearchStatistical(DateTime startDate, DateTime endDate)
        {
            return _context.Statisticals.FromSqlRaw("SearchStatistical {0}, {1}", startDate, endDate).ToList();
        }
    }
}
