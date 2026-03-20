using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieLib;
using System;
using System.Collections.Generic;

namespace TMovieShow
{
    [TestClass]
    public class TMovie
    {
        private StorageMovie storage;
        private List<Movie> allMovies;

        [TestInitialize]
        public void TestInitialize()
        {
            storage = new StorageMovie();
            allMovies = storage.LoadAllMovie();
        }


        [TestMethod]
        public void TGetAllMovies()
        {

            List<Movie> expectedMovies = new List<Movie>();
            expectedMovies.Add(new Movie("Трансформеры", 250, "Майкл Бэй", "Шайа Лабаф", new DateTime(2025, 1, 30), "Фотки\\Трансформеры.jpg", "Боевик"));
            expectedMovies.Add(new Movie("Брат 2", 300, "Алексей Балабанов", "Сергей Бодров", new DateTime(2025, 1, 31), "Фотки\\Брат2.jpg", "Боевик"));
            expectedMovies.Add(new Movie("Человек-паук: Через вселенные", 270, "Родни Ротман", "Шамеик Мур", new DateTime(2025, 2, 1), "Фотки\\ЧеловекПаук.jpg", "Фэнтези"));
            expectedMovies.Add(new Movie("Последний богатырь", 220, "Дмитрий Дьяченко", "Виктор Хориняк", new DateTime(2025, 2, 1), "Фотки\\ПоследнийБогатырь.jpg", "Фэнтези"));


            Assert.AreEqual(expectedMovies.Count, allMovies.Count, "Количество фильмов не совпадает");

            for (int i = 0; i < expectedMovies.Count; i++)
            {
                Assert.AreEqual(expectedMovies[i].Name, allMovies[i].Name);
                Assert.AreEqual(expectedMovies[i].Price, allMovies[i].Price);
                Assert.AreEqual(expectedMovies[i].Director, allMovies[i].Director);
                Assert.AreEqual(expectedMovies[i].MainActor, allMovies[i].MainActor);
                Assert.AreEqual(expectedMovies[i].Genre, allMovies[i].Genre);
                Assert.AreEqual(expectedMovies[i].Photo, allMovies[i].Photo);
                Assert.AreEqual(expectedMovies[i].Enddate, allMovies[i].Enddate);
            }
        }




        [TestMethod]
        public void TFilterGenre()
        {

            List<Movie> expectedAction = new List<Movie>();
            expectedAction.Add(allMovies[0]);  // Трансформеры
            expectedAction.Add(allMovies[1]);  // Брат 2
            List<Movie> expectedFantasy = new List<Movie>();
            expectedFantasy.Add(allMovies[2]);  // Человек-паук
            expectedFantasy.Add(allMovies[3]);  // Последний богатырь

            List<Movie> actionMovies = new List<Movie>();
            foreach (Movie movie in allMovies)
            {
                if (movie.Genre == "Боевик")
                {
                    actionMovies.Add(movie);
                }
            }
            List<Movie> fantasyMovies = new List<Movie>();
            foreach (Movie movie in allMovies)
            {
                if (movie.Genre == "Фэнтези")
                {
                    fantasyMovies.Add(movie);
                }
            }

            CollectionAssert.AreEqual(expectedAction, actionMovies, "Список фильмов жанра Боевик не совпадает");
            CollectionAssert.AreEqual(expectedFantasy, fantasyMovies, "Список фильмов жанра Фэнтези не совпадает");
        }

   

        [TestMethod]
        public void TCalculateTotalPrice()
        {
            
            Movie movie = allMovies[0]; //трансформеры

            int shows = 5;

            int totalPrice = movie.Price * shows;

            Assert.AreEqual(250, movie.Price, "Цена фильма не совпадает");
            Assert.AreEqual(1250, totalPrice, "Итоговая сумма должна быть 1250");
        }

    }
}
