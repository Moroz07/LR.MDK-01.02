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
        private Team zenit;
        private Team krasnodar;
        private Team spartak;
        private Team cska;
        private Team sochi;
        private Team lokomotiv;
        private Team dinamo;
        private Team baltika;
        private Team ahmat;
        private Team rubin;
        private Team akron;
        private Team rostov;

        [TestInitialize]
        public void TestInitialize()
        {
           

            zenit = new Team("Зенит", 65, 40);
            krasnodar = new Team("Краснодар", 60, 36);
            spartak = new Team("Спартак", 52, 22);
            cska = new Team("ЦСКА", 49, 27);
            sochi = new Team("Сочи", 18, 8);
            lokomotiv = new Team("Локомотив", 33, 15);
            dinamo = new Team("Динамо", 41, 21);
            baltika = new Team("Балтика", 55, 17);
            ahmat = new Team("Ахмат", 45, 12);
            rubin = new Team("Рубин", 38, 11);
            akron = new Team("Акрон", 48, 15);
            rostov = new Team("Ростов", 29, 18);

            league.AddTeam(zenit);
            league.AddTeam(spartak);
            league.AddTeam(krasnodar);
            league.AddTeam(cska);
            league.AddTeam(sochi);
            league.AddTeam(lokomotiv);
            league.AddTeam(dinamo);
            league.AddTeam(baltika);
            league.AddTeam(ahmat);
            league.AddTeam(rubin);
            league.AddTeam(akron);
            league.AddTeam(rostov);
        }

            [TestMethod]
            public void TestTop3Team()
            {

                List<Team> expected = new List<Team>();
                expected.Add(zenit);
                expected.Add(krasnodar);
                expected.Add(baltika);

                List<Team> result = league.TopTeams(3);
                CollectionAssert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestTop5Team()
            {

                List<Team> expected = new List<Team>();
                expected.Add(zenit);
                expected.Add(krasnodar);
                expected.Add(baltika);
                expected.Add(spartak);
                expected.Add(cska);

                List<Team> result = league.TopTeams(5);
                CollectionAssert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestTop10Team()
            {


                List<Team> expected = new List<Team>();
                expected.Add(zenit);
                expected.Add(krasnodar);
                expected.Add(baltika);
                expected.Add(spartak);
                expected.Add(cska);
                expected.Add(akron);
                expected.Add(ahmat);
                expected.Add(dinamo);
                expected.Add(rubin);
                expected.Add(lokomotiv);

                List<Team> result = league.TopTeams(10);
                CollectionAssert.AreEqual(expected, result);
            }
        }
    }
