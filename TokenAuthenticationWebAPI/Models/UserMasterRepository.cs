using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWebAPI.Models
{
    public class UserMasterRepository : IDisposable
    {
        //It is your context class
        //XYZ_DBEntities context = new XYZ_DBEntities();

        //This method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username, string password)
        {
            //return context.UserMasters.FirstOrDefault(user =>
            //user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            //&& user.UserPassword == password);

            List<UserMaster> userList = new List<UserMaster>() {
                new UserMaster(){Id=101,UserName="manishkumar",Password="Abc@123",Email="manish@test.com",RoleName="SuperAdmin" },
                new UserMaster(){Id=102,UserName="admin",Password="Abc@123",Email="admin@test.com",RoleName="Admin" },
                new UserMaster(){Id=103,UserName="user",Password="Abc@123",Email="user@test.com",RoleName="User" }
            };


            return userList.FirstOrDefault(x => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password == password);
        }

        public void Dispose()
        {
            //context.Dispose();
        }
    }
}