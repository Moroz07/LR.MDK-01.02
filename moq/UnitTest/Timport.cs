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
        public void TestMethod_UnsuccessfulImport() 
        {
            List<User> users = new List<User>
            {
                new User { Login = "i van", Password = "password123", Name = "Ivan", LastName = "Ivanov" }, // пробел в логине
                new User { Login = "login222", Password = "Passwo rd123", Name = "Kolya", LastName = "Nizki" }, // пробел в пароле
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" }, // всё ок
                new User { Login = "5ORLKA", Password = "PYATEROCHKA2", Name = "Kirill", LastName = "BumBumov" }, // логин есть уже в бд
                new User { Login = "Rijik", Password = "Rijik22", Name = "Arseniy", LastName = "Rijov" }, //всё ок
                new User { Login = "Qwerty212", Password = null, Name = "Vlad", LastName = "Ymniy" }, // нету пароля
                new User { Login = null, Password = "Password21", Name = "Nikita", LastName = "Morj" }, // нету логина
                new User { Login = "ARTEMKA", Password = "artem", Name = "Artem", LastName = "Morozov" }, // нету цифр в пароле
                new User { Login = "Shamarin", Password = "sha3", Name = "Kirill", LastName = "Shamarin" }, //
                 new User { Login = "Kuvalda", Password = "Kuvalda13", Name = "Vadim", LastName = "Kuvaldaev" } // всё ок
            };

            List<User> allUsers = new List<User>
            {
                new User { Login = "5ORLKA", Password = "PYATEROCHKA2" }
            };

            List<User> ExpectedUsers = new List<User>
            {
                new User { Login = "login542", Password = "Password21", Name = "Petya", LastName = "Visokiy" },
                new User { Login = "Rijik", Password = "Rijik22", Name = "Arseniy", LastName = "Rijov" },
                new User { Login = "Kuvalda", Password = "Kuvalda13", Name = "Vadim", LastName = "Kuvaldaev" }
            };


            Mock<IUserFile> fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            Mock<IUsersRepositoriy> repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.LoadUserInfo()).Returns(allUsers);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            List<User> added = importer.ImportUser("users.txt");


            Assert.AreEqual(ExpectedUsers.Count, added.Count);

            for (int i = 0; i < ExpectedUsers.Count; i++)
            {
                Assert.AreEqual(ExpectedUsers[i].Login, added[i].Login);
                Assert.AreEqual(ExpectedUsers[i].Password, added[i].Password);
            }
        }



    }
}