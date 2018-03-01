using RootEmployees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RootEmployees.Services
{
    public class UserauthService
    {
        private List<UserAuth> UserauthList;

        public UserauthService()
        {
            UserauthList = new List<UserAuth>
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
        }

        public UserAuth GetUserAuth(string userName, string password)
        {
            var user = new UserAuth
            {
                UserName = userName,
                Password = password
            };

            var userauth = this.UserauthList.Find(item => item.UserName == user.UserName && item.Password == user.Password);
            if (userauth != null)
                return userauth;

            return null;
        }
    }
}
