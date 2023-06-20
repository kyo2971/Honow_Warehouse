using Honow_Warehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honow_Warehouse.Service
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                var userInfo= new UserInfo();
                if (username == "00813" && password == "00813+-*/")
                {
                    userInfo.UserName = username;
                    return await Task.FromResult(userInfo);
                }
                else
                { throw new NotImplementedException("帳密錯誤!"); }
            }
            else
            { throw new NotImplementedException("找不到網路訊號"); }
            
        }
    }
}
