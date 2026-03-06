using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    internal class StorageMovie : IMovie
    {
        public List<Movies> LoadAllMovie()
        {
            List<Movies> allMovie = new List<Movies>();
            string path = "data.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allMovie.Add(new Movie(lines[1], Convert.ToInt32(lines[2]), lines[3], lines[4], Convert.ToDateTime(lines[5]), lines[6], lines[0]));
            }
            info.Close();
            return allMovie;

        }
    }

}
