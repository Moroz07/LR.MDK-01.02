using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLib;




namespace MovieShow
{
    public partial class MainForm : Form
    {
        List<Movie> allMovies = new List<Movie>();
        
        public MainForm()
        {
            InitializeComponent();


            totalShowsMovie.Minimum = 1;

            IMovie movieLoader = new StorageMovie();
            allMovies = movieLoader.LoadAllMovie();
            LoadGenresFromMovies();
            UpdatePriceInfo();

        }

        private void ListBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxMovie.Items.Clear();


            string selectedGenre = ListBoxGenre.SelectedItem.ToString();

            foreach (Movie movie in allMovies)
            {
                if (movie.Genre == selectedGenre)
                {
                    ComboBoxMovie.Items.Add(movie.Name);
                }
            }

            if (ComboBoxMovie.Items.Count != 0)
            {
                ComboBoxMovie.SelectedIndex = 0;
            }

            
        }



        private void ButtonShowMovie_Click(object sender, EventArgs e)
        {
            if (ComboBoxMovie.SelectedItem != null && ListBoxGenre.SelectedItem != null)
            {
                string selectedMovieName = ComboBoxMovie.SelectedItem.ToString();
                string selectedGenre = ListBoxGenre.SelectedItem.ToString();

                Movie selectedMovie = null;

                foreach (Movie movie in allMovies)
                {
                    if (movie.Name == selectedMovieName && movie.Genre == selectedGenre)
                    {
                        selectedMovie = movie;
                        break;
                    }
                }
                if (selectedMovie != null)
                {
                    int shows = (int)totalShowsMovie.Value;

                    int totalPrice = selectedMovie.Price * shows;
                    RichTextBoxInfo.Text = selectedMovie.GetInfo();
                    RichTextBoxInfo.Text += $"\nЗаказано показов: {shows}";
                    RichTextBoxInfo.Text += $"\nИтоговая сумма: {totalPrice} руб.";
                }
            }
        }

        private void ComboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

            string movieName = ComboBoxMovie.SelectedItem.ToString();

            foreach (Movie movie in allMovies)
            {
                if (movie.Name == movieName)
                {
                    PictureBoxMovie.Load(movie.Photo);
                }
            }

            UpdatePriceInfo();

        }

       

        private void UpdatePriceInfo()
        {
            
            if (ComboBoxMovie.SelectedItem == null) return;

            string movieName = ComboBoxMovie.SelectedItem.ToString();
            Movie selectedMovie = null;

            foreach (Movie movie in allMovies)
            {
                if (movie.Name == movieName)
                {
                    selectedMovie = movie;
                    break;
                }
            }

            if (selectedMovie != null)
            {
                int shows = (int)totalShowsMovie.Value;
                int totalPrice = selectedMovie.Price * shows;
                RichTextBoxInfo.Text =
                    $"Фильм: {selectedMovie.Name}\n" +
                    $"Цена показа: {selectedMovie.Price} руб/показ\n";
            }
        }

        private void LoadGenresFromMovies()
        {
            
            ListBoxGenre.Items.Clear();
            List<string> Genres = new List<string>();
            foreach (Movie movie in allMovies)
            {
                if (!Genres.Contains(movie.Genre))
                {
                    Genres.Add(movie.Genre);
                }
            }

            foreach (string genre in Genres)
            {
                ListBoxGenre.Items.Add(genre);
            }

            if (ListBoxGenre.Items.Count > 0)
            {
                ListBoxGenre.SelectedIndex = 0;
            }
        }


    }
}
