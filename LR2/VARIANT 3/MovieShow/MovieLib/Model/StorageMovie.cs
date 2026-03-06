using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public class StorageMovie : IMovie
    {
        public List<Movie> LoadAllMovie()
        {
            List<Movie> allMovie = new List<Movie>();
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
