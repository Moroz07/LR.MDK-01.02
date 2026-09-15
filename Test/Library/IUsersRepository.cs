using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library
{
    public interface IUsersRepository
    {
        List<User> GetAllUsers();
        User GetUserInfo(string login);
        
    }
}
