using Jelewry_Store.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jelewry_Store.Services
{
    public class UserServices
    {
        static List<User> Users { get; }
        public UserServices()
        {

        }
        static UserServices()
        {
            Users = new List<User>();
            Users.Add(new User(2, "123", "sari", "gdf@", "0527600254", "bney brak", "jerusalem 47", "12345", new DateTime()));
            Users.Add(new User(1, "123", "hadasa", "gdf@", "0527600254", "bney brak", "jerusalem 47", "12345", new DateTime()));
        }
        public List<User> GetAllUser()
        {
            return Users;
        }

        public User GetUserById(string id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }

        public void PostUser(User user)
        {
            Users.Add(user);
        }

        public void PutUser(string id, User u)
        {
            for (int i = 0; i < Users.Count(); i++)
            {
                if (Users[i].Id == id)
                {
                    Users[i] = u;
                    return;
                }
            }
        }

        public void DeleteUser(string id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    Users.Remove(user);
                    return;
                }
            }
        }
    }
}
