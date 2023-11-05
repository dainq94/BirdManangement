using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class UserRepository : IUserRepository
    {
        public bool CheckEmail(string usernameOrEmail)
        => UserDAO.Instance.Exist(usernameOrEmail);

        public bool CheckPhone(string phone)
        => UserDAO.Instance.CheckPhoneExist(phone);

        public void Create(User user)
        => UserDAO.Instance.Create(user);

        public List<User> getAllUsers()
        => UserDAO.Instance.GetAllUsers();

        public User getUserByEmail(string email)
        => UserDAO.Instance.GetUserByUsername(email);

        public void Save(User entity)
       => UserDAO.Instance.Save(entity);

        public void UpdateUser(User user)
        => UserDAO.Instance.UpdateUser(user);

        public bool UserExit(string usernameOrEmailOrPhone)
        {
            throw new NotImplementedException();
        }

    }
}