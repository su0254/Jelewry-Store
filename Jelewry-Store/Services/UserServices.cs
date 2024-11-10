
using Jelewry_Store.Entities;


namespace Jelewry_Store.Services
{
    public class UserServices
    {
        ErrorTZ error = ErrorTZ.OK;
        TzValid tzvalid=new TzValid();
        static int id = 1;

        public List<User> GetAllUser()
        {
            return DataContextManager.Manager.Users;
        }

        public User GetUserById(string tz)
        {
            if (DataContextManager.Manager.Users == null) return null;
            return DataContextManager.Manager.Users.Find((u) => u.Tz == tz);
        }

        public bool PostUser(User user)
        {
            if(user == null) return false;  
            tzvalid.ISOK(user.Tz, out error);
            if(error != ErrorTZ.OK) 
                return false;
            user.Id = id++;
            DataContextManager.Manager.Users.Add(user);
            return true;
        }

        public bool PutUser(string tz, User u)
        {
            tzvalid.ISOK(tz, out error);
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

        public bool DeleteUser(string tz)
        {
            User u = DataContextManager.Manager.Users.Find((u)=>u.Tz == tz);
            if(u == null) return false;
            DataContextManager.Manager.Users.Remove(u);
            return true;
        }
    }
}
