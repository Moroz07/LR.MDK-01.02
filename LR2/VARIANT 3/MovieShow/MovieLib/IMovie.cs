using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    internal interface IMovie
    {
        List<Movies> LoadAllMovie();
    }
}

