using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLib;

namespace UnitTest
{
    [TestClass]
    public class Timport
    {
        [TestMethod]
        public void TestImport() // если файл вернул одного валидного пользователя  и в БД его нет то ImportUser вернёт true
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = "password123", Name = "Ivan", LastName = "Ivanov" }
            };

            var fileMock = new Mock<IUserFile>(); 
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("login123")).Returns((User)null);
            IUserFile file = fileMock.Object; 
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod]
        public void TestMethod_UnsuccessfulImport() // логин с пробелом
        {
            List<User> users = new List<User>
            {
                new User { Login = "i van", Password = "password123", Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };
            Mock<IUserFile> fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            Mock<IUsersRepositoriy> repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("i van")).Returns((User)null);
            repoMock.Setup(repo => repo.GetUser("login222")).Returns((User)null);
            repoMock.Setup(repo => repo.GetUser("login542")).Returns((User)null);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod]
        public void TestImport_NoUsers() // файл вернул пустой список
        {
            List<User> users = new List<User>();

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod]
        public void TestImport_UserLoginAgain() // один логин уже есть в БД, остальные новые
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = "password123", Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("login123")).Returns(new User { Login = "login123", Password = "123" });
            repoMock.Setup(repo => repo.GetUser("login222")).Returns((User)null);
            repoMock.Setup(repo => repo.GetUser("login542")).Returns((User)null);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod]
        public void TestImport_NoPassword() // у пользователя нет пароля, у остальных есть
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = null, Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("login123")).Returns((User)null);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod]
        public void TestImport_NoLogin() // у одного логин отсутствует, у других имеется
        {
            List<User> users = new List<User>
            {
                new User { Login = null, Password = "password1", Name = "Nikita", LastName = "Popkin" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("")).Returns((User)null);
            repoMock.Setup(repo => repo.GetUser("login222")).Returns((User)null);
            repoMock.Setup(repo => repo.GetUser("login542")).Returns((User)null);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }




    }
}
