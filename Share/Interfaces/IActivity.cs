using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IActivity
    {
        bool SaveLog(string data);
        List<Activity> GetUserLog(string userName);

        Task SaveLogAsync(string data);
    }
}
