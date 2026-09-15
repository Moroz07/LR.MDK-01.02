using System;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock <IUsersRepository> mock = new Mock<IUsersRepository>();
            mock.Setup(repo => repo.GetUserInfo("morozv")).Returns(new User { Login = "morozv", Password = "123" });
            UserService service = new UserService(mock.Object);
            service.Authorization("morozv", "123");          
        }
    }
}
