using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Models
{
    class Movie
    {
        private string name_;
        private int price_;
        private string director_;
        private string mainActor_;
        private DateTime enddate_;
        private string photo_;
        private string genre_;

        public Movie(string name, int price, string director, string mainActor, DateTime enddate, string photo, string genre)
        {
            name_ = name;
            price_ = price;
            director_ = director;
            mainActor_ = mainActor;
            enddate_ = enddate;
            photo_ = photo;
            genre_ = genre;

        }

        public string Name
        { get { return name_; } }

        public int Price
        { get { return price_; } }

        public string Director
        { get { return director_; } }

        public string MainActor
        { get { return mainActor_; } }
        public DateTime Enddate
        { get { return enddate_; } }
        public string Photo
        { get { return photo_; } }

        public string Genre
        { get { return genre_; } }

        public string GetInfo()
        {
            return $"Название: {name_}\nЖанр: {genre_}\nЦена: {price_}\nРежиссер: {director_}\nГлавные роли: {mainActor_}\nСрок завершения проката: {enddate_.ToShortDateString()}";
        }
    }
}
