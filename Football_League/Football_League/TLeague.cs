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
        

        [TestMethod]
        public void TestTop3Team()
        {
            League league = new League();

            Team zenit = new Team("Зенит", 65, 40);
            Team krasnodar = new Team("Краснодар", 60, 36);
            Team spartak = new Team("Спартак", 43, 22);
            Team cska = new Team("ЦСКА", 48, 27);
            Team sochi = new Team("Сочи", 18, 8);
            Team lokomotiv = new Team("Локомотив", 33, 15);
            Team dinamo = new Team("Динамо", 41, 21);

            league.AddTeam(zenit);
            league.AddTeam(spartak);
            league.AddTeam(krasnodar);
            league.AddTeam(cska);
            league.AddTeam(sochi);
            league.AddTeam(lokomotiv);
            league.AddTeam(dinamo);


            List<Team> expected = new List<Team>();
            expected.Add(zenit);        
            expected.Add(krasnodar);    
            expected.Add(cska);

            List<Team> result = league.TopTeams(3);
            CollectionAssert.AreEqual(expected, result);

          

        }

        [TestMethod]
        public void TestTop5Team()
        {
            League league = new League();

            Team zenit = new Team("Зенит", 65, 40);
            Team krasnodar = new Team("Краснодар", 60, 36);
            Team spartak = new Team("Спартак", 43, 22);
            Team cska = new Team("ЦСКА", 48, 27);
            Team sochi = new Team("Сочи", 18, 8);
            Team lokomotiv = new Team("Локомотив", 33, 15);
            Team dinamo = new Team("Динамо", 41, 21);

            league.AddTeam(zenit);
            league.AddTeam(spartak);
            league.AddTeam(krasnodar);
            league.AddTeam(cska);
            league.AddTeam(sochi);
            league.AddTeam(lokomotiv);
            league.AddTeam(dinamo);

            List<Team> expected = new List<Team>();
            expected.Add(zenit);
            expected.Add(krasnodar);
            expected.Add(cska);
            expected.Add(spartak);
            expected.Add(dinamo);

            List<Team> result = league.TopTeams(5);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
