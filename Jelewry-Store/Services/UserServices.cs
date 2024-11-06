using Jelewry_Store.;
using Jelewry_Store.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jelewry_Store.Services
{
    public class UserServices
    {
        TzValid tzvalid=new TzValid();
        static int id = 1;

        public List<User> GetAllUser()
        {
            return DataContextManager.Manager.Users;
        }

        public User GetUserById(string tz)
        {
            
            foreach (var user in DataContextManager.Manager.Users)
            {
                if (user.Tz == tz)
                    return user;
            }
            return null;
        }

        public bool PostUser(User user)
        {
            ErrorTZ error = ErrorTZ.OK;
            tzvalid.ISOK(user.Tz, out error);
            if(error != ErrorTZ.OK) 
                return false;
            user.Id = id++;
            DataContextManager.Manager.Users.Add(user);
            return true;
        }

        public bool PutUser(string tz, User u)
        {
            ErrorTZ error = ErrorTZ.OK;
            tzvalid.ISOK(u.Tz, out error);
            if (error != ErrorTZ.OK)
                return false;
            User user=DataContextManager.Manager.Users.Find((user) => user.Tz == tz);
            if (user == null) return false;
            user.Tz = u.Tz;
            user.EStatus = u.EStatus;
            user.EStatus=u.EStatus;
            user.Address= u.Address;
            user.City= u.City;
            user.BirthDay= u.BirthDay;
            user.Name= u.Name;
            user.ZipCode= u.ZipCode;
            user.PhoneNumber= u.PhoneNumber;
            return true;
        }

        public void DeleteUser(string tz)
        {
            foreach (var user in DataContextManager.Manager.Users)
            {
                if (user.Tz == tz)
                {
                    DataContextManager.Manager.Users.Remove(user);
                    return;
                }
            }
        }
    }
}
