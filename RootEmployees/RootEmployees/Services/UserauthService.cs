using RootEmployees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RootEmployees.Services
{
    public class UserauthService
    {
        public List<UserAuth> UserauthList()
        {
            var UserAuthList = new List<UserAuth>
            {
                new UserAuth
                {
                    UserName = "root",
                    Password = "root"
                },
                new UserAuth
                {
                    UserName = "marwen",
                    Password = "root"
                }
            };

            return UserAuthList;
        }
    }
}
