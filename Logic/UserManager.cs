﻿using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> users { get; set; }
        public UserManager()
        {
            users = new List<User>()
            {
                new User() { Name = "Angy", id = 1},
                new User() { Name = "Victor", id = 2},
                new User() { Name = "Samantha", id = 3}
            };
        }
        public List<User> GetUsers()
        {
            return users;
            
        }
        
        public User PostUser(User user)
        {
           users.Add(user);
            return user;
        }
        
        public User DeleteUser(User user)
        {
            User userFound = users.Find(u => u.id == user.id);
            if(userFound == null)
            {
                users.Remove(userFound);
            }
            else
            {
                return new User() { Name = "0", id = 0 };
            }
            return user;



        }
        
        public User PutUser(User user)
        {

            User userUpdate = users.Find(u => u.id == user.id);
            userUpdate.Name = user.Name;
            userUpdate.id = user.id; 

            return user;
        }
    }
}
