using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using FootbalTeam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Football_League
{
    [TestClass]
    public class TLeague
    {
        League league = new League();

        [TestMethod]
        public void TestTop3Team()
        {
            
            league.AddTeam(new Team("Зенит", 65, 40));
            league.AddTeam(new Team("Спартак", 43, 22)  );
            league.AddTeam(new Team("Краснодар", 60, 36));
            league.AddTeam(new Team("ЦСКА", 48, 27));
            league.AddTeam(new Team("Сочи", 18, 8));
            league.AddTeam(new Team("Локомотив", 33, 15));
            league.AddTeam(new Team("Динамо", 41, 21));


            List<Team> expected = new List<Team>();
            expected.Add(new Team("Зенит", 65, 40));
            expected.Add(new Team("Краснодар", 60, 36));
            expected.Add(new Team("ЦСКА", 48, 27));

            List<Team> result = league.TopTeams(3);
            CollectionAssert.AreEqual(expected, result);
          

        }

        [TestMethod]
        public void TestTop5Team()
        {
            league.AddTeam(new Team("Зенит", 65, 40));
            league.AddTeam(new Team("Спартак", 43, 22));
            league.AddTeam(new Team("Краснодар", 60, 36));
            league.AddTeam(new Team("ЦСКА", 48, 27));
            league.AddTeam(new Team("Сочи", 18, 8));
            league.AddTeam(new Team("Локомотив", 33, 15));
            league.AddTeam(new Team("Динамо", 41, 21));

            List<Team> expected = new List<Team>();
            expected.Add(new Team("Зенит", 65, 40));
            expected.Add(new Team("Краснодар", 60, 36));
            expected.Add(new Team("ЦСКА", 48, 27));
            expected.Add(new Team("Спартак", 43, 22));
            expected.Add(new Team("Динамо", 41, 21));

            List<Team> result = league.TopTeams(5);
            Assert.AreEqual(expected[0].name_, result[0].name_);
            Assert.AreEqual(expected[1].name_, result[1].name_);
            Assert.AreEqual(expected[2].name_, result[2].name_);
            Assert.AreEqual(expected[3].name_, result[3].name_);
            Assert.AreEqual(expected[4].name_, result[4].name_);
        }
    }
}
