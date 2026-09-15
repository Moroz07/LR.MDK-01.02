using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserService
    {

        private IUsersRepository usersRepository_;
        public UserService(IUsersRepository UsersRepository)
        {
            usersRepository_ = UsersRepository;
        }

        public bool Authorization(string login, string password)
        {
            User user = usersRepository_.GetUserInfo(login);
            if (password == user.Password)
            {
                return true;
            }
            else return false;
            
        }
    }
}
