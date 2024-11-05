using Jelewry_Store.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jelewry_Store.Services
{
    public class UserServices
    {
        static int id = 1;
        static List<User> Users { get; }
        public UserServices()
        {

        }
        static UserServices()
        {
            Users = new List<User>();
        }
        public List<User> GetAllUser()
        {
            return Users;
        }

        public User GetUserById(string tz)
        {
            foreach (var user in Users)
            {
                if (user.Tz == tz)
                    return user;
            }
            return null;
        }

        public void PostUser(User user)
        {
            user.Id = id++;
            Users.Add(user);
        }

        public void PutUser(string tz, User u)
        {
            for (int i = 0; i < Users.Count(); i++)
            {
                if (Users[i].Tz == tz)
                {
                    Users[i] = u;
                    return;
                }
            }
        }

        public void DeleteUser(string tz)
        {
            foreach (var user in Users)
            {
                if (user.Tz == tz)
                {
                    Users.Remove(user);
                    return;
                }
            }
        }
    }
}
