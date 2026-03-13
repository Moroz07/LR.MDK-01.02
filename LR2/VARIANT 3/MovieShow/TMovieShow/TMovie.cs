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
        private List<Movie> expectedMovies;

        [TestInitialize]
        public void TestInitialize()
        {

            storage = new StorageMovie();

            expectedMovies = new List<Movie>();
            expectedMovies.Add(new Movie("Трансформеры",250,"Майкл Бэй","Шайа Лабаф",new System.DateTime(2025, 1, 30),"Фотки\\Трансформеры.jpg","Боевик"));
            expectedMovies.Add(new Movie("Брат 2",300,"Алексей Балабанов","Сергей Бодров",new System.DateTime(2025, 1, 31),"Фотки\\Брат2.jpg","Боевик"));
            expectedMovies.Add(new Movie("Человек-паук: Через вселенные",270,"Родни Ротман","Шамеик Мур",new System.DateTime(2025, 2, 1),"Фотки\\ЧеловекПаук.jpg","Фэнтези"));
            expectedMovies.Add(new Movie("Последний богатырь",220,"Дмитрий Дьяченко","Виктор Хориняк",new System.DateTime(2025, 2, 1),"Фотки\\ПоследнийБогатырь.jpg","Фэнтези"));
        }

        [TestMethod]
        public void TGetAllMovies()
        {
           
            List<Movie> result = storage.LoadAllMovie();
            Assert.AreEqual(expectedMovies.Count, result.Count, "Должно быть загружено 4 фильма");
        }

        
            [TestMethod]
        public void TFilterGenre()
        {
                
            StorageMovie storage = new StorageMovie();
            List<Movie> allMovies = storage.LoadAllMovie();

                
            int actionCount = 0;
            int fantasyCount = 0;
                

           foreach (Movie movie in allMovies)
           {
             if (movie.Genre == "Боевик")
             {
               actionCount++;
             }
             if (movie.Genre == "Фэнтези")
             {
               fantasyCount++;
             }
           }
                Assert.AreEqual(2, actionCount, "Должно быть 2 фильма Боевик");
                Assert.AreEqual(2, fantasyCount, "Должно быть 2 фильма Фэнтези");

        }

    }
}
