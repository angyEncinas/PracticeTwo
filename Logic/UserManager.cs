using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager
    {
        public List<User> users { get; set; }
        public UserManager()
        {
            users = new List<User>()
            {
                new User() { Name = "Angy", id = 1 },
                new User() { Name = "Victor",id =2 },
                new User() { Name = "Samantha", id = 3 }
            };
        }
        public List<User> GetUsers()
        {
            return users;
            
        }
        
        public User PostUsers(User user)
        {
           users.Add(user);
            return user;
        }
        
        public User DeleteUsers(User user)
        {
            users.Remove(user);
            return user;
        }
        
        public User PutUsers(User first, User user)
        {
           
            int index = users.FindIndex(first => first.id ==user.id);
            
            users.RemoveAt(index);
            users.Add(user);

            return user;
        }
    }
}
