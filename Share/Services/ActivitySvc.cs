using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class ActivitySvc : IActivity
    {
        protected DataContext _context;

        public ActivitySvc(DataContext context)
        {
            _context = context;
        }

        public bool SaveLog(string data)
        {
            bool stat;
            try
            {
                Activity activity = new Activity();
                if (data.Contains("@"))
                {
                    activity.CusEmail = data;
                }
                else
                {
                    activity.UserName = data;
                }
                activity.LoginTime = DateTime.Now;
                _context.Add(activity);
                _context.SaveChanges();
                stat = true;
            }
            catch
            {
                stat = false;
            }
            return stat;
        }

        public List<Activity> GetUserLog(string userName)
        {
            List<Activity> activity = _context.Activities.Where(n => n.UserName == userName).ToList();
            return activity;
        }

        public async Task SaveLogAsync(string data)
        {
            Activity activity = new Activity();
            if (data.Contains("@"))
            {
                activity.CusEmail = data;
            }
            else
            {
                activity.UserName = data;
            }
            activity.LoginTime = DateTime.Now;
            await _context.AddAsync(activity);
            await _context.SaveChangesAsync();
        }
    }
}
