using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLib
{
    public class ImportFromFile
    {
        IUserFile UserFile_;
        IUsersRepositoriy repository_;
        private int MinPasswordLength = 5;
        public ImportFromFile(IUserFile file, IUsersRepositoriy repository)
        {
            UserFile_ = file;
            repository_ = repository;
        }
        public bool ImportUser(string filePath)
        {
            List<User> users = UserFile_.ReadAllLines(filePath);

            List<User> result = new List<User>();

            foreach (User user in users)
            {
                if (user.Login == null ||
                    user.Password == null ||
                    user.Name == null ||
                    user.LastName == null)
                {
                    continue;
                }

                if (user.Login.Contains(" ") ||
                    user.Password.Contains(" ") ||
                    user.Name.Contains(" ") ||
                    user.LastName.Contains(" "))
                {
                    continue;
                }

                if (user.Password.Length < MinPasswordLength)
                {
                    continue;
                }


                bool ItsNumber = false;
                foreach (int c in user.Password)
                {
                    if (c >= '0' && c <= '9')
                    {
                        ItsNumber = true;
                    }
                }

                if (ItsNumber == false)
                {
                    continue;
                }

               
                if (repository_.GetUser(user.Login) != null)
                {
                    continue;
                }

                result.Add(user);
            }

            if (result.Count > 0)
            {
                repository_.AddAllUsers(result);
            }

            return true;
        }
    }
}
