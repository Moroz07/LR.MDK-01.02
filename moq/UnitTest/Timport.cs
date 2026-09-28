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
        [TestMethod] // если файл вернул одного валидного пользователя и в БД его нет, то ImportUser вернёт true
        public void TestImport()
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = "password123", Name = "Ivan", LastName = "Ivanov" }
            };

            List<User> allUsers = new List<User>();

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod] // логин с пробелом
        public void TestMethod_UnsuccessfulImport()
        {
            List<User> users = new List<User>
            {
                new User { Login = "i van", Password = "password123", Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            List<User> allUsers = new List<User>();

            Mock<IUserFile> fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            Mock<IUsersRepositoriy> repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod] // файл вернул пустой список
        public void TestImport_NoUsers()
        {
            List<User> users = new List<User>();
            List<User> allUsers = new List<User>();

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod] // логин из файла уже есть в БД
        public void TestImport_UserLoginAgain()
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = "password123", Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            List<User> allUsers = new List<User>
            {
                new User { Login = "login123", Password = "123" }
            };

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod] // у пользователя нет пароля
        public void TestImport_NoPassword()
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = null, Name = "Ivan", LastName = "Ivanov" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            List<User> allUsers = new List<User>();

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }

        [TestMethod] // у пользователя нет логина
        public void TestImport_NoLogin()
        {
            List<User> users = new List<User>
            {
                new User { Login = null, Password = "password1", Name = "Nikita", LastName = "Popkin" },
                new User { Login = "login222", Password = "Password123", Name = "Kolya", LastName = "Nizki" },
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }
            };

            List<User> allUsers = new List<User>();

            var fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }
    }
}