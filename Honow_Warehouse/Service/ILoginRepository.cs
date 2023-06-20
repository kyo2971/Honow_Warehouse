using Honow_Warehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honow_Warehouse.Service
{
    public interface ILoginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
