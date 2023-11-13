﻿using BirdRepository;
using BusinessObjects.Models;

namespace BirdService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = null;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool CheckEmail(string usernameOrEmail)
        {
            return _userRepository.CheckEmail(usernameOrEmail);
        }

        public bool CheckPhone(string phone)
        {
            return _userRepository.CheckPhone(phone);
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.getAllUsers();
        }

        public User GetUserByUsername(string user)
        {
            return _userRepository.getUserByEmail(user);
        }

        public void Save(User user)
        {
            _userRepository.Save(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }

        public bool UserExit(string usernameOrEmailOrPhone)
        {
            return _userRepository.UserExit(usernameOrEmailOrPhone);
        }

        List<User> IUserService.GetAllUsers()
        {
            return _userRepository.getAllUsers();
        }
    }
}