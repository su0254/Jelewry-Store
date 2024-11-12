
using Jelewry_Store.Entities;


namespace Jelewry_Store.Services
{
    public class UserServices
    {
        ErrorTZ error = ErrorTZ.OK;
        TzValid tzvalid=new TzValid();
        static int id = 1;
        readonly IDataContext _dataContext;
        public UserServices(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<User> GetAllUser()
        {
            return _dataContext.LoadUsers();
        }

        public User GetUserById(string tz)
        {
            List<User> users = _dataContext.LoadUsers();
            if (users == null) return null;
            return users.Find((u) => u.Tz == tz);
        }

        public bool PostUser(User user)
        {
            if(user == null) return false;  
            tzvalid.ISOK(user.Tz, out error);
            if(error != ErrorTZ.OK) 
                return false;
            user.Id = id++;
            List<User> users = _dataContext.LoadUsers();
            if(users.Exists((u)=>u.Tz == user.Tz))
                return true;
            users.Add(user);
            if(_dataContext.SaveUsers(users)) return true;
            return false;
        }

        public bool PutUser(string tz, User u)
        {
            tzvalid.ISOK(tz, out error);
            if (error != ErrorTZ.OK)
                return false;
            List<User> users=_dataContext.LoadUsers();
            if(users==null) return false;
            User user=users.Find((user) => user.Tz == tz);
            if (user == null) return false;
            user.Tz = u.Tz;
            user.EStatus=u.EStatus;
            user.Address= u.Address;
            user.City= u.City;
            user.BirthDay= u.BirthDay;
            user.Name= u.Name;
            user.ZipCode= u.ZipCode;
            user.PhoneNumber= u.PhoneNumber;
            user.Email= u.Email;
            if (_dataContext.SaveUsers(users)) 
                return true;
            return false;
        }

        public bool DeleteUser(string tz)
        {
            List<User> users=_dataContext.LoadUsers();
            if (users==null) return false;
            User u = users.Find((u)=>u.Tz == tz);
            if(u == null) return false;
            users.Remove(u);
            if(_dataContext.SaveUsers(users))
                return true;
            return false;
        }
    }
}
